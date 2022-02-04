using System;
using Xamarin.Forms;

namespace MvvmDataTemplate.TemplateModels
{
    public class StepOneTemplateModel : BaseTemplateModel
    {
        public StepOneTemplateModel()
        {
        }

        private bool _isMessageShowing;
        public bool IsMessageShowing { get => _isMessageShowing; set => SetProperty(ref _isMessageShowing, value); }

        public string Message => "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";

        public Command ButtonCommand => new Command(() => IsMessageShowing = true);
    }
}
