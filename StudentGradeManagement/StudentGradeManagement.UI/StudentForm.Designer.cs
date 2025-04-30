namespace StudentGradeManagement.UI
{
    partial class StudentForm
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
            cmbLesson = new ComboBox();
            btnBack = new Button();
            dgvExamScore = new DataGridView();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvExamScore).BeginInit();
            SuspendLayout();
            // 
            // cmbLesson
            // 
            cmbLesson.FormattingEnabled = true;
            cmbLesson.Location = new Point(21, 37);
            cmbLesson.Name = "cmbLesson";
            cmbLesson.Size = new Size(141, 23);
            cmbLesson.TabIndex = 0;
            cmbLesson.SelectedIndexChanged += cmbLesson_SelectedIndexChanged;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(210, 233);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(107, 26);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnExamInfo_Click;
            // 
            // dgvExamScore
            // 
            dgvExamScore.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExamScore.Location = new Point(21, 66);
            dgvExamScore.Name = "dgvExamScore";
            dgvExamScore.Size = new Size(418, 146);
            dgvExamScore.TabIndex = 2;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(332, 233);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(107, 26);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 271);
            Controls.Add(btnExit);
            Controls.Add(dgvExamScore);
            Controls.Add(btnBack);
            Controls.Add(cmbLesson);
            Name = "StudentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentForm";
            Load += StudentForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvExamScore).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbLesson;
        private Button btnBack;
        private DataGridView dgvExamScore;
        private Button btnExit;
    }
}