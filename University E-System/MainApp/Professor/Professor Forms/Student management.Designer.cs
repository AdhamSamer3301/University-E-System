namespace University_E_System.MainApp.Professor.Professor_Forms
{
    partial class Student_management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_management));
            System.Windows.Forms.Label studentIDLabel;
            System.Windows.Forms.Label studentNameLabel;
            System.Windows.Forms.Label e_MailLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label pPLabel1;
            System.Windows.Forms.Label facultyIDLabel;
            System.Windows.Forms.Label departmentIDLabel;
            this.addSTD = new Guna.UI2.WinForms.Guna2Button();
            this.delSTD = new Guna.UI2.WinForms.Guna2Button();
            this.saveSTD = new Guna.UI2.WinForms.Guna2Button();
            this.UploadPhoto = new Guna.UI2.WinForms.Guna2Button();
            this._University_E_SystemDataSet = new University_E_System.DataBase._University_E_SystemDataSet();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new University_E_System.DataBase._University_E_SystemDataSetTableAdapters.StudentTableAdapter();
            this.tableAdapterManager = new University_E_System.DataBase._University_E_SystemDataSetTableAdapters.TableAdapterManager();
            this.studentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.studentIDTextBox = new System.Windows.Forms.TextBox();
            this.studentNameTextBox = new System.Windows.Forms.TextBox();
            this.e_MailTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.PicBox = new System.Windows.Forms.PictureBox();
            this.studentDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentTableAdapter = new University_E_System.DataBase._University_E_SystemDataSetTableAdapters.DepartmentTableAdapter();
            this.departmentIDComboBox = new System.Windows.Forms.ComboBox();
            this.facultyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facultyTableAdapter = new University_E_System.DataBase._University_E_SystemDataSetTableAdapters.FacultyTableAdapter();
            this.facultyIDComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            studentIDLabel = new System.Windows.Forms.Label();
            studentNameLabel = new System.Windows.Forms.Label();
            e_MailLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            pPLabel1 = new System.Windows.Forms.Label();
            facultyIDLabel = new System.Windows.Forms.Label();
            departmentIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._University_E_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingNavigator)).BeginInit();
            this.studentBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addSTD
            // 
            this.addSTD.BackColor = System.Drawing.Color.Goldenrod;
            this.addSTD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addSTD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addSTD.BorderRadius = 6;
            this.addSTD.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.addSTD.BorderThickness = 2;
            this.addSTD.CheckedState.Parent = this.addSTD;
            this.addSTD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addSTD.CustomImages.Parent = this.addSTD;
            this.addSTD.FillColor = System.Drawing.Color.GhostWhite;
            this.addSTD.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold);
            this.addSTD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addSTD.HoverState.Parent = this.addSTD;
            this.addSTD.Location = new System.Drawing.Point(14, 334);
            this.addSTD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addSTD.Name = "addSTD";
            this.addSTD.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addSTD.ShadowDecoration.Parent = this.addSTD;
            this.addSTD.Size = new System.Drawing.Size(82, 43);
            this.addSTD.TabIndex = 54;
            this.addSTD.Text = "Add";
            this.addSTD.Click += new System.EventHandler(this.AddSTD_Click);
            // 
            // delSTD
            // 
            this.delSTD.BackColor = System.Drawing.Color.Goldenrod;
            this.delSTD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delSTD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.delSTD.BorderRadius = 6;
            this.delSTD.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.delSTD.BorderThickness = 2;
            this.delSTD.CheckedState.Parent = this.delSTD;
            this.delSTD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delSTD.CustomImages.Parent = this.delSTD;
            this.delSTD.FillColor = System.Drawing.Color.GhostWhite;
            this.delSTD.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold);
            this.delSTD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.delSTD.HoverState.Parent = this.delSTD;
            this.delSTD.Location = new System.Drawing.Point(206, 334);
            this.delSTD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delSTD.Name = "delSTD";
            this.delSTD.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.delSTD.ShadowDecoration.Parent = this.delSTD;
            this.delSTD.Size = new System.Drawing.Size(95, 43);
            this.delSTD.TabIndex = 55;
            this.delSTD.Text = "Delete";
            this.delSTD.Click += new System.EventHandler(this.DelSTD_Click);
            // 
            // saveSTD
            // 
            this.saveSTD.BackColor = System.Drawing.Color.Goldenrod;
            this.saveSTD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveSTD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.saveSTD.BorderRadius = 6;
            this.saveSTD.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.saveSTD.BorderThickness = 2;
            this.saveSTD.CheckedState.Parent = this.saveSTD;
            this.saveSTD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveSTD.CustomImages.Parent = this.saveSTD;
            this.saveSTD.FillColor = System.Drawing.Color.GhostWhite;
            this.saveSTD.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold);
            this.saveSTD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.saveSTD.HoverState.Parent = this.saveSTD;
            this.saveSTD.Location = new System.Drawing.Point(102, 334);
            this.saveSTD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveSTD.Name = "saveSTD";
            this.saveSTD.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.saveSTD.ShadowDecoration.Parent = this.saveSTD;
            this.saveSTD.Size = new System.Drawing.Size(95, 43);
            this.saveSTD.TabIndex = 56;
            this.saveSTD.Text = "Save";
            this.saveSTD.Click += new System.EventHandler(this.SaveSTD_Click);
            // 
            // UploadPhoto
            // 
            this.UploadPhoto.BackColor = System.Drawing.Color.Goldenrod;
            this.UploadPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UploadPhoto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UploadPhoto.BorderRadius = 6;
            this.UploadPhoto.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.UploadPhoto.BorderThickness = 2;
            this.UploadPhoto.CheckedState.Parent = this.UploadPhoto;
            this.UploadPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UploadPhoto.CustomImages.Parent = this.UploadPhoto;
            this.UploadPhoto.FillColor = System.Drawing.Color.GhostWhite;
            this.UploadPhoto.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold);
            this.UploadPhoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UploadPhoto.HoverState.Parent = this.UploadPhoto;
            this.UploadPhoto.Location = new System.Drawing.Point(245, 183);
            this.UploadPhoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UploadPhoto.Name = "UploadPhoto";
            this.UploadPhoto.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UploadPhoto.ShadowDecoration.Parent = this.UploadPhoto;
            this.UploadPhoto.Size = new System.Drawing.Size(83, 33);
            this.UploadPhoto.TabIndex = 57;
            this.UploadPhoto.Text = "Upload";
            this.UploadPhoto.Click += new System.EventHandler(this.UploadPhoto_Click);
            // 
            // _University_E_SystemDataSet
            // 
            this._University_E_SystemDataSet.DataSetName = "_University_E_SystemDataSet";
            this._University_E_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this._University_E_SystemDataSet;
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
            this.studentBindingNavigator.Size = new System.Drawing.Size(792, 25);
            this.studentBindingNavigator.TabIndex = 58;
            this.studentBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
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
            // studentIDLabel
            // 
            studentIDLabel.AutoSize = true;
            studentIDLabel.Location = new System.Drawing.Point(33, 39);
            studentIDLabel.Name = "studentIDLabel";
            studentIDLabel.Size = new System.Drawing.Size(61, 13);
            studentIDLabel.TabIndex = 58;
            studentIDLabel.Text = "Student ID:";
            // 
            // studentIDTextBox
            // 
            this.studentIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "StudentID", true));
            this.studentIDTextBox.Location = new System.Drawing.Point(118, 36);
            this.studentIDTextBox.Name = "studentIDTextBox";
            this.studentIDTextBox.ReadOnly = true;
            this.studentIDTextBox.Size = new System.Drawing.Size(121, 20);
            this.studentIDTextBox.TabIndex = 59;
            // 
            // studentNameLabel
            // 
            studentNameLabel.AutoSize = true;
            studentNameLabel.Location = new System.Drawing.Point(33, 65);
            studentNameLabel.Name = "studentNameLabel";
            studentNameLabel.Size = new System.Drawing.Size(78, 13);
            studentNameLabel.TabIndex = 60;
            studentNameLabel.Text = "Student Name:";
            // 
            // studentNameTextBox
            // 
            this.studentNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "StudentName", true));
            this.studentNameTextBox.Location = new System.Drawing.Point(118, 62);
            this.studentNameTextBox.Name = "studentNameTextBox";
            this.studentNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.studentNameTextBox.TabIndex = 61;
            // 
            // e_MailLabel
            // 
            e_MailLabel.AutoSize = true;
            e_MailLabel.Location = new System.Drawing.Point(33, 91);
            e_MailLabel.Name = "e_MailLabel";
            e_MailLabel.Size = new System.Drawing.Size(39, 13);
            e_MailLabel.TabIndex = 62;
            e_MailLabel.Text = "E Mail:";
            // 
            // e_MailTextBox
            // 
            this.e_MailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "E_Mail", true));
            this.e_MailTextBox.Location = new System.Drawing.Point(118, 88);
            this.e_MailTextBox.Name = "e_MailTextBox";
            this.e_MailTextBox.Size = new System.Drawing.Size(121, 20);
            this.e_MailTextBox.TabIndex = 63;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(33, 117);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(56, 13);
            passwordLabel.TabIndex = 64;
            passwordLabel.Text = "Password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(118, 114);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(121, 20);
            this.passwordTextBox.TabIndex = 65;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(33, 143);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(41, 13);
            phoneLabel.TabIndex = 66;
            phoneLabel.Text = "Phone:";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(118, 140);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(121, 20);
            this.phoneTextBox.TabIndex = 67;
            // 
            // pPLabel1
            // 
            pPLabel1.AutoSize = true;
            pPLabel1.Location = new System.Drawing.Point(33, 166);
            pPLabel1.Name = "pPLabel1";
            pPLabel1.Size = new System.Drawing.Size(24, 13);
            pPLabel1.TabIndex = 68;
            pPLabel1.Text = "PP:";
            // 
            // PicBox
            // 
            this.PicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.studentBindingSource, "PP", true));
            this.PicBox.Location = new System.Drawing.Point(118, 166);
            this.PicBox.Name = "PicBox";
            this.PicBox.Size = new System.Drawing.Size(121, 50);
            this.PicBox.TabIndex = 69;
            this.PicBox.TabStop = false;
            // 
            // facultyIDLabel
            // 
            facultyIDLabel.AutoSize = true;
            facultyIDLabel.Location = new System.Drawing.Point(33, 225);
            facultyIDLabel.Name = "facultyIDLabel";
            facultyIDLabel.Size = new System.Drawing.Size(47, 13);
            facultyIDLabel.TabIndex = 70;
            facultyIDLabel.Text = "Faculty :";
            // 
            // departmentIDLabel
            // 
            departmentIDLabel.AutoSize = true;
            departmentIDLabel.Location = new System.Drawing.Point(33, 252);
            departmentIDLabel.Name = "departmentIDLabel";
            departmentIDLabel.Size = new System.Drawing.Size(68, 13);
            departmentIDLabel.TabIndex = 72;
            departmentIDLabel.Text = "Department :";
            // 
            // studentDataGridView
            // 
            this.studentDataGridView.AutoGenerateColumns = false;
            this.studentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.studentDataGridView.DataSource = this.studentBindingSource;
            this.studentDataGridView.Location = new System.Drawing.Point(334, 36);
            this.studentDataGridView.Name = "studentDataGridView";
            this.studentDataGridView.Size = new System.Drawing.Size(438, 350);
            this.studentDataGridView.TabIndex = 72;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "StudentID";
            this.dataGridViewTextBoxColumn1.HeaderText = "StudentID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "StudentName";
            this.dataGridViewTextBoxColumn2.HeaderText = "StudentName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "E_Mail";
            this.dataGridViewTextBoxColumn3.HeaderText = "E_Mail";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn4.HeaderText = "Password";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn5.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "PP";
            this.dataGridViewImageColumn1.HeaderText = "PP";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            this.departmentBindingSource.DataSource = this._University_E_SystemDataSet;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // departmentIDComboBox
            // 
            this.departmentIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departmentBindingSource, "DepartmentID", true));
            this.departmentIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.studentBindingSource, "DepartmentID", true));
            this.departmentIDComboBox.DataSource = this.departmentBindingSource;
            this.departmentIDComboBox.DisplayMember = "DepartmentName";
            this.departmentIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentIDComboBox.FormattingEnabled = true;
            this.departmentIDComboBox.Location = new System.Drawing.Point(118, 244);
            this.departmentIDComboBox.Name = "departmentIDComboBox";
            this.departmentIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.departmentIDComboBox.TabIndex = 73;
            this.departmentIDComboBox.ValueMember = "DepartmentID";
            // 
            // facultyBindingSource
            // 
            this.facultyBindingSource.DataMember = "Faculty";
            this.facultyBindingSource.DataSource = this._University_E_SystemDataSet;
            // 
            // facultyTableAdapter
            // 
            this.facultyTableAdapter.ClearBeforeFill = true;
            // 
            // facultyIDComboBox
            // 
            this.facultyIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facultyBindingSource, "FacultyID", true));
            this.facultyIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.studentBindingSource, "FacultyID", true));
            this.facultyIDComboBox.DataSource = this.facultyBindingSource;
            this.facultyIDComboBox.DisplayMember = "FacultyName";
            this.facultyIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.facultyIDComboBox.FormattingEnabled = true;
            this.facultyIDComboBox.Location = new System.Drawing.Point(118, 221);
            this.facultyIDComboBox.Name = "facultyIDComboBox";
            this.facultyIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.facultyIDComboBox.TabIndex = 74;
            this.facultyIDComboBox.ValueMember = "FacultyID";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "DepartmentID";
            this.dataGridViewTextBoxColumn7.HeaderText = "DepartmentID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "FacultyID";
            this.dataGridViewTextBoxColumn6.HeaderText = "FacultyID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Student_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(792, 561);
            this.Controls.Add(this.facultyIDComboBox);
            this.Controls.Add(this.departmentIDComboBox);
            this.Controls.Add(this.studentDataGridView);
            this.Controls.Add(studentIDLabel);
            this.Controls.Add(this.studentIDTextBox);
            this.Controls.Add(studentNameLabel);
            this.Controls.Add(this.studentNameTextBox);
            this.Controls.Add(e_MailLabel);
            this.Controls.Add(this.e_MailTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(pPLabel1);
            this.Controls.Add(this.PicBox);
            this.Controls.Add(facultyIDLabel);
            this.Controls.Add(departmentIDLabel);
            this.Controls.Add(this.studentBindingNavigator);
            this.Controls.Add(this.UploadPhoto);
            this.Controls.Add(this.saveSTD);
            this.Controls.Add(this.delSTD);
            this.Controls.Add(this.addSTD);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Student_management";
            this.Text = "Student Management";
            this.Load += new System.EventHandler(this.Student_management_Load);
            ((System.ComponentModel.ISupportInitialize)(this._University_E_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingNavigator)).EndInit();
            this.studentBindingNavigator.ResumeLayout(false);
            this.studentBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button addSTD;
        private Guna.UI2.WinForms.Guna2Button delSTD;
        private Guna.UI2.WinForms.Guna2Button saveSTD;
        private Guna.UI2.WinForms.Guna2Button UploadPhoto;
        private DataBase._University_E_SystemDataSet _University_E_SystemDataSet;
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
        private System.Windows.Forms.TextBox studentIDTextBox;
        private System.Windows.Forms.TextBox studentNameTextBox;
        private System.Windows.Forms.TextBox e_MailTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.PictureBox PicBox;
        private System.Windows.Forms.DataGridView studentDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private DataBase._University_E_SystemDataSetTableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private DataBase._University_E_SystemDataSetTableAdapters.FacultyTableAdapter facultyTableAdapter;
        private System.Windows.Forms.ComboBox departmentIDComboBox;
        private System.Windows.Forms.BindingSource facultyBindingSource;
        private System.Windows.Forms.ComboBox facultyIDComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}