/****************************************************************************
 * Name: Clark Batungbakal
 * GitHub Name: C1ark22
 * Project: Veteran Services Student Tracker
 * 
 * File: <MainPage.xaml.cs>
 * 
 * Description: 
 * This file contains the code behind the MainPage content page. It handles 
 * the student check-in screen, including user input validation, status 
 * selection, and check-in confirmation messages.
 * 
 * The page allows student to enter their Student ID, Full Name, and current
 * status, then records the check-in display locally in a collection for 
 * display on the screen.
 * 
 * Author: Clark Batungbakal
 **************************************************************************/

using System.Collections.ObjectModel;

namespace VeteranServicesTracker
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
    public class CheckInDisplay
    {
        
    }
}
