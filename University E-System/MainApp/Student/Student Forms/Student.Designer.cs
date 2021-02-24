namespace University_E_System.MainApp.Student.Student_Forms
{
    partial class Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            this.panelMenuStudent = new System.Windows.Forms.Panel();
            this.btnStudentManagmentStudent = new System.Windows.Forms.Button();
            this.panelLogoStudent = new System.Windows.Forms.Panel();
            this.lblLogostudnent = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnCloseStudentForm = new System.Windows.Forms.Button();
            this.btnBackHomeStudent = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktopStudent = new System.Windows.Forms.Panel();
            this.panelMenuStudent.SuspendLayout();
            this.panelLogoStudent.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenuStudent
            // 
            this.panelMenuStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(67)))));
            this.panelMenuStudent.Controls.Add(this.btnStudentManagmentStudent);
            this.panelMenuStudent.Controls.Add(this.panelLogoStudent);
            this.panelMenuStudent.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuStudent.Location = new System.Drawing.Point(0, 0);
            this.panelMenuStudent.Name = "panelMenuStudent";
            this.panelMenuStudent.Size = new System.Drawing.Size(220, 753);
            this.panelMenuStudent.TabIndex = 1;
            // 
            // btnStudentManagmentStudent
            // 
            this.btnStudentManagmentStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudentManagmentStudent.FlatAppearance.BorderSize = 0;
            this.btnStudentManagmentStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentManagmentStudent.Font = new System.Drawing.Font("Segoe Print", 9F);
            this.btnStudentManagmentStudent.ForeColor = System.Drawing.Color.Silver;
            this.btnStudentManagmentStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnStudentManagmentStudent.Image")));
            this.btnStudentManagmentStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentManagmentStudent.Location = new System.Drawing.Point(0, 80);
            this.btnStudentManagmentStudent.Name = "btnStudentManagmentStudent";
            this.btnStudentManagmentStudent.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnStudentManagmentStudent.Size = new System.Drawing.Size(220, 60);
            this.btnStudentManagmentStudent.TabIndex = 0;
            this.btnStudentManagmentStudent.Text = "Student Management";
            this.btnStudentManagmentStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentManagmentStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStudentManagmentStudent.UseVisualStyleBackColor = true;
            this.btnStudentManagmentStudent.Click += new System.EventHandler(this.btnStudentManagmentStudent_Click);
            // 
            // panelLogoStudent
            // 
            this.panelLogoStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.panelLogoStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogoStudent.Controls.Add(this.lblLogostudnent);
            this.panelLogoStudent.Controls.Add(this.panel1);
            this.panelLogoStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogoStudent.Location = new System.Drawing.Point(0, 0);
            this.panelLogoStudent.Name = "panelLogoStudent";
            this.panelLogoStudent.Size = new System.Drawing.Size(220, 80);
            this.panelLogoStudent.TabIndex = 0;
            // 
            // lblLogostudnent
            // 
            this.lblLogostudnent.AutoSize = true;
            this.lblLogostudnent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.lblLogostudnent.Font = new System.Drawing.Font("Algerian", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblLogostudnent.ForeColor = System.Drawing.Color.Silver;
            this.lblLogostudnent.Location = new System.Drawing.Point(29, 24);
            this.lblLogostudnent.Name = "lblLogostudnent";
            this.lblLogostudnent.Size = new System.Drawing.Size(159, 36);
            this.lblLogostudnent.TabIndex = 4;
            this.lblLogostudnent.Text = "Student";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(217, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 3;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnCloseStudentForm);
            this.panelTitleBar.Controls.Add(this.btnBackHomeStudent);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(962, 80);
            this.panelTitleBar.TabIndex = 2;
            this.panelTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitleBar_Paint);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMinimize.Location = new System.Drawing.Point(857, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 37);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMaximize.Location = new System.Drawing.Point(893, 3);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(30, 37);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.Text = "O";
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnCloseStudentForm
            // 
            this.btnCloseStudentForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseStudentForm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnCloseStudentForm.FlatAppearance.BorderSize = 0;
            this.btnCloseStudentForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseStudentForm.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseStudentForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCloseStudentForm.Location = new System.Drawing.Point(929, 3);
            this.btnCloseStudentForm.Name = "btnCloseStudentForm";
            this.btnCloseStudentForm.Size = new System.Drawing.Size(30, 37);
            this.btnCloseStudentForm.TabIndex = 2;
            this.btnCloseStudentForm.Text = "X";
            this.btnCloseStudentForm.UseVisualStyleBackColor = true;
            this.btnCloseStudentForm.Click += new System.EventHandler(this.btnCloseStudentForm_Click);
            // 
            // btnBackHomeStudent
            // 
            this.btnBackHomeStudent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnBackHomeStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackHomeStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnBackHomeStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnBackHomeStudent.Image")));
            this.btnBackHomeStudent.Location = new System.Drawing.Point(3, 3);
            this.btnBackHomeStudent.Name = "btnBackHomeStudent";
            this.btnBackHomeStudent.Size = new System.Drawing.Size(75, 71);
            this.btnBackHomeStudent.TabIndex = 1;
            this.btnBackHomeStudent.UseVisualStyleBackColor = true;
            this.btnBackHomeStudent.Click += new System.EventHandler(this.btnBackHomeStudent_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Silver;
            this.lblTitle.Location = new System.Drawing.Point(419, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(105, 49);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Home";
            // 
            // panelDesktopStudent
            // 
            this.panelDesktopStudent.BackColor = System.Drawing.Color.White;
            this.panelDesktopStudent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelDesktopStudent.BackgroundImage")));
            this.panelDesktopStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelDesktopStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelDesktopStudent.Location = new System.Drawing.Point(220, 80);
            this.panelDesktopStudent.Name = "panelDesktopStudent";
            this.panelDesktopStudent.Size = new System.Drawing.Size(962, 673);
            this.panelDesktopStudent.TabIndex = 3;
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.panelDesktopStudent);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenuStudent);
            this.Name = "Student";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            this.panelMenuStudent.ResumeLayout(false);
            this.panelLogoStudent.ResumeLayout(false);
            this.panelLogoStudent.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuStudent;
        private System.Windows.Forms.Button btnStudentManagmentStudent;
        private System.Windows.Forms.Panel panelLogoStudent;
        private System.Windows.Forms.Label lblLogostudnent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnCloseStudentForm;
        private System.Windows.Forms.Button btnBackHomeStudent;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelDesktopStudent;
    }
}