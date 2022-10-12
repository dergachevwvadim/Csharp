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

namespace Lab_rab_4
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tBl.Text = ("");
            int x = tBox.Text.Length;
            char[] massive = new char[x];
            for (int i = 0; i < x; i++)
            {
                massive[i] = tBox.Text[i];  
            }
            for (int i = x; i != 0; i--)
            {
                tBl.Text += massive[i - 1];
            }
        }   
    }
}
