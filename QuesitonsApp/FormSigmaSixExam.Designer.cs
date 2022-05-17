namespace QuesitonsApp
{
    partial class FormSigmaSixExam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSigmaSixExam));
            this.lblRandQu = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pctimage = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTime = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSubjecIId = new System.Windows.Forms.Label();
            this.lblSchoolObject = new System.Windows.Forms.Label();
            this.lblSec = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblSubjectID = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblUnitId = new System.Windows.Forms.Label();
            this.lblCorrectAnswer = new System.Windows.Forms.Label();
            this.LblQuestion = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LblCorrect = new System.Windows.Forms.Label();
            this.BtnNextQuest = new System.Windows.Forms.Button();
            this.RdbD = new System.Windows.Forms.RadioButton();
            this.RdbC = new System.Windows.Forms.RadioButton();
            this.RdbB = new System.Windows.Forms.RadioButton();
            this.RdbA = new System.Windows.Forms.RadioButton();
            this.BtnBackPage = new System.Windows.Forms.Button();
            this.quesitonAppDataSet3 = new QuesitonsApp.QuesitonAppDataSet3();
            this.tblQuestionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_QuestionTableAdapter = new QuesitonsApp.QuesitonAppDataSet3TableAdapters.Tbl_QuestionTableAdapter();
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
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctimage)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quesitonAppDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblQuestionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRandQu
            // 
            this.lblRandQu.AutoSize = true;
            this.lblRandQu.BackColor = System.Drawing.Color.Transparent;
            this.lblRandQu.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRandQu.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblRandQu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRandQu.Location = new System.Drawing.Point(859, 768);
            this.lblRandQu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRandQu.Name = "lblRandQu";
            this.lblRandQu.Size = new System.Drawing.Size(0, 28);
            this.lblRandQu.TabIndex = 154;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.pctimage);
            this.panel2.Location = new System.Drawing.Point(22, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(861, 747);
            this.panel2.TabIndex = 153;
            // 
            // pctimage
            // 
            this.pctimage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctimage.Image = ((System.Drawing.Image)(resources.GetObject("pctimage.Image")));
            this.pctimage.Location = new System.Drawing.Point(26, 25);
            this.pctimage.Name = "pctimage";
            this.pctimage.Size = new System.Drawing.Size(811, 705);
            this.pctimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctimage.TabIndex = 120;
            this.pctimage.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnTime);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblSubjecIId);
            this.panel1.Controls.Add(this.lblSchoolObject);
            this.panel1.Controls.Add(this.lblSec);
            this.panel1.Controls.Add(this.LblCorrect);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblMin);
            this.panel1.Controls.Add(this.lblSubjectID);
            this.panel1.Controls.Add(this.lblSubject);
            this.panel1.Controls.Add(this.lblUnitId);
            this.panel1.Controls.Add(this.lblCorrectAnswer);
            this.panel1.Location = new System.Drawing.Point(889, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 155);
            this.panel1.TabIndex = 152;
            // 
            // btnTime
            // 
            this.btnTime.BackColor = System.Drawing.Color.Transparent;
            this.btnTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTime.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTime.FlatAppearance.BorderSize = 0;
            this.btnTime.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnTime.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTime.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnTime.Location = new System.Drawing.Point(-2, 102);
            this.btnTime.Margin = new System.Windows.Forms.Padding(2);
            this.btnTime.Name = "btnTime";
            this.btnTime.Size = new System.Drawing.Size(102, 49);
            this.btnTime.TabIndex = 143;
            this.btnTime.Text = "Time";
            this.btnTime.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(203, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 38);
            this.label2.TabIndex = 145;
            this.label2.Text = ":";
            // 
            // lblSubjecIId
            // 
            this.lblSubjecIId.AutoSize = true;
            this.lblSubjecIId.BackColor = System.Drawing.Color.Transparent;
            this.lblSubjecIId.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjecIId.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblSubjecIId.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSubjecIId.Location = new System.Drawing.Point(256, 54);
            this.lblSubjecIId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubjecIId.Name = "lblSubjecIId";
            this.lblSubjecIId.Size = new System.Drawing.Size(0, 28);
            this.lblSubjecIId.TabIndex = 130;
            // 
            // lblSchoolObject
            // 
            this.lblSchoolObject.AutoSize = true;
            this.lblSchoolObject.BackColor = System.Drawing.Color.Transparent;
            this.lblSchoolObject.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchoolObject.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblSchoolObject.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSchoolObject.Location = new System.Drawing.Point(21, 8);
            this.lblSchoolObject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSchoolObject.Name = "lblSchoolObject";
            this.lblSchoolObject.Size = new System.Drawing.Size(139, 28);
            this.lblSchoolObject.TabIndex = 122;
            this.lblSchoolObject.Text = "School Object";
            // 
            // lblSec
            // 
            this.lblSec.AutoSize = true;
            this.lblSec.BackColor = System.Drawing.Color.Transparent;
            this.lblSec.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSec.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblSec.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSec.Location = new System.Drawing.Point(236, 105);
            this.lblSec.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(60, 38);
            this.lblSec.TabIndex = 144;
            this.lblSec.Text = "Sec";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(21, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 28);
            this.label1.TabIndex = 124;
            this.label1.Text = "Unit :";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.BackColor = System.Drawing.Color.Transparent;
            this.lblMin.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblMin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMin.Location = new System.Drawing.Point(136, 105);
            this.lblMin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(67, 38);
            this.lblMin.TabIndex = 143;
            this.lblMin.Text = "Min";
            // 
            // lblSubjectID
            // 
            this.lblSubjectID.AutoSize = true;
            this.lblSubjectID.BackColor = System.Drawing.Color.Transparent;
            this.lblSubjectID.Font = new System.Drawing.Font("HYHeadLine-Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSubjectID.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblSubjectID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSubjectID.Location = new System.Drawing.Point(424, 28);
            this.lblSubjectID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubjectID.Name = "lblSubjectID";
            this.lblSubjectID.Size = new System.Drawing.Size(0, 17);
            this.lblSubjectID.TabIndex = 128;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.BackColor = System.Drawing.Color.Transparent;
            this.lblSubject.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblSubject.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSubject.Location = new System.Drawing.Point(162, 54);
            this.lblSubject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(90, 28);
            this.lblSubject.TabIndex = 125;
            this.lblSubject.Text = "Subject :";
            // 
            // lblUnitId
            // 
            this.lblUnitId.AutoSize = true;
            this.lblUnitId.BackColor = System.Drawing.Color.Transparent;
            this.lblUnitId.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitId.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblUnitId.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblUnitId.Location = new System.Drawing.Point(88, 54);
            this.lblUnitId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnitId.Name = "lblUnitId";
            this.lblUnitId.Size = new System.Drawing.Size(0, 28);
            this.lblUnitId.TabIndex = 127;
            // 
            // lblCorrectAnswer
            // 
            this.lblCorrectAnswer.AutoSize = true;
            this.lblCorrectAnswer.BackColor = System.Drawing.Color.Transparent;
            this.lblCorrectAnswer.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrectAnswer.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblCorrectAnswer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCorrectAnswer.Location = new System.Drawing.Point(213, 73);
            this.lblCorrectAnswer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCorrectAnswer.Name = "lblCorrectAnswer";
            this.lblCorrectAnswer.Size = new System.Drawing.Size(0, 28);
            this.lblCorrectAnswer.TabIndex = 126;
            // 
            // LblQuestion
            // 
            this.LblQuestion.BackColor = System.Drawing.Color.Transparent;
            this.LblQuestion.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQuestion.Location = new System.Drawing.Point(889, 221);
            this.LblQuestion.Name = "LblQuestion";
            this.LblQuestion.Size = new System.Drawing.Size(326, 278);
            this.LblQuestion.TabIndex = 151;
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
            this.dataGridView1.Location = new System.Drawing.Point(99, 743);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(742, 53);
            this.dataGridView1.TabIndex = 150;
            this.dataGridView1.Visible = false;
            // 
            // LblCorrect
            // 
            this.LblCorrect.AutoSize = true;
            this.LblCorrect.BackColor = System.Drawing.Color.Transparent;
            this.LblCorrect.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCorrect.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LblCorrect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblCorrect.Location = new System.Drawing.Point(256, 8);
            this.LblCorrect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCorrect.Name = "LblCorrect";
            this.LblCorrect.Size = new System.Drawing.Size(0, 28);
            this.LblCorrect.TabIndex = 144;
            this.LblCorrect.Visible = false;
            // 
            // BtnNextQuest
            // 
            this.BtnNextQuest.BackColor = System.Drawing.Color.Transparent;
            this.BtnNextQuest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnNextQuest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNextQuest.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnNextQuest.FlatAppearance.BorderSize = 2;
            this.BtnNextQuest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnNextQuest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnNextQuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNextQuest.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNextQuest.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnNextQuest.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnNextQuest.Location = new System.Drawing.Point(947, 681);
            this.BtnNextQuest.Margin = new System.Windows.Forms.Padding(2);
            this.BtnNextQuest.Name = "BtnNextQuest";
            this.BtnNextQuest.Size = new System.Drawing.Size(239, 56);
            this.BtnNextQuest.TabIndex = 149;
            this.BtnNextQuest.Text = "Next Question";
            this.BtnNextQuest.UseVisualStyleBackColor = false;
            // 
            // RdbD
            // 
            this.RdbD.AutoSize = true;
            this.RdbD.BackColor = System.Drawing.Color.Transparent;
            this.RdbD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RdbD.FlatAppearance.BorderSize = 0;
            this.RdbD.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.RdbD.Location = new System.Drawing.Point(1138, 602);
            this.RdbD.Name = "RdbD";
            this.RdbD.Size = new System.Drawing.Size(48, 32);
            this.RdbD.TabIndex = 148;
            this.RdbD.Text = "D";
            this.RdbD.UseVisualStyleBackColor = false;
            // 
            // RdbC
            // 
            this.RdbC.AutoSize = true;
            this.RdbC.BackColor = System.Drawing.Color.Transparent;
            this.RdbC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RdbC.FlatAppearance.BorderSize = 0;
            this.RdbC.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.RdbC.Location = new System.Drawing.Point(947, 602);
            this.RdbC.Name = "RdbC";
            this.RdbC.Size = new System.Drawing.Size(46, 32);
            this.RdbC.TabIndex = 147;
            this.RdbC.Text = "C";
            this.RdbC.UseVisualStyleBackColor = false;
            // 
            // RdbB
            // 
            this.RdbB.AutoSize = true;
            this.RdbB.BackColor = System.Drawing.Color.Transparent;
            this.RdbB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RdbB.FlatAppearance.BorderSize = 0;
            this.RdbB.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.RdbB.Location = new System.Drawing.Point(1140, 537);
            this.RdbB.Name = "RdbB";
            this.RdbB.Size = new System.Drawing.Size(46, 32);
            this.RdbB.TabIndex = 146;
            this.RdbB.Text = "B";
            this.RdbB.UseVisualStyleBackColor = false;
            // 
            // RdbA
            // 
            this.RdbA.AutoSize = true;
            this.RdbA.BackColor = System.Drawing.Color.Transparent;
            this.RdbA.Checked = true;
            this.RdbA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RdbA.FlatAppearance.BorderSize = 0;
            this.RdbA.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.RdbA.Location = new System.Drawing.Point(947, 537);
            this.RdbA.Name = "RdbA";
            this.RdbA.Size = new System.Drawing.Size(47, 32);
            this.RdbA.TabIndex = 145;
            this.RdbA.TabStop = true;
            this.RdbA.Text = "A";
            this.RdbA.UseVisualStyleBackColor = false;
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
            this.BtnBackPage.Location = new System.Drawing.Point(49, 759);
            this.BtnBackPage.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBackPage.Name = "BtnBackPage";
            this.BtnBackPage.Size = new System.Drawing.Size(46, 37);
            this.BtnBackPage.TabIndex = 143;
            this.BtnBackPage.UseVisualStyleBackColor = false;
            // 
            // quesitonAppDataSet3
            // 
            this.quesitonAppDataSet3.DataSetName = "QuesitonAppDataSet3";
            this.quesitonAppDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblQuestionBindingSource
            // 
            this.tblQuestionBindingSource.DataMember = "Tbl_Question";
            this.tblQuestionBindingSource.DataSource = this.quesitonAppDataSet3;
            // 
            // tbl_QuestionTableAdapter
            // 
            this.tbl_QuestionTableAdapter.ClearBeforeFill = true;
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
            // FormSigma6Exam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 803);
            this.Controls.Add(this.lblRandQu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblQuestion);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnNextQuest);
            this.Controls.Add(this.RdbD);
            this.Controls.Add(this.RdbC);
            this.Controls.Add(this.RdbB);
            this.Controls.Add(this.RdbA);
            this.Controls.Add(this.BtnBackPage);
            this.Name = "FormSigma6Exam";
            this.Text = "FormSigma6Exam";
            this.Load += new System.EventHandler(this.FormSigma6Exam_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctimage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quesitonAppDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblQuestionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRandQu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pctimage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSubjecIId;
        private System.Windows.Forms.Label lblSchoolObject;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.Label LblCorrect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblSubjectID;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblUnitId;
        private System.Windows.Forms.Label lblCorrectAnswer;
        private System.Windows.Forms.Label LblQuestion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnNextQuest;
        private System.Windows.Forms.RadioButton RdbD;
        private System.Windows.Forms.RadioButton RdbC;
        private System.Windows.Forms.RadioButton RdbB;
        private System.Windows.Forms.RadioButton RdbA;
        private System.Windows.Forms.Button BtnBackPage;
        private QuesitonAppDataSet3 quesitonAppDataSet3;
        private System.Windows.Forms.BindingSource tblQuestionBindingSource;
        private QuesitonAppDataSet3TableAdapters.Tbl_QuestionTableAdapter tbl_QuestionTableAdapter;
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
    }
}