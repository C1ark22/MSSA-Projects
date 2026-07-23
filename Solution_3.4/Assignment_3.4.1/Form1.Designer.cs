namespace Assignment_3._4._1
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.lblCoffee = new System.Windows.Forms.Label();
            this.txtCoffeeName = new System.Windows.Forms.TextBox();
            this.lblCoffeeName = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.lblRoast = new System.Windows.Forms.Label();
            this.txtRoast = new System.Windows.Forms.TextBox();
            this.lblDecaf = new System.Windows.Forms.Label();
            this.rdoDecafTrue = new System.Windows.Forms.RadioButton();
            this.rdoDecafFalse = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(77, 331);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(631, 88);
            this.dataGridView1.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(254, 267);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(127, 48);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add Coffee";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(439, 267);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(127, 48);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete Coffee";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // lblCoffee
            // 
            this.lblCoffee.AutoSize = true;
            this.lblCoffee.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoffee.Location = new System.Drawing.Point(12, 9);
            this.lblCoffee.Name = "lblCoffee";
            this.lblCoffee.Size = new System.Drawing.Size(159, 31);
            this.lblCoffee.TabIndex = 3;
            this.lblCoffee.Text = "Coffee Lists";
            this.lblCoffee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCoffeeName
            // 
            this.txtCoffeeName.Location = new System.Drawing.Point(166, 91);
            this.txtCoffeeName.Name = "txtCoffeeName";
            this.txtCoffeeName.Size = new System.Drawing.Size(150, 20);
            this.txtCoffeeName.TabIndex = 4;
            // 
            // lblCoffeeName
            // 
            this.lblCoffeeName.AutoSize = true;
            this.lblCoffeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoffeeName.Location = new System.Drawing.Point(13, 85);
            this.lblCoffeeName.Name = "lblCoffeeName";
            this.lblCoffeeName.Size = new System.Drawing.Size(147, 26);
            this.lblCoffeeName.TabIndex = 5;
            this.lblCoffeeName.Text = "Coffee Name:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(99, 126);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(61, 26);
            this.lblSize.TabIndex = 6;
            this.lblSize.Text = "Size:";
            this.lblSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(166, 132);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(150, 20);
            this.txtSize.TabIndex = 7;
            // 
            // lblRoast
            // 
            this.lblRoast.AutoSize = true;
            this.lblRoast.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoast.Location = new System.Drawing.Point(85, 167);
            this.lblRoast.Name = "lblRoast";
            this.lblRoast.Size = new System.Drawing.Size(75, 26);
            this.lblRoast.TabIndex = 8;
            this.lblRoast.Text = "Roast:";
            this.lblRoast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRoast
            // 
            this.txtRoast.Location = new System.Drawing.Point(166, 173);
            this.txtRoast.Name = "txtRoast";
            this.txtRoast.Size = new System.Drawing.Size(150, 20);
            this.txtRoast.TabIndex = 9;
            // 
            // lblDecaf
            // 
            this.lblDecaf.AutoSize = true;
            this.lblDecaf.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecaf.Location = new System.Drawing.Point(85, 213);
            this.lblDecaf.Name = "lblDecaf";
            this.lblDecaf.Size = new System.Drawing.Size(75, 26);
            this.lblDecaf.TabIndex = 10;
            this.lblDecaf.Text = "Decaf:";
            this.lblDecaf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdoDecafTrue
            // 
            this.rdoDecafTrue.AutoSize = true;
            this.rdoDecafTrue.Location = new System.Drawing.Point(180, 221);
            this.rdoDecafTrue.Name = "rdoDecafTrue";
            this.rdoDecafTrue.Size = new System.Drawing.Size(43, 17);
            this.rdoDecafTrue.TabIndex = 11;
            this.rdoDecafTrue.TabStop = true;
            this.rdoDecafTrue.Text = "Yes";
            this.rdoDecafTrue.UseVisualStyleBackColor = true;
            // 
            // rdoDecafFalse
            // 
            this.rdoDecafFalse.AutoSize = true;
            this.rdoDecafFalse.Location = new System.Drawing.Point(254, 221);
            this.rdoDecafFalse.Name = "rdoDecafFalse";
            this.rdoDecafFalse.Size = new System.Drawing.Size(39, 17);
            this.rdoDecafFalse.TabIndex = 12;
            this.rdoDecafFalse.TabStop = true;
            this.rdoDecafFalse.Text = "No";
            this.rdoDecafFalse.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(800, 609);
            this.Controls.Add(this.rdoDecafFalse);
            this.Controls.Add(this.rdoDecafTrue);
            this.Controls.Add(this.lblDecaf);
            this.Controls.Add(this.txtRoast);
            this.Controls.Add(this.lblRoast);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblCoffeeName);
            this.Controls.Add(this.txtCoffeeName);
            this.Controls.Add(this.lblCoffee);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Beverage/Coffee Project";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label lblCoffee;
        private System.Windows.Forms.TextBox txtCoffeeName;
        private System.Windows.Forms.Label lblCoffeeName;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label lblRoast;
        private System.Windows.Forms.TextBox txtRoast;
        private System.Windows.Forms.Label lblDecaf;
        private System.Windows.Forms.RadioButton rdoDecafTrue;
        private System.Windows.Forms.RadioButton rdoDecafFalse;
    }
}

