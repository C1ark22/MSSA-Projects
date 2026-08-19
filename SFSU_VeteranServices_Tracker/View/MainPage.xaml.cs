namespace SFSU_VeteranServices_Tracker
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCheckInClicked(object? sender, EventArgs e)
        {

        }
        private async void OnCodeOfConductTapped(object sender, TappedEventArgs e)
        {
            await DisplayAlert(
                "Code of Conduct",
                "Veterans Corner Code of Conduct will be displayed here.",
                "Close");

            codeOfConductCheckBox.IsEnabled = true;
        }
    }
}
