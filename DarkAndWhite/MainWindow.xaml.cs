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

namespace DarkAndWhite
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void WhiteMode_Checked(object sender, RoutedEventArgs e)
        {
            app.Default.ColorMode = "White";
            app.Default.Save();
        }

        private void LightMode_Checked(object sender, RoutedEventArgs e)
        {
            app.Default.ColorMode = "Light";
            app.Default.Save();
        }

        private void DarkMode_Checked(object sender, RoutedEventArgs e)
        {
            app.Default.ColorMode = "Dark";
            app.Default.Save();
        }

        private void BlackMode_Checked(object sender, RoutedEventArgs e)
        {
            app.Default.ColorMode = "Black";
            app.Default.Save();
        }
    }
}