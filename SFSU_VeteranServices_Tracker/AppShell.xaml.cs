using SFSU_VeteranServices_Tracker.View;

namespace SFSU_VeteranServices_Tracker
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
        }
    }
}
