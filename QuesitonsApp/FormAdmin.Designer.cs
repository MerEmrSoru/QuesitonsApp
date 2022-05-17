namespace QuesitonsApp
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.BtnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnUserList = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNewDate = new System.Windows.Forms.Label();
            this.BtnAddQuestion = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.Transparent;
            this.BtnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnBack.BackgroundImage")));
            this.BtnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnBack.FlatAppearance.BorderSize = 0;
            this.BtnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBack.Font = new System.Drawing.Font("Headline R", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnBack.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnBack.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnBack.Location = new System.Drawing.Point(11, 694);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(46, 37);
            this.BtnBack.TabIndex = 103;
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnUserList);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblNewDate);
            this.panel1.Controls.Add(this.BtnAddQuestion);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Location = new System.Drawing.Point(428, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 561);
            this.panel1.TabIndex = 102;
            // 
            // BtnUserList
            // 
            this.BtnUserList.BackColor = System.Drawing.Color.Transparent;
            this.BtnUserList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnUserList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUserList.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnUserList.FlatAppearance.BorderSize = 3;
            this.BtnUserList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PeachPuff;
            this.BtnUserList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.BtnUserList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUserList.Font = new System.Drawing.Font("Headline R", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnUserList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnUserList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnUserList.Location = new System.Drawing.Point(54, 426);
            this.BtnUserList.Margin = new System.Windows.Forms.Padding(2);
            this.BtnUserList.Name = "BtnUserList";
            this.BtnUserList.Size = new System.Drawing.Size(230, 68);
            this.BtnUserList.TabIndex = 102;
            this.BtnUserList.Text = "USER LIST";
            this.BtnUserList.UseVisualStyleBackColor = false;
            this.BtnUserList.Click += new System.EventHandler(this.BtnUserProfile_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(342, 237);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 97;
            this.pictureBox1.TabStop = false;
            // 
            // lblNewDate
            // 
            this.lblNewDate.AutoSize = true;
            this.lblNewDate.BackColor = System.Drawing.Color.Transparent;
            this.lblNewDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblNewDate.Location = new System.Drawing.Point(11, 620);
            this.lblNewDate.Name = "lblNewDate";
            this.lblNewDate.Size = new System.Drawing.Size(0, 23);
            this.lblNewDate.TabIndex = 101;
            // 
            // BtnAddQuestion
            // 
            this.BtnAddQuestion.BackColor = System.Drawing.Color.Transparent;
            this.BtnAddQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAddQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddQuestion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnAddQuestion.FlatAppearance.BorderSize = 3;
            this.BtnAddQuestion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PeachPuff;
            this.BtnAddQuestion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.BtnAddQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddQuestion.Font = new System.Drawing.Font("Headline R", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnAddQuestion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAddQuestion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnAddQuestion.Location = new System.Drawing.Point(52, 326);
            this.BtnAddQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAddQuestion.Name = "BtnAddQuestion";
            this.BtnAddQuestion.Size = new System.Drawing.Size(230, 68);
            this.BtnAddQuestion.TabIndex = 99;
            this.BtnAddQuestion.Text = "ADD QUESTION";
            this.BtnAddQuestion.UseVisualStyleBackColor = false;
            this.BtnAddQuestion.Click += new System.EventHandler(this.BtnUpdate_Click);
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
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1197, 742);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdmin";
            this.Text = "Admin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnUserList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNewDate;
        private System.Windows.Forms.Button BtnAddQuestion;
        private System.Windows.Forms.Button button6;
    }
}