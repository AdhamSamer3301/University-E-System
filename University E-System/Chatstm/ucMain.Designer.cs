
namespace University_E_System.Chatstm
{
    partial class ucMain
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.professorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._University_E_SystemDataSet = new University_E_System.DataBase._University_E_SystemDataSet();
            this.professorTableAdapter = new University_E_System.DataBase._University_E_SystemDataSetTableAdapters.ProfessorTableAdapter();
            this.tableAdapterManager = new University_E_System.DataBase._University_E_SystemDataSetTableAdapters.TableAdapterManager();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new University_E_System.DataBase._University_E_SystemDataSetTableAdapters.StudentTableAdapter();
            this.Professors = new System.Windows.Forms.Button();
            this.Students = new System.Windows.Forms.Button();
            this.professorIDListBox = new System.Windows.Forms.ListBox();
            this.studentIDListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._University_E_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // professorBindingSource
            // 
            this.professorBindingSource.DataMember = "Professor";
            this.professorBindingSource.DataSource = this._University_E_SystemDataSet;
            // 
            // _University_E_SystemDataSet
            // 
            this._University_E_SystemDataSet.DataSetName = "_University_E_SystemDataSet";
            this._University_E_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // professorTableAdapter
            // 
            this.professorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DepartmentTableAdapter = null;
            this.tableAdapterManager.FacultyTableAdapter = null;
            this.tableAdapterManager.ProfessorTableAdapter = this.professorTableAdapter;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = University_E_System.DataBase._University_E_SystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            // Professors
            // 
            this.Professors.Location = new System.Drawing.Point(140, 37);
            this.Professors.Name = "Professors";
            this.Professors.Size = new System.Drawing.Size(75, 23);
            this.Professors.TabIndex = 0;
            this.Professors.Text = "Professors";
            this.Professors.UseVisualStyleBackColor = true;
            this.Professors.Click += new System.EventHandler(this.Professors_Click);
            // 
            // Students
            // 
            this.Students.Location = new System.Drawing.Point(12, 37);
            this.Students.Name = "Students";
            this.Students.Size = new System.Drawing.Size(75, 23);
            this.Students.TabIndex = 0;
            this.Students.Text = "Students";
            this.Students.UseVisualStyleBackColor = true;
            this.Students.Click += new System.EventHandler(this.Students_Click);
            // 
            // professorIDListBox
            // 
            this.professorIDListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.studentBindingSource, "StudentID", true));
            this.professorIDListBox.DataSource = this.professorBindingSource;
            this.professorIDListBox.DisplayMember = "ProfessorName";
            this.professorIDListBox.FormattingEnabled = true;
            this.professorIDListBox.Location = new System.Drawing.Point(12, 66);
            this.professorIDListBox.Name = "professorIDListBox";
            this.professorIDListBox.Size = new System.Drawing.Size(203, 355);
            this.professorIDListBox.TabIndex = 3;
            this.professorIDListBox.ValueMember = "ProfessorID";
            this.professorIDListBox.SelectedIndexChanged += new System.EventHandler(this.professorIDListBox_SelectedIndexChanged);
            // 
            // studentIDListBox
            // 
            this.studentIDListBox.BackColor = System.Drawing.SystemColors.Window;
            this.studentIDListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.studentBindingSource, "StudentID", true));
            this.studentIDListBox.DataSource = this.studentBindingSource;
            this.studentIDListBox.DisplayMember = "StudentName";
            this.studentIDListBox.FormattingEnabled = true;
            this.studentIDListBox.Location = new System.Drawing.Point(12, 66);
            this.studentIDListBox.Name = "studentIDListBox";
            this.studentIDListBox.Size = new System.Drawing.Size(203, 355);
            this.studentIDListBox.TabIndex = 4;
            this.studentIDListBox.ValueMember = "StudentID";
            this.studentIDListBox.SelectedIndexChanged += new System.EventHandler(this.studentIDListBox_SelectedIndexChanged);
            // 
            // ucMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.studentIDListBox);
            this.Controls.Add(this.professorIDListBox);
            this.Controls.Add(this.Students);
            this.Controls.Add(this.Professors);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucMain";
            this.Size = new System.Drawing.Size(240, 437);
            this.Load += new System.EventHandler(this.ucMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._University_E_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource professorBindingSource;
        private DataBase._University_E_SystemDataSet _University_E_SystemDataSet;
        private DataBase._University_E_SystemDataSetTableAdapters.ProfessorTableAdapter professorTableAdapter;
        private DataBase._University_E_SystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private DataBase._University_E_SystemDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.Button Professors;
        private System.Windows.Forms.Button Students;
        private System.Windows.Forms.ListBox professorIDListBox;
        private System.Windows.Forms.ListBox studentIDListBox;
    }
}
