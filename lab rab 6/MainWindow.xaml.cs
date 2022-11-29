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

namespace lab_rab_6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Double result = 0;
        string operatiion = string.Empty;
        string fstNum;
        string secNum;
        bool enterValue = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnNum_Click(object sender, RoutedEventArgs e)
        {
            if (txtDisplay1.Text == "0" || enterValue) txtDisplay1.Text = string.Empty;
            enterValue = false;
            Button button = (Button)sender;
            if (button.Content == ".")
            {
                if (!txtDisplay1.Text.Contains("."))
                    txtDisplay1.Text = txtDisplay1.Text + button.Content;
            }
               else txtDisplay1.Text = txtDisplay1.Text + button.Content;

        }

        private void BtnMath_Click(object sender, RoutedEventArgs e)
        {
            if (result != 0) BtnEqual.;
            else result = Double.Parse(txtDisplay1.Text);
            Button button = (Button)sender;

        }
    }
}
