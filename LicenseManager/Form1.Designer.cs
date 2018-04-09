namespace LicenseManager
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtbx_lic_exp_date = new System.Windows.Forms.TextBox();
            this.lbl_lic_exp_date = new System.Windows.Forms.Label();
            this.bt_test = new System.Windows.Forms.Button();
            this.lbl_slct_date_expry = new System.Windows.Forms.Label();
            this.numupdwn_no_of_mac = new System.Windows.Forms.NumericUpDown();
            this.lbl_no_of_mac = new System.Windows.Forms.Label();
            this.txtbx_mac_1_1 = new System.Windows.Forms.TextBox();
            this.txtbx_mac_1_2 = new System.Windows.Forms.TextBox();
            this.txtbx_mac_1_3 = new System.Windows.Forms.TextBox();
            this.txtbx_mac_1_4 = new System.Windows.Forms.TextBox();
            this.txtbx_mac_1_5 = new System.Windows.Forms.TextBox();
            this.txtbx_mac_1_6 = new System.Windows.Forms.TextBox();
            this.lbl_mac_addr_1 = new System.Windows.Forms.Label();
            this.lbl_mac_addr_2 = new System.Windows.Forms.Label();
            this.txtbx_mac_2_6 = new System.Windows.Forms.TextBox();
            this.txtbx_mac_2_5 = new System.Windows.Forms.TextBox();
            this.txtbx_mac_2_4 = new System.Windows.Forms.TextBox();
            this.txtbx_mac_2_3 = new System.Windows.Forms.TextBox();
            this.txtbx_mac_2_2 = new System.Windows.Forms.TextBox();
            this.txtbx_mac_2_1 = new System.Windows.Forms.TextBox();
            this.lbl_mac_addr_3 = new System.Windows.Forms.Label();
            this.txtbx_mac_3_6 = new System.Windows.Forms.TextBox();
            this.txtbx_mac_3_5 = new System.Windows.Forms.TextBox();
            this.txtbx_mac_3_4 = new System.Windows.Forms.TextBox();
            this.txtbx_mac_3_3 = new System.Windows.Forms.TextBox();
            this.txtbx_mac_3_2 = new System.Windows.Forms.TextBox();
            this.txtbx_mac_3_1 = new System.Windows.Forms.TextBox();
            this.lbl_mac_addr_4 = new System.Windows.Forms.Label();
            this.txtbx_mac_4_6 = new System.Windows.Forms.TextBox();
            this.txtbx_mac_4_5 = new System.Windows.Forms.TextBox();
            this.txtbx_mac_4_4 = new System.Windows.Forms.TextBox();
            this.txtbx_mac_4_3 = new System.Windows.Forms.TextBox();
            this.txtbx_mac_4_2 = new System.Windows.Forms.TextBox();
            this.txtbx_mac_4_1 = new System.Windows.Forms.TextBox();
            this.lbl_mac_addr_5 = new System.Windows.Forms.Label();
            this.txtbx_mac_5_6 = new System.Windows.Forms.TextBox();
            this.txtbx_mac_5_5 = new System.Windows.Forms.TextBox();
            this.txtbx_mac_5_4 = new System.Windows.Forms.TextBox();
            this.txtbx_mac_5_3 = new System.Windows.Forms.TextBox();
            this.txtbx_mac_5_2 = new System.Windows.Forms.TextBox();
            this.txtbx_mac_5_1 = new System.Windows.Forms.TextBox();
            this.txtbx_version = new System.Windows.Forms.TextBox();
            this.lbl_version = new System.Windows.Forms.Label();
            this.save_file_dialog = new System.Windows.Forms.SaveFileDialog();
            this.open_file_dialog = new System.Windows.Forms.OpenFileDialog();
            this.btn_create_license = new System.Windows.Forms.Button();
            this.btn_read_license = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numupdwn_no_of_mac)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(518, 37);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(183, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtbx_lic_exp_date
            // 
            this.txtbx_lic_exp_date.Location = new System.Drawing.Point(518, 73);
            this.txtbx_lic_exp_date.MaxLength = 100;
            this.txtbx_lic_exp_date.Name = "txtbx_lic_exp_date";
            this.txtbx_lic_exp_date.Size = new System.Drawing.Size(183, 20);
            this.txtbx_lic_exp_date.TabIndex = 1;
            // 
            // lbl_lic_exp_date
            // 
            this.lbl_lic_exp_date.AutoSize = true;
            this.lbl_lic_exp_date.Location = new System.Drawing.Point(395, 76);
            this.lbl_lic_exp_date.Name = "lbl_lic_exp_date";
            this.lbl_lic_exp_date.Size = new System.Drawing.Size(117, 13);
            this.lbl_lic_exp_date.TabIndex = 2;
            this.lbl_lic_exp_date.Text = "License Expiry Date is  ";
            // 
            // bt_test
            // 
            this.bt_test.Location = new System.Drawing.Point(421, 306);
            this.bt_test.Name = "bt_test";
            this.bt_test.Size = new System.Drawing.Size(75, 23);
            this.bt_test.TabIndex = 3;
            this.bt_test.Text = "test";
            this.bt_test.UseVisualStyleBackColor = true;
            this.bt_test.Click += new System.EventHandler(this.bt_test_Click);
            // 
            // lbl_slct_date_expry
            // 
            this.lbl_slct_date_expry.AutoSize = true;
            this.lbl_slct_date_expry.Location = new System.Drawing.Point(370, 43);
            this.lbl_slct_date_expry.Name = "lbl_slct_date_expry";
            this.lbl_slct_date_expry.Size = new System.Drawing.Size(142, 13);
            this.lbl_slct_date_expry.TabIndex = 4;
            this.lbl_slct_date_expry.Text = "Select  License Validity Date";
            // 
            // numupdwn_no_of_mac
            // 
            this.numupdwn_no_of_mac.Location = new System.Drawing.Point(626, 99);
            this.numupdwn_no_of_mac.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numupdwn_no_of_mac.Name = "numupdwn_no_of_mac";
            this.numupdwn_no_of_mac.Size = new System.Drawing.Size(35, 20);
            this.numupdwn_no_of_mac.TabIndex = 5;
            this.numupdwn_no_of_mac.ValueChanged += new System.EventHandler(this.numupdwn_no_of_mac_ValueChanged);
            // 
            // lbl_no_of_mac
            // 
            this.lbl_no_of_mac.AutoSize = true;
            this.lbl_no_of_mac.Location = new System.Drawing.Point(412, 103);
            this.lbl_no_of_mac.Name = "lbl_no_of_mac";
            this.lbl_no_of_mac.Size = new System.Drawing.Size(201, 13);
            this.lbl_no_of_mac.TabIndex = 6;
            this.lbl_no_of_mac.Text = "Select number of MAC add to be inserted";
            // 
            // txtbx_mac_1_1
            // 
            this.txtbx_mac_1_1.Location = new System.Drawing.Point(518, 124);
            this.txtbx_mac_1_1.MaxLength = 2;
            this.txtbx_mac_1_1.Name = "txtbx_mac_1_1";
            this.txtbx_mac_1_1.Size = new System.Drawing.Size(30, 20);
            this.txtbx_mac_1_1.TabIndex = 7;
            // 
            // txtbx_mac_1_2
            // 
            this.txtbx_mac_1_2.Location = new System.Drawing.Point(554, 124);
            this.txtbx_mac_1_2.MaxLength = 2;
            this.txtbx_mac_1_2.Name = "txtbx_mac_1_2";
            this.txtbx_mac_1_2.Size = new System.Drawing.Size(30, 20);
            this.txtbx_mac_1_2.TabIndex = 8;
            // 
            // txtbx_mac_1_3
            // 
            this.txtbx_mac_1_3.Location = new System.Drawing.Point(590, 124);
            this.txtbx_mac_1_3.MaxLength = 2;
            this.txtbx_mac_1_3.Name = "txtbx_mac_1_3";
            this.txtbx_mac_1_3.Size = new System.Drawing.Size(30, 20);
            this.txtbx_mac_1_3.TabIndex = 9;
            // 
            // txtbx_mac_1_4
            // 
            this.txtbx_mac_1_4.Location = new System.Drawing.Point(626, 124);
            this.txtbx_mac_1_4.MaxLength = 2;
            this.txtbx_mac_1_4.Name = "txtbx_mac_1_4";
            this.txtbx_mac_1_4.Size = new System.Drawing.Size(30, 20);
            this.txtbx_mac_1_4.TabIndex = 10;
            // 
            // txtbx_mac_1_5
            // 
            this.txtbx_mac_1_5.Location = new System.Drawing.Point(662, 124);
            this.txtbx_mac_1_5.MaxLength = 2;
            this.txtbx_mac_1_5.Name = "txtbx_mac_1_5";
            this.txtbx_mac_1_5.Size = new System.Drawing.Size(30, 20);
            this.txtbx_mac_1_5.TabIndex = 11;
            // 
            // txtbx_mac_1_6
            // 
            this.txtbx_mac_1_6.Location = new System.Drawing.Point(698, 124);
            this.txtbx_mac_1_6.MaxLength = 2;
            this.txtbx_mac_1_6.Name = "txtbx_mac_1_6";
            this.txtbx_mac_1_6.Size = new System.Drawing.Size(30, 20);
            this.txtbx_mac_1_6.TabIndex = 12;
            // 
            // lbl_mac_addr_1
            // 
            this.lbl_mac_addr_1.AutoSize = true;
            this.lbl_mac_addr_1.Location = new System.Drawing.Point(418, 128);
            this.lbl_mac_addr_1.Name = "lbl_mac_addr_1";
            this.lbl_mac_addr_1.Size = new System.Drawing.Size(94, 13);
            this.lbl_mac_addr_1.TabIndex = 13;
            this.lbl_mac_addr_1.Text = "MAC ADDRESS 1";
            // 
            // lbl_mac_addr_2
            // 
            this.lbl_mac_addr_2.AutoSize = true;
            this.lbl_mac_addr_2.Location = new System.Drawing.Point(418, 161);
            this.lbl_mac_addr_2.Name = "lbl_mac_addr_2";
            this.lbl_mac_addr_2.Size = new System.Drawing.Size(94, 13);
            this.lbl_mac_addr_2.TabIndex = 20;
            this.lbl_mac_addr_2.Text = "MAC ADDRESS 2";
            // 
            // txtbx_mac_2_6
            // 
            this.txtbx_mac_2_6.Location = new System.Drawing.Point(698, 157);
            this.txtbx_mac_2_6.MaxLength = 2;
            this.txtbx_mac_2_6.Name = "txtbx_mac_2_6";
            this.txtbx_mac_2_6.Size = new System.Drawing.Size(30, 20);
            this.txtbx_mac_2_6.TabIndex = 19;
            // 
            // txtbx_mac_2_5
            // 
            this.txtbx_mac_2_5.Location = new System.Drawing.Point(662, 157);
            this.txtbx_mac_2_5.MaxLength = 2;
            this.txtbx_mac_2_5.Name = "txtbx_mac_2_5";
            this.txtbx_mac_2_5.Size = new System.Drawing.Size(30, 20);
            this.txtbx_mac_2_5.TabIndex = 18;
            // 
            // txtbx_mac_2_4
            // 
            this.txtbx_mac_2_4.Location = new System.Drawing.Point(626, 157);
            this.txtbx_mac_2_4.MaxLength = 2;
            this.txtbx_mac_2_4.Name = "txtbx_mac_2_4";
            this.txtbx_mac_2_4.Size = new System.Drawing.Size(30, 20);
            this.txtbx_mac_2_4.TabIndex = 17;
            // 
            // txtbx_mac_2_3
            // 
            this.txtbx_mac_2_3.Location = new System.Drawing.Point(590, 157);
            this.txtbx_mac_2_3.MaxLength = 2;
            this.txtbx_mac_2_3.Name = "txtbx_mac_2_3";
            this.txtbx_mac_2_3.Size = new System.Drawing.Size(30, 20);
            this.txtbx_mac_2_3.TabIndex = 16;
            // 
            // txtbx_mac_2_2
            // 
            this.txtbx_mac_2_2.Location = new System.Drawing.Point(554, 157);
            this.txtbx_mac_2_2.MaxLength = 2;
            this.txtbx_mac_2_2.Name = "txtbx_mac_2_2";
            this.txtbx_mac_2_2.Size = new System.Drawing.Size(30, 20);
            this.txtbx_mac_2_2.TabIndex = 15;
            // 
            // txtbx_mac_2_1
            // 
            this.txtbx_mac_2_1.Location = new System.Drawing.Point(518, 157);
            this.txtbx_mac_2_1.MaxLength = 2;
            this.txtbx_mac_2_1.Name = "txtbx_mac_2_1";
            this.txtbx_mac_2_1.Size = new System.Drawing.Size(30, 20);
            this.txtbx_mac_2_1.TabIndex = 14;
            // 
            // lbl_mac_addr_3
            // 
            this.lbl_mac_addr_3.AutoSize = true;
            this.lbl_mac_addr_3.Location = new System.Drawing.Point(418, 194);
            this.lbl_mac_addr_3.Name = "lbl_mac_addr_3";
            this.lbl_mac_addr_3.Size = new System.Drawing.Size(94, 13);
            this.lbl_mac_addr_3.TabIndex = 27;
            this.lbl_mac_addr_3.Text = "MAC ADDRESS 3";
            // 
            // txtbx_mac_3_6
            // 
            this.txtbx_mac_3_6.Location = new System.Drawing.Point(698, 190);
            this.txtbx_mac_3_6.MaxLength = 2;
            this.txtbx_mac_3_6.Name = "txtbx_mac_3_6";
            this.txtbx_mac_3_6.Size = new System.Drawing.Size(30, 20);
            this.txtbx_mac_3_6.TabIndex = 26;
            // 
            // txtbx_mac_3_5
            // 
            this.txtbx_mac_3_5.Location = new System.Drawing.Point(662, 190);
            this.txtbx_mac_3_5.MaxLength = 2;
            this.txtbx_mac_3_5.Name = "txtbx_mac_3_5";
            this.txtbx_mac_3_5.Size = new System.Drawing.Size(30, 20);
            this.txtbx_mac_3_5.TabIndex = 25;
            // 
            // txtbx_mac_3_4
            // 
            this.txtbx_mac_3_4.Location = new System.Drawing.Point(626, 190);
            this.txtbx_mac_3_4.MaxLength = 2;
            this.txtbx_mac_3_4.Name = "txtbx_mac_3_4";
            this.txtbx_mac_3_4.Size = new System.Drawing.Size(30, 20);
            this.txtbx_mac_3_4.TabIndex = 24;
            // 
            // txtbx_mac_3_3
            // 
            this.txtbx_mac_3_3.Location = new System.Drawing.Point(590, 190);
            this.txtbx_mac_3_3.MaxLength = 2;
            this.txtbx_mac_3_3.Name = "txtbx_mac_3_3";
            this.txtbx_mac_3_3.Size = new System.Drawing.Size(30, 20);
            this.txtbx_mac_3_3.TabIndex = 23;
            // 
            // txtbx_mac_3_2
            // 
            this.txtbx_mac_3_2.Location = new System.Drawing.Point(554, 190);
            this.txtbx_mac_3_2.MaxLength = 2;
            this.txtbx_mac_3_2.Name = "txtbx_mac_3_2";
            this.txtbx_mac_3_2.Size = new System.Drawing.Size(30, 20);
            this.txtbx_mac_3_2.TabIndex = 22;
            // 
            // txtbx_mac_3_1
            // 
            this.txtbx_mac_3_1.Location = new System.Drawing.Point(518, 190);
            this.txtbx_mac_3_1.MaxLength = 2;
            this.txtbx_mac_3_1.Name = "txtbx_mac_3_1";
            this.txtbx_mac_3_1.Size = new System.Drawing.Size(30, 20);
            this.txtbx_mac_3_1.TabIndex = 21;
            // 
            // lbl_mac_addr_4
            // 
            this.lbl_mac_addr_4.AutoSize = true;
            this.lbl_mac_addr_4.Location = new System.Drawing.Point(418, 227);
            this.lbl_mac_addr_4.Name = "lbl_mac_addr_4";
            this.lbl_mac_addr_4.Size = new System.Drawing.Size(94, 13);
            this.lbl_mac_addr_4.TabIndex = 34;
            this.lbl_mac_addr_4.Text = "MAC ADDRESS 4";
            // 
            // txtbx_mac_4_6
            // 
            this.txtbx_mac_4_6.Location = new System.Drawing.Point(698, 223);
            this.txtbx_mac_4_6.MaxLength = 2;
            this.txtbx_mac_4_6.Name = "txtbx_mac_4_6";
            this.txtbx_mac_4_6.Size = new System.Drawing.Size(30, 20);
            this.txtbx_mac_4_6.TabIndex = 33;
            // 
            // txtbx_mac_4_5
            // 
            this.txtbx_mac_4_5.Location = new System.Drawing.Point(662, 223);
            this.txtbx_mac_4_5.MaxLength = 2;
            this.txtbx_mac_4_5.Name = "txtbx_mac_4_5";
            this.txtbx_mac_4_5.Size = new System.Drawing.Size(30, 20);
            this.txtbx_mac_4_5.TabIndex = 32;
            // 
            // txtbx_mac_4_4
            // 
            this.txtbx_mac_4_4.Location = new System.Drawing.Point(626, 223);
            this.txtbx_mac_4_4.MaxLength = 2;
            this.txtbx_mac_4_4.Name = "txtbx_mac_4_4";
            this.txtbx_mac_4_4.Size = new System.Drawing.Size(30, 20);
            this.txtbx_mac_4_4.TabIndex = 31;
            // 
            // txtbx_mac_4_3
            // 
            this.txtbx_mac_4_3.Location = new System.Drawing.Point(590, 223);
            this.txtbx_mac_4_3.MaxLength = 2;
            this.txtbx_mac_4_3.Name = "txtbx_mac_4_3";
            this.txtbx_mac_4_3.Size = new System.Drawing.Size(30, 20);
            this.txtbx_mac_4_3.TabIndex = 30;
            // 
            // txtbx_mac_4_2
            // 
            this.txtbx_mac_4_2.Location = new System.Drawing.Point(554, 223);
            this.txtbx_mac_4_2.MaxLength = 2;
            this.txtbx_mac_4_2.Name = "txtbx_mac_4_2";
            this.txtbx_mac_4_2.Size = new System.Drawing.Size(30, 20);
            this.txtbx_mac_4_2.TabIndex = 29;
            // 
            // txtbx_mac_4_1
            // 
            this.txtbx_mac_4_1.Location = new System.Drawing.Point(518, 223);
            this.txtbx_mac_4_1.MaxLength = 2;
            this.txtbx_mac_4_1.Name = "txtbx_mac_4_1";
            this.txtbx_mac_4_1.Size = new System.Drawing.Size(30, 20);
            this.txtbx_mac_4_1.TabIndex = 28;
            // 
            // lbl_mac_addr_5
            // 
            this.lbl_mac_addr_5.AutoSize = true;
            this.lbl_mac_addr_5.Location = new System.Drawing.Point(418, 260);
            this.lbl_mac_addr_5.Name = "lbl_mac_addr_5";
            this.lbl_mac_addr_5.Size = new System.Drawing.Size(94, 13);
            this.lbl_mac_addr_5.TabIndex = 41;
            this.lbl_mac_addr_5.Text = "MAC ADDRESS 5";
            // 
            // txtbx_mac_5_6
            // 
            this.txtbx_mac_5_6.Location = new System.Drawing.Point(698, 256);
            this.txtbx_mac_5_6.MaxLength = 2;
            this.txtbx_mac_5_6.Name = "txtbx_mac_5_6";
            this.txtbx_mac_5_6.Size = new System.Drawing.Size(30, 20);
            this.txtbx_mac_5_6.TabIndex = 40;
            // 
            // txtbx_mac_5_5
            // 
            this.txtbx_mac_5_5.Location = new System.Drawing.Point(662, 256);
            this.txtbx_mac_5_5.MaxLength = 2;
            this.txtbx_mac_5_5.Name = "txtbx_mac_5_5";
            this.txtbx_mac_5_5.Size = new System.Drawing.Size(30, 20);
            this.txtbx_mac_5_5.TabIndex = 39;
            // 
            // txtbx_mac_5_4
            // 
            this.txtbx_mac_5_4.Location = new System.Drawing.Point(626, 256);
            this.txtbx_mac_5_4.MaxLength = 2;
            this.txtbx_mac_5_4.Name = "txtbx_mac_5_4";
            this.txtbx_mac_5_4.Size = new System.Drawing.Size(30, 20);
            this.txtbx_mac_5_4.TabIndex = 38;
            // 
            // txtbx_mac_5_3
            // 
            this.txtbx_mac_5_3.Location = new System.Drawing.Point(590, 256);
            this.txtbx_mac_5_3.MaxLength = 2;
            this.txtbx_mac_5_3.Name = "txtbx_mac_5_3";
            this.txtbx_mac_5_3.Size = new System.Drawing.Size(30, 20);
            this.txtbx_mac_5_3.TabIndex = 37;
            // 
            // txtbx_mac_5_2
            // 
            this.txtbx_mac_5_2.Location = new System.Drawing.Point(554, 256);
            this.txtbx_mac_5_2.MaxLength = 2;
            this.txtbx_mac_5_2.Name = "txtbx_mac_5_2";
            this.txtbx_mac_5_2.Size = new System.Drawing.Size(30, 20);
            this.txtbx_mac_5_2.TabIndex = 36;
            // 
            // txtbx_mac_5_1
            // 
            this.txtbx_mac_5_1.Location = new System.Drawing.Point(518, 256);
            this.txtbx_mac_5_1.MaxLength = 2;
            this.txtbx_mac_5_1.Name = "txtbx_mac_5_1";
            this.txtbx_mac_5_1.Size = new System.Drawing.Size(30, 20);
            this.txtbx_mac_5_1.TabIndex = 35;
            // 
            // txtbx_version
            // 
            this.txtbx_version.Location = new System.Drawing.Point(518, 12);
            this.txtbx_version.MaxLength = 16;
            this.txtbx_version.Name = "txtbx_version";
            this.txtbx_version.ReadOnly = true;
            this.txtbx_version.Size = new System.Drawing.Size(123, 20);
            this.txtbx_version.TabIndex = 42;
            this.txtbx_version.Text = "ACCMNGR1_1_1.1_1";
            // 
            // lbl_version
            // 
            this.lbl_version.AutoSize = true;
            this.lbl_version.Location = new System.Drawing.Point(470, 15);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(42, 13);
            this.lbl_version.TabIndex = 43;
            this.lbl_version.Text = "Version";
            // 
            // save_file_dialog
            // 
            this.save_file_dialog.DefaultExt = "DAT";
            this.save_file_dialog.Filter = "LICENSE FILE (*.DAT)|*.DAT";
            // 
            // open_file_dialog
            // 
            this.open_file_dialog.DefaultExt = "DAT";
            this.open_file_dialog.FileName = "LICENSE.DAT";
            this.open_file_dialog.Filter = "LICENSE FILE (*.DAT)|*.DAT";
            // 
            // btn_create_license
            // 
            this.btn_create_license.Location = new System.Drawing.Point(626, 306);
            this.btn_create_license.Name = "btn_create_license";
            this.btn_create_license.Size = new System.Drawing.Size(102, 23);
            this.btn_create_license.TabIndex = 44;
            this.btn_create_license.Text = "CREATE";
            this.btn_create_license.UseVisualStyleBackColor = true;
            this.btn_create_license.Click += new System.EventHandler(this.btn_create_license_Click);
            // 
            // btn_read_license
            // 
            this.btn_read_license.Location = new System.Drawing.Point(518, 306);
            this.btn_read_license.Name = "btn_read_license";
            this.btn_read_license.Size = new System.Drawing.Size(102, 23);
            this.btn_read_license.TabIndex = 45;
            this.btn_read_license.Text = "READ";
            this.btn_read_license.UseVisualStyleBackColor = true;
            this.btn_read_license.Click += new System.EventHandler(this.btn_read_license_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 369);
            this.Controls.Add(this.btn_read_license);
            this.Controls.Add(this.btn_create_license);
            this.Controls.Add(this.lbl_version);
            this.Controls.Add(this.txtbx_version);
            this.Controls.Add(this.lbl_mac_addr_5);
            this.Controls.Add(this.txtbx_mac_5_6);
            this.Controls.Add(this.txtbx_mac_5_5);
            this.Controls.Add(this.txtbx_mac_5_4);
            this.Controls.Add(this.txtbx_mac_5_3);
            this.Controls.Add(this.txtbx_mac_5_2);
            this.Controls.Add(this.txtbx_mac_5_1);
            this.Controls.Add(this.lbl_mac_addr_4);
            this.Controls.Add(this.txtbx_mac_4_6);
            this.Controls.Add(this.txtbx_mac_4_5);
            this.Controls.Add(this.txtbx_mac_4_4);
            this.Controls.Add(this.txtbx_mac_4_3);
            this.Controls.Add(this.txtbx_mac_4_2);
            this.Controls.Add(this.txtbx_mac_4_1);
            this.Controls.Add(this.lbl_mac_addr_3);
            this.Controls.Add(this.txtbx_mac_3_6);
            this.Controls.Add(this.txtbx_mac_3_5);
            this.Controls.Add(this.txtbx_mac_3_4);
            this.Controls.Add(this.txtbx_mac_3_3);
            this.Controls.Add(this.txtbx_mac_3_2);
            this.Controls.Add(this.txtbx_mac_3_1);
            this.Controls.Add(this.lbl_mac_addr_2);
            this.Controls.Add(this.txtbx_mac_2_6);
            this.Controls.Add(this.txtbx_mac_2_5);
            this.Controls.Add(this.txtbx_mac_2_4);
            this.Controls.Add(this.txtbx_mac_2_3);
            this.Controls.Add(this.txtbx_mac_2_2);
            this.Controls.Add(this.txtbx_mac_2_1);
            this.Controls.Add(this.lbl_mac_addr_1);
            this.Controls.Add(this.txtbx_mac_1_6);
            this.Controls.Add(this.txtbx_mac_1_5);
            this.Controls.Add(this.txtbx_mac_1_4);
            this.Controls.Add(this.txtbx_mac_1_3);
            this.Controls.Add(this.txtbx_mac_1_2);
            this.Controls.Add(this.txtbx_mac_1_1);
            this.Controls.Add(this.lbl_no_of_mac);
            this.Controls.Add(this.numupdwn_no_of_mac);
            this.Controls.Add(this.lbl_slct_date_expry);
            this.Controls.Add(this.bt_test);
            this.Controls.Add(this.lbl_lic_exp_date);
            this.Controls.Add(this.txtbx_lic_exp_date);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form1";
            this.Text = "License Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numupdwn_no_of_mac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtbx_lic_exp_date;
        private System.Windows.Forms.Label lbl_lic_exp_date;
        private System.Windows.Forms.Button bt_test;
        private System.Windows.Forms.Label lbl_slct_date_expry;
        private System.Windows.Forms.NumericUpDown numupdwn_no_of_mac;
        private System.Windows.Forms.Label lbl_no_of_mac;
        private System.Windows.Forms.TextBox txtbx_mac_1_1;
        private System.Windows.Forms.TextBox txtbx_mac_1_2;
        private System.Windows.Forms.TextBox txtbx_mac_1_3;
        private System.Windows.Forms.TextBox txtbx_mac_1_4;
        private System.Windows.Forms.TextBox txtbx_mac_1_5;
        private System.Windows.Forms.TextBox txtbx_mac_1_6;
        private System.Windows.Forms.Label lbl_mac_addr_1;
        private System.Windows.Forms.Label lbl_mac_addr_2;
        private System.Windows.Forms.TextBox txtbx_mac_2_6;
        private System.Windows.Forms.TextBox txtbx_mac_2_5;
        private System.Windows.Forms.TextBox txtbx_mac_2_4;
        private System.Windows.Forms.TextBox txtbx_mac_2_3;
        private System.Windows.Forms.TextBox txtbx_mac_2_2;
        private System.Windows.Forms.TextBox txtbx_mac_2_1;
        private System.Windows.Forms.Label lbl_mac_addr_3;
        private System.Windows.Forms.TextBox txtbx_mac_3_6;
        private System.Windows.Forms.TextBox txtbx_mac_3_5;
        private System.Windows.Forms.TextBox txtbx_mac_3_4;
        private System.Windows.Forms.TextBox txtbx_mac_3_3;
        private System.Windows.Forms.TextBox txtbx_mac_3_2;
        private System.Windows.Forms.TextBox txtbx_mac_3_1;
        private System.Windows.Forms.Label lbl_mac_addr_4;
        private System.Windows.Forms.TextBox txtbx_mac_4_6;
        private System.Windows.Forms.TextBox txtbx_mac_4_5;
        private System.Windows.Forms.TextBox txtbx_mac_4_4;
        private System.Windows.Forms.TextBox txtbx_mac_4_3;
        private System.Windows.Forms.TextBox txtbx_mac_4_2;
        private System.Windows.Forms.TextBox txtbx_mac_4_1;
        private System.Windows.Forms.Label lbl_mac_addr_5;
        private System.Windows.Forms.TextBox txtbx_mac_5_6;
        private System.Windows.Forms.TextBox txtbx_mac_5_5;
        private System.Windows.Forms.TextBox txtbx_mac_5_4;
        private System.Windows.Forms.TextBox txtbx_mac_5_3;
        private System.Windows.Forms.TextBox txtbx_mac_5_2;
        private System.Windows.Forms.TextBox txtbx_mac_5_1;
        private System.Windows.Forms.TextBox txtbx_version;
        private System.Windows.Forms.Label lbl_version;
        private System.Windows.Forms.SaveFileDialog save_file_dialog;
        private System.Windows.Forms.OpenFileDialog open_file_dialog;
        private System.Windows.Forms.Button btn_create_license;
        private System.Windows.Forms.Button btn_read_license;
    }
}

