using Prism.Commands;
using Prism.Mvvm;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ContentViewTest.ViewModels
{
    public class MyControlViewModel : BindableBase
    {
        public ReactiveProperty<string> BackColor { get; set; } = new ReactiveProperty<string>("White");
        public ReactiveCommand Command { get; } = new ReactiveCommand();

        public MyControlViewModel()
        {
            Command.Subscribe(_ => BackColor.Value = "Yellow");
        }
    }
}
