using ContentViewTest.Models;
using Prism.Navigation;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using System;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using Xamarin.Forms;

namespace ContentViewTest.ViewModels {
    public class MainPageViewModel : ViewModelBase, IDisposable {
        private CompositeDisposable Disposable { get; } = new CompositeDisposable();
        public RundomColor RundomColorModel = new RundomColor();
        public ReactiveProperty<Color> BackColor { get; set; } = new ReactiveProperty<Color>();
        public ReactiveCommand Command { get; } = new ReactiveCommand();

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService) {
            BackColor = RundomColorModel.ObserveProperty(x => x.Color)
                                        .ToReactiveProperty<Color>()
                                        .AddTo(this.Disposable);
            Command.Subscribe(_ => RundomColorModel.SetColor());

        }
        public void Dispose() => this.Disposable.Dispose();
    }
}
