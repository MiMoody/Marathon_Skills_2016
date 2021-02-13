using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marathon_Skills_2016
{
    public partial class BMI : Form
    {
        public BMI()
        {
            InitializeComponent();
        }

        

        private void BMI_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(200, 50);
            this.ControlBox = false;
            ClockForStart.Start();
            this.health.BackColor = Color.FromArgb(180, 180, 180, 180);
            this.health_picture.BackColor= Color.FromArgb(180, 180, 180, 180);
            checkMale.BackColor = Color.FromArgb(235,235,235,235);
            checkFemale.BackColor = Color.FromArgb(235, 235, 235, 235);
            this.gender_male.BackColor = Color.FromArgb(235, 235, 235, 235);
            this.gender_female.BackColor = Color.FromArgb(235, 235, 235, 235);
            checkMale.Checked = true;
        }

     

      
        private void Back_Click(object sender, EventArgs e)
        {
          
        }

        private void ClockForStart_Tick(object sender, EventArgs e)
        {

            if (ClockForStart.Interval == 1)
            {
                ClockForStart.Interval = 3;
            }
            timeForStartMarathon.Text = DateTimeTickcs.date;
        }

        private void text_height_TextChanged(object sender, EventArgs e)
        {
            text_height.MaxLength = 3;
        }

        private void text_weight_TextChanged(object sender, EventArgs e)
        {
            text_weight.MaxLength = 3;
        }

        private void checkMale_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkFemale_CheckedChanged(object sender, EventArgs e)
        {
            checkMale.Checked = false;
            checkFemale.Checked = true;
        }

        private void Back_n_Click(object sender, EventArgs e)
        {
            Close();
            opacity.op = false;
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            double height = double.Parse(text_height.Text) / 100;
            figures.Text = Convert.ToString(Math.Round(double.Parse(text_weight.Text) / (height * height), 1));
            if (Convert.ToInt32(Math.Round(double.Parse(text_weight.Text) / (height * height))) > 35)
            {
                trackBar.Value = 35;
            }
            if (Convert.ToInt32(Math.Round(double.Parse(text_weight.Text) / (height * height))) < 13)
            {
                trackBar.Value = 13;
                health_picture.Image = Image.FromFile(@"Resourse\Дрищ.png");
                health.Text = "Недостаточный";

            }
            if (Convert.ToInt32(Math.Round(double.Parse(text_weight.Text) / (height * height))) >= 13 & Convert.ToInt32(Math.Round(double.Parse(text_weight.Text) / (height * height))) <= 35)

            {
                trackBar.Value = Convert.ToInt32(Math.Round(double.Parse(text_weight.Text) / (height * height)));
            }
            if (Convert.ToInt32(Math.Round(double.Parse(text_weight.Text) / (height * height))) >= 13 & Convert.ToInt32(Math.Round(double.Parse(text_weight.Text) / (height * height))) < 19)

            {
                health_picture.Image = Image.FromFile(@"Resourse\Дрищ.png");

                health.Text = "Недостаточный";

            }
            if (Convert.ToInt32(Math.Round(double.Parse(text_weight.Text) / (height * height))) >= 19 & Convert.ToInt32(Math.Round(double.Parse(text_weight.Text) / (height * height))) < 25)

            {
                health_picture.Image = Image.FromFile(@"Resourse\1.png");

                health.Text = "Здоровый";

            }
            if (Convert.ToInt32(Math.Round(double.Parse(text_weight.Text) / (height * height))) >= 25 & Convert.ToInt32(Math.Round(double.Parse(text_weight.Text) / (height * height))) < 30)

            {
                health_picture.Image = Image.FromFile(@"Resourse\Толстоватая.png");

                health.Text = "Избыточный";

            }
            if (Convert.ToInt32(Math.Round(double.Parse(text_weight.Text) / (height * height))) >= 30)

            {
                health_picture.Image = Image.FromFile(@"Resourse\Жирноватая.png");

                health.Text = "Ожирение";

            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            health_picture.Image = Image.FromFile(@"Resourse\1.png");
            trackBar.Value = 20;
            figures.Text = "20";
            health.Text = "Здоровый";
            text_height.Text = "";
            text_weight.Text = "";
            checkMale.Checked = true;
            checkFemale.Checked = false;
        }
    }
}
