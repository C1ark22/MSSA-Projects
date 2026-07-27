namespace Assignment_4._1._1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAddStudent = new Button();
            btnDelete = new Button();
            lblFirstName = new Label();
            lblLastName = new Label();
            label1 = new Label();
            lblMobileNumber = new Label();
            lblWorkNumber = new Label();
            lblAddress = new Label();
            txtboxFirstName = new TextBox();
            txtboxLastName = new TextBox();
            txtboxMobileNumber = new TextBox();
            txtboxWorkNumber = new TextBox();
            txtboxAddress = new TextBox();
            dataGridView1 = new DataGridView();
            txtboxSearch = new TextBox();
            btnSearch = new Button();
            btnShowAll = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnAddStudent
            // 
            btnAddStudent.AutoSize = true;
            btnAddStudent.BackColor = SystemColors.ControlLight;
            btnAddStudent.Font = new Font("Segoe UI", 12F);
            btnAddStudent.Location = new Point(679, 79);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(94, 31);
            btnAddStudent.TabIndex = 0;
            btnAddStudent.Text = "Add";
            btnAddStudent.UseVisualStyleBackColor = false;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = true;
            btnDelete.BackColor = SystemColors.ControlLight;
            btnDelete.Font = new Font("Segoe UI", 12F);
            btnDelete.Location = new Point(679, 149);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 31);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 12F);
            lblFirstName.Location = new Point(22, 59);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(89, 21);
            lblFirstName.TabIndex = 2;
            lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 12F);
            lblLastName.Location = new Point(20, 93);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(87, 21);
            lblLastName.TabIndex = 3;
            lblLastName.Text = "Last Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(22, 18);
            label1.Name = "label1";
            label1.Size = new Size(193, 28);
            label1.TabIndex = 4;
            label1.Text = "Personal Information";
            // 
            // lblMobileNumber
            // 
            lblMobileNumber.AutoSize = true;
            lblMobileNumber.Font = new Font("Segoe UI", 12F);
            lblMobileNumber.Location = new Point(20, 126);
            lblMobileNumber.Name = "lblMobileNumber";
            lblMobileNumber.Size = new Size(123, 21);
            lblMobileNumber.TabIndex = 5;
            lblMobileNumber.Text = "Mobile Number:";
            // 
            // lblWorkNumber
            // 
            lblWorkNumber.AutoSize = true;
            lblWorkNumber.Font = new Font("Segoe UI", 12F);
            lblWorkNumber.Location = new Point(20, 159);
            lblWorkNumber.Name = "lblWorkNumber";
            lblWorkNumber.Size = new Size(112, 21);
            lblWorkNumber.TabIndex = 6;
            lblWorkNumber.Text = "Work Number:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 12F);
            lblAddress.Location = new Point(22, 192);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(69, 21);
            lblAddress.TabIndex = 7;
            lblAddress.Text = "Address:";
            // 
            // txtboxFirstName
            // 
            txtboxFirstName.Location = new Point(149, 59);
            txtboxFirstName.Name = "txtboxFirstName";
            txtboxFirstName.Size = new Size(117, 23);
            txtboxFirstName.TabIndex = 8;
            // 
            // txtboxLastName
            // 
            txtboxLastName.Location = new Point(149, 93);
            txtboxLastName.Name = "txtboxLastName";
            txtboxLastName.Size = new Size(117, 23);
            txtboxLastName.TabIndex = 9;
            // 
            // txtboxMobileNumber
            // 
            txtboxMobileNumber.Location = new Point(149, 126);
            txtboxMobileNumber.Name = "txtboxMobileNumber";
            txtboxMobileNumber.Size = new Size(117, 23);
            txtboxMobileNumber.TabIndex = 10;
            // 
            // txtboxWorkNumber
            // 
            txtboxWorkNumber.Location = new Point(149, 159);
            txtboxWorkNumber.Name = "txtboxWorkNumber";
            txtboxWorkNumber.Size = new Size(117, 23);
            txtboxWorkNumber.TabIndex = 11;
            // 
            // txtboxAddress
            // 
            txtboxAddress.Location = new Point(149, 192);
            txtboxAddress.Name = "txtboxAddress";
            txtboxAddress.Size = new Size(422, 23);
            txtboxAddress.TabIndex = 12;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 288);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 150);
            dataGridView1.TabIndex = 13;
            // 
            // txtboxSearch
            // 
            txtboxSearch.Location = new Point(318, 258);
            txtboxSearch.Name = "txtboxSearch";
            txtboxSearch.Size = new Size(156, 23);
            txtboxSearch.TabIndex = 15;
            // 
            // btnSearch
            // 
            btnSearch.AutoSize = true;
            btnSearch.BackColor = SystemColors.ControlLight;
            btnSearch.Font = new Font("Segoe UI", 12F);
            btnSearch.Location = new Point(480, 252);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(132, 31);
            btnSearch.TabIndex = 16;
            btnSearch.Text = "Search A Person";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnShowAll
            // 
            btnShowAll.AutoSize = true;
            btnShowAll.BackColor = SystemColors.ControlLight;
            btnShowAll.Font = new Font("Segoe UI", 12F);
            btnShowAll.Location = new Point(12, 252);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(81, 31);
            btnShowAll.TabIndex = 17;
            btnShowAll.Text = "Show All";
            btnShowAll.UseVisualStyleBackColor = false;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnShowAll);
            Controls.Add(btnSearch);
            Controls.Add(txtboxSearch);
            Controls.Add(dataGridView1);
            Controls.Add(txtboxAddress);
            Controls.Add(txtboxWorkNumber);
            Controls.Add(txtboxMobileNumber);
            Controls.Add(txtboxLastName);
            Controls.Add(txtboxFirstName);
            Controls.Add(lblAddress);
            Controls.Add(lblWorkNumber);
            Controls.Add(lblMobileNumber);
            Controls.Add(label1);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(btnDelete);
            Controls.Add(btnAddStudent);
            Name = "Form1";
            Text = "Assignment 4.1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddStudent;
        private Button btnDelete;
        private Label lblFirstName;
        private Label lblLastName;
        private Label label1;
        private Label lblMobileNumber;
        private Label lblWorkNumber;
        private Label lblAddress;
        private TextBox txtboxFirstName;
        private TextBox txtboxLastName;
        private TextBox txtboxMobileNumber;
        private TextBox txtboxWorkNumber;
        private TextBox txtboxAddress;
        private DataGridView dataGridView1;
        private TextBox txtboxSearch;
        private Button btnSearch;
        private Button btnShowAll;
    }
}
