using CommunityToolkit.Mvvm.Input;
using FinalProject.Models;

namespace FinalProject.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}