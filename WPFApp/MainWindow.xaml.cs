using DemoLibrary;
using System;
using System.Windows;
using System.Threading;
using System.Threading.Tasks;
using DemoLibrary;
using System.Windows.Media.Imaging;

namespace WPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int maxNumber { get; set; }
        private int currentNumber { get; set; }


        public MainWindow()
        {
            InitializeComponent();
            ApiHelper.InitalizeClient();  // init at start of application Could also put in the app.xaml but more visible here


            // cant put it in here  can't call in here or make it async.

        }


        private async Task LoadImage(int imageNumber = 0 )
        {
            var comic = await ComicProcessor.LoadComic(imageNumber);

            if (imageNumber == 0)
            {
                maxNumber = comic.Num;
            }

            currentNumber = comic.Num;

            var uriSource = new Uri(comic.Img, UriKind.Absolute);               // grabs url as a whole url
            comicImage.Source = new BitmapImage(uriSource);                     // 
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            await LoadImage();
        }
    }
}
