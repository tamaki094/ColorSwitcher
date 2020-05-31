using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ColorSwitcher
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ChangeColor(object sender, ValueChangedEventArgs e)
        {
            var red = redSlider.Value;
            var green = greenSlider.Value;
            var blue = blueSlider.Value;

            Color bgColor = new Color(red, green, blue);

            boxColor.BackgroundColor = bgColor;

            lblDisplay.Text = ColorToHex(bgColor);
        }

        private string ColorToHex(Color bgColor)
        {
            int red = (int)(bgColor.R * 255);
            int green = (int)(bgColor.G * 255);
            int blue = (int)(bgColor.B * 255);
            int alpha = (int)(bgColor.A * 255);

            return $"#{red:X2}{green:X2}{blue:X2}{alpha:X2}";
        }
    }
}
