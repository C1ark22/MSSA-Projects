/******************************************************************************
 * Project: SFSU Veteran Services Tracker
 * Author: Clark Batungbakal 
 * Class Name: LoginPage.xaml.cs
 * 
 * Description: This class represents the login page of the application. 
 * It handles user input for username and password, validates the input, and 
 * navigates to the StaffPage upon successful login.
 * 
 * ***************************************************************************/

using System;
using System.Collections.Generic;
using System.Text;

namespace SFSU_VeteranServices_Tracker.View;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        string username = usernameEntry.Text;
        string password = passwordEntry.Text;

        if (string.IsNullOrWhiteSpace(username))
        {
            await DisplayAlertAsync(
                "Missing Information",
                "Please enter your username.",
                "OK");

            return;
        }

        if (string.IsNullOrWhiteSpace(password))
        {
            await DisplayAlertAsync(
                "Missing Information",
                "Please enter your password.",
                "OK");

            return;
        }

        if (username == "staff" && password == "1234")
        {
            await Shell.Current.GoToAsync(nameof(StaffPage));
        }
        else
        {
            await DisplayAlertAsync(
                "Login Failed",
                "Incorrect username or password.",
                "OK");
        }
    }
}