using SFSU_VeteranServices_Tracker.Model;
using SFSU_VeteranServices_Tracker.Services;
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SFSU_VeteranServices_Tracker.View
{
    public partial class StaffPage : ContentPage
    {
        private readonly EncryptionService encryptionService = new EncryptionService();
        private List<StudentCheckIn> checkIns = new List<StudentCheckIn>();
        public StaffPage() {

            InitializeComponent();

        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await LoadCheckInsAsync();
        }
        private async void OnSignOutClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("..");
        }

        private async Task LoadCheckInsAsync()
        {
            // Read CSV

            checkIns.Clear();

            string documentsFolder = 
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            string trackerFolder = 
                Path.Combine(documentsFolder, "VeteranServicesTracker");

            string filePath = 
                Path.Combine(trackerFolder, "checkins.csv");

            if (!File.Exists(filePath))
            {
                await DisplayAlertAsync(
                    "File Not Found",
                    $"The app looked here:\n\n{filePath}",
                    "OK");

                return;
            }

            if (!File.Exists(filePath))
            {
                await DisplayAlertAsync(
                    "File Not Found",
                    "The check-in records file was not found.",
                    "OK");
                return;
            }

            string[] lines = await File.ReadAllLinesAsync(filePath);

            // Start at 1 so we skip:
            // RecordId,EncryptedPayload
            for (int i = 1; i < lines.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lines[i]))
                {
                    continue;
                }

                // Split the line into RecordId and EncryptedPayload
                string[] parts =
                    lines[i].Split(',', 2);

                if (parts.Length != 2)
                {
                    continue;
                }

                string encryptedPayload =
                    parts[1];

                // Decrypt the payload
                string decryptedJson =
                    await encryptionService.DecryptAsync(
                        encryptedPayload);

                // Deserialize the JSON into a StudentCheckIn object
                StudentCheckIn? student =
                    JsonSerializer.Deserialize<StudentCheckIn>(
                        decryptedJson);

                if (student != null)
                {
                    checkIns.Add(student);
                }
            }

            UpdateDashboard();
        }

        private void UpdateDashboard()
        {
            // Count totals

            List<StudentCheckIn> todaysCheckIns = 
                checkIns
                .Where(student => student.CheckInTime.Date == DateTime.Today)
                .OrderByDescending(student => student.CheckInTime)
                .ToList();

            totalCheckInsLabel.Text = todaysCheckIns.Count.ToString();

            veteranCountLabel.Text =
                todaysCheckIns.Count(student => student.Status == "Veteran").ToString();

            activeDutyCountLabel.Text =
                todaysCheckIns.Count(student => student.Status == "Active Duty").ToString();

            reserveCountLabel.Text =
                todaysCheckIns.Count(student => student.Status == "Reserve").ToString();

            dependentCountLabel.Text =
                todaysCheckIns.Count(student => student.Status == "Dependent").ToString();

            civilianCountLabel.Text =
                todaysCheckIns.Count(student => student.Status == "Civilian").ToString();

            checkInCollectionView.ItemsSource = todaysCheckIns;
        }
    }
}
