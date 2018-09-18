using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wincubate.Module07.Slide17
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

        private void OnClick(object sender, RoutedEventArgs e)
        {
            int number = int.Parse(txtNumber.Text);
            string result = string.Join("*", PrimeHelper.GetPrimeFactors(number));

            lblResult.Content = result;
        }

        #region Task-based

        private Task<string> FactorAsync()
        {
            int number = int.Parse(txtNumber.Text);

            return Task.Factory.StartNew<string>(() =>
              string.Join("*", PrimeHelper.GetPrimeFactors(number))
            );
        }

        #endregion
    }
}
