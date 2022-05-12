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
            this.BtnBackPage = new System.Windows.Forms.Button();
            this.RdbA = new System.Windows.Forms.RadioButton();
            this.RdbB = new System.Windows.Forms.RadioButton();
            this.RdbC = new System.Windows.Forms.RadioButton();
            this.RdbD = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonAfterQuest = new System.Windows.Forms.Button();
            this.pctimage = new System.Windows.Forms.PictureBox();
            this.quesitonAppDataSet2 = new QuesitonsApp.QuesitonAppDataSet2();
            this.tblQuestionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_QuestionTableAdapter = new QuesitonsApp.QuesitonAppDataSet2TableAdapters.Tbl_QuestionTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.questionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolObjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correctAnswerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ımageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.option1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.option2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.option3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.option4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSchoolObject = new System.Windows.Forms.Label();
            this.LblQuestion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblUnitId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quesitonAppDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblQuestionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBackPage
            // 
            this.BtnBackPage.BackColor = System.Drawing.Color.Transparent;
            this.BtnBackPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnBackPage.BackgroundImage")));
            this.BtnBackPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBackPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBackPage.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnBackPage.FlatAppearance.BorderSize = 0;
            this.BtnBackPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnBackPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnBackPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBackPage.Font = new System.Drawing.Font("Headline R", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnBackPage.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnBackPage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnBackPage.Location = new System.Drawing.Point(11, 686);
            this.BtnBackPage.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBackPage.Name = "BtnBackPage";
            this.BtnBackPage.Size = new System.Drawing.Size(46, 37);
            this.BtnBackPage.TabIndex = 5;
            this.BtnBackPage.UseVisualStyleBackColor = false;
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
            // timer1
            // 
            this.timer1.Interval = 1000;
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
            this.label2.Location = new System.Drawing.Point(5, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 34);
            this.label2.TabIndex = 61;
            this.label2.Text = "Time";
            // 
            // ButtonAfterQuest
            // 
            this.ButtonAfterQuest.BackColor = System.Drawing.Color.Transparent;
            this.ButtonAfterQuest.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonAfterQuest.BackgroundImage")));
            this.ButtonAfterQuest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonAfterQuest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAfterQuest.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ButtonAfterQuest.FlatAppearance.BorderSize = 0;
            this.ButtonAfterQuest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ButtonAfterQuest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.ButtonAfterQuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAfterQuest.Font = new System.Drawing.Font("Headline R", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonAfterQuest.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.ButtonAfterQuest.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ButtonAfterQuest.Location = new System.Drawing.Point(997, 478);
            this.ButtonAfterQuest.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonAfterQuest.Name = "ButtonAfterQuest";
            this.ButtonAfterQuest.Size = new System.Drawing.Size(62, 37);
            this.ButtonAfterQuest.TabIndex = 63;
            this.ButtonAfterQuest.UseVisualStyleBackColor = false;
            // 
            // pctimage
            // 
            this.pctimage.Location = new System.Drawing.Point(234, 9);
            this.pctimage.Name = "pctimage";
            this.pctimage.Size = new System.Drawing.Size(702, 377);
            this.pctimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctimage.TabIndex = 64;
            this.pctimage.TabStop = false;
            // 
            // quesitonAppDataSet2
            // 
            this.quesitonAppDataSet2.DataSetName = "QuesitonAppDataSet2";
            this.quesitonAppDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblQuestionBindingSource
            // 
            this.tblQuestionBindingSource.DataMember = "Tbl_Question";
            this.tblQuestionBindingSource.DataSource = this.quesitonAppDataSet2;
            // 
            // tbl_QuestionTableAdapter
            // 
            this.tbl_QuestionTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.questionIDDataGridViewTextBoxColumn,
            this.questionDataGridViewTextBoxColumn,
            this.schoolObjectDataGridViewTextBoxColumn,
            this.unitIDDataGridViewTextBoxColumn,
            this.subjectIDDataGridViewTextBoxColumn,
            this.correctAnswerDataGridViewTextBoxColumn,
            this.ımageDataGridViewImageColumn,
            this.option1DataGridViewTextBoxColumn,
            this.option2DataGridViewTextBoxColumn,
            this.option3DataGridViewTextBoxColumn,
            this.option4DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblQuestionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(81, 640);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1046, 65);
            this.dataGridView1.TabIndex = 103;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // questionIDDataGridViewTextBoxColumn
            // 
            this.questionIDDataGridViewTextBoxColumn.DataPropertyName = "QuestionID";
            this.questionIDDataGridViewTextBoxColumn.HeaderText = "QuestionID";
            this.questionIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.questionIDDataGridViewTextBoxColumn.Name = "questionIDDataGridViewTextBoxColumn";
            this.questionIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // questionDataGridViewTextBoxColumn
            // 
            this.questionDataGridViewTextBoxColumn.DataPropertyName = "Question";
            this.questionDataGridViewTextBoxColumn.HeaderText = "Question";
            this.questionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.questionDataGridViewTextBoxColumn.Name = "questionDataGridViewTextBoxColumn";
            // 
            // schoolObjectDataGridViewTextBoxColumn
            // 
            this.schoolObjectDataGridViewTextBoxColumn.DataPropertyName = "SchoolObject";
            this.schoolObjectDataGridViewTextBoxColumn.HeaderText = "SchoolObject";
            this.schoolObjectDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.schoolObjectDataGridViewTextBoxColumn.Name = "schoolObjectDataGridViewTextBoxColumn";
            // 
            // unitIDDataGridViewTextBoxColumn
            // 
            this.unitIDDataGridViewTextBoxColumn.DataPropertyName = "UnitID";
            this.unitIDDataGridViewTextBoxColumn.HeaderText = "UnitID";
            this.unitIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitIDDataGridViewTextBoxColumn.Name = "unitIDDataGridViewTextBoxColumn";
            // 
            // subjectIDDataGridViewTextBoxColumn
            // 
            this.subjectIDDataGridViewTextBoxColumn.DataPropertyName = "SubjectID";
            this.subjectIDDataGridViewTextBoxColumn.HeaderText = "SubjectID";
            this.subjectIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subjectIDDataGridViewTextBoxColumn.Name = "subjectIDDataGridViewTextBoxColumn";
            // 
            // correctAnswerDataGridViewTextBoxColumn
            // 
            this.correctAnswerDataGridViewTextBoxColumn.DataPropertyName = "CorrectAnswer";
            this.correctAnswerDataGridViewTextBoxColumn.HeaderText = "CorrectAnswer";
            this.correctAnswerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.correctAnswerDataGridViewTextBoxColumn.Name = "correctAnswerDataGridViewTextBoxColumn";
            // 
            // ımageDataGridViewImageColumn
            // 
            this.ımageDataGridViewImageColumn.DataPropertyName = "Image";
            this.ımageDataGridViewImageColumn.HeaderText = "Image";
            this.ımageDataGridViewImageColumn.MinimumWidth = 6;
            this.ımageDataGridViewImageColumn.Name = "ımageDataGridViewImageColumn";
            // 
            // option1DataGridViewTextBoxColumn
            // 
            this.option1DataGridViewTextBoxColumn.DataPropertyName = "Option1";
            this.option1DataGridViewTextBoxColumn.HeaderText = "Option1";
            this.option1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.option1DataGridViewTextBoxColumn.Name = "option1DataGridViewTextBoxColumn";
            // 
            // option2DataGridViewTextBoxColumn
            // 
            this.option2DataGridViewTextBoxColumn.DataPropertyName = "Option2";
            this.option2DataGridViewTextBoxColumn.HeaderText = "Option2";
            this.option2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.option2DataGridViewTextBoxColumn.Name = "option2DataGridViewTextBoxColumn";
            // 
            // option3DataGridViewTextBoxColumn
            // 
            this.option3DataGridViewTextBoxColumn.DataPropertyName = "Option3";
            this.option3DataGridViewTextBoxColumn.HeaderText = "Option3";
            this.option3DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.option3DataGridViewTextBoxColumn.Name = "option3DataGridViewTextBoxColumn";
            // 
            // option4DataGridViewTextBoxColumn
            // 
            this.option4DataGridViewTextBoxColumn.DataPropertyName = "Option4";
            this.option4DataGridViewTextBoxColumn.HeaderText = "Option4";
            this.option4DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.option4DataGridViewTextBoxColumn.Name = "option4DataGridViewTextBoxColumn";
            // 
            // lblSchoolObject
            // 
            this.lblSchoolObject.AutoSize = true;
            this.lblSchoolObject.BackColor = System.Drawing.Color.Transparent;
            this.lblSchoolObject.Font = new System.Drawing.Font("HYHeadLine-Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSchoolObject.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblSchoolObject.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSchoolObject.Location = new System.Drawing.Point(29, 102);
            this.lblSchoolObject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSchoolObject.Name = "lblSchoolObject";
            this.lblSchoolObject.Size = new System.Drawing.Size(122, 17);
            this.lblSchoolObject.TabIndex = 104;
            this.lblSchoolObject.Text = "School Object";
            // 
            // LblQuestion
            // 
            this.LblQuestion.AutoSize = true;
            this.LblQuestion.BackColor = System.Drawing.Color.Transparent;
            this.LblQuestion.Font = new System.Drawing.Font("HYHeadLine-Medium", 10.2F);
            this.LblQuestion.Location = new System.Drawing.Point(293, 415);
            this.LblQuestion.Name = "LblQuestion";
            this.LblQuestion.Size = new System.Drawing.Size(79, 17);
            this.LblQuestion.TabIndex = 105;
            this.LblQuestion.Text = "Question";
            this.LblQuestion.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("HYHeadLine-Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(29, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 106;
            this.label1.Text = "School Object";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("HYHeadLine-Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(29, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 107;
            this.label3.Text = "School Object";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("HYHeadLine-Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(29, 235);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 108;
            this.label4.Text = "School Object";
            // 
            // lblUnitId
            // 
            this.lblUnitId.AutoSize = true;
            this.lblUnitId.BackColor = System.Drawing.Color.Transparent;
            this.lblUnitId.Font = new System.Drawing.Font("HYHeadLine-Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblUnitId.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblUnitId.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblUnitId.Location = new System.Drawing.Point(155, 144);
            this.lblUnitId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnitId.Name = "lblUnitId";
            this.lblUnitId.Size = new System.Drawing.Size(0, 17);
            this.lblUnitId.TabIndex = 109;
            // 
            // FormQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1197, 734);
            this.Controls.Add(this.lblUnitId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblQuestion);
            this.Controls.Add(this.lblSchoolObject);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pctimage);
            this.Controls.Add(this.ButtonAfterQuest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RdbD);
            this.Controls.Add(this.RdbC);
            this.Controls.Add(this.RdbB);
            this.Controls.Add(this.RdbA);
            this.Controls.Add(this.BtnBackPage);
            this.Name = "FormQuestion";
            this.Text = "FormQuestion";
            this.Load += new System.EventHandler(this.FormQuestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quesitonAppDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblQuestionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnBackPage;
        private System.Windows.Forms.RadioButton RdbA;
        private System.Windows.Forms.RadioButton RdbB;
        private System.Windows.Forms.RadioButton RdbC;
        private System.Windows.Forms.RadioButton RdbD;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonAfterQuest;
        private System.Windows.Forms.PictureBox pctimage;
        private QuesitonAppDataSet2 quesitonAppDataSet2;
        private System.Windows.Forms.BindingSource tblQuestionBindingSource;
        private QuesitonAppDataSet2TableAdapters.Tbl_QuestionTableAdapter tbl_QuestionTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolObjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correctAnswerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn ımageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn option1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn option2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn option3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn option4DataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblSchoolObject;
        private System.Windows.Forms.Label LblQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblUnitId;
    }
}