namespace Assignment4._2
{
    partial class Form2
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
            lblStudentID = new Label();
            lblStudentName = new Label();
            lblTitle = new Label();
            lblGPA = new Label();
            txtboxStudentID = new TextBox();
            txtboxStudentName = new TextBox();
            txtboxGPA = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnLogout = new Button();
            dataGridViewStudents = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).BeginInit();
            SuspendLayout();
            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.Font = new Font("Segoe UI", 14F);
            lblStudentID.Location = new Point(12, 81);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(103, 25);
            lblStudentID.TabIndex = 0;
            lblStudentID.Text = "Student ID:";
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Font = new Font("Segoe UI", 14F);
            lblStudentName.Location = new Point(12, 120);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(135, 25);
            lblStudentName.TabIndex = 1;
            lblStudentName.Text = "Student Name:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F);
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(279, 30);
            lblTitle.TabIndex = 6;
            lblTitle.Text = "Mini Learning Management";
            // 
            // lblGPA
            // 
            lblGPA.AutoSize = true;
            lblGPA.Font = new Font("Segoe UI", 14F);
            lblGPA.Location = new Point(12, 157);
            lblGPA.Name = "lblGPA";
            lblGPA.Size = new Size(51, 25);
            lblGPA.TabIndex = 7;
            lblGPA.Text = "GPA:";
            // 
            // txtboxStudentID
            // 
            txtboxStudentID.Font = new Font("Segoe UI", 14F);
            txtboxStudentID.Location = new Point(121, 78);
            txtboxStudentID.Name = "txtboxStudentID";
            txtboxStudentID.Size = new Size(142, 32);
            txtboxStudentID.TabIndex = 8;
            // 
            // txtboxStudentName
            // 
            txtboxStudentName.Font = new Font("Segoe UI", 14F);
            txtboxStudentName.Location = new Point(153, 113);
            txtboxStudentName.Name = "txtboxStudentName";
            txtboxStudentName.Size = new Size(199, 32);
            txtboxStudentName.TabIndex = 9;
            // 
            // txtboxGPA
            // 
            txtboxGPA.Font = new Font("Segoe UI", 14F);
            txtboxGPA.Location = new Point(69, 150);
            txtboxGPA.Name = "txtboxGPA";
            txtboxGPA.Size = new Size(88, 32);
            txtboxGPA.TabIndex = 10;
            // 
            // btnAdd
            // 
            btnAdd.AutoSize = true;
            btnAdd.Font = new Font("Segoe UI", 14F);
            btnAdd.Location = new Point(343, 177);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 35);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = true;
            btnDelete.Font = new Font("Segoe UI", 14F);
            btnDelete.Location = new Point(424, 177);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(76, 35);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLogout
            // 
            btnLogout.AutoSize = true;
            btnLogout.Font = new Font("Segoe UI", 14F);
            btnLogout.Location = new Point(419, 437);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(81, 35);
            btnLogout.TabIndex = 13;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // dataGridViewStudents
            // 
            dataGridViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudents.Location = new Point(12, 218);
            dataGridViewStudents.Name = "dataGridViewStudents";
            dataGridViewStudents.Size = new Size(488, 213);
            dataGridViewStudents.TabIndex = 14;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(538, 487);
            Controls.Add(dataGridViewStudents);
            Controls.Add(btnLogout);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtboxGPA);
            Controls.Add(txtboxStudentName);
            Controls.Add(txtboxStudentID);
            Controls.Add(lblGPA);
            Controls.Add(lblTitle);
            Controls.Add(lblStudentName);
            Controls.Add(lblStudentID);
            Name = "Form2";
            Text = "Student Management";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudentID;
        private Label lblStudentName;
        private Label lblTitle;
        private Label lblGPA;
        private TextBox txtboxStudentID;
        private TextBox txtboxStudentName;
        private TextBox txtboxGPA;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnLogout;
        private DataGridView dataGridViewStudents;
    }
}