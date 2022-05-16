namespace QuesitonsApp
{
    partial class FormUserSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserSelect));
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAdmin = new System.Windows.Forms.Button();
            this.BtnTeacher = new System.Windows.Forms.Button();
            this.BtnStudent = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Headline R", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(388, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "USER TYPE";
            // 
            // BtnAdmin
            // 
            this.BtnAdmin.BackColor = System.Drawing.Color.Transparent;
            this.BtnAdmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAdmin.BackgroundImage")));
            this.BtnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdmin.FlatAppearance.BorderSize = 0;
            this.BtnAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdmin.Location = new System.Drawing.Point(1134, 12);
            this.BtnAdmin.Name = "BtnAdmin";
            this.BtnAdmin.Size = new System.Drawing.Size(51, 46);
            this.BtnAdmin.TabIndex = 1;
            this.BtnAdmin.UseVisualStyleBackColor = false;
            this.BtnAdmin.Click += new System.EventHandler(this.BtnAdmin_Click);
            // 
            // BtnTeacher
            // 
            this.BtnTeacher.BackColor = System.Drawing.Color.Transparent;
            this.BtnTeacher.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnTeacher.BackgroundImage")));
            this.BtnTeacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTeacher.FlatAppearance.BorderSize = 0;
            this.BtnTeacher.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.BtnTeacher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
            this.BtnTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTeacher.Location = new System.Drawing.Point(599, 266);
            this.BtnTeacher.Name = "BtnTeacher";
            this.BtnTeacher.Size = new System.Drawing.Size(313, 218);
            this.BtnTeacher.TabIndex = 2;
            this.BtnTeacher.UseVisualStyleBackColor = false;
            this.BtnTeacher.Click += new System.EventHandler(this.BtnTeacher_Click);
            // 
            // BtnStudent
            // 
            this.BtnStudent.BackColor = System.Drawing.Color.Transparent;
            this.BtnStudent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnStudent.BackgroundImage")));
            this.BtnStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStudent.FlatAppearance.BorderSize = 0;
            this.BtnStudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.BtnStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
            this.BtnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStudent.Location = new System.Drawing.Point(322, 289);
            this.BtnStudent.Name = "BtnStudent";
            this.BtnStudent.Size = new System.Drawing.Size(111, 195);
            this.BtnStudent.TabIndex = 3;
            this.BtnStudent.UseVisualStyleBackColor = false;
            this.BtnStudent.Click += new System.EventHandler(this.BtnStudent_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Headline R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(318, 523);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "STUDENT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Headline R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(702, 523);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "TEACHER";
            // 
            // FormUserSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1197, 742);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnStudent);
            this.Controls.Add(this.BtnTeacher);
            this.Controls.Add(this.BtnAdmin);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUserSelect";
            this.Text = "USER TYPE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAdmin;
        private System.Windows.Forms.Button BtnTeacher;
        private System.Windows.Forms.Button BtnStudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

