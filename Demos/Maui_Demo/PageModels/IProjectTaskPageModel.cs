using CommunityToolkit.Mvvm.Input;
using Maui_Demo.Models;

namespace Maui_Demo.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}