
using SFSU_VeteranServices_Tracker.Model;

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
                StudentId = studentID,
                Status = studentStatusPicker.SelectedItem.ToString(),
                CheckInTime = DateTime.Now
            };

            checkIns.Add(student);

            await SaveCheckIntoFile(student);


            await DisplayAlertAsync(
                "Check In Successful",
                $"Thank you for checking in, {student.FullName}!",
                "OK");
        }
        private async void OnCodeOfConductTapped(object sender, TappedEventArgs e)
        {
            await DisplayAlertAsync(
                "Code of Conduct",
                "Veterans Corner Code of Conduct will be displayed here.",
                "Close");

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

                // If CSV does not exist, create it with column names
                if (!File.Exists(filePath))
                {
                    await File.WriteAllTextAsync(
                        filePath,
                        "StudentId,FullName,Status,CheckInTime" +
                        Environment.NewLine);
                }

                string record =
                    $"{student.StudentId}," +
                    $"{student.FullName}," +
                    $"{student.Status}," +
                    $"{student.CheckInTime}";

                await File.AppendAllTextAsync(
                    filePath,
                    record + Environment.NewLine);

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
