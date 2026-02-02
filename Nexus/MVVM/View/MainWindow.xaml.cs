using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Nexus.MVVM.View
{
    public partial class MainWindow : Window
    {
        private string _userName; //Speichert den UserName lokal

        public MainWindow(string userName)
        {
            InitializeComponent();
            _userName = userName;
            SetGreeting();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void ButtonMinimize_Click(object sender, RoutedEventArgs e) =>
            WindowState = WindowState.Minimized;

        private void ButtonMaximize_Click(object sender, RoutedEventArgs e) =>
            WindowState = WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized;

        private void ButtonClose_Click(object sender, RoutedEventArgs e) =>
            Close();

        private void SetGreeting()
        {
            GreetingTextBlock.Text = $"Welcome back, {_userName}.";
        }

        /*
        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            var fadeOut = new System.Windows.Media.Animation.DoubleAnimation
            {
                From = 1.0,
                To = 0.0,
                Duration = new Duration(TimeSpan.FromSeconds(0.5))
            };

            fadeOut.Completed += (s, _) =>
            {
                StartOverlay.Visibility = Visibility.Collapsed;
            };

            StartOverlay.BeginAnimation(UIElement.OpacityProperty, fadeOut);
        } */
    }
}