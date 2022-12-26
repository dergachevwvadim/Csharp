using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace lab_rab_8
{
    public partial class MainPage : ContentPage
    {
        bool isRunning = false;
        DateTime startTime;
        public MainPage()
        {
            InitializeComponent();
            lblStartTime.Text = "00:00:00.000";
            lblStopTime.Text = "00:00:00.000";
            lblTimer.Text = "00:00:00.000";
        }

        private void btnStart_Clicked(object sender, EventArgs e)
        {
            if (isRunning)
            {
                btnStart.Text = "Start";
                lblStopTime.Text = DateTime.Now.ToString("hh:mm:ss.fff");
                isRunning = false;
            }
            else
            {
                btnStart.Text = "Stop";
                startTime = DateTime.Now;
                lblStartTime.Text = startTime.ToString("hh:mm:ss.fff");
                lblStopTime.Text = "";
                isRunning = true;
                Device.StartTimer(new TimeSpan(0, 0, 0, 0, 50), onTimer);

            }
        }
        private bool onTimer()
        {
            lblTimer.Text = (DateTime.Now - startTime).ToString("hh\\:mm\\:ss\\.fff");
            return isRunning;
        }
        private void insertPreviousMeasurement(string start, string stop, string time)
        {
            Label label1 = new Label()
            {
                Text = start,
                TextColor = Color.DarkGray,
                FontSize = 17
            };

            Label label2 = new Label()
            {
                Text = time,
                TextColor = Color.Gray,
                FontSize = 24
            };
            Label label3 = new Label()
            {
                Text = stop,
                TextColor = Color.DarkGray,
                FontSize = 17
            };
            StackLayout stackLayout = new StackLayout()
            {
                Children = { label1, label2, label3 }
            };
            stackLayout.Orientation = StackOrientation.Horizontal;
            stackLayout.Spacing = 20;
            stackLayout.HorizontalOptions = new LayoutOptions(LayoutAlignment.Center, true);
            stackLayout.VerticalOptions = new LayoutOptions(LayoutAlignment.Center, true);
            scrollLayout.Children.Insert(0, stackLayout);
        }
    }
}
