namespace Login_SignUp.Admin_Forms
{
    partial class StudentManagement
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
            System.Windows.Forms.Label departmentIDLabel;
            System.Windows.Forms.Label facultyIDLabel;
            System.Windows.Forms.Label pPLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label e_MailLabel;
            System.Windows.Forms.Label studentNameLabel;
            System.Windows.Forms.Label studentIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentManagement));
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.studentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.studentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._University_E_SystemDataSet = new University_E_System.DataBase._University_E_SystemDataSet();
            this.tableAdapterManager = new University_E_System.DataBase._University_E_SystemDataSetTableAdapters.TableAdapterManager();
            this.studentTableAdapter = new University_E_System.DataBase._University_E_SystemDataSetTableAdapters.StudentTableAdapter();
            this.btnSubmitStdAdmin = new Guna.UI2.WinForms.Guna2Button();
            this.PPUpload = new Guna.UI2.WinForms.Guna2Button();
            this.DelStd = new Guna.UI2.WinForms.Guna2Button();
            this.PicBox = new System.Windows.Forms.PictureBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.e_MailTextBox = new System.Windows.Forms.TextBox();
            this.studentNameTextBox = new System.Windows.Forms.TextBox();
            this.studentIDTextBox = new System.Windows.Forms.TextBox();
            this.facultyIDComboBox = new System.Windows.Forms.ComboBox();
            this.facultyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentIDComboBox = new System.Windows.Forms.ComboBox();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddStd = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDataGridView = new System.Windows.Forms.DataGridView();
            this.facultyTableAdapter = new University_E_System.DataBase._University_E_SystemDataSetTableAdapters.FacultyTableAdapter();
            this.departmentTableAdapter = new University_E_System.DataBase._University_E_SystemDataSetTableAdapters.DepartmentTableAdapter();
            this.PrintStd = new Guna.UI2.WinForms.Guna2Button();
            this.helpBtn = new System.Windows.Forms.Button();
            departmentIDLabel = new System.Windows.Forms.Label();
            facultyIDLabel = new System.Windows.Forms.Label();
            pPLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            e_MailLabel = new System.Windows.Forms.Label();
            studentNameLabel = new System.Windows.Forms.Label();
            studentIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingNavigator)).BeginInit();
            this.studentBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._University_E_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // departmentIDLabel
            // 
            departmentIDLabel.AutoSize = true;
            departmentIDLabel.Location = new System.Drawing.Point(35, 299);
            departmentIDLabel.Name = "departmentIDLabel";
            departmentIDLabel.Size = new System.Drawing.Size(94, 21);
            departmentIDLabel.TabIndex = 67;
            departmentIDLabel.Text = "Department :";
            // 
            // facultyIDLabel
            // 
            facultyIDLabel.AutoSize = true;
            facultyIDLabel.Location = new System.Drawing.Point(35, 264);
            facultyIDLabel.Name = "facultyIDLabel";
            facultyIDLabel.Size = new System.Drawing.Size(62, 21);
            facultyIDLabel.TabIndex = 65;
            facultyIDLabel.Text = "Faculty :";
            // 
            // pPLabel
            // 
            pPLabel.AutoSize = true;
            pPLabel.Location = new System.Drawing.Point(35, 205);
            pPLabel.Name = "pPLabel";
            pPLabel.Size = new System.Drawing.Size(30, 21);
            pPLabel.TabIndex = 63;
            pPLabel.Text = "PP:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(35, 173);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(51, 21);
            phoneLabel.TabIndex = 61;
            phoneLabel.Text = "Phone:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(35, 138);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(71, 21);
            passwordLabel.TabIndex = 59;
            passwordLabel.Text = "Password:";
            // 
            // e_MailLabel
            // 
            e_MailLabel.AutoSize = true;
            e_MailLabel.Location = new System.Drawing.Point(35, 103);
            e_MailLabel.Name = "e_MailLabel";
            e_MailLabel.Size = new System.Drawing.Size(51, 21);
            e_MailLabel.TabIndex = 57;
            e_MailLabel.Text = "E Mail:";
            // 
            // studentNameLabel
            // 
            studentNameLabel.AutoSize = true;
            studentNameLabel.Location = new System.Drawing.Point(35, 68);
            studentNameLabel.Name = "studentNameLabel";
            studentNameLabel.Size = new System.Drawing.Size(103, 21);
            studentNameLabel.TabIndex = 55;
            studentNameLabel.Text = "Student Name:";
            // 
            // studentIDLabel
            // 
            studentIDLabel.AutoSize = true;
            studentIDLabel.Location = new System.Drawing.Point(35, 33);
            studentIDLabel.Name = "studentIDLabel";
            studentIDLabel.Size = new System.Drawing.Size(82, 21);
            studentIDLabel.TabIndex = 53;
            studentIDLabel.Text = "Student ID:";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
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
            // studentBindingNavigatorSaveItem
            // 
            this.studentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.studentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("studentBindingNavigatorSaveItem.Image")));
            this.studentBindingNavigatorSaveItem.Name = "studentBindingNavigatorSaveItem";
            this.studentBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.studentBindingNavigatorSaveItem.Text = "Save Data";
            this.studentBindingNavigatorSaveItem.Click += new System.EventHandler(this.StudentBindingNavigatorSaveItem_Click);
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
            this.studentBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.studentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.studentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.studentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.studentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.studentBindingNavigator.Name = "studentBindingNavigator";
            this.studentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.studentBindingNavigator.Size = new System.Drawing.Size(1054, 25);
            this.studentBindingNavigator.TabIndex = 4;
            this.studentBindingNavigator.Text = "bindingNavigator1";
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DepartmentTableAdapter = null;
            this.tableAdapterManager.FacultyTableAdapter = null;
            this.tableAdapterManager.ProfessorTableAdapter = null;
            this.tableAdapterManager.StudentTableAdapter = this.studentTableAdapter;
            this.tableAdapterManager.UpdateOrder = University_E_System.DataBase._University_E_SystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // btnSubmitStdAdmin
            // 
            this.btnSubmitStdAdmin.BackColor = System.Drawing.Color.Goldenrod;
            this.btnSubmitStdAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubmitStdAdmin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSubmitStdAdmin.BorderRadius = 6;
            this.btnSubmitStdAdmin.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnSubmitStdAdmin.BorderThickness = 2;
            this.btnSubmitStdAdmin.CheckedState.Parent = this.btnSubmitStdAdmin;
            this.btnSubmitStdAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmitStdAdmin.CustomImages.Parent = this.btnSubmitStdAdmin;
            this.btnSubmitStdAdmin.FillColor = System.Drawing.Color.GhostWhite;
            this.btnSubmitStdAdmin.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSubmitStdAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSubmitStdAdmin.HoverState.Parent = this.btnSubmitStdAdmin;
            this.btnSubmitStdAdmin.Location = new System.Drawing.Point(112, 463);
            this.btnSubmitStdAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmitStdAdmin.Name = "btnSubmitStdAdmin";
            this.btnSubmitStdAdmin.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSubmitStdAdmin.ShadowDecoration.Parent = this.btnSubmitStdAdmin;
            this.btnSubmitStdAdmin.Size = new System.Drawing.Size(147, 43);
            this.btnSubmitStdAdmin.TabIndex = 43;
            this.btnSubmitStdAdmin.Text = "Save";
            this.btnSubmitStdAdmin.Click += new System.EventHandler(this.BtnSubmitStdAdmin_Click);
            // 
            // PPUpload
            // 
            this.PPUpload.BackColor = System.Drawing.Color.Goldenrod;
            this.PPUpload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PPUpload.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PPUpload.BorderRadius = 6;
            this.PPUpload.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.PPUpload.BorderThickness = 2;
            this.PPUpload.CheckedState.Parent = this.PPUpload;
            this.PPUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PPUpload.CustomImages.Parent = this.PPUpload;
            this.PPUpload.FillColor = System.Drawing.Color.GhostWhite;
            this.PPUpload.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold);
            this.PPUpload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PPUpload.HoverState.Parent = this.PPUpload;
            this.PPUpload.Location = new System.Drawing.Point(276, 212);
            this.PPUpload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PPUpload.Name = "PPUpload";
            this.PPUpload.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PPUpload.ShadowDecoration.Parent = this.PPUpload;
            this.PPUpload.Size = new System.Drawing.Size(80, 43);
            this.PPUpload.TabIndex = 52;
            this.PPUpload.Text = "Upload";
            this.PPUpload.Click += new System.EventHandler(this.PPUpload_Click);
            // 
            // DelStd
            // 
            this.DelStd.BackColor = System.Drawing.Color.Goldenrod;
            this.DelStd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DelStd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DelStd.BorderRadius = 6;
            this.DelStd.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.DelStd.BorderThickness = 2;
            this.DelStd.CheckedState.Parent = this.DelStd;
            this.DelStd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DelStd.CustomImages.Parent = this.DelStd;
            this.DelStd.FillColor = System.Drawing.Color.GhostWhite;
            this.DelStd.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold);
            this.DelStd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DelStd.HoverState.Parent = this.DelStd;
            this.DelStd.Location = new System.Drawing.Point(209, 391);
            this.DelStd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DelStd.Name = "DelStd";
            this.DelStd.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DelStd.ShadowDecoration.Parent = this.DelStd;
            this.DelStd.Size = new System.Drawing.Size(147, 43);
            this.DelStd.TabIndex = 53;
            this.DelStd.Text = "Delete";
            this.DelStd.Click += new System.EventHandler(this.DelStd_Click);
            // 
            // PicBox
            // 
            this.PicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.studentBindingSource, "PP", true));
            this.PicBox.Location = new System.Drawing.Point(149, 205);
            this.PicBox.Name = "PicBox";
            this.PicBox.Size = new System.Drawing.Size(121, 50);
            this.PicBox.TabIndex = 64;
            this.PicBox.TabStop = false;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(149, 170);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(121, 29);
            this.phoneTextBox.TabIndex = 62;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(149, 135);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(121, 29);
            this.passwordTextBox.TabIndex = 60;
            // 
            // e_MailTextBox
            // 
            this.e_MailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "E_Mail", true));
            this.e_MailTextBox.Location = new System.Drawing.Point(149, 100);
            this.e_MailTextBox.Name = "e_MailTextBox";
            this.e_MailTextBox.Size = new System.Drawing.Size(121, 29);
            this.e_MailTextBox.TabIndex = 58;
            // 
            // studentNameTextBox
            // 
            this.studentNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "StudentName", true));
            this.studentNameTextBox.Location = new System.Drawing.Point(149, 65);
            this.studentNameTextBox.Name = "studentNameTextBox";
            this.studentNameTextBox.Size = new System.Drawing.Size(121, 29);
            this.studentNameTextBox.TabIndex = 56;
            // 
            // studentIDTextBox
            // 
            this.studentIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "StudentID", true));
            this.studentIDTextBox.Location = new System.Drawing.Point(149, 30);
            this.studentIDTextBox.Name = "studentIDTextBox";
            this.studentIDTextBox.ReadOnly = true;
            this.studentIDTextBox.Size = new System.Drawing.Size(121, 29);
            this.studentIDTextBox.TabIndex = 54;
            // 
            // facultyIDComboBox
            // 
            this.facultyIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.studentBindingSource, "FacultyID", true));
            this.facultyIDComboBox.DataSource = this.facultyBindingSource;
            this.facultyIDComboBox.DisplayMember = "FacultyName";
            this.facultyIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.facultyIDComboBox.FormattingEnabled = true;
            this.facultyIDComboBox.Location = new System.Drawing.Point(149, 264);
            this.facultyIDComboBox.Name = "facultyIDComboBox";
            this.facultyIDComboBox.Size = new System.Drawing.Size(121, 29);
            this.facultyIDComboBox.TabIndex = 68;
            this.facultyIDComboBox.ValueMember = "FacultyID";
            // 
            // facultyBindingSource
            // 
            this.facultyBindingSource.DataMember = "Faculty";
            this.facultyBindingSource.DataSource = this._University_E_SystemDataSet;
            // 
            // departmentIDComboBox
            // 
            this.departmentIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.studentBindingSource, "DepartmentID", true));
            this.departmentIDComboBox.DataSource = this.departmentBindingSource;
            this.departmentIDComboBox.DisplayMember = "DepartmentName";
            this.departmentIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentIDComboBox.FormattingEnabled = true;
            this.departmentIDComboBox.Location = new System.Drawing.Point(149, 296);
            this.departmentIDComboBox.Name = "departmentIDComboBox";
            this.departmentIDComboBox.Size = new System.Drawing.Size(121, 29);
            this.departmentIDComboBox.TabIndex = 69;
            this.departmentIDComboBox.ValueMember = "DepartmentID";
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            this.departmentBindingSource.DataSource = this._University_E_SystemDataSet;
            // 
            // AddStd
            // 
            this.AddStd.BackColor = System.Drawing.Color.Goldenrod;
            this.AddStd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddStd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddStd.BorderRadius = 6;
            this.AddStd.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.AddStd.BorderThickness = 2;
            this.AddStd.CheckedState.Parent = this.AddStd;
            this.AddStd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddStd.CustomImages.Parent = this.AddStd;
            this.AddStd.FillColor = System.Drawing.Color.GhostWhite;
            this.AddStd.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold);
            this.AddStd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddStd.HoverState.Parent = this.AddStd;
            this.AddStd.Location = new System.Drawing.Point(17, 391);
            this.AddStd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddStd.Name = "AddStd";
            this.AddStd.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddStd.ShadowDecoration.Parent = this.AddStd;
            this.AddStd.Size = new System.Drawing.Size(147, 43);
            this.AddStd.TabIndex = 70;
            this.AddStd.Text = "Add";
            this.AddStd.Click += new System.EventHandler(this.AddStd_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.Controls.Add(this.AddStd);
            this.panel1.Controls.Add(this.departmentIDComboBox);
            this.panel1.Controls.Add(this.facultyIDComboBox);
            this.panel1.Controls.Add(studentIDLabel);
            this.panel1.Controls.Add(this.studentIDTextBox);
            this.panel1.Controls.Add(studentNameLabel);
            this.panel1.Controls.Add(this.studentNameTextBox);
            this.panel1.Controls.Add(e_MailLabel);
            this.panel1.Controls.Add(this.e_MailTextBox);
            this.panel1.Controls.Add(passwordLabel);
            this.panel1.Controls.Add(this.passwordTextBox);
            this.panel1.Controls.Add(phoneLabel);
            this.panel1.Controls.Add(this.phoneTextBox);
            this.panel1.Controls.Add(pPLabel);
            this.panel1.Controls.Add(this.PicBox);
            this.panel1.Controls.Add(facultyIDLabel);
            this.panel1.Controls.Add(departmentIDLabel);
            this.panel1.Controls.Add(this.DelStd);
            this.panel1.Controls.Add(this.PPUpload);
            this.panel1.Controls.Add(this.btnSubmitStdAdmin);
            this.panel1.Font = new System.Drawing.Font("Segoe Print", 9F);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 508);
            this.panel1.TabIndex = 3;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "PP";
            this.dataGridViewImageColumn1.HeaderText = "PP";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn5.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "E_Mail";
            this.dataGridViewTextBoxColumn3.HeaderText = "E_Mail";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "DepartmentID";
            this.dataGridViewTextBoxColumn7.HeaderText = "DepartmentID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 98;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "FacultyID";
            this.dataGridViewTextBoxColumn6.HeaderText = "FacultyID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 77;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "StudentName";
            this.dataGridViewTextBoxColumn2.HeaderText = "StudentName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 97;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "StudentID";
            this.dataGridViewTextBoxColumn1.HeaderText = "StudentID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // studentDataGridView
            // 
            this.studentDataGridView.AutoGenerateColumns = false;
            this.studentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewImageColumn1});
            this.studentDataGridView.DataSource = this.studentBindingSource;
            this.studentDataGridView.Location = new System.Drawing.Point(369, 33);
            this.studentDataGridView.Name = "studentDataGridView";
            this.studentDataGridView.Size = new System.Drawing.Size(452, 389);
            this.studentDataGridView.TabIndex = 4;
            // 
            // facultyTableAdapter
            // 
            this.facultyTableAdapter.ClearBeforeFill = true;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // PrintStd
            // 
            this.PrintStd.BackColor = System.Drawing.Color.Goldenrod;
            this.PrintStd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PrintStd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PrintStd.BorderRadius = 6;
            this.PrintStd.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.PrintStd.BorderThickness = 2;
            this.PrintStd.CheckedState.Parent = this.PrintStd;
            this.PrintStd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrintStd.CustomImages.Parent = this.PrintStd;
            this.PrintStd.FillColor = System.Drawing.Color.GhostWhite;
            this.PrintStd.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold);
            this.PrintStd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PrintStd.HoverState.Parent = this.PrintStd;
            this.PrintStd.Location = new System.Drawing.Point(726, 438);
            this.PrintStd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PrintStd.Name = "PrintStd";
            this.PrintStd.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PrintStd.ShadowDecoration.Parent = this.PrintStd;
            this.PrintStd.Size = new System.Drawing.Size(95, 43);
            this.PrintStd.TabIndex = 61;
            this.PrintStd.Text = "Print";
            this.PrintStd.Click += new System.EventHandler(this.PrintStd_Click);
            // 
            // helpBtn
            // 
            this.helpBtn.Location = new System.Drawing.Point(827, 44);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(27, 28);
            this.helpBtn.TabIndex = 62;
            this.helpBtn.Text = "?";
            this.helpBtn.UseVisualStyleBackColor = true;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // StudentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1054, 636);
            this.Controls.Add(this.helpBtn);
            this.Controls.Add(this.PrintStd);
            this.Controls.Add(this.studentDataGridView);
            this.Controls.Add(this.studentBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StudentManagement";
            this.Text = "StudentManagement";
            this.Load += new System.EventHandler(this.StudentManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingNavigator)).EndInit();
            this.studentBindingNavigator.ResumeLayout(false);
            this.studentBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._University_E_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton studentBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator studentBindingNavigator;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private University_E_System.DataBase._University_E_SystemDataSet _University_E_SystemDataSet;
        private University_E_System.DataBase._University_E_SystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private University_E_System.DataBase._University_E_SystemDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private Guna.UI2.WinForms.Guna2Button btnSubmitStdAdmin;
        private Guna.UI2.WinForms.Guna2Button PPUpload;
        private Guna.UI2.WinForms.Guna2Button DelStd;
        private System.Windows.Forms.PictureBox PicBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox e_MailTextBox;
        private System.Windows.Forms.TextBox studentNameTextBox;
        private System.Windows.Forms.TextBox studentIDTextBox;
        private System.Windows.Forms.ComboBox facultyIDComboBox;
        private System.Windows.Forms.ComboBox departmentIDComboBox;
        private Guna.UI2.WinForms.Guna2Button AddStd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView studentDataGridView;
        private System.Windows.Forms.BindingSource facultyBindingSource;
        private University_E_System.DataBase._University_E_SystemDataSetTableAdapters.FacultyTableAdapter facultyTableAdapter;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private University_E_System.DataBase._University_E_SystemDataSetTableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private Guna.UI2.WinForms.Guna2Button PrintStd;
        private System.Windows.Forms.Button helpBtn;
    }
}