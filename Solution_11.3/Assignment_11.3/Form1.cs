using Assignment_11._3.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment_11._3
{
    public partial class Form1 : Form
    {
        private readonly MoviesContext _context = new MoviesContext();
        public Form1()
        {
            InitializeComponent();

            // Run when the form opens
            Load += Form1_Load;

            // Run when the selected genre changes
            genreComboBox.SelectedIndexChanged +=
                genreComboBox_SelectedIndexChanged;

            // Run when the Show All Movies button is clicked
            btnShowAllMovies.Click += btnShowAllMovies_Click;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Create the database and seed data if it does not exist
            _context.Database.EnsureCreated();

            // Set up columns to display only these movie properties
            moviesDataGridView.AutoGenerateColumns = false;
            moviesDataGridView.Columns.Clear();

            moviesDataGridView.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    HeaderText = "Movie ID",
                    DataPropertyName = "MovieId",
                    ReadOnly = true
                });

            moviesDataGridView.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    HeaderText = "Title",
                    DataPropertyName = "Title"
                });

            moviesDataGridView.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    HeaderText = "Release Year",
                    DataPropertyName = "ReleaseYear"
                });

            moviesDataGridView.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            // This example handles viewing; CRUD buttons can be added next
            moviesDataGridView.ReadOnly = true;
            moviesDataGridView.AllowUserToAddRows = false;
            moviesDataGridView.AllowUserToDeleteRows = false;

            // Display genre names while keeping their IDs available
            genreComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            genreComboBox.DisplayMember = "GenreName";
            genreComboBox.ValueMember = "GenreId";

            genreComboBox.DataSource = _context.Movies_Genres
                .OrderBy(genre => genre.GenreId)
                .ToList();

            // Start with no genre selected and show every movie
            genreComboBox.SelectedIndex = -1;
            ShowAllMovies();
        }
        private void ShowAllMovies()
        {
            // Retrieve all movies, ordered by their primary key
            moviesDataGridView.DataSource = _context.Movies
                .OrderBy(movie => movie.MovieId)
                .ToList();
        }

        private void btnShowAllMovies_Click(object sender, EventArgs e)
        {
            // Clear the genre selection because we are showing all movies
            genreComboBox.SelectedIndex = -1;

            moviesDataGridView.DataSource = _context.Movies
                .OrderBy(movie => movie.MovieId)
                .ToList();
        }

        private void genreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (genreComboBox.SelectedValue is int selectedGenreId)
            {
                // Find movies belonging to the selected genre
                moviesDataGridView.DataSource = _context.Movies
                    .Where(movie => movie.GenreId == selectedGenreId)
                    .OrderBy(movie => movie.MovieId)
                    .ToList();
            }
        }

        private void moviesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
