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
    public partial class Map : Form
    {
        public Map()
        {
            InitializeComponent();

        }

       
        private void Map_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(200, 50);
            this.ControlBox = false;
            timerForStartMarathon.Start();
            CheckPoint_1.BackColor = Color.Transparent;
            forCheckPoint.BackColor = Color.Transparent;
            description.BackColor = Color.Transparent;
            Close.BackColor = Color.Transparent;
            CheckPoint_2.BackColor = Color.Transparent;
            CheckPoint_3.BackColor = Color.Transparent;
            CheckPoint_4.BackColor = Color.Transparent;
            CheckPoint_5.BackColor = Color.Transparent;
            CheckPoint_6.BackColor = Color.Transparent;
            CheckPoint_7.BackColor = Color.Transparent;
            CheckPoint_8.BackColor = Color.Transparent;
            Finish.BackColor = Color.Transparent;
        }
      
        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            forCheckPoint.BackColor = Color.Transparent;
            description.BackColor = Color.Transparent;
            forCheckPoint.Text = "";
            description.Text = "";
            picForDescription_1.Image = null;
            picForDescription_2.Image = null;
            picForDescription_3.Image = null;
            picForDescription_4.Image = null;
            picForDescription_5.Image = null;
            Close.BackColor = Color.Transparent;
            Close.Text = "";
        }

        private void CheckPoint_1_Click(object sender, EventArgs e)
        {
            forCheckPoint.BackColor = Color.FromArgb(235, 235, 235, 235);
            description.BackColor = Color.FromArgb(235, 235, 235, 235);
            Close.BackColor = Color.FromArgb(235, 235, 235, 235);
            picForDescription_1.Image = null;
            picForDescription_2.Image = null;
            picForDescription_3.Image = null;
            picForDescription_4.Image = null;
            picForDescription_5.Image = null;
            Close.Text = "X";
            forCheckPoint.Text = "Avenida Rudge";
            description.Text = "  \n                      Особенности:" +
                "\n\n - Energy Bars" +
                "\n - Drinks ";
            picForDescription_1.Image = Image.FromFile(@"Resourse\E1.png");
            picForDescription_2.Image = Image.FromFile(@"Resourse\map-icon-drinks.png");
        }

        private void CheckPoint_2_Click(object sender, EventArgs e)
        {
            forCheckPoint.BackColor = Color.FromArgb(235, 235, 235, 235);
            description.BackColor = Color.FromArgb(235, 235, 235, 235);
            Close.BackColor = Color.FromArgb(235, 235, 235, 235);
            picForDescription_1.Image = null;
            picForDescription_2.Image = null;
            picForDescription_3.Image = null;
            picForDescription_4.Image = null;
            picForDescription_5.Image = null;
            Close.Text = "X";
            forCheckPoint.Text = "Theatro Municipal";
            description.Text = "  \n                      Особенности:" +
                "\n\n - Энергетические батончики " +
                "\n - Туалет" +
                "\n - Стойка информации" +
                "\n - Медицинский пункт" +
                "\n - Стенд питья ";
            picForDescription_1.Image = Image.FromFile(@"Resourse\E1.png");
            picForDescription_2.Image = Image.FromFile(@"Resourse\map-icon-toilets.png");
            picForDescription_3.Image = Image.FromFile(@"Resourse\map-icon-information.png"); ;
            picForDescription_4.Image = Image.FromFile(@"Resourse\map-icon-medical.png");
            picForDescription_5.Image = Image.FromFile(@"Resourse\map-icon-drinks.png");
        }

        private void CheckPoint_3_Click(object sender, EventArgs e)
        {
            forCheckPoint.BackColor = Color.FromArgb(235, 235, 235, 235);
            description.BackColor = Color.FromArgb(235, 235, 235, 235);
            Close.BackColor = Color.FromArgb(235, 235, 235, 235);
            picForDescription_1.Image = null;
            picForDescription_2.Image = null;
            picForDescription_3.Image = null;
            picForDescription_4.Image = null;
            picForDescription_5.Image = null;
            Close.Text = "X";
            forCheckPoint.Text = "Parque do Ibirapuera";
            description.Text = "  \n                      Особенности:" +
                "\n\n - Энергетические батончики" +
                "\n - Стенд питья" +
                "\n - Туалет";
            picForDescription_1.Image = Image.FromFile(@"Resourse\E1.png");
            picForDescription_2.Image = Image.FromFile(@"Resourse\map-icon-drinks.png");
            picForDescription_3.Image = Image.FromFile(@"Resourse\map-icon-toilets.png");
        }

        private void CheckPoint_4_Click(object sender, EventArgs e)
        {
            forCheckPoint.BackColor = Color.FromArgb(235, 235, 235, 235);
            description.BackColor = Color.FromArgb(235, 235, 235, 235);
            Close.BackColor = Color.FromArgb(235, 235, 235, 235);
            picForDescription_1.Image = null;
            picForDescription_2.Image = null;
            picForDescription_3.Image = null;
            picForDescription_4.Image = null;
            picForDescription_5.Image = null;
            Close.Text = "X";
            forCheckPoint.Text = "Jardim Luzitania ";
            description.Text = "  \n                      Особенности:" +
                "\n\n - Энергетические батончики " +
                "\n - Туалет" +
                "\n - Медицинский пункт" +
                "\n - Стенд питья ";
            picForDescription_1.Image = Image.FromFile(@"Resourse\E1.png");
            picForDescription_2.Image = Image.FromFile(@"Resourse\map-icon-toilets.png");
            picForDescription_3.Image = Image.FromFile(@"Resourse\map-icon-medical.png");
            picForDescription_4.Image = Image.FromFile(@"Resourse\map-icon-drinks.png");
        }

        private void CheckPoint_5_Click(object sender, EventArgs e)
        {
            forCheckPoint.BackColor = Color.FromArgb(235, 235, 235, 235);
            description.BackColor = Color.FromArgb(235, 235, 235, 235);
            Close.BackColor = Color.FromArgb(235, 235, 235, 235);
            picForDescription_1.Image = null;
            picForDescription_2.Image = null;
            picForDescription_3.Image = null;
            picForDescription_4.Image = null;
            picForDescription_5.Image = null;
            Close.Text = "X";
            forCheckPoint.Text = " Iguatemi ";
            description.Text = "  \n                      Особенности:" +
                "\n\n - Энергетические батончики " +
                "\n - Туалет" +
                "\n - Стойка информации" +
                "\n - Стенд питья ";
            picForDescription_1.Image = Image.FromFile(@"Resourse\E1.png");
            picForDescription_2.Image = Image.FromFile(@"Resourse\map-icon-toilets.png");
            picForDescription_3.Image = Image.FromFile(@"Resourse\map-icon-information.png"); ;
            picForDescription_4.Image = Image.FromFile(@"Resourse\map-icon-drinks.png");
        }

        private void CheckPoint_6_Click(object sender, EventArgs e)
        {
            forCheckPoint.BackColor = Color.FromArgb(235, 235, 235, 235);
            description.BackColor = Color.FromArgb(235, 235, 235, 235);
            Close.BackColor = Color.FromArgb(235, 235, 235, 235);
            picForDescription_1.Image = null;
            picForDescription_2.Image = null;
            picForDescription_3.Image = null;
            picForDescription_4.Image = null;
            picForDescription_5.Image = null;
            Close.Text = "X";
            forCheckPoint.Text = "Rua Lisboa";
            forCheckPoint.Text = "Parque do Ibirapuera";
            description.Text = "  \n                      Особенности:" +
                "\n\n - Энергетические батончики" +
                "\n - Стенд питья" +
                "\n - Туалет";
            picForDescription_1.Image = Image.FromFile(@"Resourse\E1.png");
            picForDescription_2.Image = Image.FromFile(@"Resourse\map-icon-drinks.png");
            picForDescription_3.Image = Image.FromFile(@"Resourse\map-icon-toilets.png");
        }

        private void CheckPoint_7_Click(object sender, EventArgs e)
        {
            forCheckPoint.BackColor = Color.FromArgb(235, 235, 235, 235);
            description.BackColor = Color.FromArgb(235, 235, 235, 235);
            Close.BackColor = Color.FromArgb(235, 235, 235, 235);
            picForDescription_1.Image = null;
            picForDescription_2.Image = null;
            picForDescription_3.Image = null;
            picForDescription_4.Image = null;
            picForDescription_5.Image = null;
            Close.Text = "X";
            forCheckPoint.Text = "Cemitério da Consolação";
            description.Text = "  \n                      Особенности:" +
                 "\n\n - Энергетические батончики " +
                 "\n - Туалет" +
                 "\n - Стойка информации" +
                 "\n - Медицинский пункт" +
                 "\n - Стенд питья ";
            picForDescription_1.Image = Image.FromFile(@"Resourse\E1.png");
            picForDescription_2.Image = Image.FromFile(@"Resourse\map-icon-toilets.png");
            picForDescription_3.Image = Image.FromFile(@"Resourse\map-icon-information.png"); ;
            picForDescription_4.Image = Image.FromFile(@"Resourse\map-icon-medical.png");
            picForDescription_5.Image = Image.FromFile(@"Resourse\map-icon-drinks.png");
        }

        private void CheckPoint_8_Click(object sender, EventArgs e)
        {
            forCheckPoint.BackColor = Color.FromArgb(235, 235, 235, 235);
            description.BackColor = Color.FromArgb(235, 235, 235, 235);
            Close.BackColor = Color.FromArgb(235, 235, 235, 235);
            picForDescription_1.Image = null;
            picForDescription_2.Image = null;
            picForDescription_3.Image = null;
            picForDescription_4.Image = null;
            picForDescription_5.Image = null;
            Close.Text = "X";
            forCheckPoint.Text = "Cemitério da Consolação";
            description.Text = "  \n                      Особенности:" +
                "\n\n - Энергетические батончики " +
                "\n - Туалет" +
                "\n - Стойка информации" +
                "\n - Медицинский пункт" +
                "\n - Стенд питья ";
            picForDescription_1.Image = Image.FromFile(@"Resourse\E1.png");
            picForDescription_2.Image = Image.FromFile(@"Resourse\map-icon-toilets.png");
            picForDescription_3.Image = Image.FromFile(@"Resourse\map-icon-information.png"); ;
            picForDescription_4.Image = Image.FromFile(@"Resourse\map-icon-medical.png");
            picForDescription_5.Image = Image.FromFile(@"Resourse\map-icon-drinks.png");
        }

        private void Finish_Click(object sender, EventArgs e)
        {
            forCheckPoint.BackColor = Color.FromArgb(235, 235, 235, 235);
            description.BackColor = Color.FromArgb(235, 235, 235, 235);
            Close.BackColor = Color.FromArgb(235, 235, 235, 235);
            picForDescription_1.Image = null;
            picForDescription_2.Image = null;
            picForDescription_3.Image = null;
            picForDescription_4.Image = null;
            picForDescription_5.Image = null;
            Close.Text = "X";
            forCheckPoint.Text = "Finish";
            description.Text = "  \n                      Особенности:" +
                "\n\n - Поздравляем, вы закончили гонку";

            picForDescription_1.Image = Image.FromFile(@"Resourse\finish_119587.png");
        }

        private void timerForStartMarathon_Tick(object sender, EventArgs e)
        {
            if (timerForStartMarathon.Interval == 1)
            {
                timerForStartMarathon.Interval = 3;
            }
            time_start_marathon.Text = DateTimeTickcs.date;
        }

        private void Back_n_Click(object sender, EventArgs e)
        {
            Close();
            opacity.op1 = false;
        }
    }
}
