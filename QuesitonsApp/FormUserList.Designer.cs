namespace QuesitonsApp
{
    partial class FormUserList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserList));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quesitonAppDataSet3 = new QuesitonsApp.QuesitonAppDataSet3();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUserDelete = new System.Windows.Forms.Button();
            this.cmbUserTypeId = new System.Windows.Forms.ComboBox();
            this.BtnAddUser = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lblNewDate = new System.Windows.Forms.Label();
            this.btnaUpdateUser = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tblQuestionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fillAllUserToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillAllUserToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fillStudentToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillStudentToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fillTeacherToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillTeacherToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fillAdminToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillAdminToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tbl_UserTableAdapter = new QuesitonsApp.QuesitonAppDataSet3TableAdapters.Tbl_UserTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quesitonAppDataSet3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblQuestionBindingSource)).BeginInit();
            this.fillAllUserToolStrip.SuspendLayout();
            this.fillStudentToolStrip.SuspendLayout();
            this.fillTeacherToolStrip.SuspendLayout();
            this.fillAdminToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRefresh.FlatAppearance.BorderSize = 3;
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Headline R", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRefresh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRefresh.Location = new System.Drawing.Point(1344, 722);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(14, 16);
            this.btnRefresh.TabIndex = 129;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.userTypeIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblUserBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(259, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1119, 702);
            this.dataGridView1.TabIndex = 128;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIDDataGridViewTextBoxColumn.Width = 90;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 180;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.Width = 160;
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            this.mailDataGridViewTextBoxColumn.Width = 260;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // userTypeIDDataGridViewTextBoxColumn
            // 
            this.userTypeIDDataGridViewTextBoxColumn.DataPropertyName = "UserTypeID";
            this.userTypeIDDataGridViewTextBoxColumn.HeaderText = "UserTypeID";
            this.userTypeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userTypeIDDataGridViewTextBoxColumn.Name = "userTypeIDDataGridViewTextBoxColumn";
            this.userTypeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblUserBindingSource
            // 
            this.tblUserBindingSource.DataMember = "Tbl_User";
            this.tblUserBindingSource.DataSource = this.quesitonAppDataSet3;
            // 
            // quesitonAppDataSet3
            // 
            this.quesitonAppDataSet3.DataSetName = "QuesitonAppDataSet3";
            this.quesitonAppDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnUserDelete);
            this.panel1.Controls.Add(this.cmbUserTypeId);
            this.panel1.Controls.Add(this.BtnAddUser);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtMail);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtSurname);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.txtUserID);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.lblNewDate);
            this.panel1.Controls.Add(this.btnaUpdateUser);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 807);
            this.panel1.TabIndex = 127;
            // 
            // btnUserDelete
            // 
            this.btnUserDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnUserDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUserDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUserDelete.FlatAppearance.BorderSize = 3;
            this.btnUserDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnUserDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnUserDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserDelete.Font = new System.Drawing.Font("Headline R", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnUserDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUserDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUserDelete.Location = new System.Drawing.Point(141, 669);
            this.btnUserDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnUserDelete.Name = "btnUserDelete";
            this.btnUserDelete.Size = new System.Drawing.Size(112, 68);
            this.btnUserDelete.TabIndex = 121;
            this.btnUserDelete.Text = "Delete User";
            this.btnUserDelete.UseVisualStyleBackColor = false;
            this.btnUserDelete.Click += new System.EventHandler(this.btnUserDelete_Click);
            // 
            // cmbUserTypeId
            // 
            this.cmbUserTypeId.BackColor = System.Drawing.Color.MistyRose;
            this.cmbUserTypeId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbUserTypeId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbUserTypeId.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmbUserTypeId.FormattingEnabled = true;
            this.cmbUserTypeId.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbUserTypeId.Location = new System.Drawing.Point(170, 522);
            this.cmbUserTypeId.Margin = new System.Windows.Forms.Padding(2);
            this.cmbUserTypeId.Name = "cmbUserTypeId";
            this.cmbUserTypeId.Size = new System.Drawing.Size(52, 31);
            this.cmbUserTypeId.TabIndex = 120;
            // 
            // BtnAddUser
            // 
            this.BtnAddUser.BackColor = System.Drawing.Color.Transparent;
            this.BtnAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddUser.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnAddUser.FlatAppearance.BorderSize = 3;
            this.BtnAddUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BtnAddUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddUser.Font = new System.Drawing.Font("Headline R", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnAddUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAddUser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnAddUser.Location = new System.Drawing.Point(2, 575);
            this.BtnAddUser.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAddUser.Name = "BtnAddUser";
            this.BtnAddUser.Size = new System.Drawing.Size(112, 68);
            this.BtnAddUser.TabIndex = 119;
            this.BtnAddUser.Text = "Add User";
            this.BtnAddUser.UseVisualStyleBackColor = false;
            this.BtnAddUser.Click += new System.EventHandler(this.BtnAddUser_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.MistyRose;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPassword.Location = new System.Drawing.Point(112, 484);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.MaxLength = 25;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(110, 30);
            this.txtPassword.TabIndex = 117;
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.MistyRose;
            this.txtMail.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtMail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMail.Location = new System.Drawing.Point(70, 442);
            this.txtMail.Margin = new System.Windows.Forms.Padding(2);
            this.txtMail.MaxLength = 25;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(152, 30);
            this.txtMail.TabIndex = 116;
            this.txtMail.Text = " ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(11, 522);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 23);
            this.label6.TabIndex = 115;
            this.label6.Text = "User Type Id :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(12, 481);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 23);
            this.label5.TabIndex = 114;
            this.label5.Text = "Password :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(11, 439);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 23);
            this.label3.TabIndex = 113;
            this.label3.Text = "Mail :";
            // 
            // txtSurname
            // 
            this.txtSurname.BackColor = System.Drawing.Color.MistyRose;
            this.txtSurname.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtSurname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSurname.Location = new System.Drawing.Point(105, 402);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(2);
            this.txtSurname.MaxLength = 25;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(117, 30);
            this.txtSurname.TabIndex = 112;
            this.txtSurname.Text = " ";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.MistyRose;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtName.Location = new System.Drawing.Point(83, 361);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.MaxLength = 25;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(139, 30);
            this.txtName.TabIndex = 111;
            this.txtName.Text = " ";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.MistyRose;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtUsername.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtUsername.Location = new System.Drawing.Point(114, 324);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.MaxLength = 25;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(108, 30);
            this.txtUsername.TabIndex = 110;
            this.txtUsername.Text = " ";
            // 
            // txtUserID
            // 
            this.txtUserID.BackColor = System.Drawing.Color.MistyRose;
            this.txtUserID.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtUserID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtUserID.Location = new System.Drawing.Point(156, 283);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserID.MaxLength = 25;
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(66, 30);
            this.txtUserID.TabIndex = 109;
            this.txtUserID.Text = " ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label17.Location = new System.Drawing.Point(12, 280);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 23);
            this.label17.TabIndex = 108;
            this.label17.Text = "User Id : ";
            this.label17.Visible = false;
            // 
            // lblNewDate
            // 
            this.lblNewDate.AutoSize = true;
            this.lblNewDate.BackColor = System.Drawing.Color.Transparent;
            this.lblNewDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblNewDate.Location = new System.Drawing.Point(11, 632);
            this.lblNewDate.Name = "lblNewDate";
            this.lblNewDate.Size = new System.Drawing.Size(0, 23);
            this.lblNewDate.TabIndex = 101;
            // 
            // btnaUpdateUser
            // 
            this.btnaUpdateUser.BackColor = System.Drawing.Color.Transparent;
            this.btnaUpdateUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnaUpdateUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaUpdateUser.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnaUpdateUser.FlatAppearance.BorderSize = 3;
            this.btnaUpdateUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnaUpdateUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnaUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaUpdateUser.Font = new System.Drawing.Font("Headline R", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnaUpdateUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnaUpdateUser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnaUpdateUser.Location = new System.Drawing.Point(141, 575);
            this.btnaUpdateUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnaUpdateUser.Name = "btnaUpdateUser";
            this.btnaUpdateUser.Size = new System.Drawing.Size(112, 68);
            this.btnaUpdateUser.TabIndex = 99;
            this.btnaUpdateUser.Text = "Update User";
            this.btnaUpdateUser.UseVisualStyleBackColor = false;
            this.btnaUpdateUser.Click += new System.EventHandler(this.btnaUpdateUser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-15, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 97;
            this.pictureBox1.TabStop = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Headline R", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button6.Location = new System.Drawing.Point(10, 752);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(46, 43);
            this.button6.TabIndex = 94;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(11, 399);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 23);
            this.label4.TabIndex = 72;
            this.label4.Text = "Surname :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(11, 321);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 23);
            this.label1.TabIndex = 59;
            this.label1.Text = "Username :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(11, 358);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 60;
            this.label2.Text = "Name :";
            // 
            // fillAllUserToolStrip
            // 
            this.fillAllUserToolStrip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fillAllUserToolStrip.BackgroundImage")));
            this.fillAllUserToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillAllUserToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillAllUserToolStripButton});
            this.fillAllUserToolStrip.Location = new System.Drawing.Point(257, 0);
            this.fillAllUserToolStrip.Name = "fillAllUserToolStrip";
            this.fillAllUserToolStrip.Size = new System.Drawing.Size(1121, 30);
            this.fillAllUserToolStrip.TabIndex = 130;
            this.fillAllUserToolStrip.Text = "fillAllUserToolStrip";
            // 
            // fillAllUserToolStripButton
            // 
            this.fillAllUserToolStripButton.BackColor = System.Drawing.Color.PeachPuff;
            this.fillAllUserToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillAllUserToolStripButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.fillAllUserToolStripButton.Name = "fillAllUserToolStripButton";
            this.fillAllUserToolStripButton.Size = new System.Drawing.Size(81, 27);
            this.fillAllUserToolStripButton.Text = "User List";
            this.fillAllUserToolStripButton.Click += new System.EventHandler(this.fillAllUserToolStripButton_Click);
            // 
            // fillStudentToolStrip
            // 
            this.fillStudentToolStrip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fillStudentToolStrip.BackgroundImage")));
            this.fillStudentToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillStudentToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillStudentToolStripButton});
            this.fillStudentToolStrip.Location = new System.Drawing.Point(257, 30);
            this.fillStudentToolStrip.Name = "fillStudentToolStrip";
            this.fillStudentToolStrip.Size = new System.Drawing.Size(1121, 30);
            this.fillStudentToolStrip.TabIndex = 131;
            this.fillStudentToolStrip.Text = "fillStudentToolStrip";
            // 
            // fillStudentToolStripButton
            // 
            this.fillStudentToolStripButton.BackColor = System.Drawing.Color.PeachPuff;
            this.fillStudentToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillStudentToolStripButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.fillStudentToolStripButton.Name = "fillStudentToolStripButton";
            this.fillStudentToolStripButton.Size = new System.Drawing.Size(106, 27);
            this.fillStudentToolStripButton.Text = "Student List";
            this.fillStudentToolStripButton.Click += new System.EventHandler(this.fillStudentToolStripButton_Click);
            // 
            // fillTeacherToolStrip
            // 
            this.fillTeacherToolStrip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fillTeacherToolStrip.BackgroundImage")));
            this.fillTeacherToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillTeacherToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillTeacherToolStripButton});
            this.fillTeacherToolStrip.Location = new System.Drawing.Point(257, 60);
            this.fillTeacherToolStrip.Name = "fillTeacherToolStrip";
            this.fillTeacherToolStrip.Size = new System.Drawing.Size(1121, 30);
            this.fillTeacherToolStrip.TabIndex = 132;
            this.fillTeacherToolStrip.Text = "fillTeacherToolStrip";
            // 
            // fillTeacherToolStripButton
            // 
            this.fillTeacherToolStripButton.BackColor = System.Drawing.Color.PeachPuff;
            this.fillTeacherToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillTeacherToolStripButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.fillTeacherToolStripButton.Name = "fillTeacherToolStripButton";
            this.fillTeacherToolStripButton.Size = new System.Drawing.Size(109, 27);
            this.fillTeacherToolStripButton.Text = "Teacher List";
            this.fillTeacherToolStripButton.Click += new System.EventHandler(this.fillTeacherToolStripButton_Click);
            // 
            // fillAdminToolStrip
            // 
            this.fillAdminToolStrip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fillAdminToolStrip.BackgroundImage")));
            this.fillAdminToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillAdminToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillAdminToolStripButton});
            this.fillAdminToolStrip.Location = new System.Drawing.Point(257, 90);
            this.fillAdminToolStrip.Name = "fillAdminToolStrip";
            this.fillAdminToolStrip.Size = new System.Drawing.Size(1121, 30);
            this.fillAdminToolStrip.TabIndex = 133;
            this.fillAdminToolStrip.Text = "fillAdminToolStrip";
            // 
            // fillAdminToolStripButton
            // 
            this.fillAdminToolStripButton.BackColor = System.Drawing.Color.PeachPuff;
            this.fillAdminToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillAdminToolStripButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.fillAdminToolStripButton.Name = "fillAdminToolStripButton";
            this.fillAdminToolStripButton.Size = new System.Drawing.Size(98, 27);
            this.fillAdminToolStripButton.Text = "Admin List";
            this.fillAdminToolStripButton.Click += new System.EventHandler(this.fillAdminToolStripButton_Click);
            // 
            // tbl_UserTableAdapter
            // 
            this.tbl_UserTableAdapter.ClearBeforeFill = true;
            // 
            // FormUserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1378, 807);
            this.Controls.Add(this.fillAdminToolStrip);
            this.Controls.Add(this.fillTeacherToolStrip);
            this.Controls.Add(this.fillStudentToolStrip);
            this.Controls.Add(this.fillAllUserToolStrip);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUserList";
            this.Text = "FormUserList";
            this.Load += new System.EventHandler(this.FormUserList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quesitonAppDataSet3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblQuestionBindingSource)).EndInit();
            this.fillAllUserToolStrip.ResumeLayout(false);
            this.fillAllUserToolStrip.PerformLayout();
            this.fillStudentToolStrip.ResumeLayout(false);
            this.fillStudentToolStrip.PerformLayout();
            this.fillTeacherToolStrip.ResumeLayout(false);
            this.fillTeacherToolStrip.PerformLayout();
            this.fillAdminToolStrip.ResumeLayout(false);
            this.fillAdminToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUserDelete;
        private System.Windows.Forms.ComboBox cmbUserTypeId;
        private System.Windows.Forms.Button BtnAddUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblNewDate;
        private System.Windows.Forms.Button btnaUpdateUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource tblQuestionBindingSource;
        private QuesitonAppDataSet3 quesitonAppDataSet3;
        private System.Windows.Forms.BindingSource tblUserBindingSource;
        private QuesitonAppDataSet3TableAdapters.Tbl_UserTableAdapter tbl_UserTableAdapter;
        private System.Windows.Forms.ToolStrip fillAllUserToolStrip;
        private System.Windows.Forms.ToolStripButton fillAllUserToolStripButton;
        private System.Windows.Forms.ToolStrip fillStudentToolStrip;
        private System.Windows.Forms.ToolStripButton fillStudentToolStripButton;
        private System.Windows.Forms.ToolStrip fillTeacherToolStrip;
        private System.Windows.Forms.ToolStripButton fillTeacherToolStripButton;
        private System.Windows.Forms.ToolStrip fillAdminToolStrip;
        private System.Windows.Forms.ToolStripButton fillAdminToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userTypeIDDataGridViewTextBoxColumn;
    }
}