/******************************************************************************
 * Project: SFSU Veteran Services Tracker
 * Author: Clark Batungbakal 
 * Class Name: MainPage.xaml.cs
 * 
 * Description: This class represents the main page of the application. It 
 * provides a user interface for checking in students and viewing their 
 * check-in status.
 * 
 * ***************************************************************************/
using SFSU_VeteranServices_Tracker.Model;
using SFSU_VeteranServices_Tracker.View;

namespace SFSU_VeteranServices_Tracker
{
    public partial class MainPage : ContentPage
    {
        private List<StudentCheckIn> checkIns = new List<StudentCheckIn>();
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        private async void OnStaffClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(LoginPage));
        }

        private async void OnCheckInClicked(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(fullNameEntry.Text))
            {
                await DisplayAlertAsync(
                    "Missing Information",
                    "Please enter your Full Name",
                    "OK");
                return;
            }
            foreach (char character in fullNameEntry.Text)
            {
                if (!char.IsLetter(character) && character != ' ')
                {
                    await DisplayAlertAsync(
                        "Invalid Name",
                        "Student name can only contain letters and spaces.",
                        "OK");
                    return;
                }
            }

            if(!int.TryParse(studentIdEntry.Text, out int studentID))
            {
                await DisplayAlertAsync(
                    "Invalid Student ID",
                    "Please enter numbers only.",
                    "OK");
                return;
            }
            if (studentStatusPicker.SelectedItem == null)
            {
                await DisplayAlertAsync(
                    "Missing Information",
                    "Please select your status.",
                    "OK");
                return;
            }
            if (!codeOfConductCheckBox.IsChecked)
            {
                await DisplayAlertAsync(
                    "Code of Conduct",
                    "Please read and acknowledge the Code of Conduct",
                    "OK");
                return;
            }

            StudentCheckIn student = new StudentCheckIn
            {
                FullName = fullNameEntry.Text,
                StudentId = studentID.ToString(),
                Status = studentStatusPicker.SelectedItem.ToString(),
                CheckInTime = DateTime.Now
            };

            checkIns.Insert(0,student);

            await SaveCheckIntoFile(student);


            await DisplayAlertAsync(
                "Check In Successful",
                $"Thank you for checking in, {student.FullName}!",
                "OK");
        }
        private async void OnCodeOfConductTapped(object sender, TappedEventArgs e)
        {
            string url = "https://conduct.sfsu.edu/standards";

            await Launcher.Default.OpenAsync(url);

            codeOfConductCheckBox.IsEnabled = true;
        }
        private async Task SaveCheckIntoFile(StudentCheckIn student)
        {
            try
            {
                string documentsFolder =
                    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                string trackerFolder = Path.Combine(
                    documentsFolder,
                    "VeteranServicesTracker");

                Directory.CreateDirectory(trackerFolder);

                string filePath = Path.Combine(
                    trackerFolder,
                    "checkins.csv");

                string header =
                    "StudentId,FullName,Status,CheckInTime";

                string record =
                    $"{student.StudentId}," +
                    $"{student.FullName}," +
                    $"{student.Status}," +
                    $"{student.CheckInTime}";

                // First time creating the CSV
                if (!File.Exists(filePath))
                {
                    await File.WriteAllTextAsync(
                        filePath,
                        header + Environment.NewLine +
                        record + Environment.NewLine);
                }
                else
                {
                    // Read everything already inside the CSV
                    string[] lines = await File.ReadAllLinesAsync(filePath);

                    // Create a new list of lines
                    List<string> updatedLines = new List<string>();

                    // Keep the column headers first
                    updatedLines.Add(header);

                    // Add newest student directly under the header
                    updatedLines.Add(record);

                    // Add the older records after the new student
                    for (int i = 1; i < lines.Length; i++)
                    {
                        updatedLines.Add(lines[i]);
                    }

                    // Rewrite the CSV
                    await File.WriteAllLinesAsync(
                        filePath,
                        updatedLines);
                }

                await DisplayAlertAsync(
                    "Saved",
                    $"CSV saved at:\n{filePath}",
                    "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlertAsync(
                    "File Error",
                    ex.Message,
                    "OK");
            }
        }
    }
}
