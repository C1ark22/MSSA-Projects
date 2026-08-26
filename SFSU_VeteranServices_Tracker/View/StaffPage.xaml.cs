using SFSU_VeteranServices_Tracker.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SFSU_VeteranServices_Tracker.View
{
    public partial class StaffPage : ContentPage
    {
        private List<StudentCheckIn> checkIns;
        public StaffPage() {

            InitializeComponent();

            checkIns = new List<StudentCheckIn>();
        }
        private async void OnSignOutClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("..");
        }

        private async Task LoadCheckIns()
        {
            // Read CSV
        }

        private void UpdateDashboard()
        {
            // Count totals
        }
    }
}
