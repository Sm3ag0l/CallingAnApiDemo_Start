using DemoLibrary;
using System;
using System.Windows;

namespace WPFApp
{
    /// <summary>
    /// Interaction logic for SunInfo.xaml
    /// </summary>
    public partial class SunInfo : Window
    {
        public SunInfo()
        {
            InitializeComponent();
        }

        private async void loadSunInfo_Click(object sender, RoutedEventArgs e)
        {
            var suninfo = await SunProcessor.LoadSunInformation();

            //sunriseText.Text = $"at {suninfo.SunriseTime.ToLocalTime().ToShortTimeString() }";
            //sunsetText.Text = $"at {suninfo.SunsetTime.ToLocalTime().ToShortTimeString()}";

            sunriseText.Text = $"at {suninfo.SunriseTime.ToShortTimeString() }";
            sunsetText.Text = $"at {suninfo.SunsetTime.ToShortTimeString()}";

        }



    }
}
