namespace StudentGradeManagement.UI
{
    partial class TeacherForm
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
            dataGridView1 = new DataGridView();
            btnList = new Button();
            lblStudentId = new Label();
            lblStudentName = new Label();
            txtStudentId = new TextBox();
            txtStudentName = new TextBox();
            btnAddStudent = new Button();
            btnUpdate = new Button();
            txtPassword = new TextBox();
            label1 = new Label();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(383, 146);
            dataGridView1.TabIndex = 0;
            // 
            // btnList
            // 
            btnList.Location = new Point(320, 164);
            btnList.Name = "btnList";
            btnList.Size = new Size(75, 23);
            btnList.TabIndex = 1;
            btnList.Text = "ListStudent";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.Location = new Point(420, 45);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(61, 15);
            lblStudentId.TabIndex = 2;
            lblStudentId.Text = "StudentId:";
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Location = new Point(401, 76);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(83, 15);
            lblStudentName.TabIndex = 3;
            lblStudentName.Text = "StudentName:";
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(504, 37);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(154, 23);
            txtStudentId.TabIndex = 4;
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(504, 73);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(154, 23);
            txtStudentName.TabIndex = 5;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(549, 132);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(109, 26);
            btnAddStudent.TabIndex = 6;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(549, 164);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(109, 26);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(504, 102);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(154, 23);
            txtPassword.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(401, 105);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 8;
            label1.Text = "StudentPassword:";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(549, 196);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(109, 26);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // TeacherForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 246);
            Controls.Add(btnDelete);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            Controls.Add(btnUpdate);
            Controls.Add(btnAddStudent);
            Controls.Add(txtStudentName);
            Controls.Add(txtStudentId);
            Controls.Add(lblStudentName);
            Controls.Add(lblStudentId);
            Controls.Add(btnList);
            Controls.Add(dataGridView1);
            Name = "TeacherForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TeacherForm";
            Load += TeacherForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnList;
        private Label lblStudentId;
        private Label lblStudentName;
        private TextBox txtStudentId;
        private TextBox txtStudentName;
        private Button btnAddStudent;
        private Button btnUpdate;
        private TextBox txtPassword;
        private Label label1;
        private Button btnDelete;
    }
}