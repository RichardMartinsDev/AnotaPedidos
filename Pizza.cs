using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Data.OleDb;
using System.IO;

namespace Pizza_Order
{
  public partial class frmPizza : Form
  {
    public frmPizza()
    {
      InitializeComponent();
    }

    int orderNumber;
    OleDbConnection pizzaConnection;
    OleDbCommand customersCommand;
    OleDbDataAdapter customersAdapter;
    DataTable customersTable;
    CurrencyManager customersManager;
    OleDbCommand ordersCommand;
    OleDbDataAdapter ordersAdapter;
    DataTable ordersTable;
    OleDbCommand pizzasCommand;
    OleDbDataAdapter pizzasAdapter;
    DataTable pizzasTable;
    int pizzaSize, numberPizzas;
    float totalCost;
    float[] toppingCost = new float[12];
    float[] sizeCost = new float[3];
    float deliveryCost;
    float taxRate;
    const int numberToppings = 12;
    CheckBox[] chkTop = new CheckBox[12];
    RadioButton[] rdoSize = new RadioButton[3];

    private void frmPizza_Load(object sender, EventArgs e)
    {
      // Cobertura (vegetais 50 centavos, carnes 1 real)
      chkTop[0] = chkCheese; toppingCost[0] = 0.5F;
      chkTop[1] = chkMushrooms; toppingCost[1] = 0.5F;
      chkTop[2] = chkBlackOlives; toppingCost[2] = 0.5F;
      chkTop[3] = chkOnions; toppingCost[3] = 0.5F;
      chkTop[4] = chkGreenPeppers; toppingCost[4] = 0.5F;
      chkTop[5] = chkTomatoes; toppingCost[5] = 0.5F;
      chkTop[6] = chkPepperoni; toppingCost[6] = 1.0F;
      chkTop[7] = chkSalami; toppingCost[7] = 1.0F;
      chkTop[8] = chkSausage; toppingCost[8] = 1.0F;
      chkTop[9] = chkGroundBeef; toppingCost[9] = 1.0F;
      chkTop[10] = chkShrimp; toppingCost[10] = 1.0F;
      chkTop[11] = chkAnchovies; toppingCost[11] = 1.0F;
      // custo tamanho
      rdoSize[0] = rdoSmall; sizeCost[0] = 7.0F;
      rdoSize[1] = rdoMedium; sizeCost[1] = 10.0F;
      rdoSize[2] = rdoLarge; sizeCost[2] = 15.0F;
      pizzaSize = 0;
      // Taxa de Entrega
      deliveryCost = 2.5F;
      // Tax rate
      taxRate = 8.9F;
      // obter o numero do pedido
      StreamReader inputFile = new StreamReader(Application.StartupPath + "\\..\\..\\pizza.ini");
      orderNumber = Convert.ToInt32(inputFile.ReadLine());
      inputFile.Close();
      this.Text = "Pedido Pizza #" + orderNumber.ToString().PadLeft(4, '0');
      // connect to pizza database
      pizzaConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source = " + Application.StartupPath + "\\..\\..\\PizzaDB.mdb");
      pizzaConnection.Open();
      // establish Customers command object
      customersCommand = new OleDbCommand("SELECT * FROM Customers ORDER BY PhoneNumber", pizzaConnection);
      // establish Customers data adapter/data table
      customersAdapter = new OleDbDataAdapter();
      customersAdapter.SelectCommand = customersCommand;
      customersTable = new DataTable();
      customersAdapter.Fill(customersTable);
      // bind controls to data table
      txtFirstName.DataBindings.Add("Text", customersTable, "FirstName");
      txtLastName.DataBindings.Add("Text", customersTable, "LastName");
      txtAddress.DataBindings.Add("Text", customersTable, "Address");
      txtCity.DataBindings.Add("Text", customersTable, "City");
      txtState.DataBindings.Add("Text", customersTable, "State");
      txtZip.DataBindings.Add("Text", customersTable, "Zip");
      txtComment.DataBindings.Add("Text", customersTable, "Comment");
      // establish currency manager
      customersManager = (CurrencyManager) this.BindingContext[customersTable];
      // establish Orders command object
      ordersCommand = new OleDbCommand("SELECT * FROM Orders ORDER BY PhoneNumber", pizzaConnection);
      // establish Orders data adapter/data table
      ordersAdapter = new OleDbDataAdapter();
      ordersAdapter.SelectCommand = ordersCommand;
      ordersTable = new DataTable();
      ordersAdapter.Fill(ordersTable);
      // establish Pizzas command object
      pizzasCommand = new OleDbCommand("SELECT * FROM Pizzas ORDER BY OrderNumber", pizzaConnection);
      // establish Pizzas data adapter/data table
      pizzasAdapter = new OleDbDataAdapter();
      pizzasAdapter.SelectCommand = pizzasCommand;
      pizzasTable = new DataTable();
      pizzasAdapter.Fill(pizzasTable);
      lblDate.Text = DateTime.Now.ToShortDateString();
      txtPhone.Focus();
    }

