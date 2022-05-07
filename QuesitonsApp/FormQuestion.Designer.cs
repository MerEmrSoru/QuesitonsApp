namespace QuesitonsApp
{
    partial class FormQuestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuestion));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnBack = new System.Windows.Forms.Button();
            this.RdbA = new System.Windows.Forms.RadioButton();
            this.RdbB = new System.Windows.Forms.RadioButton();
            this.RdbC = new System.Windows.Forms.RadioButton();
            this.RdbD = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(172, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(804, 394);
            this.dataGridView1.TabIndex = 0;
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
            this.BtnBack.Location = new System.Drawing.Point(11, 686);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(46, 37);
            this.BtnBack.TabIndex = 5;
            this.BtnBack.UseVisualStyleBackColor = false;
            // 
            // RdbA
            // 
            this.RdbA.AutoSize = true;
            this.RdbA.BackColor = System.Drawing.Color.Transparent;
            this.RdbA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RdbA.FlatAppearance.BorderSize = 0;
            this.RdbA.Font = new System.Drawing.Font("Headline R", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RdbA.Location = new System.Drawing.Point(273, 587);
            this.RdbA.Name = "RdbA";
            this.RdbA.Size = new System.Drawing.Size(59, 33);
            this.RdbA.TabIndex = 1;
            this.RdbA.TabStop = true;
            this.RdbA.Text = "A";
            this.RdbA.UseVisualStyleBackColor = false;
            // 
            // RdbB
            // 
            this.RdbB.AutoSize = true;
            this.RdbB.BackColor = System.Drawing.Color.Transparent;
            this.RdbB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RdbB.FlatAppearance.BorderSize = 0;
            this.RdbB.Font = new System.Drawing.Font("Headline R", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RdbB.Location = new System.Drawing.Point(442, 587);
            this.RdbB.Name = "RdbB";
            this.RdbB.Size = new System.Drawing.Size(55, 33);
            this.RdbB.TabIndex = 2;
            this.RdbB.TabStop = true;
            this.RdbB.Text = "B";
            this.RdbB.UseVisualStyleBackColor = false;
            // 
            // RdbC
            // 
            this.RdbC.AutoSize = true;
            this.RdbC.BackColor = System.Drawing.Color.Transparent;
            this.RdbC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RdbC.FlatAppearance.BorderSize = 0;
            this.RdbC.Font = new System.Drawing.Font("Headline R", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RdbC.Location = new System.Drawing.Point(615, 587);
            this.RdbC.Name = "RdbC";
            this.RdbC.Size = new System.Drawing.Size(58, 33);
            this.RdbC.TabIndex = 3;
            this.RdbC.TabStop = true;
            this.RdbC.Text = "C";
            this.RdbC.UseVisualStyleBackColor = false;
            // 
            // RdbD
            // 
            this.RdbD.AutoSize = true;
            this.RdbD.BackColor = System.Drawing.Color.Transparent;
            this.RdbD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RdbD.FlatAppearance.BorderSize = 0;
            this.RdbD.Font = new System.Drawing.Font("Headline R", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RdbD.Location = new System.Drawing.Point(801, 587);
            this.RdbD.Name = "RdbD";
            this.RdbD.Size = new System.Drawing.Size(56, 33);
            this.RdbD.TabIndex = 4;
            this.RdbD.TabStop = true;
            this.RdbD.Text = "D";
            this.RdbD.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("HYHeadLine-Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(169, 534);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 60;
            this.label1.Text = "RIGHT ANSWER";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(997, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Headline R", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(991, 682);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 35);
            this.label2.TabIndex = 61;
            this.label2.Text = "Time";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Headline R", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(997, 478);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 37);
            this.button1.TabIndex = 63;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FormQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1197, 734);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RdbD);
            this.Controls.Add(this.RdbC);
            this.Controls.Add(this.RdbB);
            this.Controls.Add(this.RdbA);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormQuestion";
            this.Text = "FormQuestion";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.RadioButton RdbA;
        private System.Windows.Forms.RadioButton RdbB;
        private System.Windows.Forms.RadioButton RdbC;
        private System.Windows.Forms.RadioButton RdbD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}