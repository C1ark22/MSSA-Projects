namespace Assignment4._2
{
    partial class MainForm
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
            btnLogin = new Button();
            lblUserID = new Label();
            lblPassword = new Label();
            txtboxUserID = new TextBox();
            txtboxPassword = new TextBox();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.AutoSize = true;
            btnLogin.Font = new Font("Segoe UI", 16F);
            btnLogin.Location = new Point(238, 237);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(76, 40);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Font = new Font("Segoe UI", 16F);
            lblUserID.Location = new Point(115, 104);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(89, 30);
            lblUserID.TabIndex = 1;
            lblUserID.Text = "User ID:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 16F);
            lblPassword.Location = new Point(96, 158);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(108, 30);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password:";
            // 
            // txtboxUserID
            // 
            txtboxUserID.Location = new Point(210, 111);
            txtboxUserID.Name = "txtboxUserID";
            txtboxUserID.Size = new Size(153, 23);
            txtboxUserID.TabIndex = 3;
            // 
            // txtboxPassword
            // 
            txtboxPassword.Location = new Point(210, 165);
            txtboxPassword.Name = "txtboxPassword";
            txtboxPassword.Size = new Size(153, 23);
            txtboxPassword.TabIndex = 4;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F);
            lblTitle.Location = new Point(130, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(279, 30);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Mini Learning Management";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(546, 336);
            Controls.Add(lblTitle);
            Controls.Add(txtboxPassword);
            Controls.Add(txtboxUserID);
            Controls.Add(lblPassword);
            Controls.Add(lblUserID);
            Controls.Add(btnLogin);
            Name = "MainForm";
            Text = "Mini Learning Management";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label lblUserID;
        private Label lblPassword;
        private TextBox txtboxUserID;
        private TextBox txtboxPassword;
        private Label lblTitle;
    }
}
