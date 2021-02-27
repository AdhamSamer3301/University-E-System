namespace Login_SignUp.Admin_Forms
{
    partial class ProfessorManagement
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
            System.Windows.Forms.Label professorIDLabel;
            System.Windows.Forms.Label professorNameLabel;
            System.Windows.Forms.Label facultyIDLabel;
            System.Windows.Forms.Label departmentIDLabel;
            System.Windows.Forms.Label e_MailLabel;
            System.Windows.Forms.Label passwordLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfessorManagement));
            this._University_E_SystemDataSet = new University_E_System.DataBase._University_E_SystemDataSet();
            this.professorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.professorTableAdapter = new University_E_System.DataBase._University_E_SystemDataSetTableAdapters.ProfessorTableAdapter();
            this.tableAdapterManager = new University_E_System.DataBase._University_E_SystemDataSetTableAdapters.TableAdapterManager();
            this.departmentTableAdapter = new University_E_System.DataBase._University_E_SystemDataSetTableAdapters.DepartmentTableAdapter();
            this.facultyTableAdapter = new University_E_System.DataBase._University_E_SystemDataSetTableAdapters.FacultyTableAdapter();
            this.professorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.professorBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.professorDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professorIDTextBox = new System.Windows.Forms.TextBox();
            this.professorNameTextBox = new System.Windows.Forms.TextBox();
            this.e_MailTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.PrintProf = new Guna.UI2.WinForms.Guna2Button();
            this.AddFac = new Guna.UI2.WinForms.Guna2Button();
            this.btnSubmitFacTAmin = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteFaculty = new Guna.UI2.WinForms.Guna2Button();
            this.facultyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentIDComboBox = new System.Windows.Forms.ComboBox();
            this.facultyIDComboBox = new System.Windows.Forms.ComboBox();
            this.HelpBtn = new System.Windows.Forms.Button();
            professorIDLabel = new System.Windows.Forms.Label();
            professorNameLabel = new System.Windows.Forms.Label();
            facultyIDLabel = new System.Windows.Forms.Label();
            departmentIDLabel = new System.Windows.Forms.Label();
            e_MailLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._University_E_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingNavigator)).BeginInit();
            this.professorBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.professorDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // professorIDLabel
            // 
            professorIDLabel.AutoSize = true;
            professorIDLabel.Location = new System.Drawing.Point(29, 60);
            professorIDLabel.Name = "professorIDLabel";
            professorIDLabel.Size = new System.Drawing.Size(68, 13);
            professorIDLabel.TabIndex = 2;
            professorIDLabel.Text = "Professor ID:";
            // 
            // professorNameLabel
            // 
            professorNameLabel.AutoSize = true;
            professorNameLabel.Location = new System.Drawing.Point(29, 86);
            professorNameLabel.Name = "professorNameLabel";
            professorNameLabel.Size = new System.Drawing.Size(85, 13);
            professorNameLabel.TabIndex = 4;
            professorNameLabel.Text = "Professor Name:";
            // 
            // facultyIDLabel
            // 
            facultyIDLabel.AutoSize = true;
            facultyIDLabel.Location = new System.Drawing.Point(29, 112);
            facultyIDLabel.Name = "facultyIDLabel";
            facultyIDLabel.Size = new System.Drawing.Size(47, 13);
            facultyIDLabel.TabIndex = 6;
            facultyIDLabel.Text = "Faculty :";
            // 
            // departmentIDLabel
            // 
            departmentIDLabel.AutoSize = true;
            departmentIDLabel.Location = new System.Drawing.Point(29, 138);
            departmentIDLabel.Name = "departmentIDLabel";
            departmentIDLabel.Size = new System.Drawing.Size(68, 13);
            departmentIDLabel.TabIndex = 8;
            departmentIDLabel.Text = "Department :";
            // 
            // e_MailLabel
            // 
            e_MailLabel.AutoSize = true;
            e_MailLabel.Location = new System.Drawing.Point(29, 164);
            e_MailLabel.Name = "e_MailLabel";
            e_MailLabel.Size = new System.Drawing.Size(39, 13);
            e_MailLabel.TabIndex = 10;
            e_MailLabel.Text = "E Mail:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(29, 190);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(56, 13);
            passwordLabel.TabIndex = 12;
            passwordLabel.Text = "Password:";
            // 
            // _University_E_SystemDataSet
            // 
            this._University_E_SystemDataSet.DataSetName = "_University_E_SystemDataSet";
            this._University_E_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // professorBindingSource
            // 
            this.professorBindingSource.DataMember = "Professor";
            this.professorBindingSource.DataSource = this._University_E_SystemDataSet;
            // 
            // professorTableAdapter
            // 
            this.professorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DepartmentTableAdapter = this.departmentTableAdapter;
            this.tableAdapterManager.FacultyTableAdapter = this.facultyTableAdapter;
            this.tableAdapterManager.ProfessorTableAdapter = this.professorTableAdapter;
            this.tableAdapterManager.StudentTableAdapter = null;
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
            // professorBindingNavigator
            // 
            this.professorBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.professorBindingNavigator.BindingSource = this.professorBindingSource;
            this.professorBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.professorBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.professorBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.professorBindingNavigatorSaveItem});
            this.professorBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.professorBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.professorBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.professorBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.professorBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.professorBindingNavigator.Name = "professorBindingNavigator";
            this.professorBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.professorBindingNavigator.Size = new System.Drawing.Size(831, 25);
            this.professorBindingNavigator.TabIndex = 0;
            this.professorBindingNavigator.Text = "bindingNavigator1";
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
            // professorBindingNavigatorSaveItem
            // 
            this.professorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.professorBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("professorBindingNavigatorSaveItem.Image")));
            this.professorBindingNavigatorSaveItem.Name = "professorBindingNavigatorSaveItem";
            this.professorBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.professorBindingNavigatorSaveItem.Text = "Save Data";
            this.professorBindingNavigatorSaveItem.Click += new System.EventHandler(this.professorBindingNavigatorSaveItem_Click);
            // 
            // professorDataGridView
            // 
            this.professorDataGridView.AutoGenerateColumns = false;
            this.professorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.professorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.professorDataGridView.DataSource = this.professorBindingSource;
            this.professorDataGridView.Location = new System.Drawing.Point(317, 40);
            this.professorDataGridView.Name = "professorDataGridView";
            this.professorDataGridView.Size = new System.Drawing.Size(478, 252);
            this.professorDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ProfessorID";
            this.dataGridViewTextBoxColumn7.HeaderText = "ProfessorID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ProfessorName";
            this.dataGridViewTextBoxColumn8.HeaderText = "ProfessorName";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "FacultyID";
            this.dataGridViewTextBoxColumn9.HeaderText = "FacultyID";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "DepartmentID";
            this.dataGridViewTextBoxColumn10.HeaderText = "DepartmentID";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "E_Mail";
            this.dataGridViewTextBoxColumn11.HeaderText = "E_Mail";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // professorIDTextBox
            // 
            this.professorIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.professorBindingSource, "ProfessorID", true));
            this.professorIDTextBox.Location = new System.Drawing.Point(120, 57);
            this.professorIDTextBox.Name = "professorIDTextBox";
            this.professorIDTextBox.ReadOnly = true;
            this.professorIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.professorIDTextBox.TabIndex = 3;
            // 
            // professorNameTextBox
            // 
            this.professorNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.professorBindingSource, "ProfessorName", true));
            this.professorNameTextBox.Location = new System.Drawing.Point(120, 83);
            this.professorNameTextBox.Name = "professorNameTextBox";
            this.professorNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.professorNameTextBox.TabIndex = 5;
            // 
            // e_MailTextBox
            // 
            this.e_MailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.professorBindingSource, "E_Mail", true));
            this.e_MailTextBox.Location = new System.Drawing.Point(120, 161);
            this.e_MailTextBox.Name = "e_MailTextBox";
            this.e_MailTextBox.Size = new System.Drawing.Size(100, 20);
            this.e_MailTextBox.TabIndex = 11;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.professorBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(120, 187);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 13;
            // 
            // PrintProf
            // 
            this.PrintProf.BackColor = System.Drawing.Color.Goldenrod;
            this.PrintProf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PrintProf.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PrintProf.BorderRadius = 6;
            this.PrintProf.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.PrintProf.BorderThickness = 2;
            this.PrintProf.CheckedState.Parent = this.PrintProf;
            this.PrintProf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrintProf.CustomImages.Parent = this.PrintProf;
            this.PrintProf.FillColor = System.Drawing.Color.GhostWhite;
            this.PrintProf.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold);
            this.PrintProf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PrintProf.HoverState.Parent = this.PrintProf;
            this.PrintProf.Location = new System.Drawing.Point(181, 324);
            this.PrintProf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PrintProf.Name = "PrintProf";
            this.PrintProf.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PrintProf.ShadowDecoration.Parent = this.PrintProf;
            this.PrintProf.Size = new System.Drawing.Size(95, 43);
            this.PrintProf.TabIndex = 60;
            this.PrintProf.Text = "Print";
            this.PrintProf.Click += new System.EventHandler(this.PrintProf_Click);
            // 
            // AddFac
            // 
            this.AddFac.BackColor = System.Drawing.Color.Goldenrod;
            this.AddFac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddFac.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddFac.BorderRadius = 6;
            this.AddFac.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.AddFac.BorderThickness = 2;
            this.AddFac.CheckedState.Parent = this.AddFac;
            this.AddFac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddFac.CustomImages.Parent = this.AddFac;
            this.AddFac.FillColor = System.Drawing.Color.GhostWhite;
            this.AddFac.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold);
            this.AddFac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddFac.HoverState.Parent = this.AddFac;
            this.AddFac.Location = new System.Drawing.Point(19, 249);
            this.AddFac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddFac.Name = "AddFac";
            this.AddFac.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddFac.ShadowDecoration.Parent = this.AddFac;
            this.AddFac.Size = new System.Drawing.Size(95, 43);
            this.AddFac.TabIndex = 59;
            this.AddFac.Text = "Add";
            this.AddFac.Click += new System.EventHandler(this.AddProf_Click);
            // 
            // btnSubmitFacTAmin
            // 
            this.btnSubmitFacTAmin.BackColor = System.Drawing.Color.Goldenrod;
            this.btnSubmitFacTAmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubmitFacTAmin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSubmitFacTAmin.BorderRadius = 6;
            this.btnSubmitFacTAmin.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnSubmitFacTAmin.BorderThickness = 2;
            this.btnSubmitFacTAmin.CheckedState.Parent = this.btnSubmitFacTAmin;
            this.btnSubmitFacTAmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmitFacTAmin.CustomImages.Parent = this.btnSubmitFacTAmin;
            this.btnSubmitFacTAmin.FillColor = System.Drawing.Color.GhostWhite;
            this.btnSubmitFacTAmin.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSubmitFacTAmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSubmitFacTAmin.HoverState.Parent = this.btnSubmitFacTAmin;
            this.btnSubmitFacTAmin.Location = new System.Drawing.Point(19, 324);
            this.btnSubmitFacTAmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmitFacTAmin.Name = "btnSubmitFacTAmin";
            this.btnSubmitFacTAmin.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSubmitFacTAmin.ShadowDecoration.Parent = this.btnSubmitFacTAmin;
            this.btnSubmitFacTAmin.Size = new System.Drawing.Size(95, 43);
            this.btnSubmitFacTAmin.TabIndex = 58;
            this.btnSubmitFacTAmin.Text = "Submit";
            this.btnSubmitFacTAmin.Click += new System.EventHandler(this.btnSubmitProfAdmin_Click);
            // 
            // btnDeleteFaculty
            // 
            this.btnDeleteFaculty.BackColor = System.Drawing.Color.Goldenrod;
            this.btnDeleteFaculty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteFaculty.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDeleteFaculty.BorderRadius = 6;
            this.btnDeleteFaculty.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnDeleteFaculty.BorderThickness = 2;
            this.btnDeleteFaculty.CheckedState.Parent = this.btnDeleteFaculty;
            this.btnDeleteFaculty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteFaculty.CustomImages.Parent = this.btnDeleteFaculty;
            this.btnDeleteFaculty.FillColor = System.Drawing.Color.GhostWhite;
            this.btnDeleteFaculty.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnDeleteFaculty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDeleteFaculty.HoverState.Parent = this.btnDeleteFaculty;
            this.btnDeleteFaculty.Location = new System.Drawing.Point(181, 249);
            this.btnDeleteFaculty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteFaculty.Name = "btnDeleteFaculty";
            this.btnDeleteFaculty.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDeleteFaculty.ShadowDecoration.Parent = this.btnDeleteFaculty;
            this.btnDeleteFaculty.Size = new System.Drawing.Size(92, 43);
            this.btnDeleteFaculty.TabIndex = 57;
            this.btnDeleteFaculty.Text = "Delete";
            this.btnDeleteFaculty.Click += new System.EventHandler(this.btnDeleteProf_Click);
            // 
            // facultyBindingSource
            // 
            this.facultyBindingSource.DataMember = "Faculty";
            this.facultyBindingSource.DataSource = this._University_E_SystemDataSet;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            this.departmentBindingSource.DataSource = this._University_E_SystemDataSet;
            // 
            // departmentIDComboBox
            // 
            this.departmentIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departmentBindingSource, "DepartmentID", true));
            this.departmentIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.professorBindingSource, "DepartmentID", true));
            this.departmentIDComboBox.DataSource = this.departmentBindingSource;
            this.departmentIDComboBox.DisplayMember = "DepartmentName";
            this.departmentIDComboBox.FormattingEnabled = true;
            this.departmentIDComboBox.Location = new System.Drawing.Point(120, 135);
            this.departmentIDComboBox.Name = "departmentIDComboBox";
            this.departmentIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.departmentIDComboBox.TabIndex = 61;
            this.departmentIDComboBox.ValueMember = "DepartmentID";
            // 
            // facultyIDComboBox
            // 
            this.facultyIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facultyBindingSource, "FacultyID", true));
            this.facultyIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.professorBindingSource, "FacultyID", true));
            this.facultyIDComboBox.DataSource = this.facultyBindingSource;
            this.facultyIDComboBox.DisplayMember = "FacultyName";
            this.facultyIDComboBox.FormattingEnabled = true;
            this.facultyIDComboBox.Location = new System.Drawing.Point(120, 108);
            this.facultyIDComboBox.Name = "facultyIDComboBox";
            this.facultyIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.facultyIDComboBox.TabIndex = 62;
            this.facultyIDComboBox.ValueMember = "FacultyID";
            // 
            // HelpBtn
            // 
            this.HelpBtn.Location = new System.Drawing.Point(800, 46);
            this.HelpBtn.Name = "HelpBtn";
            this.HelpBtn.Size = new System.Drawing.Size(29, 27);
            this.HelpBtn.TabIndex = 63;
            this.HelpBtn.Text = "?";
            this.HelpBtn.UseVisualStyleBackColor = true;
            this.HelpBtn.Click += new System.EventHandler(this.HelpBtn_Click);
            // 
            // ProfessorManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(831, 384);
            this.Controls.Add(this.HelpBtn);
            this.Controls.Add(this.facultyIDComboBox);
            this.Controls.Add(this.departmentIDComboBox);
            this.Controls.Add(this.PrintProf);
            this.Controls.Add(this.AddFac);
            this.Controls.Add(this.btnSubmitFacTAmin);
            this.Controls.Add(this.btnDeleteFaculty);
            this.Controls.Add(professorIDLabel);
            this.Controls.Add(this.professorIDTextBox);
            this.Controls.Add(professorNameLabel);
            this.Controls.Add(this.professorNameTextBox);
            this.Controls.Add(facultyIDLabel);
            this.Controls.Add(departmentIDLabel);
            this.Controls.Add(e_MailLabel);
            this.Controls.Add(this.e_MailTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.professorDataGridView);
            this.Controls.Add(this.professorBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProfessorManagement";
            this.Text = "ProfessorManagement";
            this.Load += new System.EventHandler(this.ProfessorManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this._University_E_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingNavigator)).EndInit();
            this.professorBindingNavigator.ResumeLayout(false);
            this.professorBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.professorDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private University_E_System.DataBase._University_E_SystemDataSet _University_E_SystemDataSet;
        private System.Windows.Forms.BindingSource professorBindingSource;
        private University_E_System.DataBase._University_E_SystemDataSetTableAdapters.ProfessorTableAdapter professorTableAdapter;
        private University_E_System.DataBase._University_E_SystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator professorBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton professorBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView professorDataGridView;
        private System.Windows.Forms.TextBox professorIDTextBox;
        private System.Windows.Forms.TextBox professorNameTextBox;
        private System.Windows.Forms.TextBox e_MailTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private Guna.UI2.WinForms.Guna2Button PrintProf;
        private Guna.UI2.WinForms.Guna2Button AddFac;
        private Guna.UI2.WinForms.Guna2Button btnSubmitFacTAmin;
        private Guna.UI2.WinForms.Guna2Button btnDeleteFaculty;
        private University_E_System.DataBase._University_E_SystemDataSetTableAdapters.FacultyTableAdapter facultyTableAdapter;
        private System.Windows.Forms.BindingSource facultyBindingSource;
        private University_E_System.DataBase._University_E_SystemDataSetTableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private System.Windows.Forms.ComboBox departmentIDComboBox;
        private System.Windows.Forms.ComboBox facultyIDComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Button HelpBtn;
    }
}