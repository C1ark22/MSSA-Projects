namespace Assignment_10._3
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
            dataGridViewCars = new DataGridView();
            buttonSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCars).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCars
            // 
            dataGridViewCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCars.Location = new Point(29, 29);
            dataGridViewCars.Name = "dataGridViewCars";
            dataGridViewCars.Size = new Size(741, 365);
            dataGridViewCars.TabIndex = 0;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(678, 408);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(88, 33);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSave);
            Controls.Add(dataGridViewCars);
            Name = "MainForm";
            Text = "Cars";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCars).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewCars;
        private Button buttonSave;
    }
}
