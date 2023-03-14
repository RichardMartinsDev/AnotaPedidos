namespace Pizza_Order
{
  partial class frmPizza
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPizza));
            this.grpOrder = new System.Windows.Forms.GroupBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpSize = new System.Windows.Forms.GroupBox();
            this.rdoLarge = new System.Windows.Forms.RadioButton();
            this.rdoMedium = new System.Windows.Forms.RadioButton();
            this.rdoSmall = new System.Windows.Forms.RadioButton();
            this.grpToppings = new System.Windows.Forms.GroupBox();
            this.chkAnchovies = new System.Windows.Forms.CheckBox();
            this.chkShrimp = new System.Windows.Forms.CheckBox();
            this.chkGroundBeef = new System.Windows.Forms.CheckBox();
            this.chkSausage = new System.Windows.Forms.CheckBox();
            this.chkSalami = new System.Windows.Forms.CheckBox();
            this.chkPepperoni = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chkOnions = new System.Windows.Forms.CheckBox();
            this.chkBlackOlives = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkCheese = new System.Windows.Forms.CheckBox();
            this.btnBuild = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpDeliver = new System.Windows.Forms.GroupBox();
            this.chkDeliver = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSpecial = new System.Windows.Forms.TextBox();
            this.dlgPreview = new System.Windows.Forms.PrintPreviewDialog();
            this.txtNome = new System.Windows.Forms.Label();
            this.txtSobrenome = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.Label();
            this.txtUF = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.Label();
            this.grpOrder.SuspendLayout();
            this.grpCustomer.SuspendLayout();
            this.grpSize.SuspendLayout();
            this.grpToppings.SuspendLayout();
            this.grpDeliver.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOrder
            // 
            this.grpOrder.Controls.Add(this.lblDate);
            this.grpOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOrder.Location = new System.Drawing.Point(11, 10);
            this.grpOrder.Name = "grpOrder";
            this.grpOrder.Size = new System.Drawing.Size(112, 52);
            this.grpOrder.TabIndex = 0;
            this.grpOrder.TabStop = false;
            this.grpOrder.Text = "Data Pedido";
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.Color.White;
            this.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(6, 16);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(88, 24);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "1/3/2007";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpCustomer
            // 
            this.grpCustomer.Controls.Add(this.txtObs);
            this.grpCustomer.Controls.Add(this.txtCEP);
            this.grpCustomer.Controls.Add(this.txtUF);
            this.grpCustomer.Controls.Add(this.txtCidade);
            this.grpCustomer.Controls.Add(this.txtEndereco);
            this.grpCustomer.Controls.Add(this.txtSobrenome);
            this.grpCustomer.Controls.Add(this.txtNome);
            this.grpCustomer.Controls.Add(this.txtComment);
            this.grpCustomer.Controls.Add(this.txtZip);
            this.grpCustomer.Controls.Add(this.txtState);
            this.grpCustomer.Controls.Add(this.txtCity);
            this.grpCustomer.Controls.Add(this.txtAddress);
            this.grpCustomer.Controls.Add(this.txtLastName);
            this.grpCustomer.Controls.Add(this.txtFirstName);
            this.grpCustomer.Controls.Add(this.btnFind);
            this.grpCustomer.Controls.Add(this.btnCancel);
            this.grpCustomer.Controls.Add(this.btnSave);
            this.grpCustomer.Controls.Add(this.txtPhone);
            this.grpCustomer.Controls.Add(this.label1);
            this.grpCustomer.Location = new System.Drawing.Point(12, 68);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Size = new System.Drawing.Size(242, 236);
            this.grpCustomer.TabIndex = 1;
            this.grpCustomer.TabStop = false;
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(9, 164);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(226, 37);
            this.txtComment.TabIndex = 11;
            this.txtComment.Visible = false;
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(164, 127);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(71, 20);
            this.txtZip.TabIndex = 10;
            this.txtZip.Visible = false;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(125, 127);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(35, 20);
            this.txtState.TabIndex = 9;
            this.txtState.Visible = false;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(10, 127);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(109, 20);
            this.txtCity.TabIndex = 8;
            this.txtCity.Visible = false;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(10, 91);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(226, 20);
            this.txtAddress.TabIndex = 7;
            this.txtAddress.Visible = false;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(99, 52);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(137, 20);
            this.txtLastName.TabIndex = 6;
            this.txtLastName.Visible = false;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(10, 52);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(83, 20);
            this.txtFirstName.TabIndex = 5;
            this.txtFirstName.Visible = false;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(140, 11);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(96, 23);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Procurar Cliente";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(77, 207);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(57, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(14, 207);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(57, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(50, 13);
            this.txtPhone.Mask = "(99) 00000-0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(84, 20);
            this.txtPhone.TabIndex = 1;
            this.txtPhone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtPhone_MaskInputRejected);
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fone:";
            // 
            // grpSize
            // 
            this.grpSize.Controls.Add(this.rdoLarge);
            this.grpSize.Controls.Add(this.rdoMedium);
            this.grpSize.Controls.Add(this.rdoSmall);
            this.grpSize.Enabled = false;
            this.grpSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSize.Location = new System.Drawing.Point(269, 10);
            this.grpSize.Name = "grpSize";
            this.grpSize.Size = new System.Drawing.Size(93, 92);
            this.grpSize.TabIndex = 2;
            this.grpSize.TabStop = false;
            this.grpSize.Text = "Tamanho";
            // 
            // rdoLarge
            // 
            this.rdoLarge.AutoSize = true;
            this.rdoLarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoLarge.Location = new System.Drawing.Point(12, 64);
            this.rdoLarge.Name = "rdoLarge";
            this.rdoLarge.Size = new System.Drawing.Size(60, 17);
            this.rdoLarge.TabIndex = 2;
            this.rdoLarge.Text = "Grande";
            this.rdoLarge.UseVisualStyleBackColor = true;
            this.rdoLarge.CheckedChanged += new System.EventHandler(this.rdoSize_CheckedChanged);
            // 
            // rdoMedium
            // 
            this.rdoMedium.AutoSize = true;
            this.rdoMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMedium.Location = new System.Drawing.Point(12, 42);
            this.rdoMedium.Name = "rdoMedium";
            this.rdoMedium.Size = new System.Drawing.Size(54, 17);
            this.rdoMedium.TabIndex = 1;
            this.rdoMedium.Text = "Média";
            this.rdoMedium.UseVisualStyleBackColor = true;
            this.rdoMedium.CheckedChanged += new System.EventHandler(this.rdoSize_CheckedChanged);
            // 
            // rdoSmall
            // 
            this.rdoSmall.AutoSize = true;
            this.rdoSmall.Checked = true;
            this.rdoSmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSmall.Location = new System.Drawing.Point(12, 19);
            this.rdoSmall.Name = "rdoSmall";
            this.rdoSmall.Size = new System.Drawing.Size(68, 17);
            this.rdoSmall.TabIndex = 0;
            this.rdoSmall.TabStop = true;
            this.rdoSmall.Text = "Pequena";
            this.rdoSmall.UseVisualStyleBackColor = true;
            this.rdoSmall.CheckedChanged += new System.EventHandler(this.rdoSize_CheckedChanged);
            // 
            // grpToppings
            // 
            this.grpToppings.Controls.Add(this.chkAnchovies);
            this.grpToppings.Controls.Add(this.chkShrimp);
            this.grpToppings.Controls.Add(this.chkGroundBeef);
            this.grpToppings.Controls.Add(this.chkSausage);
            this.grpToppings.Controls.Add(this.chkSalami);
            this.grpToppings.Controls.Add(this.chkPepperoni);
            this.grpToppings.Controls.Add(this.chkTomatoes);
            this.grpToppings.Controls.Add(this.chkGreenPeppers);
            this.grpToppings.Controls.Add(this.chkOnions);
            this.grpToppings.Controls.Add(this.chkBlackOlives);
            this.grpToppings.Controls.Add(this.chkMushrooms);
            this.grpToppings.Controls.Add(this.chkCheese);
            this.grpToppings.Enabled = false;
            this.grpToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpToppings.Location = new System.Drawing.Point(373, 10);
            this.grpToppings.Name = "grpToppings";
            this.grpToppings.Size = new System.Drawing.Size(215, 160);
            this.grpToppings.TabIndex = 4;
            this.grpToppings.TabStop = false;
            this.grpToppings.Text = "Coberturas";
            // 
            // chkAnchovies
            // 
            this.chkAnchovies.AutoSize = true;
            this.chkAnchovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAnchovies.Location = new System.Drawing.Point(115, 133);
            this.chkAnchovies.Name = "chkAnchovies";
            this.chkAnchovies.Size = new System.Drawing.Size(74, 17);
            this.chkAnchovies.TabIndex = 15;
            this.chkAnchovies.Text = "Anchovas";
            this.chkAnchovies.UseVisualStyleBackColor = true;
            // 
            // chkShrimp
            // 
            this.chkShrimp.AutoSize = true;
            this.chkShrimp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShrimp.Location = new System.Drawing.Point(115, 110);
            this.chkShrimp.Name = "chkShrimp";
            this.chkShrimp.Size = new System.Drawing.Size(68, 17);
            this.chkShrimp.TabIndex = 14;
            this.chkShrimp.Text = "Camarão";
            this.chkShrimp.UseVisualStyleBackColor = true;
            // 
            // chkGroundBeef
            // 
            this.chkGroundBeef.AutoSize = true;
            this.chkGroundBeef.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGroundBeef.Location = new System.Drawing.Point(115, 87);
            this.chkGroundBeef.Name = "chkGroundBeef";
            this.chkGroundBeef.Size = new System.Drawing.Size(68, 17);
            this.chkGroundBeef.TabIndex = 13;
            this.chkGroundBeef.Text = "Presunto";
            this.chkGroundBeef.UseVisualStyleBackColor = true;
            // 
            // chkSausage
            // 
            this.chkSausage.AutoSize = true;
            this.chkSausage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSausage.Location = new System.Drawing.Point(115, 64);
            this.chkSausage.Name = "chkSausage";
            this.chkSausage.Size = new System.Drawing.Size(66, 17);
            this.chkSausage.TabIndex = 12;
            this.chkSausage.Text = "Salsicha";
            this.chkSausage.UseVisualStyleBackColor = true;
            // 
            // chkSalami
            // 
            this.chkSalami.AutoSize = true;
            this.chkSalami.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSalami.Location = new System.Drawing.Point(115, 42);
            this.chkSalami.Name = "chkSalami";
            this.chkSalami.Size = new System.Drawing.Size(61, 17);
            this.chkSalami.TabIndex = 11;
            this.chkSalami.Text = "Salame";
            this.chkSalami.UseVisualStyleBackColor = true;
            // 
            // chkPepperoni
            // 
            this.chkPepperoni.AutoSize = true;
            this.chkPepperoni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPepperoni.Location = new System.Drawing.Point(115, 20);
            this.chkPepperoni.Name = "chkPepperoni";
            this.chkPepperoni.Size = new System.Drawing.Size(73, 17);
            this.chkPepperoni.TabIndex = 10;
            this.chkPepperoni.Text = "Calabreza";
            this.chkPepperoni.UseVisualStyleBackColor = true;
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTomatoes.Location = new System.Drawing.Point(9, 133);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(67, 17);
            this.chkTomatoes.TabIndex = 9;
            this.chkTomatoes.Text = "Tomates";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            // 
            // chkGreenPeppers
            // 
            this.chkGreenPeppers.AutoSize = true;
            this.chkGreenPeppers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGreenPeppers.Location = new System.Drawing.Point(9, 110);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Size = new System.Drawing.Size(70, 17);
            this.chkGreenPeppers.TabIndex = 8;
            this.chkGreenPeppers.Text = "Pimentão";
            this.chkGreenPeppers.UseVisualStyleBackColor = true;
            // 
            // chkOnions
            // 
            this.chkOnions.AutoSize = true;
            this.chkOnions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOnions.Location = new System.Drawing.Point(9, 87);
            this.chkOnions.Name = "chkOnions";
            this.chkOnions.Size = new System.Drawing.Size(64, 17);
            this.chkOnions.TabIndex = 7;
            this.chkOnions.Text = "Cebolas";
            this.chkOnions.UseVisualStyleBackColor = true;
            // 
            // chkBlackOlives
            // 
            this.chkBlackOlives.AutoSize = true;
            this.chkBlackOlives.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBlackOlives.Location = new System.Drawing.Point(9, 64);
            this.chkBlackOlives.Name = "chkBlackOlives";
            this.chkBlackOlives.Size = new System.Drawing.Size(72, 17);
            this.chkBlackOlives.TabIndex = 6;
            this.chkBlackOlives.Text = "Azeitonas";
            this.chkBlackOlives.UseVisualStyleBackColor = true;
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMushrooms.Location = new System.Drawing.Point(9, 42);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(78, 17);
            this.chkMushrooms.TabIndex = 5;
            this.chkMushrooms.Text = "Cogumelos";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            // 
            // chkCheese
            // 
            this.chkCheese.AutoSize = true;
            this.chkCheese.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCheese.Location = new System.Drawing.Point(9, 20);
            this.chkCheese.Name = "chkCheese";
            this.chkCheese.Size = new System.Drawing.Size(83, 17);
            this.chkCheese.TabIndex = 4;
            this.chkCheese.Text = "Queijo Extra";
            this.chkCheese.UseVisualStyleBackColor = true;
            // 
            // btnBuild
            // 
            this.btnBuild.Enabled = false;
            this.btnBuild.Location = new System.Drawing.Point(276, 275);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(100, 23);
            this.btnBuild.TabIndex = 4;
            this.btnBuild.Text = "Criar Pizza";
            this.btnBuild.UseVisualStyleBackColor = true;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(382, 275);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(100, 23);
            this.btnComplete.TabIndex = 5;
            this.btnComplete.Text = "Completar Pedido";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(488, 275);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Sair";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpDeliver
            // 
            this.grpDeliver.Controls.Add(this.chkDeliver);
            this.grpDeliver.Enabled = false;
            this.grpDeliver.Location = new System.Drawing.Point(270, 116);
            this.grpDeliver.Name = "grpDeliver";
            this.grpDeliver.Size = new System.Drawing.Size(92, 44);
            this.grpDeliver.TabIndex = 7;
            this.grpDeliver.TabStop = false;
            // 
            // chkDeliver
            // 
            this.chkDeliver.AutoSize = true;
            this.chkDeliver.Location = new System.Drawing.Point(14, 16);
            this.chkDeliver.Name = "chkDeliver";
            this.chkDeliver.Size = new System.Drawing.Size(63, 17);
            this.chkDeliver.TabIndex = 0;
            this.chkDeliver.Text = "Entrega";
            this.chkDeliver.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(273, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Informação Adicional::";
            // 
            // txtSpecial
            // 
            this.txtSpecial.Enabled = false;
            this.txtSpecial.Location = new System.Drawing.Point(276, 184);
            this.txtSpecial.Multiline = true;
            this.txtSpecial.Name = "txtSpecial";
            this.txtSpecial.Size = new System.Drawing.Size(312, 85);
            this.txtSpecial.TabIndex = 12;
            // 
            // dlgPreview
            // 
            this.dlgPreview.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.dlgPreview.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.dlgPreview.ClientSize = new System.Drawing.Size(400, 300);
            this.dlgPreview.Enabled = true;
            this.dlgPreview.Icon = ((System.Drawing.Icon)(resources.GetObject("dlgPreview.Icon")));
            this.dlgPreview.Name = "dlgPreview";
            this.dlgPreview.Visible = false;
            // 
            // txtNome
            // 
            this.txtNome.AutoSize = true;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtNome.Location = new System.Drawing.Point(7, 36);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(39, 13);
            this.txtNome.TabIndex = 12;
            this.txtNome.Text = "Nome";
            this.txtNome.Visible = false;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.AutoSize = true;
            this.txtSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtSobrenome.Location = new System.Drawing.Point(96, 36);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(70, 13);
            this.txtSobrenome.TabIndex = 13;
            this.txtSobrenome.Text = "Sobrenome";
            this.txtSobrenome.Visible = false;
            // 
            // txtEndereco
            // 
            this.txtEndereco.AutoSize = true;
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtEndereco.Location = new System.Drawing.Point(7, 75);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(61, 13);
            this.txtEndereco.TabIndex = 14;
            this.txtEndereco.Text = "Endereço";
            this.txtEndereco.Visible = false;
            // 
            // txtCidade
            // 
            this.txtCidade.AutoSize = true;
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtCidade.Location = new System.Drawing.Point(7, 114);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(46, 13);
            this.txtCidade.TabIndex = 15;
            this.txtCidade.Text = "Cidade";
            this.txtCidade.Visible = false;
            // 
            // txtUF
            // 
            this.txtUF.AutoSize = true;
            this.txtUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtUF.Location = new System.Drawing.Point(131, 112);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(23, 13);
            this.txtUF.TabIndex = 16;
            this.txtUF.Text = "UF";
            this.txtUF.Visible = false;
            // 
            // txtCEP
            // 
            this.txtCEP.AutoSize = true;
            this.txtCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtCEP.Location = new System.Drawing.Point(161, 112);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(31, 13);
            this.txtCEP.TabIndex = 17;
            this.txtCEP.Text = "CEP";
            this.txtCEP.Visible = false;
            // 
            // txtObs
            // 
            this.txtObs.AutoSize = true;
            this.txtObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtObs.Location = new System.Drawing.Point(6, 150);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(81, 13);
            this.txtObs.TabIndex = 18;
            this.txtObs.Text = "Observações";
            this.txtObs.Visible = false;
            // 
            // frmPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 318);
            this.ControlBox = false;
            this.Controls.Add(this.txtSpecial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpDeliver);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.btnBuild);
            this.Controls.Add(this.grpToppings);
            this.Controls.Add(this.grpSize);
            this.Controls.Add(this.grpCustomer);
            this.Controls.Add(this.grpOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPizza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizzaria Mama Mia - Pedidos ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPizza_FormClosing);
            this.Load += new System.EventHandler(this.frmPizza_Load);
            this.grpOrder.ResumeLayout(false);
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            this.grpSize.ResumeLayout(false);
            this.grpSize.PerformLayout();
            this.grpToppings.ResumeLayout(false);
            this.grpToppings.PerformLayout();
            this.grpDeliver.ResumeLayout(false);
            this.grpDeliver.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.GroupBox grpOrder;
    private System.Windows.Forms.Label lblDate;
    private System.Windows.Forms.GroupBox grpCustomer;
    private System.Windows.Forms.Button btnFind;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.MaskedTextBox txtPhone;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtComment;
    private System.Windows.Forms.TextBox txtZip;
    private System.Windows.Forms.TextBox txtState;
    private System.Windows.Forms.TextBox txtCity;
    private System.Windows.Forms.TextBox txtAddress;
    private System.Windows.Forms.TextBox txtLastName;
    private System.Windows.Forms.TextBox txtFirstName;
    private System.Windows.Forms.GroupBox grpSize;
    private System.Windows.Forms.RadioButton rdoLarge;
    private System.Windows.Forms.RadioButton rdoMedium;
    private System.Windows.Forms.RadioButton rdoSmall;
    private System.Windows.Forms.GroupBox grpToppings;
    private System.Windows.Forms.Button btnBuild;
    private System.Windows.Forms.Button btnComplete;
    private System.Windows.Forms.Button btnExit;
    private System.Windows.Forms.CheckBox chkTomatoes;
    private System.Windows.Forms.CheckBox chkGreenPeppers;
    private System.Windows.Forms.CheckBox chkOnions;
    private System.Windows.Forms.CheckBox chkBlackOlives;
    private System.Windows.Forms.CheckBox chkMushrooms;
    private System.Windows.Forms.CheckBox chkCheese;
    private System.Windows.Forms.GroupBox grpDeliver;
    private System.Windows.Forms.CheckBox chkDeliver;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtSpecial;
    private System.Windows.Forms.CheckBox chkAnchovies;
    private System.Windows.Forms.CheckBox chkShrimp;
    private System.Windows.Forms.CheckBox chkGroundBeef;
    private System.Windows.Forms.CheckBox chkSausage;
    private System.Windows.Forms.CheckBox chkSalami;
    private System.Windows.Forms.CheckBox chkPepperoni;
    private System.Windows.Forms.PrintPreviewDialog dlgPreview;
        private System.Windows.Forms.Label txtNome;
        private System.Windows.Forms.Label txtEndereco;
        private System.Windows.Forms.Label txtSobrenome;
        private System.Windows.Forms.Label txtObs;
        private System.Windows.Forms.Label txtCEP;
        private System.Windows.Forms.Label txtUF;
        private System.Windows.Forms.Label txtCidade;
    }
}

