namespace UI_Forms
{
    partial class Form1
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
            this.btnAddClient = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnDisplayClient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMaker = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbYellow = new System.Windows.Forms.RadioButton();
            this.rdbBrown = new System.Windows.Forms.RadioButton();
            this.rdbSilver = new System.Windows.Forms.RadioButton();
            this.rdbGreen = new System.Windows.Forms.RadioButton();
            this.rdbBlue = new System.Windows.Forms.RadioButton();
            this.rdbRed = new System.Windows.Forms.RadioButton();
            this.rdbGray = new System.Windows.Forms.RadioButton();
            this.rdbWhite = new System.Windows.Forms.RadioButton();
            this.rdbBlack = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ckbFourWheelDrive = new System.Windows.Forms.CheckBox();
            this.ckbSunroof = new System.Windows.Forms.CheckBox();
            this.ckbNavigationSystem = new System.Windows.Forms.CheckBox();
            this.ckbCruiseControl = new System.Windows.Forms.CheckBox();
            this.ckbAutomaticTransmission = new System.Windows.Forms.CheckBox();
            this.ckbAirConditioner = new System.Windows.Forms.CheckBox();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.btnDisplayCar = new System.Windows.Forms.Button();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lstDisplayClients = new System.Windows.Forms.ListBox();
            this.lstDisplayCars = new System.Windows.Forms.ListBox();
            this.dataGridClients = new System.Windows.Forms.DataGridView();
            this.dataGridCars = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCars)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(9, 138);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(90, 23);
            this.btnAddClient.TabIndex = 0;
            this.btnAddClient.Text = "Add Client";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click_1);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(88, 16);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(170, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(88, 40);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(170, 20);
            this.txtLastName.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(88, 66);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(170, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(88, 92);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(170, 20);
            this.txtPhoneNumber.TabIndex = 4;
            // 
            // btnDisplayClient
            // 
            this.btnDisplayClient.Location = new System.Drawing.Point(140, 138);
            this.btnDisplayClient.Name = "btnDisplayClient";
            this.btnDisplayClient.Size = new System.Drawing.Size(98, 23);
            this.btnDisplayClient.TabIndex = 5;
            this.btnDisplayClient.Text = "Display Client";
            this.btnDisplayClient.UseVisualStyleBackColor = true;
            this.btnDisplayClient.Click += new System.EventHandler(this.btnDisplayClient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Email adress";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Phone number";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblMaker
            // 
            this.lblMaker.AutoSize = true;
            this.lblMaker.Location = new System.Drawing.Point(6, 21);
            this.lblMaker.Name = "lblMaker";
            this.lblMaker.Size = new System.Drawing.Size(37, 13);
            this.lblMaker.TabIndex = 10;
            this.lblMaker.Text = "Maker";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Model";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Year";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Car color";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbYellow);
            this.groupBox1.Controls.Add(this.rdbBrown);
            this.groupBox1.Controls.Add(this.rdbSilver);
            this.groupBox1.Controls.Add(this.rdbGreen);
            this.groupBox1.Controls.Add(this.rdbBlue);
            this.groupBox1.Controls.Add(this.rdbRed);
            this.groupBox1.Controls.Add(this.rdbGray);
            this.groupBox1.Controls.Add(this.rdbWhite);
            this.groupBox1.Controls.Add(this.rdbBlack);
            this.groupBox1.Location = new System.Drawing.Point(61, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 144);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // rdbYellow
            // 
            this.rdbYellow.AutoSize = true;
            this.rdbYellow.Location = new System.Drawing.Point(99, 89);
            this.rdbYellow.Name = "rdbYellow";
            this.rdbYellow.Size = new System.Drawing.Size(56, 17);
            this.rdbYellow.TabIndex = 8;
            this.rdbYellow.TabStop = true;
            this.rdbYellow.Text = "Yellow";
            this.rdbYellow.UseVisualStyleBackColor = true;
            // 
            // rdbBrown
            // 
            this.rdbBrown.AutoSize = true;
            this.rdbBrown.Location = new System.Drawing.Point(99, 65);
            this.rdbBrown.Name = "rdbBrown";
            this.rdbBrown.Size = new System.Drawing.Size(55, 17);
            this.rdbBrown.TabIndex = 7;
            this.rdbBrown.TabStop = true;
            this.rdbBrown.Text = "Brown";
            this.rdbBrown.UseVisualStyleBackColor = true;
            // 
            // rdbSilver
            // 
            this.rdbSilver.AutoSize = true;
            this.rdbSilver.Location = new System.Drawing.Point(99, 42);
            this.rdbSilver.Name = "rdbSilver";
            this.rdbSilver.Size = new System.Drawing.Size(51, 17);
            this.rdbSilver.TabIndex = 6;
            this.rdbSilver.TabStop = true;
            this.rdbSilver.Text = "Silver";
            this.rdbSilver.UseVisualStyleBackColor = true;
            // 
            // rdbGreen
            // 
            this.rdbGreen.AutoSize = true;
            this.rdbGreen.Location = new System.Drawing.Point(99, 20);
            this.rdbGreen.Name = "rdbGreen";
            this.rdbGreen.Size = new System.Drawing.Size(54, 17);
            this.rdbGreen.TabIndex = 5;
            this.rdbGreen.TabStop = true;
            this.rdbGreen.Text = "Green";
            this.rdbGreen.UseVisualStyleBackColor = true;
            // 
            // rdbBlue
            // 
            this.rdbBlue.AutoSize = true;
            this.rdbBlue.Location = new System.Drawing.Point(6, 112);
            this.rdbBlue.Name = "rdbBlue";
            this.rdbBlue.Size = new System.Drawing.Size(46, 17);
            this.rdbBlue.TabIndex = 4;
            this.rdbBlue.TabStop = true;
            this.rdbBlue.Text = "Blue";
            this.rdbBlue.UseVisualStyleBackColor = true;
            // 
            // rdbRed
            // 
            this.rdbRed.AutoSize = true;
            this.rdbRed.Location = new System.Drawing.Point(6, 89);
            this.rdbRed.Name = "rdbRed";
            this.rdbRed.Size = new System.Drawing.Size(45, 17);
            this.rdbRed.TabIndex = 3;
            this.rdbRed.TabStop = true;
            this.rdbRed.Text = "Red";
            this.rdbRed.UseVisualStyleBackColor = true;
            // 
            // rdbGray
            // 
            this.rdbGray.AutoSize = true;
            this.rdbGray.Location = new System.Drawing.Point(6, 65);
            this.rdbGray.Name = "rdbGray";
            this.rdbGray.Size = new System.Drawing.Size(47, 17);
            this.rdbGray.TabIndex = 2;
            this.rdbGray.TabStop = true;
            this.rdbGray.Text = "Gray";
            this.rdbGray.UseVisualStyleBackColor = true;
            // 
            // rdbWhite
            // 
            this.rdbWhite.AutoSize = true;
            this.rdbWhite.Location = new System.Drawing.Point(6, 42);
            this.rdbWhite.Name = "rdbWhite";
            this.rdbWhite.Size = new System.Drawing.Size(53, 17);
            this.rdbWhite.TabIndex = 1;
            this.rdbWhite.TabStop = true;
            this.rdbWhite.Text = "White";
            this.rdbWhite.UseVisualStyleBackColor = true;
            // 
            // rdbBlack
            // 
            this.rdbBlack.AutoSize = true;
            this.rdbBlack.Location = new System.Drawing.Point(6, 19);
            this.rdbBlack.Name = "rdbBlack";
            this.rdbBlack.Size = new System.Drawing.Size(52, 17);
            this.rdbBlack.TabIndex = 0;
            this.rdbBlack.TabStop = true;
            this.rdbBlack.Text = "Black";
            this.rdbBlack.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 288);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Car options";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ckbFourWheelDrive);
            this.groupBox2.Controls.Add(this.ckbSunroof);
            this.groupBox2.Controls.Add(this.ckbNavigationSystem);
            this.groupBox2.Controls.Add(this.ckbCruiseControl);
            this.groupBox2.Controls.Add(this.ckbAutomaticTransmission);
            this.groupBox2.Controls.Add(this.ckbAirConditioner);
            this.groupBox2.Location = new System.Drawing.Point(72, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 118);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // ckbFourWheelDrive
            // 
            this.ckbFourWheelDrive.AutoSize = true;
            this.ckbFourWheelDrive.Location = new System.Drawing.Point(149, 41);
            this.ckbFourWheelDrive.Name = "ckbFourWheelDrive";
            this.ckbFourWheelDrive.Size = new System.Drawing.Size(109, 17);
            this.ckbFourWheelDrive.TabIndex = 5;
            this.ckbFourWheelDrive.Text = "Four Wheel Drive";
            this.ckbFourWheelDrive.UseVisualStyleBackColor = true;
            this.ckbFourWheelDrive.CheckedChanged += new System.EventHandler(this.ckbOptions_CheckedChanged);
            // 
            // ckbSunroof
            // 
            this.ckbSunroof.AutoSize = true;
            this.ckbSunroof.Location = new System.Drawing.Point(149, 14);
            this.ckbSunroof.Name = "ckbSunroof";
            this.ckbSunroof.Size = new System.Drawing.Size(63, 17);
            this.ckbSunroof.TabIndex = 4;
            this.ckbSunroof.Text = "Sunroof";
            this.ckbSunroof.UseVisualStyleBackColor = true;
            this.ckbSunroof.CheckedChanged += new System.EventHandler(this.ckbOptions_CheckedChanged);
            // 
            // ckbNavigationSystem
            // 
            this.ckbNavigationSystem.AutoSize = true;
            this.ckbNavigationSystem.Location = new System.Drawing.Point(6, 89);
            this.ckbNavigationSystem.Name = "ckbNavigationSystem";
            this.ckbNavigationSystem.Size = new System.Drawing.Size(114, 17);
            this.ckbNavigationSystem.TabIndex = 3;
            this.ckbNavigationSystem.Text = "Navigation System";
            this.ckbNavigationSystem.UseVisualStyleBackColor = true;
            this.ckbNavigationSystem.CheckedChanged += new System.EventHandler(this.ckbOptions_CheckedChanged);
            // 
            // ckbCruiseControl
            // 
            this.ckbCruiseControl.AutoSize = true;
            this.ckbCruiseControl.Location = new System.Drawing.Point(6, 65);
            this.ckbCruiseControl.Name = "ckbCruiseControl";
            this.ckbCruiseControl.Size = new System.Drawing.Size(91, 17);
            this.ckbCruiseControl.TabIndex = 2;
            this.ckbCruiseControl.Text = "Cruise Control";
            this.ckbCruiseControl.UseVisualStyleBackColor = true;
            this.ckbCruiseControl.CheckedChanged += new System.EventHandler(this.ckbOptions_CheckedChanged);
            // 
            // ckbAutomaticTransmission
            // 
            this.ckbAutomaticTransmission.AutoSize = true;
            this.ckbAutomaticTransmission.Location = new System.Drawing.Point(6, 41);
            this.ckbAutomaticTransmission.Name = "ckbAutomaticTransmission";
            this.ckbAutomaticTransmission.Size = new System.Drawing.Size(137, 17);
            this.ckbAutomaticTransmission.TabIndex = 1;
            this.ckbAutomaticTransmission.Text = "Automatic Transmission";
            this.ckbAutomaticTransmission.UseVisualStyleBackColor = true;
            this.ckbAutomaticTransmission.CheckedChanged += new System.EventHandler(this.ckbOptions_CheckedChanged);
            // 
            // ckbAirConditioner
            // 
            this.ckbAirConditioner.AutoSize = true;
            this.ckbAirConditioner.Location = new System.Drawing.Point(6, 17);
            this.ckbAirConditioner.Name = "ckbAirConditioner";
            this.ckbAirConditioner.Size = new System.Drawing.Size(94, 17);
            this.ckbAirConditioner.TabIndex = 0;
            this.ckbAirConditioner.Text = "Air Conditioner";
            this.ckbAirConditioner.UseVisualStyleBackColor = true;
            this.ckbAirConditioner.CheckedChanged += new System.EventHandler(this.ckbOptions_CheckedChanged);
            // 
            // btnAddCar
            // 
            this.btnAddCar.Location = new System.Drawing.Point(37, 402);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(75, 23);
            this.btnAddCar.TabIndex = 18;
            this.btnAddCar.Text = "Add Car";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // btnDisplayCar
            // 
            this.btnDisplayCar.Location = new System.Drawing.Point(160, 402);
            this.btnDisplayCar.Name = "btnDisplayCar";
            this.btnDisplayCar.Size = new System.Drawing.Size(75, 23);
            this.btnDisplayCar.TabIndex = 19;
            this.btnDisplayCar.Text = "Display Car";
            this.btnDisplayCar.UseVisualStyleBackColor = true;
            this.btnDisplayCar.Click += new System.EventHandler(this.btnDisplayCar_Click);
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(49, 19);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(170, 20);
            this.txtMake.TabIndex = 20;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(49, 45);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(170, 20);
            this.txtModel.TabIndex = 21;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(49, 71);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(170, 20);
            this.txtYear.TabIndex = 22;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(49, 97);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(170, 20);
            this.txtPrice.TabIndex = 23;
            this.txtPrice.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(198, 256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Cars";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblMaker);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnDisplayCar);
            this.groupBox3.Controls.Add(this.txtPrice);
            this.groupBox3.Controls.Add(this.btnAddCar);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.txtYear);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.txtModel);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtMake);
            this.groupBox3.Location = new System.Drawing.Point(34, 272);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(416, 442);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.btnDisplayClient);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.btnAddClient);
            this.groupBox4.Controls.Add(this.txtPhoneNumber);
            this.groupBox4.Controls.Add(this.txtFirstName);
            this.groupBox4.Controls.Add(this.txtEmail);
            this.groupBox4.Controls.Add(this.txtLastName);
            this.groupBox4.Location = new System.Drawing.Point(34, 46);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(264, 185);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(198, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Clients";
            // 
            // lstDisplayClients
            // 
            this.lstDisplayClients.FormattingEnabled = true;
            this.lstDisplayClients.Location = new System.Drawing.Point(390, 136);
            this.lstDisplayClients.Name = "lstDisplayClients";
            this.lstDisplayClients.Size = new System.Drawing.Size(400, 121);
            this.lstDisplayClients.TabIndex = 28;
            // 
            // lstDisplayCars
            // 
            this.lstDisplayCars.FormattingEnabled = true;
            this.lstDisplayCars.Location = new System.Drawing.Point(465, 567);
            this.lstDisplayCars.Name = "lstDisplayCars";
            this.lstDisplayCars.Size = new System.Drawing.Size(474, 147);
            this.lstDisplayCars.TabIndex = 29;
            // 
            // dataGridClients
            // 
            this.dataGridClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClients.Location = new System.Drawing.Point(844, 136);
            this.dataGridClients.Name = "dataGridClients";
            this.dataGridClients.Size = new System.Drawing.Size(400, 121);
            this.dataGridClients.TabIndex = 30;
            this.dataGridClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridCars
            // 
            this.dataGridCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCars.Location = new System.Drawing.Point(986, 567);
            this.dataGridCars.Name = "dataGridCars";
            this.dataGridCars.Size = new System.Drawing.Size(474, 147);
            this.dataGridCars.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.dataGridCars);
            this.Controls.Add(this.dataGridClients);
            this.Controls.Add(this.lstDisplayCars);
            this.Controls.Add(this.lstDisplayClients);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label10);
            this.Name = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Button btnDisplayClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbGray;
        private System.Windows.Forms.RadioButton rdbWhite;
        private System.Windows.Forms.RadioButton rdbBlack;
        private System.Windows.Forms.RadioButton rdbBlue;
        private System.Windows.Forms.RadioButton rdbRed;
        private System.Windows.Forms.RadioButton rdbYellow;
        private System.Windows.Forms.RadioButton rdbBrown;
        private System.Windows.Forms.RadioButton rdbSilver;
        private System.Windows.Forms.RadioButton rdbGreen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ckbAirConditioner;
        private System.Windows.Forms.CheckBox ckbNavigationSystem;
        private System.Windows.Forms.CheckBox ckbCruiseControl;
        private System.Windows.Forms.CheckBox ckbAutomaticTransmission;
        private System.Windows.Forms.CheckBox ckbFourWheelDrive;
        private System.Windows.Forms.CheckBox ckbSunroof;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnDisplayCar;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox lstDisplayClients;
        private System.Windows.Forms.ListBox lstDisplayCars;
        private System.Windows.Forms.DataGridView dataGridClients;
        private System.Windows.Forms.DataGridView dataGridCars;
    }
}

