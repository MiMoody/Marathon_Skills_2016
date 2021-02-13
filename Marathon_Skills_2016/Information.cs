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
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
        }

        private void Information_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(200, 50);
            clockForOpacity.Start();
            this.ControlBox = false;
            map.Image = Image.FromFile(@"Resourse\b1.jpg");
            banco_banespa_pic.Image = Image.FromFile(@"Resourse\b2.jpg");
            ibirapuera_park_lake_pic.Image = Image.FromFile(@"Resourse\i1.jpg");
            marathon_image_pic.Image = Image.FromFile(@"Resourse\m1.jpg");
            teatro_municipal_pic.Image = Image.FromFile(@"Resourse\t1.jpg");
            text_about_marathon.Text = "\t\t\t О Marathon Skills 2016" +
                "\n\n Marathon Skills - фестиваль бега, проводимый каждый год в разных частях мира. Может быть три зачета: Полный Марафон," +
                " Полумарафон и  забег для новичков - таким образом фестиваль подходит всем." +
                "\n\n В прошлых годах марафон был проведен в Осаке, Япония (2014); Лейпциг, Германия (2013); Ханой, Вьетнам (2012) и Йорк, Англия (2011)." +
                "\n\n В этом году, Marathon Skills очень зрелищно, продет в  Сан-Паоло, Бразилия, он должен быть самым большим фестивалем бега. Это финансовый центр Бразилии и самый большой город в Южной Америке." +
                "Сан-Пауло увидят тысячи бегунов, которые будут бежать мимо небоскребов, зеленые парки и великолепная архитектура." +
                "\n\n Этот фестиваль привлек рекордное количество бегунов со всего мира.  особое внимание будет обращено на участников из Кении и Ямайки, поскольку мы надеемся увидеть победителя 2014 года. (Эфиоп закончил гонку за 45 минут 4 секунды.)" +
                "\n\n Атмосфера праздника обещает развлечения для всех зрителей." +
                "\n\n События:" +
                "\n\n - Программа 'Самба' Полный Марафон начнется в Руа-Ду-Американо в 6 утра." +
                "\n\n - Программа 'Джонго' Полумарафон начнет в 7 утра Бегуны будут стартовать от недалеко от пересечения улицы Руа Ciniciata и Авенида." +
                "\n\n - Программа 'Капоэйра' в 5 км забег для новичков начнется в 15 часов Наши новички побегут от Мемориала Унинове." +
                "\n\n Спасибо всем волонтерам, которые будут помогать нам проводить марафон!";
        }

        
        


        private void map_Click(object sender, EventArgs e)
        {
            opacity.op1 = true;
            Map Show = new Map();
            Show.Owner = this;
            Show.ShowDialog();
        }

        private void clockForOpacity_Tick(object sender, EventArgs e)
        {
            if (clockForOpacity.Interval == 1)
            {
                clockForOpacity.Interval = 3;
            }
            forStart_Marathon.Text = DateTimeTickcs.date;
            if (opacity.op1)
            {
                this.Opacity = 0;
            }
            else
            {
                this.Opacity = 1;
            }
        }

        private void Back_n_Click(object sender, EventArgs e)
        {
            Close();
            opacity.op = false;
            clockForOpacity.Stop();
        }

        private void text_about_marathon_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
