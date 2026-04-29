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

namespace Paleta
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Color color;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Download(object sender, RoutedEventArgs e)
        {
            output.Background = new SolidColorBrush(color);
            output.Text = r.Value + ", " + g.Value + ", " + b.Value;
            ro.Content = r.Value;
            go.Content = g.Value;
            bo.Content = b.Value;
            Clipboard.SetText(r.Value + ", " + g.Value + ", " + b.Value);
        }

        private void Change(object sender, RoutedEventArgs e)
        {
            if (r!=null&& g != null && b != null)
            {
                color = Color.FromRgb((byte)r.Value, (byte)g.Value, (byte)b.Value);
                test.Fill = new SolidColorBrush(color);
            }
            

        }
    }
}