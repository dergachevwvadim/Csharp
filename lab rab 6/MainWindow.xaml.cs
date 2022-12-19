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
using System.Windows.Media.Animation;
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
        string operation = string.Empty;
        bool res = true;
        string fstNum;
        string secNum;
        bool enterValue = false;
        public MainWindow()
        {
            InitializeComponent();
            txtDisplay1.Clear();
            txtDisplay1.Text = "0";
            txtDisplay2.Clear();
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
            if (fstNum != null) res = false;
        }
        private void BtnMath_Click(object sender, RoutedEventArgs e)
        {
            if (res)
            {
                if (fstNum == null) fstNum = txtDisplay1.Text;
                Button button = (Button)sender;
                txtDisplay2.Clear();
                txtDisplay2.Text = txtDisplay2.Text + fstNum + button.Content;
                txtDisplay1.Clear();
                txtDisplay1.Text += button.Content;
                operation = txtDisplay1.Text;
                txtDisplay1.Clear();
            }
        }
        private void BtnEqual_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case "+":
                    {
                        if (secNum == null) secNum = txtDisplay1.Text;
                        result = Double.Parse(fstNum) + Double.Parse(secNum);
                        txtDisplay2.Clear();
                        txtDisplay2.Text = txtDisplay2.Text + fstNum.ToString() + "+" + secNum.ToString() + "=" + result.ToString();
                        txtDisplay1.Text = (Double.Parse(fstNum) + Double.Parse(secNum)).ToString();
                        fstNum = result.ToString();
                        break;
                    }
                case "-":
                    {
                        if (secNum == null) secNum = txtDisplay1.Text;
                        result = Double.Parse(fstNum) - Double.Parse(secNum);
                        txtDisplay2.Clear();
                        txtDisplay2.Text = txtDisplay2.Text + fstNum.ToString() + "-" + secNum.ToString() + "=" + result.ToString();
                        txtDisplay1.Text = (Double.Parse(fstNum) - Double.Parse(secNum)).ToString();
                        fstNum = result.ToString();
                        break;
                    }
                case "×":
                    {
                        if (secNum == null) secNum = txtDisplay1.Text;
                        result = Double.Parse(fstNum) * Double.Parse(secNum);
                        txtDisplay2.Clear();
                        txtDisplay2.Text = txtDisplay2.Text + fstNum.ToString() + "×" + secNum.ToString() + "=" + result.ToString();
                        txtDisplay1.Text = (Double.Parse(fstNum) * Double.Parse(secNum)).ToString();
                        fstNum = result.ToString();
                        break;
                    }
                case "÷":
                    {
                        if (secNum == null) secNum = txtDisplay1.Text;
                        result = Double.Parse(fstNum) / Double.Parse(secNum);
                        txtDisplay2.Clear();
                        txtDisplay2.Text = txtDisplay2.Text + fstNum.ToString() + "÷" + secNum.ToString() + "=" + result.ToString();
                        txtDisplay1.Text = (Double.Parse(fstNum) / Double.Parse(secNum)).ToString();
                        fstNum = result.ToString();
                        break;
                    }
                default:
                    break;
            }
            res = true;
        }
        private void Clear1dispalyClick(object sender, RoutedEventArgs e)
        {
            txtDisplay1.Clear();
            result = 0;
            secNum = null;
        }
        private void ClearAllBtn(object sender, RoutedEventArgs e)
        {
            txtDisplay1.Clear();
            txtDisplay2.Clear();
            result = 0;
            fstNum = null;
            secNum = null;
        }
    }
}