    private void frmPizza_FormClosing(object sender, FormClosingEventArgs e)
    {
      // salva o numero do pedido
      StreamWriter outputFile = new StreamWriter(Application.StartupPath + "\\..\\..\\pizza.ini");
      outputFile.WriteLine(orderNumber);
      outputFile.Close();
      try
      {
        // salva a tabela 
        OleDbCommandBuilder ordersAdapterCommands = new OleDbCommandBuilder(ordersAdapter);
        ordersAdapter.Update(ordersTable);
        OleDbCommandBuilder customersAdapterCommands = new OleDbCommandBuilder(customersAdapter);
        customersAdapter.Update(customersTable);
        OleDbCommandBuilder pizzasAdapterCommands = new OleDbCommandBuilder(pizzasAdapter);
        pizzasAdapter.Update(pizzasTable);
      }
      catch (Exception ex)
      {
        MessageBox.Show("Erro ao salvar no banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      // fecha a conexao
      pizzaConnection.Close();
      // libera os objetos
      ordersCommand.Dispose();
      ordersAdapter.Dispose();
      ordersTable.Dispose();
      customersCommand.Dispose();
      customersAdapter.Dispose();
      customersTable.Dispose();
      pizzasCommand.Dispose();
      pizzasAdapter.Dispose();
      pizzasTable.Dispose();
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btnFind_Click(object sender, EventArgs e)
    {
      // Verifica a validade do telefone
      int l = txtPhone.Text.Length;
      if (l != 15)
      {
        MessageBox.Show("O telefone requer 10 digitos.", "Erro no numero do telefone", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        txtPhone.Focus();
        return;
      }
      customersTable.DefaultView.Sort = "PhoneNumber";
      int foundRow = customersTable.DefaultView.Find(txtPhone.Text);
      if (foundRow != -1)
      {
        btnFind.Enabled = false;
        grpSize.Enabled = true;
        grpDeliver.Enabled = true;
        grpToppings.Enabled = true;
        txtSpecial.Enabled = true;
        btnBuild.Enabled = true;
        btnComplete.Enabled = false;
        txtPhone.Enabled = false;
                txtNome.Visible= true;
        txtFirstName.Visible = true;
                txtSobrenome.Visible = true;
        txtLastName.Visible = true;
                txtEndereco.Visible = true; 
        txtAddress.Visible = true;
                txtCidade.Visible = true;   
        txtCity.Visible = true;
                txtUF.Visible = true;   
        txtState.Visible = true;
                txtCEP.Visible = true;  
        txtZip.Visible = true;
                txtObs.Visible = true;  
        txtComment.Visible = true;
        totalCost = 0;
        numberPizzas = 0;
        customersManager.Position = foundRow;
      }
      else
      {
        // code for new customer
        btnFind.Enabled = false;
        txtPhone.Enabled = false;
                txtNome.Visible = true;
        txtFirstName.Visible = true;
                txtSobrenome.Visible = true;
        txtLastName.Visible = true;
                txtEndereco.Visible = true;
        txtAddress.Visible = true;
                txtCidade.Visible = true;
        txtCity.Visible = true;
                txtUF.Visible = true;   
        txtState.Visible = true;
                txtCEP.Visible = true;  
        txtZip.Visible = true;
                txtObs.Visible = true;  
        txtComment.Visible = true;
        customersManager.AddNew();
        txtFirstName.Focus();
        btnSave.Visible = true;
        btnCancel.Visible = true;
      }
    }

    private void btnBuild_Click(object sender, EventArgs e)
    {
      //Esta rotina cria uma mensage que exibe o tipo da sua pizza
      string message = "", toppingString;
      float cost;
      if (pizzaSize < 0)
      {
        MessageBox.Show("Escolha um tamanho", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }
      message += rdoSize[pizzaSize].Text + " pizza\r\n";
      cost = sizeCost[pizzaSize];
      toppingString = "";
      for (int i = 0; i < numberToppings; i++)
      {
        if (chkTop[i].Checked)
        {
          message += chkTop[i].Text + "\r\n";
          toppingString += "1";
          cost += toppingCost[i];
        }
        else
        {
          toppingString += "0";
        }
      }
      if (toppingString.Equals("000000000000"))
        message += "Somente queijo\r\n";
      if (!txtSpecial.Text.Equals(""))
        message += txtSpecial.Text + "\r\n";
      if (chkDeliver.Checked)
      {
        message += "Para Entrega\r\n";
        cost += deliveryCost;
      }
      else
      {
        message += "Para retirada\r\n";
      }
      message += "Custo é $" + String.Format("{0:f2}", cost);
      // Se estiver ok inclui no banco de dados 
      if (MessageBox.Show(message + "\r\n\r\n" + "Esta correto?", "Sua Pizza", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        // Inclui pizza a tabela de pizzas
        DataRow newRow = pizzasTable.NewRow();
        newRow["OrderNumber"] = orderNumber;
        if (chkDeliver.Checked)
          newRow["Delivery"] = "1";
        else
          newRow["Delivery"] = "0";
        newRow["PizzaSize"] = pizzaSize.ToString();
        newRow["Toppings"] = toppingString;
        newRow["SpecialInfo"] = txtSpecial.Text;
        newRow["Cost"] = cost;
        pizzasTable.Rows.Add(newRow);
        numberPizzas++;
        totalCost += cost;
        cost = 0;
        pizzaSize = 0;
        rdoSize[pizzaSize].Checked = true;
        for (int i = 0; i < numberToppings; i++)
          chkTop[i].Checked = false;
        txtSpecial.Text = "";
        chkDeliver.Checked = false;
        btnComplete.Enabled = true;
      }
    }

    private void btnComplete_Click(object sender, EventArgs e)
    {
      totalCost = (1 + taxRate / 100) * totalCost;
      if (MessageBox.Show("Pedido Inclui " + numberPizzas.ToString() + " pizza(s)\r\nCusto total é $" + String.Format("{0:f2}", totalCost) + " (incluindo taxas)\r\n\r\nDeseja imprimir o recibo?", "Pedido Completo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        PrintReceipt();
      // Escreve o numero do pedido no banco de dados
      DataRow newRow = ordersTable.NewRow();
      newRow["OrderNumber"] = orderNumber;
      newRow["PhoneNumber"] = txtPhone.Text;
      newRow["OrderDate"] = lblDate.Text;
      newRow["TotalCost"] = totalCost;
      ordersTable.Rows.Add(newRow);
      orderNumber++;
      this.Text = "Pizza Pedido #" + orderNumber.ToString().PadLeft(4, '0');
      btnFind.Enabled = true;
      grpSize.Enabled = false;
      grpDeliver.Enabled = false;
      grpToppings.Enabled = false;
      txtSpecial.Enabled = false;
      btnBuild.Enabled = false;
      btnComplete.Enabled = false;
            txtNome.Visible = false;
      txtFirstName.Visible = false;
            txtSobrenome.Visible = false;   
      txtLastName.Visible = false;
            txtEndereco.Visible = false;    
      txtAddress.Visible = false;
            txtCidade.Visible = false;  
      txtCity.Visible = false;
            txtUF.Visible = false; 
      txtState.Visible = false;
            txtCEP.Visible = false;
      txtZip.Visible = false;
            txtObs.Visible = false;
      txtComment.Visible = false;
      txtPhone.Enabled = true;
      txtPhone.Text = "";
      txtPhone.Focus();
    }

    private void UpdateTitle()
    {
      string o = orderNumber.ToString();
      if (orderNumber < 10)
        o = "000" + o;
      else if (orderNumber < 100)
        o = "00" + o;
      else if (orderNumber < 1000)
        o = "0" + o;
      this.Text = "Pizza Pedido #" + o;
    }

    private void PrintReceipt()
    {
      PrintDocument recordDocument;
      // Cria um novo documento
      recordDocument = new PrintDocument();
      recordDocument.DocumentName = "Pizza Recibo";
      recordDocument.PrintPage += new PrintPageEventHandler(this.PrintReceiptPage);
      // Preview 
      dlgPreview.Document = recordDocument;
      dlgPreview.ShowDialog();
      // Libera o documento apos imprimir
      recordDocument.Dispose();
    }


    private void PrintReceiptPage(object sender, PrintPageEventArgs e)
    {
      string s;
      int y;
      // Imprime recibo
      Font myFont = new Font("Arial", 12, FontStyle.Bold);
      y = e.MarginBounds.Y;
      e.Graphics.DrawString("Pedido Pizza No. " + orderNumber.ToString().PadLeft(4, '0'), myFont, Brushes.Black, e.MarginBounds.X, y);
      y += Convert.ToInt32(2 * myFont.GetHeight(e.Graphics));
      myFont = new Font("Arial", 12, FontStyle.Regular);
      e.Graphics.DrawString(txtFirstName.Text + " " + txtLastName.Text, myFont, Brushes.Black, e.MarginBounds.X, y);
      y += Convert.ToInt32(myFont.GetHeight(e.Graphics));
      e.Graphics.DrawString(txtAddress.Text, myFont, Brushes.Black, e.MarginBounds.X, y);
      y += Convert.ToInt32(myFont.GetHeight(e.Graphics));
      e.Graphics.DrawString(txtCity.Text + ", " + txtState.Text + " " + txtZip.Text, myFont, Brushes.Black, e.MarginBounds.X, y);
      y += Convert.ToInt32(myFont.GetHeight(e.Graphics));
      e.Graphics.DrawString(txtPhone.Text, myFont, Brushes.Black, e.MarginBounds.X, y);
      y += Convert.ToInt32(2 * myFont.GetHeight(e.Graphics));
      e.Graphics.DrawString("Pedido " + numberPizzas.ToString() + " Pizza(s):", myFont, Brushes.Black, e.MarginBounds.X, y);
      DataRow[] foundRows;
      foundRows = pizzasTable.Select("OrderNumber ='" + orderNumber.ToString() + "'");
      for (int i = 0; i < foundRows.Length; i++)
      {
        y += Convert.ToInt32(2 * myFont.GetHeight(e.Graphics));
        e.Graphics.DrawString(rdoSize[Convert.ToInt32(foundRows[i]["PizzaSize"])].Text + " Pizza", myFont, Brushes.Black, e.MarginBounds.X, y);
        y += Convert.ToInt32(myFont.GetHeight(e.Graphics));
        if (Convert.ToInt32(foundRows[i]["Delivery"]) == 1)
          e.Graphics.DrawString("Entrega", myFont, Brushes.Black, e.MarginBounds.X, y);
        else
          e.Graphics.DrawString("Para ser retirada", myFont, Brushes.Black, e.MarginBounds.X, y);
        s = foundRows[i]["Toppings"].ToString();
        for (int j = 0; j < numberToppings; j++)
        {
          if (s.Substring(j, 1).Equals("1"))
          {
            y += Convert.ToInt32(myFont.GetHeight(e.Graphics));
            e.Graphics.DrawString(chkTop[j].Text, myFont, Brushes.Black, e.MarginBounds.X, y);
          }
        }
        y += Convert.ToInt32(myFont.GetHeight(e.Graphics));
        e.Graphics.DrawString("Custo: $" + String.Format("{0:f2}", foundRows[i]["Cost"]), myFont, Brushes.Black, e.MarginBounds.X, y);
      }
      y += Convert.ToInt32(2 * myFont.GetHeight(e.Graphics));
      e.Graphics.DrawString("Total : $" + String.Format("{0:f2}", totalCost), myFont, Brushes.Black, e.MarginBounds.X, y);
      e.HasMorePages = false;
    }

    private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
    {
      if ((int)e.KeyChar == 13)
        btnFind.PerformClick();
    }

    private void rdoSize_CheckedChanged(object sender, EventArgs e)
    {
      RadioButton buttonChecked = (RadioButton)sender;
      switch (buttonChecked.Name)
      {
        case "rdoSmall":
          pizzaSize = 0;
          break;
        case "rdoMedium":
          pizzaSize = 1;
          break;
        case "rdoLarge":
          pizzaSize = 2;
          break;
      }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      btnSave.Visible = false;
      btnCancel.Visible = false;
      customersManager.EndCurrentEdit();
      DataRow currentRow = customersTable.Rows[customersTable.Rows.Count - 1];
      currentRow["PhoneNumber"] = txtPhone.Text;
      btnFind.Enabled = false;
      grpSize.Enabled = true;
      grpDeliver.Enabled = true;
      grpToppings.Enabled = true;
      txtSpecial.Enabled = true;
      btnBuild.Enabled = true;
      btnComplete.Enabled = false;
      txtPhone.Enabled = false;
      totalCost = 0;
      numberPizzas = 0;
    }

        private void txtPhone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
    {
      customersManager.CancelCurrentEdit();
      btnSave.Visible = false;
      btnCancel.Visible = false;
      btnFind.Enabled = true;
      txtFirstName.Visible = false;
      txtLastName.Visible = false;
      txtAddress.Visible = false;
      txtCity.Visible = false;
      txtState.Visible = false;
      txtZip.Visible = false;
      txtComment.Visible = false;
      txtPhone.Enabled = true;
      txtPhone.Text = "";
      txtPhone.Focus();
    }



  }
}