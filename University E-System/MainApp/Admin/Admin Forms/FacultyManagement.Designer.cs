namespace Login_SignUp.Admin_Forms
{
    partial class FacultyManagement
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
            System.Windows.Forms.Label facultyNameLabel;
            System.Windows.Forms.Label levelsLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacultyManagement));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnDeleteFaculty = new Guna.UI2.WinForms.Guna2Button();
            this.btnSubmitFacTAmin = new Guna.UI2.WinForms.Guna2Button();
            this._University_E_SystemDataSet = new University_E_System.DataBase._University_E_SystemDataSet();
            this.facultyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facultyTableAdapter = new University_E_System.DataBase._University_E_SystemDataSetTableAdapters.FacultyTableAdapter();
            this.tableAdapterManager = new University_E_System.DataBase._University_E_SystemDataSetTableAdapters.TableAdapterManager();
            this.facultyBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.facultyBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.facultyDataGridView = new System.Windows.Forms.DataGridView();
            this.facultyNameTextBox = new System.Windows.Forms.TextBox();
            this.levelsTextBox = new System.Windows.Forms.TextBox();
            this.AddFac = new Guna.UI2.WinForms.Guna2Button();
            this.facultyIDTextBox = new System.Windows.Forms.TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            facultyNameLabel = new System.Windows.Forms.Label();
            levelsLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._University_E_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingNavigator)).BeginInit();
            this.facultyBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facultyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // facultyNameLabel
            // 
            facultyNameLabel.AutoSize = true;
            facultyNameLabel.Font = new System.Drawing.Font("Segoe Print", 9F);
            facultyNameLabel.Location = new System.Drawing.Point(12, 58);
            facultyNameLabel.Name = "facultyNameLabel";
            facultyNameLabel.Size = new System.Drawing.Size(97, 21);
            facultyNameLabel.TabIndex = 45;
            facultyNameLabel.Text = "Faculty Name:";
            // 
            // levelsLabel
            // 
            levelsLabel.AutoSize = true;
            levelsLabel.Font = new System.Drawing.Font("Segoe Print", 9F);
            levelsLabel.Location = new System.Drawing.Point(22, 91);
            levelsLabel.Name = "levelsLabel";
            levelsLabel.Size = new System.Drawing.Size(49, 21);
            levelsLabel.TabIndex = 46;
            levelsLabel.Text = "Levels:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe Print", 9F);
            label1.Location = new System.Drawing.Point(12, 32);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(76, 21);
            label1.TabIndex = 55;
            label1.Text = "Faculty ID:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(117, 82);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 1);
            this.panel1.TabIndex = 39;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(137, 1);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Location = new System.Drawing.Point(117, 113);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(137, 1);
            this.panel3.TabIndex = 39;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(0, -5);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(137, 1);
            this.panel6.TabIndex = 5;
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
            this.btnDeleteFaculty.Location = new System.Drawing.Point(188, 164);
            this.btnDeleteFaculty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteFaculty.Name = "btnDeleteFaculty";
            this.btnDeleteFaculty.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDeleteFaculty.ShadowDecoration.Parent = this.btnDeleteFaculty;
            this.btnDeleteFaculty.Size = new System.Drawing.Size(92, 43);
            this.btnDeleteFaculty.TabIndex = 48;
            this.btnDeleteFaculty.Text = "Delete";
            this.btnDeleteFaculty.Click += new System.EventHandler(this.btnDeleteFaculty_Click);
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
            this.btnSubmitFacTAmin.Location = new System.Drawing.Point(26, 239);
            this.btnSubmitFacTAmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmitFacTAmin.Name = "btnSubmitFacTAmin";
            this.btnSubmitFacTAmin.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSubmitFacTAmin.ShadowDecoration.Parent = this.btnSubmitFacTAmin;
            this.btnSubmitFacTAmin.Size = new System.Drawing.Size(95, 43);
            this.btnSubmitFacTAmin.TabIndex = 49;
            this.btnSubmitFacTAmin.Text = "Submit";
            this.btnSubmitFacTAmin.Click += new System.EventHandler(this.btnSubmitFacTAmin_Click);
            // 
            // _University_E_SystemDataSet
            // 
            this._University_E_SystemDataSet.DataSetName = "_University_E_SystemDataSet";
            this._University_E_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DepartmentTableAdapter = null;
            this.tableAdapterManager.FacultyTableAdapter = this.facultyTableAdapter;
            this.tableAdapterManager.ProfessorTableAdapter = null;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = University_E_System.DataBase._University_E_SystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // facultyBindingNavigator
            // 
            this.facultyBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.facultyBindingNavigator.BindingSource = this.facultyBindingSource;
            this.facultyBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.facultyBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.facultyBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.facultyBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.facultyBindingNavigatorSaveItem});
            this.facultyBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.facultyBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.facultyBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.facultyBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.facultyBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.facultyBindingNavigator.Name = "facultyBindingNavigator";
            this.facultyBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.facultyBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.facultyBindingNavigator.Size = new System.Drawing.Size(763, 31);
            this.facultyBindingNavigator.TabIndex = 50;
            this.facultyBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // facultyBindingNavigatorSaveItem
            // 
            this.facultyBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.facultyBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("facultyBindingNavigatorSaveItem.Image")));
            this.facultyBindingNavigatorSaveItem.Name = "facultyBindingNavigatorSaveItem";
            this.facultyBindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 28);
            this.facultyBindingNavigatorSaveItem.Text = "Save Data";
            this.facultyBindingNavigatorSaveItem.Click += new System.EventHandler(this.facultyBindingNavigatorSaveItem_Click);
            // 
            // facultyDataGridView
            // 
            this.facultyDataGridView.AutoGenerateColumns = false;
            this.facultyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.facultyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.facultyDataGridView.DataSource = this.facultyBindingSource;
            this.facultyDataGridView.Location = new System.Drawing.Point(317, 28);
            this.facultyDataGridView.Name = "facultyDataGridView";
            this.facultyDataGridView.RowHeadersWidth = 62;
            this.facultyDataGridView.Size = new System.Drawing.Size(298, 228);
            this.facultyDataGridView.TabIndex = 50;
            // 
            // facultyNameTextBox
            // 
            this.facultyNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facultyBindingSource, "FacultyName", true));
            this.facultyNameTextBox.Location = new System.Drawing.Point(117, 59);
            this.facultyNameTextBox.Name = "facultyNameTextBox";
            this.facultyNameTextBox.Size = new System.Drawing.Size(137, 20);
            this.facultyNameTextBox.TabIndex = 51;
            // 
            // levelsTextBox
            // 
            this.levelsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facultyBindingSource, "Levels", true));
            this.levelsTextBox.Location = new System.Drawing.Point(117, 91);
            this.levelsTextBox.Name = "levelsTextBox";
            this.levelsTextBox.Size = new System.Drawing.Size(137, 20);
            this.levelsTextBox.TabIndex = 52;
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
            this.AddFac.Location = new System.Drawing.Point(26, 164);
            this.AddFac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddFac.Name = "AddFac";
            this.AddFac.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddFac.ShadowDecoration.Parent = this.AddFac;
            this.AddFac.Size = new System.Drawing.Size(95, 43);
            this.AddFac.TabIndex = 53;
            this.AddFac.Text = "Add";
            this.AddFac.Click += new System.EventHandler(this.AddFac_Click);
            // 
            // facultyIDTextBox
            // 
            this.facultyIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facultyBindingSource, "FacultyID", true));
            this.facultyIDTextBox.Location = new System.Drawing.Point(117, 33);
            this.facultyIDTextBox.Name = "facultyIDTextBox";
            this.facultyIDTextBox.ReadOnly = true;
            this.facultyIDTextBox.Size = new System.Drawing.Size(137, 20);
            this.facultyIDTextBox.TabIndex = 54;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Goldenrod;
            this.guna2Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button1.BorderRadius = 6;
            this.guna2Button1.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.guna2Button1.BorderThickness = 2;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.GhostWhite;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(188, 239);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(95, 43);
            this.guna2Button1.TabIndex = 56;
            this.guna2Button1.Text = "Print";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FacultyID";
            this.dataGridViewTextBoxColumn4.HeaderText = "FacultyID";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 77;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FacultyName";
            this.dataGridViewTextBoxColumn5.HeaderText = "FacultyName";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 94;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Levels";
            this.dataGridViewTextBoxColumn6.HeaderText = "Levels";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 63;
            // 
            // FacultyManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(763, 487);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(label1);
            this.Controls.Add(this.facultyIDTextBox);
            this.Controls.Add(this.AddFac);
            this.Controls.Add(this.levelsTextBox);
            this.Controls.Add(this.facultyNameTextBox);
            this.Controls.Add(this.facultyDataGridView);
            this.Controls.Add(this.facultyBindingNavigator);
            this.Controls.Add(this.btnSubmitFacTAmin);
            this.Controls.Add(this.btnDeleteFaculty);
            this.Controls.Add(levelsLabel);
            this.Controls.Add(facultyNameLabel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FacultyManagement";
            this.Text = "FacultyManagement";
            this.Load += new System.EventHandler(this.FacultyManagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._University_E_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingNavigator)).EndInit();
            this.facultyBindingNavigator.ResumeLayout(false);
            this.facultyBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facultyDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private Guna.UI2.WinForms.Guna2Button btnDeleteFaculty;
        private Guna.UI2.WinForms.Guna2Button btnSubmitFacTAmin;
        private University_E_System.DataBase._University_E_SystemDataSet _University_E_SystemDataSet;
        private System.Windows.Forms.BindingSource facultyBindingSource;
        private University_E_System.DataBase._University_E_SystemDataSetTableAdapters.FacultyTableAdapter facultyTableAdapter;
        private University_E_System.DataBase._University_E_SystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator facultyBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton facultyBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView facultyDataGridView;
        private System.Windows.Forms.TextBox facultyNameTextBox;
        private System.Windows.Forms.TextBox levelsTextBox;
        private Guna.UI2.WinForms.Guna2Button AddFac;
        private System.Windows.Forms.TextBox facultyIDTextBox;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}