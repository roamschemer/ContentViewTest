using Prism.Navigation;
using Reactive.Bindings;
using System;

namespace ContentViewTest.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public ReactiveProperty<string> BackColor { get; set; } = new ReactiveProperty<string>("White");
        public ReactiveCommand Command { get; } = new ReactiveCommand();

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Command.Subscribe(_ => BackColor.Value = "Pink");
        }
    }
}
