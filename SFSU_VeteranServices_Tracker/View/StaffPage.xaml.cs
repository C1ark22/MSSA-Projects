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
        private readonly ApiService apiService = new ApiService();
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
            try
            {
                // Get all check-ins from the API
                checkIns =
                    await apiService.GetCheckInsAsync();

                // Update the dashboard with the data
                UpdateDashboard();
            }
            catch (Exception ex)
            {
                await DisplayAlertAsync(
                    "Connection Error",
                    $"Unable to load check-ins.\n\n{ex.Message}",
                    "OK");
            }
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
