namespace Assignment_11._3
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
            components = new System.ComponentModel.Container();
            lblGenre = new Label();
            genreComboBox = new ComboBox();
            moviesDataGridView = new DataGridView();
            btnShowAllMovies = new Button();
            moviesGenreBindingSource = new BindingSource(components);
            moviesBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)moviesDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)moviesGenreBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)moviesBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Location = new Point(15, 15);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(44, 15);
            lblGenre.TabIndex = 0;
            lblGenre.Text = "Genre: ";
            // 
            // genreComboBox
            // 
            genreComboBox.FormattingEnabled = true;
            genreComboBox.Items.AddRange(new object[] { "Drama", "Action", "Crime/Thriller", "Comedy" });
            genreComboBox.Location = new Point(65, 12);
            genreComboBox.Name = "genreComboBox";
            genreComboBox.Size = new Size(153, 23);
            genreComboBox.TabIndex = 1;
            genreComboBox.SelectedIndexChanged += genreComboBox_SelectedIndexChanged;
            // 
            // moviesDataGridView
            // 
            moviesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            moviesDataGridView.Location = new Point(17, 99);
            moviesDataGridView.Name = "moviesDataGridView";
            moviesDataGridView.Size = new Size(776, 327);
            moviesDataGridView.TabIndex = 2;
            // 
            // btnShowAllMovies
            // 
            btnShowAllMovies.Location = new Point(17, 57);
            btnShowAllMovies.Name = "btnShowAllMovies";
            btnShowAllMovies.Size = new Size(109, 36);
            btnShowAllMovies.TabIndex = 3;
            btnShowAllMovies.Text = "Show All Movies";
            btnShowAllMovies.UseVisualStyleBackColor = true;
            btnShowAllMovies.Click += btnShowAllMovies_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 468);
            Controls.Add(btnShowAllMovies);
            Controls.Add(moviesDataGridView);
            Controls.Add(genreComboBox);
            Controls.Add(lblGenre);
            Name = "Form1";
            Text = "Movies";
            ((System.ComponentModel.ISupportInitialize)moviesDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)moviesGenreBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)moviesBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGenre;
        private ComboBox genreComboBox;
        private DataGridView moviesDataGridView;
        private Button btnShowAllMovies;
        private BindingSource moviesGenreBindingSource;
        private BindingSource moviesBindingSource;
    }
}
