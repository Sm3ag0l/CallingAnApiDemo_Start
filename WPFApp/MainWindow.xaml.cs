using DemoLibrary;
using System;
using System.Windows;

namespace WPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ApiHelper.InitalizeClient();  // init at start of application Could also put in the app.xaml but more visible here

        }
    }
}
