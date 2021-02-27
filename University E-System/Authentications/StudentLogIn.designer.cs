using University_E_System.DataBase;

namespace University_E_System
{
    partial class StudentLogIn
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
            System.Windows.Forms.Label std_NameLabel;
            System.Windows.Forms.Label e_MailLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label e_MailLabel1;
            System.Windows.Forms.Label passwordLabel1;
            System.Windows.Forms.Label phone_NumberLabel;
            System.Windows.Forms.Label faculty_IDLabel;
            System.Windows.Forms.Label dept_IDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentLogIn));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.btnBackLoginStudent = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnClose = new Guna.UI2.WinForms.Guna2CircleButton();
            this.SignUpPanel = new System.Windows.Forms.Panel();
            this.PicBox = new System.Windows.Forms.PictureBox();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._University_E_SystemDataSet = new University_E_System.DataBase._University_E_SystemDataSet();
            this.facultyIDComboBox = new System.Windows.Forms.ComboBox();
            this.facultyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentIDComboBox = new System.Windows.Forms.ComboBox();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox1 = new System.Windows.Forms.TextBox();
            this.e_MailTextBox1 = new System.Windows.Forms.TextBox();
            this.studentNameTextBox = new System.Windows.Forms.TextBox();
            this.SignUpBtn = new Guna.UI2.WinForms.Guna2Button();
            this.btnSignIn = new Guna.UI2.WinForms.Guna2Button();
            this.lblhaveAcc = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnUploadPhoto = new Guna.UI2.WinForms.Guna2Button();
            this.PicSignup = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblCreateAcc = new System.Windows.Forms.Label();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.e_MailTextBox = new System.Windows.Forms.TextBox();
            this.lblDntHvAcc = new System.Windows.Forms.Label();
            this.picPassword = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.PicUsername = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnGoSignUp = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.PicLogin = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.studentTableAdapter = new University_E_System.DataBase._University_E_SystemDataSetTableAdapters.StudentTableAdapter();
            this.tableAdapterManager = new University_E_System.DataBase._University_E_SystemDataSetTableAdapters.TableAdapterManager();
            this.departmentTableAdapter = new University_E_System.DataBase._University_E_SystemDataSetTableAdapters.DepartmentTableAdapter();
            this.facultyTableAdapter = new University_E_System.DataBase._University_E_SystemDataSetTableAdapters.FacultyTableAdapter();
            this.studentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.studentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            std_NameLabel = new System.Windows.Forms.Label();
            e_MailLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            e_MailLabel1 = new System.Windows.Forms.Label();
            passwordLabel1 = new System.Windows.Forms.Label();
            phone_NumberLabel = new System.Windows.Forms.Label();
            faculty_IDLabel = new System.Windows.Forms.Label();
            dept_IDLabel = new System.Windows.Forms.Label();
            this.TopPanel.SuspendLayout();
            this.SignUpPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._University_E_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSignup)).BeginInit();
            this.LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingNavigator)).BeginInit();
            this.studentBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // std_NameLabel
            // 
            std_NameLabel.AutoSize = true;
            std_NameLabel.Font = new System.Drawing.Font("Segoe Print", 9F);
            std_NameLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            std_NameLabel.Location = new System.Drawing.Point(44, 179);
            std_NameLabel.Name = "std_NameLabel";
            std_NameLabel.Size = new System.Drawing.Size(49, 21);
            std_NameLabel.TabIndex = 7;
            std_NameLabel.Text = "Name:";
            // 
            // e_MailLabel
            // 
            e_MailLabel.AutoSize = true;
            e_MailLabel.Font = new System.Drawing.Font("Segoe Print", 9F);
            e_MailLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            e_MailLabel.Location = new System.Drawing.Point(91, 235);
            e_MailLabel.Name = "e_MailLabel";
            e_MailLabel.Size = new System.Drawing.Size(51, 21);
            e_MailLabel.TabIndex = 7;
            e_MailLabel.Text = "E Mail:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new System.Drawing.Font("Segoe Print", 9F);
            passwordLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            passwordLabel.Location = new System.Drawing.Point(70, 282);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(71, 21);
            passwordLabel.TabIndex = 8;
            passwordLabel.Text = "Password:";
            // 
            // e_MailLabel1
            // 
            e_MailLabel1.AutoSize = true;
            e_MailLabel1.Font = new System.Drawing.Font("Segoe Print", 9F);
            e_MailLabel1.ForeColor = System.Drawing.SystemColors.ControlDark;
            e_MailLabel1.Location = new System.Drawing.Point(41, 210);
            e_MailLabel1.Name = "e_MailLabel1";
            e_MailLabel1.Size = new System.Drawing.Size(51, 21);
            e_MailLabel1.TabIndex = 11;
            e_MailLabel1.Text = "E Mail:";
            // 
            // passwordLabel1
            // 
            passwordLabel1.AutoSize = true;
            passwordLabel1.Font = new System.Drawing.Font("Segoe Print", 9F);
            passwordLabel1.ForeColor = System.Drawing.SystemColors.ControlDark;
            passwordLabel1.Location = new System.Drawing.Point(41, 250);
            passwordLabel1.Name = "passwordLabel1";
            passwordLabel1.Size = new System.Drawing.Size(71, 21);
            passwordLabel1.TabIndex = 12;
            passwordLabel1.Text = "Password:";
            // 
            // phone_NumberLabel
            // 
            phone_NumberLabel.AutoSize = true;
            phone_NumberLabel.Font = new System.Drawing.Font("Segoe Print", 9F);
            phone_NumberLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            phone_NumberLabel.Location = new System.Drawing.Point(288, 182);
            phone_NumberLabel.Name = "phone_NumberLabel";
            phone_NumberLabel.Size = new System.Drawing.Size(104, 21);
            phone_NumberLabel.TabIndex = 13;
            phone_NumberLabel.Text = "Phone Number:";
            // 
            // faculty_IDLabel
            // 
            faculty_IDLabel.AutoSize = true;
            faculty_IDLabel.Font = new System.Drawing.Font("Segoe Print", 9F);
            faculty_IDLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            faculty_IDLabel.Location = new System.Drawing.Point(288, 215);
            faculty_IDLabel.Name = "faculty_IDLabel";
            faculty_IDLabel.Size = new System.Drawing.Size(57, 21);
            faculty_IDLabel.TabIndex = 15;
            faculty_IDLabel.Text = "Faculty:";
            // 
            // dept_IDLabel
            // 
            dept_IDLabel.AutoSize = true;
            dept_IDLabel.Font = new System.Drawing.Font("Segoe Print", 9F);
            dept_IDLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            dept_IDLabel.Location = new System.Drawing.Point(288, 255);
            dept_IDLabel.Name = "dept_IDLabel";
            dept_IDLabel.Size = new System.Drawing.Size(89, 21);
            dept_IDLabel.TabIndex = 16;
            dept_IDLabel.Text = "Department:";
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Black;
            this.TopPanel.Controls.Add(this.btnBackLoginStudent);
            this.TopPanel.Controls.Add(this.btnMinimize);
            this.TopPanel.Controls.Add(this.btnClose);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1055, 36);
            this.TopPanel.TabIndex = 0;
            // 
            // btnBackLoginStudent
            // 
            this.btnBackLoginStudent.CheckedState.Parent = this.btnBackLoginStudent;
            this.btnBackLoginStudent.CustomImages.Parent = this.btnBackLoginStudent;
            this.btnBackLoginStudent.FillColor = System.Drawing.Color.Black;
            this.btnBackLoginStudent.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackLoginStudent.ForeColor = System.Drawing.Color.White;
            this.btnBackLoginStudent.HoverState.Parent = this.btnBackLoginStudent;
            this.btnBackLoginStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnBackLoginStudent.Image")));
            this.btnBackLoginStudent.Location = new System.Drawing.Point(10, 0);
            this.btnBackLoginStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackLoginStudent.Name = "btnBackLoginStudent";
            this.btnBackLoginStudent.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnBackLoginStudent.ShadowDecoration.Parent = this.btnBackLoginStudent;
            this.btnBackLoginStudent.Size = new System.Drawing.Size(33, 33);
            this.btnBackLoginStudent.TabIndex = 8;
            this.btnBackLoginStudent.Click += new System.EventHandler(this.BtnBackLoginStudent_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.CheckedState.Parent = this.btnMinimize;
            this.btnMinimize.CustomImages.Parent = this.btnMinimize;
            this.btnMinimize.FillColor = System.Drawing.Color.Black;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.HoverState.Parent = this.btnMinimize;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(981, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnMinimize.ShadowDecoration.Parent = this.btnMinimize;
            this.btnMinimize.Size = new System.Drawing.Size(33, 33);
            this.btnMinimize.TabIndex = 7;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.FillColor = System.Drawing.Color.Black;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1018, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(33, 33);
            this.btnClose.TabIndex = 6;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // SignUpPanel
            // 
            this.SignUpPanel.Controls.Add(this.PicBox);
            this.SignUpPanel.Controls.Add(this.facultyIDComboBox);
            this.SignUpPanel.Controls.Add(this.departmentIDComboBox);
            this.SignUpPanel.Controls.Add(this.phoneTextBox);
            this.SignUpPanel.Controls.Add(this.passwordTextBox1);
            this.SignUpPanel.Controls.Add(this.e_MailTextBox1);
            this.SignUpPanel.Controls.Add(this.studentNameTextBox);
            this.SignUpPanel.Controls.Add(this.SignUpBtn);
            this.SignUpPanel.Controls.Add(dept_IDLabel);
            this.SignUpPanel.Controls.Add(faculty_IDLabel);
            this.SignUpPanel.Controls.Add(phone_NumberLabel);
            this.SignUpPanel.Controls.Add(passwordLabel1);
            this.SignUpPanel.Controls.Add(e_MailLabel1);
            this.SignUpPanel.Controls.Add(std_NameLabel);
            this.SignUpPanel.Controls.Add(this.btnSignIn);
            this.SignUpPanel.Controls.Add(this.lblhaveAcc);
            this.SignUpPanel.Controls.Add(this.btnUploadPhoto);
            this.SignUpPanel.Controls.Add(this.PicSignup);
            this.SignUpPanel.Controls.Add(this.lblCreateAcc);
            this.SignUpPanel.Location = new System.Drawing.Point(504, 41);
            this.SignUpPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SignUpPanel.Name = "SignUpPanel";
            this.SignUpPanel.Size = new System.Drawing.Size(614, 482);
            this.SignUpPanel.TabIndex = 1;
            // 
            // PicBox
            // 
            this.PicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.studentBindingSource, "PP", true));
            this.PicBox.Location = new System.Drawing.Point(212, 333);
            this.PicBox.Name = "PicBox";
            this.PicBox.Size = new System.Drawing.Size(149, 65);
            this.PicBox.TabIndex = 32;
            this.PicBox.TabStop = false;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this._University_E_SystemDataSet;
            // 
            // _University_E_SystemDataSet
            // 
            this._University_E_SystemDataSet.DataSetName = "_University_E_SystemDataSet";
            this._University_E_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facultyIDComboBox
            // 
            this.facultyIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facultyBindingSource, "FacultyID", true));
            this.facultyIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.studentBindingSource, "FacultyID", true));
            this.facultyIDComboBox.DataSource = this.facultyBindingSource;
            this.facultyIDComboBox.DisplayMember = "FacultyName";
            this.facultyIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.facultyIDComboBox.FormattingEnabled = true;
            this.facultyIDComboBox.Location = new System.Drawing.Point(398, 216);
            this.facultyIDComboBox.Name = "facultyIDComboBox";
            this.facultyIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.facultyIDComboBox.TabIndex = 31;
            this.facultyIDComboBox.ValueMember = "FacultyID";
            // 
            // facultyBindingSource
            // 
            this.facultyBindingSource.DataMember = "Faculty";
            this.facultyBindingSource.DataSource = this._University_E_SystemDataSet;
            // 
            // departmentIDComboBox
            // 
            this.departmentIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departmentBindingSource, "DepartmentID", true));
            this.departmentIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.studentBindingSource, "DepartmentID", true));
            this.departmentIDComboBox.DataSource = this.departmentBindingSource;
            this.departmentIDComboBox.DisplayMember = "DepartmentName";
            this.departmentIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentIDComboBox.FormattingEnabled = true;
            this.departmentIDComboBox.Location = new System.Drawing.Point(398, 256);
            this.departmentIDComboBox.Name = "departmentIDComboBox";
            this.departmentIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.departmentIDComboBox.TabIndex = 30;
            this.departmentIDComboBox.ValueMember = "DepartmentID";
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            this.departmentBindingSource.DataSource = this._University_E_SystemDataSet;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.phoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Phone", true));
            this.phoneTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.phoneTextBox.Location = new System.Drawing.Point(398, 180);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(121, 20);
            this.phoneTextBox.TabIndex = 29;
            // 
            // passwordTextBox1
            // 
            this.passwordTextBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.passwordTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Password", true));
            this.passwordTextBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.passwordTextBox1.Location = new System.Drawing.Point(106, 250);
            this.passwordTextBox1.Name = "passwordTextBox1";
            this.passwordTextBox1.PasswordChar = '*';
            this.passwordTextBox1.Size = new System.Drawing.Size(128, 20);
            this.passwordTextBox1.TabIndex = 28;
            // 
            // e_MailTextBox1
            // 
            this.e_MailTextBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.e_MailTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.e_MailTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "E_Mail", true));
            this.e_MailTextBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.e_MailTextBox1.Location = new System.Drawing.Point(99, 210);
            this.e_MailTextBox1.Name = "e_MailTextBox1";
            this.e_MailTextBox1.Size = new System.Drawing.Size(135, 20);
            this.e_MailTextBox1.TabIndex = 27;
            // 
            // studentNameTextBox
            // 
            this.studentNameTextBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.studentNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "StudentName", true));
            this.studentNameTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.studentNameTextBox.Location = new System.Drawing.Point(99, 179);
            this.studentNameTextBox.Name = "studentNameTextBox";
            this.studentNameTextBox.Size = new System.Drawing.Size(135, 20);
            this.studentNameTextBox.TabIndex = 26;
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SignUpBtn.BorderRadius = 6;
            this.SignUpBtn.BorderThickness = 3;
            this.SignUpBtn.CheckedState.Parent = this.SignUpBtn;
            this.SignUpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUpBtn.CustomImages.Parent = this.SignUpBtn;
            this.SignUpBtn.FillColor = System.Drawing.Color.Yellow;
            this.SignUpBtn.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpBtn.ForeColor = System.Drawing.Color.Black;
            this.SignUpBtn.HoverState.Parent = this.SignUpBtn;
            this.SignUpBtn.Location = new System.Drawing.Point(400, 355);
            this.SignUpBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.ShadowDecoration.Parent = this.SignUpBtn;
            this.SignUpBtn.Size = new System.Drawing.Size(147, 43);
            this.SignUpBtn.TabIndex = 20;
            this.SignUpBtn.Text = "Sign Up";
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSignIn.BorderRadius = 6;
            this.btnSignIn.BorderThickness = 3;
            this.btnSignIn.CheckedState.Parent = this.btnSignIn;
            this.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIn.CustomImages.Parent = this.btnSignIn;
            this.btnSignIn.FillColor = System.Drawing.Color.Yellow;
            this.btnSignIn.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.Black;
            this.btnSignIn.HoverState.Parent = this.btnSignIn;
            this.btnSignIn.Location = new System.Drawing.Point(267, 431);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.ShadowDecoration.Parent = this.btnSignIn;
            this.btnSignIn.Size = new System.Drawing.Size(94, 41);
            this.btnSignIn.TabIndex = 11;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.Click += new System.EventHandler(this.BtnSignIn_Click);
            // 
            // lblhaveAcc
            // 
            this.lblhaveAcc.AutoSize = false;
            this.lblhaveAcc.BackColor = System.Drawing.Color.Transparent;
            this.lblhaveAcc.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhaveAcc.ForeColor = System.Drawing.Color.Silver;
            this.lblhaveAcc.Location = new System.Drawing.Point(62, 431);
            this.lblhaveAcc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblhaveAcc.Name = "lblhaveAcc";
            this.lblhaveAcc.Size = new System.Drawing.Size(195, 41);
            this.lblhaveAcc.TabIndex = 10;
            this.lblhaveAcc.Text = "Already have an account !!";
            this.lblhaveAcc.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUploadPhoto
            // 
            this.btnUploadPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUploadPhoto.BorderRadius = 6;
            this.btnUploadPhoto.BorderThickness = 3;
            this.btnUploadPhoto.CheckedState.Parent = this.btnUploadPhoto;
            this.btnUploadPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUploadPhoto.CustomImages.Parent = this.btnUploadPhoto;
            this.btnUploadPhoto.FillColor = System.Drawing.Color.Yellow;
            this.btnUploadPhoto.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadPhoto.ForeColor = System.Drawing.Color.Black;
            this.btnUploadPhoto.HoverState.Parent = this.btnUploadPhoto;
            this.btnUploadPhoto.Location = new System.Drawing.Point(54, 333);
            this.btnUploadPhoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUploadPhoto.Name = "btnUploadPhoto";
            this.btnUploadPhoto.ShadowDecoration.Parent = this.btnUploadPhoto;
            this.btnUploadPhoto.Size = new System.Drawing.Size(152, 65);
            this.btnUploadPhoto.TabIndex = 9;
            this.btnUploadPhoto.Text = "Upload Your Profile Picture";
            this.btnUploadPhoto.Click += new System.EventHandler(this.BtnUploadPhoto_Click);
            // 
            // PicSignup
            // 
            this.PicSignup.Image = ((System.Drawing.Image)(resources.GetObject("PicSignup.Image")));
            this.PicSignup.Location = new System.Drawing.Point(56, 34);
            this.PicSignup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PicSignup.Name = "PicSignup";
            this.PicSignup.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PicSignup.ShadowDecoration.Parent = this.PicSignup;
            this.PicSignup.Size = new System.Drawing.Size(128, 128);
            this.PicSignup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicSignup.TabIndex = 4;
            this.PicSignup.TabStop = false;
            // 
            // lblCreateAcc
            // 
            this.lblCreateAcc.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblCreateAcc.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateAcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblCreateAcc.Location = new System.Drawing.Point(204, 70);
            this.lblCreateAcc.Name = "lblCreateAcc";
            this.lblCreateAcc.Size = new System.Drawing.Size(230, 50);
            this.lblCreateAcc.TabIndex = 0;
            this.lblCreateAcc.Text = "Create New Account";
            this.lblCreateAcc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginPanel
            // 
            this.LoginPanel.Controls.Add(this.passwordTextBox);
            this.LoginPanel.Controls.Add(this.e_MailTextBox);
            this.LoginPanel.Controls.Add(passwordLabel);
            this.LoginPanel.Controls.Add(e_MailLabel);
            this.LoginPanel.Controls.Add(this.lblDntHvAcc);
            this.LoginPanel.Controls.Add(this.picPassword);
            this.LoginPanel.Controls.Add(this.PicUsername);
            this.LoginPanel.Controls.Add(this.btnGoSignUp);
            this.LoginPanel.Controls.Add(this.btnLogin);
            this.LoginPanel.Controls.Add(this.PicLogin);
            this.LoginPanel.Location = new System.Drawing.Point(10, 41);
            this.LoginPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(480, 482);
            this.LoginPanel.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Password", true));
            this.passwordTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.passwordTextBox.Location = new System.Drawing.Point(183, 286);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(144, 20);
            this.passwordTextBox.TabIndex = 10;
            // 
            // e_MailTextBox
            // 
            this.e_MailTextBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.e_MailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.e_MailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "E_Mail", true));
            this.e_MailTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.e_MailTextBox.Location = new System.Drawing.Point(183, 236);
            this.e_MailTextBox.Name = "e_MailTextBox";
            this.e_MailTextBox.Size = new System.Drawing.Size(144, 20);
            this.e_MailTextBox.TabIndex = 9;
            // 
            // lblDntHvAcc
            // 
            this.lblDntHvAcc.AutoSize = true;
            this.lblDntHvAcc.BackColor = System.Drawing.Color.Black;
            this.lblDntHvAcc.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDntHvAcc.ForeColor = System.Drawing.Color.Gray;
            this.lblDntHvAcc.Location = new System.Drawing.Point(50, 431);
            this.lblDntHvAcc.Name = "lblDntHvAcc";
            this.lblDntHvAcc.Size = new System.Drawing.Size(196, 26);
            this.lblDntHvAcc.TabIndex = 6;
            this.lblDntHvAcc.Text = "Don\'t have an account ?";
            // 
            // picPassword
            // 
            this.picPassword.Image = ((System.Drawing.Image)(resources.GetObject("picPassword.Image")));
            this.picPassword.Location = new System.Drawing.Point(150, 280);
            this.picPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picPassword.Name = "picPassword";
            this.picPassword.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picPassword.ShadowDecoration.Parent = this.picPassword;
            this.picPassword.Size = new System.Drawing.Size(25, 26);
            this.picPassword.TabIndex = 5;
            this.picPassword.TabStop = false;
            // 
            // PicUsername
            // 
            this.PicUsername.Image = ((System.Drawing.Image)(resources.GetObject("PicUsername.Image")));
            this.PicUsername.Location = new System.Drawing.Point(150, 234);
            this.PicUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PicUsername.Name = "PicUsername";
            this.PicUsername.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PicUsername.ShadowDecoration.Parent = this.PicUsername;
            this.PicUsername.Size = new System.Drawing.Size(27, 26);
            this.PicUsername.TabIndex = 4;
            this.PicUsername.TabStop = false;
            // 
            // btnGoSignUp
            // 
            this.btnGoSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGoSignUp.BorderRadius = 6;
            this.btnGoSignUp.BorderThickness = 3;
            this.btnGoSignUp.CheckedState.Parent = this.btnGoSignUp;
            this.btnGoSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoSignUp.CustomImages.Parent = this.btnGoSignUp;
            this.btnGoSignUp.FillColor = System.Drawing.Color.Yellow;
            this.btnGoSignUp.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoSignUp.ForeColor = System.Drawing.Color.Black;
            this.btnGoSignUp.HoverState.Parent = this.btnGoSignUp;
            this.btnGoSignUp.Location = new System.Drawing.Point(271, 418);
            this.btnGoSignUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGoSignUp.Name = "btnGoSignUp";
            this.btnGoSignUp.ShadowDecoration.Parent = this.btnGoSignUp;
            this.btnGoSignUp.Size = new System.Drawing.Size(90, 41);
            this.btnGoSignUp.TabIndex = 2;
            this.btnGoSignUp.Text = "Sign Up";
            this.btnGoSignUp.Click += new System.EventHandler(this.BtnGoSignUp_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.BorderRadius = 6;
            this.btnLogin.BorderThickness = 3;
            this.btnLogin.CheckedState.Parent = this.btnLogin;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.CustomImages.Parent = this.btnLogin;
            this.btnLogin.FillColor = System.Drawing.Color.Yellow;
            this.btnLogin.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.HoverState.Parent = this.btnLogin;
            this.btnLogin.Location = new System.Drawing.Point(152, 327);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
            this.btnLogin.Size = new System.Drawing.Size(162, 37);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Log In";
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // PicLogin
            // 
            this.PicLogin.Image = ((System.Drawing.Image)(resources.GetObject("PicLogin.Image")));
            this.PicLogin.Location = new System.Drawing.Point(194, 34);
            this.PicLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PicLogin.Name = "PicLogin";
            this.PicLogin.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PicLogin.ShadowDecoration.Parent = this.PicLogin;
            this.PicLogin.Size = new System.Drawing.Size(128, 128);
            this.PicLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicLogin.TabIndex = 0;
            this.PicLogin.TabStop = false;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DepartmentTableAdapter = this.departmentTableAdapter;
            this.tableAdapterManager.FacultyTableAdapter = this.facultyTableAdapter;
            this.tableAdapterManager.ProfessorTableAdapter = null;
            this.tableAdapterManager.StudentTableAdapter = this.studentTableAdapter;
            this.tableAdapterManager.UpdateOrder = University_E_System.DataBase._University_E_SystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // facultyTableAdapter
            // 
            this.facultyTableAdapter.ClearBeforeFill = true;
            // 
            // studentBindingNavigator
            // 
            this.studentBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.studentBindingNavigator.BindingSource = this.studentBindingSource;
            this.studentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.studentBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.studentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.studentBindingNavigatorSaveItem});
            this.studentBindingNavigator.Location = new System.Drawing.Point(0, 36);
            this.studentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.studentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.studentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.studentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.studentBindingNavigator.Name = "studentBindingNavigator";
            this.studentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.studentBindingNavigator.Size = new System.Drawing.Size(1055, 25);
            this.studentBindingNavigator.TabIndex = 3;
            this.studentBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // studentBindingNavigatorSaveItem
            // 
            this.studentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.studentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("studentBindingNavigatorSaveItem.Image")));
            this.studentBindingNavigatorSaveItem.Name = "studentBindingNavigatorSaveItem";
            this.studentBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.studentBindingNavigatorSaveItem.Text = "Save Data";
            this.studentBindingNavigatorSaveItem.Click += new System.EventHandler(this.StudentBindingNavigatorSaveItem_Click);
            // 
            // StudentLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1055, 533);
            this.Controls.Add(this.studentBindingNavigator);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.SignUpPanel);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StudentLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login & Sign Up";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TopPanel.ResumeLayout(false);
            this.SignUpPanel.ResumeLayout(false);
            this.SignUpPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._University_E_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSignup)).EndInit();
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingNavigator)).EndInit();
            this.studentBindingNavigator.ResumeLayout(false);
            this.studentBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel SignUpPanel;
        private System.Windows.Forms.Panel LoginPanel;
        private Guna.UI2.WinForms.Guna2CirclePictureBox PicLogin;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2Button btnGoSignUp;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2CirclePictureBox PicSignup;
        private System.Windows.Forms.Label lblCreateAcc;
        private Guna.UI2.WinForms.Guna2CirclePictureBox PicUsername;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picPassword;
        private Guna.UI2.WinForms.Guna2Button btnSignIn;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblhaveAcc;
        private Guna.UI2.WinForms.Guna2Button btnUploadPhoto;
        private Guna.UI2.WinForms.Guna2CircleButton btnMinimize;
        private Guna.UI2.WinForms.Guna2CircleButton btnClose;
        private System.Windows.Forms.Label lblDntHvAcc;
        private Guna.UI2.WinForms.Guna2CircleButton btnBackLoginStudent;
        private Guna.UI2.WinForms.Guna2Button SignUpBtn;
        private _University_E_SystemDataSet _University_E_SystemDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private DataBase._University_E_SystemDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private DataBase._University_E_SystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator studentBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton studentBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox passwordTextBox1;
        private System.Windows.Forms.TextBox e_MailTextBox1;
        private System.Windows.Forms.TextBox studentNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox e_MailTextBox;
        private DataBase._University_E_SystemDataSetTableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private System.Windows.Forms.ComboBox departmentIDComboBox;
        private DataBase._University_E_SystemDataSetTableAdapters.FacultyTableAdapter facultyTableAdapter;
        private System.Windows.Forms.BindingSource facultyBindingSource;
        private System.Windows.Forms.PictureBox PicBox;
        private System.Windows.Forms.ComboBox facultyIDComboBox;
    }
}

