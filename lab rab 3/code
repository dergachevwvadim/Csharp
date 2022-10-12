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

namespace Lab_rab_3
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnConvert_Click(object sender, RoutedEventArgs e)
        {
            double a = double.Parse(tb1summ.Text);
            int operation = CBValue.SelectedIndex;
            double result = 0;
            switch (operation)
            {
                case 0:
                    tblinfo.Text = String.Format("Доллар в рублях равен:");
                    result = a * 63.1;
                    break;
                case 1:
                    tblinfo.Text = String.Format("Евро в рублях равно:");
                    result = a * 61.23;
                    break;
                case 2:
                    tblinfo.Text = String.Format("Юани в рублях равны:");
                    result = a * 8.83;
                    break;
            }
            tbResult.Text = String.Format("{0:0.00}", result);
        }
    }
}
