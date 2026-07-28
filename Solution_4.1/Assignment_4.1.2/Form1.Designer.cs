namespace Assignment_4._1._2
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
            btnPlus = new Button();
            btnMinus = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            lblFirstNumber = new Label();
            lblSecondNumber = new Label();
            lblResult = new Label();
            txtboxFirstNumber = new TextBox();
            txtboxSecondNumber = new TextBox();
            txtboxResult = new TextBox();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnPlus
            // 
            btnPlus.AutoSize = true;
            btnPlus.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnPlus.Location = new Point(519, 118);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(39, 40);
            btnPlus.TabIndex = 0;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnMinus
            // 
            btnMinus.AutoSize = true;
            btnMinus.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnMinus.Location = new Point(581, 118);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(39, 40);
            btnMinus.TabIndex = 1;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.AutoSize = true;
            btnMultiply.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnMultiply.Location = new Point(519, 178);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(39, 40);
            btnMultiply.TabIndex = 2;
            btnMultiply.Text = "x";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnDivide
            // 
            btnDivide.AutoSize = true;
            btnDivide.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnDivide.Location = new Point(581, 178);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(39, 40);
            btnDivide.TabIndex = 3;
            btnDivide.Text = "÷";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // lblFirstNumber
            // 
            lblFirstNumber.AutoSize = true;
            lblFirstNumber.Font = new Font("Segoe UI", 16F);
            lblFirstNumber.Location = new Point(132, 128);
            lblFirstNumber.Name = "lblFirstNumber";
            lblFirstNumber.Size = new Size(144, 30);
            lblFirstNumber.TabIndex = 4;
            lblFirstNumber.Text = "First Number:";
            // 
            // lblSecondNumber
            // 
            lblSecondNumber.AutoSize = true;
            lblSecondNumber.Font = new Font("Segoe UI", 16F);
            lblSecondNumber.Location = new Point(100, 183);
            lblSecondNumber.Name = "lblSecondNumber";
            lblSecondNumber.Size = new Size(176, 30);
            lblSecondNumber.TabIndex = 5;
            lblSecondNumber.Text = "Second Number:";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 16F);
            lblResult.Location = new Point(201, 252);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(75, 30);
            lblResult.TabIndex = 6;
            lblResult.Text = "Result:";
            // 
            // txtboxFirstNumber
            // 
            txtboxFirstNumber.Location = new Point(305, 135);
            txtboxFirstNumber.Name = "txtboxFirstNumber";
            txtboxFirstNumber.Size = new Size(146, 23);
            txtboxFirstNumber.TabIndex = 7;
            // 
            // txtboxSecondNumber
            // 
            txtboxSecondNumber.Location = new Point(305, 190);
            txtboxSecondNumber.Name = "txtboxSecondNumber";
            txtboxSecondNumber.Size = new Size(146, 23);
            txtboxSecondNumber.TabIndex = 8;
            // 
            // txtboxResult
            // 
            txtboxResult.Location = new Point(305, 259);
            txtboxResult.Name = "txtboxResult";
            txtboxResult.Size = new Size(146, 23);
            txtboxResult.TabIndex = 9;
            // 
            // btnClear
            // 
            btnClear.AutoSize = true;
            btnClear.Font = new Font("Segoe UI", 16F);
            btnClear.Location = new Point(244, 352);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(73, 40);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.AutoSize = true;
            btnExit.Font = new Font("Segoe UI", 16F);
            btnExit.Location = new Point(429, 352);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(73, 40);
            btnExit.TabIndex = 11;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(txtboxResult);
            Controls.Add(txtboxSecondNumber);
            Controls.Add(txtboxFirstNumber);
            Controls.Add(lblResult);
            Controls.Add(lblSecondNumber);
            Controls.Add(lblFirstNumber);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiply);
            Controls.Add(btnMinus);
            Controls.Add(btnPlus);
            Name = "Form1";
            Text = "Sample Calculator App";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPlus;
        private Button btnMinus;
        private Button btnMultiply;
        private Button btnDivide;
        private Label lblFirstNumber;
        private Label lblSecondNumber;
        private Label lblResult;
        private TextBox txtboxFirstNumber;
        private TextBox txtboxSecondNumber;
        private TextBox txtboxResult;
        private Button btnClear;
        private Button btnExit;
    }
}
