namespace University_E_System
{
    partial class ProfessorLogIn
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
            System.Windows.Forms.Label e_MailLabel;
            System.Windows.Forms.Label passwordLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfessorLogIn));
            this.PicBoxProfessorLogin = new System.Windows.Forms.PictureBox();
            this.PicBoxPofessorEmail = new System.Windows.Forms.PictureBox();
            this.PicBoxProfessorPassword = new System.Windows.Forms.PictureBox();
            this.btnLoginProfessor = new System.Windows.Forms.Button();
            this.btnCloseLoginProfessor = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnBackProfessorLogin = new Guna.UI2.WinForms.Guna2CircleButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.professorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._University_E_SystemDataSet = new University_E_System.DataBase._University_E_SystemDataSet();
            this.professorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.professorTableAdapter = new University_E_System.DataBase._University_E_SystemDataSetTableAdapters.ProfessorTableAdapter();
            this.tableAdapterManager = new University_E_System.DataBase._University_E_SystemDataSetTableAdapters.TableAdapterManager();
            this.e_MailTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            e_MailLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxProfessorLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxPofessorEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxProfessorPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._University_E_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // e_MailLabel
            // 
            e_MailLabel.AutoSize = true;
            e_MailLabel.Font = new System.Drawing.Font("Segoe Print", 9F);
            e_MailLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            e_MailLabel.Location = new System.Drawing.Point(16, 230);
            e_MailLabel.Name = "e_MailLabel";
            e_MailLabel.Size = new System.Drawing.Size(51, 21);
            e_MailLabel.TabIndex = 11;
            e_MailLabel.Text = "E Mail:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new System.Drawing.Font("Segoe Print", 9F);
            passwordLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            passwordLabel.Location = new System.Drawing.Point(16, 272);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(71, 21);
            passwordLabel.TabIndex = 12;
            passwordLabel.Text = "Password:";
            // 
            // PicBoxProfessorLogin
            // 
            this.PicBoxProfessorLogin.ErrorImage = null;
            this.PicBoxProfessorLogin.Image = ((System.Drawing.Image)(resources.GetObject("PicBoxProfessorLogin.Image")));
            this.PicBoxProfessorLogin.InitialImage = null;
            this.PicBoxProfessorLogin.Location = new System.Drawing.Point(106, 56);
            this.PicBoxProfessorLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PicBoxProfessorLogin.Name = "PicBoxProfessorLogin";
            this.PicBoxProfessorLogin.Size = new System.Drawing.Size(132, 126);
            this.PicBoxProfessorLogin.TabIndex = 0;
            this.PicBoxProfessorLogin.TabStop = false;
            // 
            // PicBoxPofessorEmail
            // 
            this.PicBoxPofessorEmail.Image = ((System.Drawing.Image)(resources.GetObject("PicBoxPofessorEmail.Image")));
            this.PicBoxPofessorEmail.Location = new System.Drawing.Point(96, 230);
            this.PicBoxPofessorEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PicBoxPofessorEmail.Name = "PicBoxPofessorEmail";
            this.PicBoxPofessorEmail.Size = new System.Drawing.Size(22, 21);
            this.PicBoxPofessorEmail.TabIndex = 1;
            this.PicBoxPofessorEmail.TabStop = false;
            // 
            // PicBoxProfessorPassword
            // 
            this.PicBoxProfessorPassword.Image = ((System.Drawing.Image)(resources.GetObject("PicBoxProfessorPassword.Image")));
            this.PicBoxProfessorPassword.Location = new System.Drawing.Point(96, 272);
            this.PicBoxProfessorPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PicBoxProfessorPassword.Name = "PicBoxProfessorPassword";
            this.PicBoxProfessorPassword.Size = new System.Drawing.Size(27, 21);
            this.PicBoxProfessorPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PicBoxProfessorPassword.TabIndex = 5;
            this.PicBoxProfessorPassword.TabStop = false;
            // 
            // btnLoginProfessor
            // 
            this.btnLoginProfessor.BackColor = System.Drawing.Color.Yellow;
            this.btnLoginProfessor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoginProfessor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginProfessor.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginProfessor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnLoginProfessor.Location = new System.Drawing.Point(125, 347);
            this.btnLoginProfessor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoginProfessor.Name = "BtnLoginProfessor";
            this.btnLoginProfessor.Size = new System.Drawing.Size(111, 41);
            this.btnLoginProfessor.TabIndex = 8;
            this.btnLoginProfessor.Text = "Log In";
            this.btnLoginProfessor.UseVisualStyleBackColor = false;
            this.btnLoginProfessor.Click += new System.EventHandler(this.BtnLoginProfessor_Click);
            // 
            // btnCloseLoginProfessor
            // 
            this.btnCloseLoginProfessor.CheckedState.Parent = this.btnCloseLoginProfessor;
            this.btnCloseLoginProfessor.CustomImages.Parent = this.btnCloseLoginProfessor;
            this.btnCloseLoginProfessor.FillColor = System.Drawing.Color.Black;
            this.btnCloseLoginProfessor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCloseLoginProfessor.ForeColor = System.Drawing.Color.White;
            this.btnCloseLoginProfessor.HoverState.Parent = this.btnCloseLoginProfessor;
            this.btnCloseLoginProfessor.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseLoginProfessor.Image")));
            this.btnCloseLoginProfessor.Location = new System.Drawing.Point(314, -1);
            this.btnCloseLoginProfessor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCloseLoginProfessor.Name = "btnCloseLoginProfessor";
            this.btnCloseLoginProfessor.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnCloseLoginProfessor.ShadowDecoration.Parent = this.btnCloseLoginProfessor;
            this.btnCloseLoginProfessor.Size = new System.Drawing.Size(37, 26);
            this.btnCloseLoginProfessor.TabIndex = 9;
            this.btnCloseLoginProfessor.Click += new System.EventHandler(this.BtnCloseLoginProfessor_Click);
            // 
            // btnBackProfessorLogin
            // 
            this.btnBackProfessorLogin.CheckedState.Parent = this.btnBackProfessorLogin;
            this.btnBackProfessorLogin.CustomImages.Parent = this.btnBackProfessorLogin;
            this.btnBackProfessorLogin.FillColor = System.Drawing.Color.Black;
            this.btnBackProfessorLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBackProfessorLogin.ForeColor = System.Drawing.Color.White;
            this.btnBackProfessorLogin.HoverState.Parent = this.btnBackProfessorLogin;
            this.btnBackProfessorLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnBackProfessorLogin.Image")));
            this.btnBackProfessorLogin.Location = new System.Drawing.Point(0, -1);
            this.btnBackProfessorLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackProfessorLogin.Name = "btnBackProfessorLogin";
            this.btnBackProfessorLogin.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnBackProfessorLogin.ShadowDecoration.Parent = this.btnBackProfessorLogin;
            this.btnBackProfessorLogin.Size = new System.Drawing.Size(37, 26);
            this.btnBackProfessorLogin.TabIndex = 11;
            this.btnBackProfessorLogin.Click += new System.EventHandler(this.BtnBackProfessorLogin_Click);
            // 
            // professorBindingSource
            // 
            this.professorBindingSource.DataMember = "Professor";
            // 
            // _University_E_SystemDataSet
            // 
            this._University_E_SystemDataSet.DataSetName = "_University_E_SystemDataSet";
            this._University_E_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // professorBindingSource1
            // 
            this.professorBindingSource1.DataMember = "Professor";
            this.professorBindingSource1.DataSource = this._University_E_SystemDataSet;
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
            // e_MailTextBox
            // 
            this.e_MailTextBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.e_MailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.e_MailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.professorBindingSource1, "E_Mail", true));
            this.e_MailTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.e_MailTextBox.Location = new System.Drawing.Point(125, 231);
            this.e_MailTextBox.Name = "e_MailTextBox";
            this.e_MailTextBox.Size = new System.Drawing.Size(142, 20);
            this.e_MailTextBox.TabIndex = 13;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.professorBindingSource1, "Password", true));
            this.passwordTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.passwordTextBox.Location = new System.Drawing.Point(128, 273);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(139, 20);
            this.passwordTextBox.TabIndex = 14;
            // 
            // ProfessorLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(352, 441);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.e_MailTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(e_MailLabel);
            this.Controls.Add(this.btnBackProfessorLogin);
            this.Controls.Add(this.btnCloseLoginProfessor);
            this.Controls.Add(this.btnLoginProfessor);
            this.Controls.Add(this.PicBoxProfessorPassword);
            this.Controls.Add(this.PicBoxPofessorEmail);
            this.Controls.Add(this.PicBoxProfessorLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProfessorLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProfessorLogIn";
            this.Load += new System.EventHandler(this.ProfessorLogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxProfessorLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxPofessorEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxProfessorPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._University_E_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBoxProfessorLogin;
        private System.Windows.Forms.PictureBox PicBoxPofessorEmail;
        private System.Windows.Forms.PictureBox PicBoxProfessorPassword;
        private System.Windows.Forms.Button btnLoginProfessor;
        private Guna.UI2.WinForms.Guna2CircleButton btnCloseLoginProfessor;
        private Guna.UI2.WinForms.Guna2CircleButton btnBackProfessorLogin;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.BindingSource professorBindingSource;
        private DataBase._University_E_SystemDataSet _University_E_SystemDataSet;
        private System.Windows.Forms.BindingSource professorBindingSource1;
        private DataBase._University_E_SystemDataSetTableAdapters.ProfessorTableAdapter professorTableAdapter;
        private DataBase._University_E_SystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox e_MailTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
    }
}