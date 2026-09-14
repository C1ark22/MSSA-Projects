using Microsoft.EntityFrameworkCore;

namespace Assignment_10._3
{
    public partial class MainForm : Form
    {
        private readonly CarsContext dbContext = new CarsContext();
        private readonly BindingSource carsBindingSource = new BindingSource();
        public MainForm()
        {
            InitializeComponent();
            // Connect the button to its method.
            buttonSave.Click += buttonSave_Click;

            // Show a helpful message for invalid cell values.
            dataGridViewCars.DataError += (sender, e) =>
            {
                MessageBox.Show(
                    "Check your entry. Year must be a whole number " +
                    "and Price must be a number.");

                e.ThrowException = false;
            };
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            dbContext.Database.EnsureCreated();
            dbContext.Cars.Load();

            carsBindingSource.DataSource =
                dbContext.Cars.Local.ToBindingList();

            dataGridViewCars.DataSource = carsBindingSource;
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            carsBindingSource.Dispose();
            dbContext.Dispose();

            base.OnFormClosed(e);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Finish editing before saving.
            if (!Validate() || !dataGridViewCars.EndEdit())
            {
                return;
            }

            carsBindingSource.EndEdit();

            // Check new and edited cars.
            foreach (Car car in dbContext.Cars.Local)
            {
                if (string.IsNullOrWhiteSpace(car.VIN) ||
                    string.IsNullOrWhiteSpace(car.Make) ||
                    string.IsNullOrWhiteSpace(car.Model) ||
                    car.Year <= 0 ||
                    car.Price < 0)
                {
                    MessageBox.Show(
                        "Enter VIN, Make, Model, a positive Year, " +
                        "and a Price of zero or more.");

                    return;
                }
            }

            try
            {
                // Save additions, edits, and deletions.
                dbContext.SaveChanges();

                // Display generated IDs.
                dataGridViewCars.Refresh();

                MessageBox.Show("Changes saved.");
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(
                    "Changes could not be saved. Check your data and try again.");
            }
        }
    }
}
