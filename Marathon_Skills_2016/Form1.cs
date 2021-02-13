using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Marathon_Skills_2016
{
    public partial class Menu : Form
    {
        DateTime startTime = new DateTime(2020,6,1,12,0,0);
        
        public Menu()
        {
            InitializeComponent();
            clock_for_start.Tick += clock_for_start_Tick;
            clock_for_start.Interval = 1000;
            clock_for_start.Enabled = true;
            clock_for_start.Start();

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(200, 50);
            forOpacity.Start();
           
            

        }
                    
        

        private void clock_for_start_Tick(object sender, EventArgs e)
        {
            TimeSpan interval = startTime - DateTime.Now;
            string hour = "";
            string minute = "";
            string day = "";
            string second = "";
            if (interval.Days <= 24 && interval.Days >= 22 || interval.Days <= 4 && interval.Days >= 2)
            {
                day = " дня ";
            }
            if (interval.Days == 21 || interval.Days == 1)
            {
                day = " день ";
            }
            if (interval.Days <= 20 && interval.Days >= 5 || interval.Days == 0)
            {
                day = " дней ";
            }
            if (interval.Hours <= 24 && interval.Hours >= 22 || interval.Hours <= 4 && interval.Hours >= 2)
            {
                hour = " часа ";
            }
            if (interval.Hours == 21 || interval.Hours == 1)
            {
                hour = " час ";
            }
            if (interval.Hours <= 20 && interval.Hours >= 5 || interval.Hours == 0)
            {
                hour = " часов ";
            }
            if (interval.Minutes % 10 == 0 || interval.Minutes % 10 <= 9 && interval.Minutes % 10 >= 5)
            {
                minute = " минут ";
            }
            if (interval.Minutes % 10 <= 4 && interval.Minutes % 10 >= 2)
            {
                minute = " минуты ";
            }
            if (interval.Minutes % 10 == 1)
            {
                minute = " минута ";
            }
            if (interval.Minutes <= 14 && interval.Minutes >= 11)
            {
                minute = " минут  ";
            }

            if (interval.Seconds % 10 == 0 || interval.Seconds % 10 <= 9 && interval.Seconds % 10 >= 5)
            {
                second = " секунд ";
            }
            if (interval.Seconds % 10 <= 4 && interval.Seconds % 10 >= 2)
            {
                second = " секунды ";
            }

            if (interval.Seconds % 10 == 1)
            {
                second = " секунда ";
            }
            if (interval.Seconds <= 14 && interval.Seconds >= 11)
            {
                second = " cекунд  ";
            }

            clock.Text = "До начала марафона осталось " + interval.Days + day + interval.Hours + hour + interval.Minutes + minute + interval.Seconds + second;
            DateTimeTickcs.date = clock.Text;
        }

        private void forOpacity_Tick(object sender, EventArgs e)
        {
            if (forOpacity.Interval == 1)
            {
                forOpacity.Interval = 3;
            }
            if (opacity.op)
            {
                this.Opacity = 0;
            }
            else
            {
                this.Opacity = 1;
            }
        }

       

        private void MarSkills2016_Click_1(object sender, EventArgs e)
        {
            opacity.op = true;

            Information AddRec = new Information();
            AddRec.Owner = this;
            AddRec.ShowDialog();
        }

        private void How_Long_Click(object sender, EventArgs e)
        {
            opacity.op = true;
            HowLong Show = new HowLong();
            Show.Owner = this;
            Show.ShowDialog();
        }

        private void calcBMI_Click(object sender, EventArgs e)
        {
            opacity.op = true;
            BMI Show = new BMI();
            Show.Owner = this;
            Show.ShowDialog();
        }

        private void calcBMR_Click(object sender, EventArgs e)
        {
            opacity.op = true;
            BMR Show = new BMR();
            Show.Owner = this;
            Show.ShowDialog();
        }
    }

}
    

