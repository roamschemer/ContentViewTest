using Prism.Mvvm;
using System;
using Xamarin.Forms;

namespace ContentViewTest.Models {

    /// <summary>
    /// ランダム色クラス
    /// </summary>
    public class RundomColor : BindableBase {

        /// <summary>
        /// 色
        /// </summary>
        public Color Color {
            get => color;
            private set => SetProperty(ref color, value);
        }
        private Color color;

        /// <summary>
        /// Colorにランダムで色をSetする
        /// </summary>
        public void SetColor() {
            int seed = Environment.TickCount;
            var rnd = new System.Random(seed);
            var r = rnd.Next(0, 255);
            var g = rnd.Next(0, 255);
            var b = rnd.Next(0, 255);
            Color = Color.FromRgb(r, g, b);
        }
    }
}
