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
            double B = 0;
            switch (operation)
            {
                case 0:                    
                    B = a * 63.1;
                    break;
                case 1:                   
                    B = a * 1;
                    break;
                case 2:                    
                    B = a * 61.23;
                    break;
                case 3:
                    B = a * 8.83;
                    break;
            }
            int operation2 = CB2.SelectedIndex;
            switch (operation2)
            {
                case 0:
                    result = B / 1;
                    break;
                case 1:
                    result = B / 63.1;
                    break;
                case 2:
                    result = B / 8.83;
                    break;
                case 3:
                    result = B / 61.23;
                    break;
            }
            tblinfo.Text = String.Format("Результат конвертации:");
            tbResult.Text = String.Format("{0} {1} = {2:0.00} {3}", tb1summ.Text, CBValue.Text, result, CB2.Text);
        }
    }
}
