using System.Data;
using System.Windows;
using System.Windows.Controls;
namespace LoginPage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            foreach (UIElement item in MainGrid.Children)
            {
                if (item is Button)
                    ((Button)item).Click += ButtonClick;
            }
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;

            if (str == "AC")
            {
                textLabel.Text = "";
            }
            else if (str == "=")
            {
                string? value = new DataTable().Compute(textLabel.Text, null).ToString();
                textLabel.Text = value;
            }
            else
                textLabel.Text += str;
        }
    }
}
