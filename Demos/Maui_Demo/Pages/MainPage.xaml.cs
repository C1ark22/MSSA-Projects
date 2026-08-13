using Maui_Demo.Models;
using Maui_Demo.PageModels;

namespace Maui_Demo.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}