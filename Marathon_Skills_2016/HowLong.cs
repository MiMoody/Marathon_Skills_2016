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
    public partial class HowLong : Form
    {
        public HowLong()
        {
            InitializeComponent();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            picForSpeed_Distance.Image = Image.FromFile(@"Resourse\Create2\bus.jpg");
            nameObject.Text = forBus_pic.Text;
            label18.Text = "Длина Bus 10 м. Это займет 420 автобусов, чтобы покрыть расстояние в 42 км марафона";
        }

        private void label13_Click(object sender, EventArgs e)
        {
            picForSpeed_Distance.Image = Image.FromFile(@"Resourse\Create2\pair.jpg");
            nameObject.Text = forPairs_pic.Text;
            label18.Text = "Длина Pair of Havaianas 0.245 м. Это займет 17 тысяч 143 пары тапочек, чтобы покрыть расстояние в 42 км марафона";
        }

        private void label12_Click(object sender, EventArgs e)
        {
            picForSpeed_Distance.Image = Image.FromFile(@"Resourse\Create2\airbus.jpg");
            nameObject.Text = forAirbus_pic.Text;
            label18.Text = "Длина Airbus A380 73 м. Это займет 57 самолётов, чтобы покрыть расстояние в 42 км марафона";
        }

        private void label11_Click(object sender, EventArgs e)
        {
            picForSpeed_Distance.Image = Image.FromFile(@"Resourse\Create2\foot.jpg");
            nameObject.Text = forFootball_pic.Text;
            label18.Text = "Длина Football Field  105 м. Это займет 40 футбольных полей, чтобы покрыть расстояние в 42 км марафона";
        }

        private void label10_Click(object sender, EventArgs e)
        {
            picForSpeed_Distance.Image = Image.FromFile(@"Resourse\Create2\ronaldinho.jpg");
            nameObject.Text = forRonaldinho_pic.Text;
            label18.Text = "Длина Ronaldinho 1.81 м. Это займет 2 тысячи 320  Ronaldinho, чтобы покрыть расстояние в 42 км марафона";
        }

        private void HowLong_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(200, 50);
            this.ControlBox = false;
            timerStartMarathon.Start();
            picForSpeed_Distance.Image = Image.FromFile(@"Resourse\Create2\f1.jpg");
            nameObject.Text = forF1_car.Text;
            label18.Text = "Максимальная скорость F1 Car 345 km/h. Это займет 7 минут 18 секунд,чтобы завершить 42km марафон ";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timerStartMarathon_Tick(object sender, EventArgs e)
        {
            if (timerStartMarathon.Interval == 1)
            {
                timerStartMarathon.Interval = 3;
            }
            clockStartMarathon.Text = DateTimeTickcs.date;
        }

        private void F1_car_pic_Click(object sender, EventArgs e)
        {
            picForSpeed_Distance.Image = Image.FromFile(@"Resourse\Create2\f1.jpg");
            nameObject.Text = forF1_car.Text;
            label18.Text = "Максимальная скорость F1 Car 345 km/h. Это займет 7 минут 18 секунд,чтобы завершить 42km марафон ";
        }

        private void Slug_pic_Click(object sender, EventArgs e)
        {
            picForSpeed_Distance.Image = Image.FromFile(@"Resourse\Create2\slug.jpg");
            nameObject.Text = forSlug.Text;
            label18.Text = "Максимальная скорость Slug 0.01 km/h. Это займет 4200 часов, чтобы завершить 42km марафон ";
        }

        private void horse_pic_Click(object sender, EventArgs e)
        {
            picForSpeed_Distance.Image = Image.FromFile(@"Resourse\Create2\horse.png");
            nameObject.Text = forhorse_pic.Text;
            label18.Text = "Максимальная скорость Horse 15 km/h. Это займет 2 часа 48 минут, чтобы завершить 42km марафон ";
        }

        private void Sloth_pic_Click(object sender, EventArgs e)
        {
            picForSpeed_Distance.Image = Image.FromFile(@"Resourse\Create2\sloth.jpg");
            nameObject.Text = forSloth_pic.Text;
            label18.Text = "Максимальная скорость Sloth 0.12 km/h. Это займет 350 часов, чтобы завершить 42km марафон ";
        }

        private void Capybara_pic_Click(object sender, EventArgs e)
        {
            picForSpeed_Distance.Image = Image.FromFile(@"Resourse\Create2\capybara.jpg");
            nameObject.Text = forCapybara_pic.Text;
            label18.Text = "Максимальная скорость Capybara 35 km/h. Это займет 1 час 12 минут, чтобы завершить 42km марафон ";
        }

        private void Jaguar_pic_Click(object sender, EventArgs e)
        {
            picForSpeed_Distance.Image = Image.FromFile(@"Resourse\Create2\jaguar.jpg");
            nameObject.Text = forJaguar_pic.Text;
            label18.Text = "Максимальная скорость Jaguar 80 km/h. Это займет 31 минуту 30 секунд, чтобы завершить 42km марафон ";
        }

        private void Worm_pic_Click(object sender, EventArgs e)
        {
            picForSpeed_Distance.Image = Image.FromFile(@"Resourse\Create2\worm.jpg");
            nameObject.Text = forWorm_pic.Text;
            label18.Text = "Максимальная скорость Worm 0.03 km/h. Это займет 1400 часов, чтобы завершить 42km марафон ";
        }

        private void forF1_car_Click(object sender, EventArgs e)
        {
            picForSpeed_Distance.Image = Image.FromFile(@"Resourse\Create2\f1.jpg");
            nameObject.Text = forF1_car.Text;
            label18.Text = "Максимальная скорость F1 Car 345 km/h. Это займет 7 минут 18 секунд, чтобы завершить 42km марафон ";
        }

        private void forSlug_Click(object sender, EventArgs e)
        {
            picForSpeed_Distance.Image = Image.FromFile(@"Resourse\Create2\slug.jpg");
            nameObject.Text = forSlug.Text;
            label18.Text = "Максимальная скорость Slug 0.01 km/h. Это займет 4200 часов, чтобы завершить 42km марафон ";
        }

        private void forhorse_pic_Click(object sender, EventArgs e)
        {
            picForSpeed_Distance.Image = Image.FromFile(@"Resourse\Create2\horse.png");
            nameObject.Text = forhorse_pic.Text;
            label18.Text = "Максимальная скорость Horse 15 km/h. Это займет 2 часа 48 минут, чтобы завершить 42km марафон ";
        }

        private void forSloth_pic_Click(object sender, EventArgs e)
        {
            picForSpeed_Distance.Image = Image.FromFile(@"Resourse\Create2\sloth.jpg");
            nameObject.Text = forSloth_pic.Text;
            label18.Text = "Максимальная скорость Sloth 0.12 km/h. Это займет 350 часов, чтобы завершить 42km марафон ";
        }

        private void forCapybara_pic_Click(object sender, EventArgs e)
        {
            picForSpeed_Distance.Image = Image.FromFile(@"Resourse\Create2\capybara.jpg");
            nameObject.Text = forCapybara_pic.Text;
            label18.Text = "Максимальная скорость Capybara 35 km/h. Это займет 1 час 12 минут, чтобы завершить 42km марафон ";
        }

        private void forJaguar_pic_Click(object sender, EventArgs e)
        {
            picForSpeed_Distance.Image = Image.FromFile(@"Resourse\Create2\jaguar.jpg");
            nameObject.Text = forJaguar_pic.Text;
            label18.Text = "Максимальная скорость Jaguar 80 km/h. Это займет 31 минуту 30 секунд, чтобы завершить 42km марафон ";
        }

        private void forWorm_pic_Click(object sender, EventArgs e)
        {
            picForSpeed_Distance.Image = Image.FromFile(@"Resourse\Create2\worm.jpg");
            nameObject.Text = forWorm_pic.Text;
            label18.Text = "Максимальная скорость Worm 0.03 km/h. Это займет 1400 часов, чтобы завершить 42km марафон ";
        }

        private void Bus_pic_Click(object sender, EventArgs e)
        {
            picForSpeed_Distance.Image = Image.FromFile(@"Resourse\Create2\bus.jpg");
            nameObject.Text = forBus_pic.Text;
            label18.Text = "Длина Bus 10 м. Это займет 420 из них, чтобы покрыть расстояние в 42 км марафона";
        }

        private void forBus_pic_Click(object sender, EventArgs e)
        {
            picForSpeed_Distance.Image = Image.FromFile(@"Resourse\Create2\bus.jpg");
            nameObject.Text = forBus_pic.Text;
            label18.Text = "Длина Bus 10 м. Это займет 420 из них, чтобы покрыть расстояние в 42 км марафона";
        }

        private void pairs_pic_Click(object sender, EventArgs e)
        {
            picForSpeed_Distance.Image = Image.FromFile(@"Resourse\Create2\pair.jpg");
            nameObject.Text = forPairs_pic.Text;
            label18.Text = "Длина Pair of Havaianas 0.245 м. Это займет 17 тысяч 143 пары тапочек, чтобы покрыть расстояние в 42 км марафона";
        }

        private void forPairs_pic_Click(object sender, EventArgs e)
        {
            picForSpeed_Distance.Image = Image.FromFile(@"Resourse\Create2\pair.jpg");
            nameObject.Text = forPairs_pic.Text;
            label18.Text = "Длина Pair of Havaianas 0.245 м. Это займет 17 тысяч 143 пары тапочек, чтобы покрыть расстояние в 42 км марафона";
        }

        private void airbus_pic_Click(object sender, EventArgs e)
        {
            picForSpeed_Distance.Image = Image.FromFile(@"Resourse\Create2\airbus.jpg");
            nameObject.Text = forAirbus_pic.Text;
            label18.Text = "Длина Airbus A380 73 м. Это займет 57 самолётов, чтобы покрыть расстояние в 42 км марафона";
        }

        private void forAirbus_pic_Click(object sender, EventArgs e)
        {
            picForSpeed_Distance.Image = Image.FromFile(@"Resourse\Create2\airbus.jpg");
            nameObject.Text = forAirbus_pic.Text;
            label18.Text = "Длина Airbus A380 73 м. Это займет 57 самолётов, чтобы покрыть расстояние в 42 км марафона";
        }

        private void footbal_pic_Click(object sender, EventArgs e)
        {
            picForSpeed_Distance.Image = Image.FromFile(@"Resourse\Create2\foot.jpg");
            nameObject.Text = forFootball_pic.Text;
            label18.Text = "Длина Football Field  105 м. Это займет 40 футбольных полей, чтобы покрыть расстояние в 42 км марафона";
        }

        private void forFootball_pic_Click(object sender, EventArgs e)
        {
            picForSpeed_Distance.Image = Image.FromFile(@"Resourse\Create2\foot.jpg");
            nameObject.Text = forFootball_pic.Text;
            label18.Text = "Длина Football Field  105 м. Это займет 40 футбольных полей, чтобы покрыть расстояние в 42 км марафона";
        }

        private void ronaldinho_Click(object sender, EventArgs e)
        {
            picForSpeed_Distance.Image = Image.FromFile(@"Resourse\Create2\ronaldinho.jpg");
            nameObject.Text = forRonaldinho_pic.Text;
            label18.Text = "Длина Ronaldinho 1.81 м. Это займет 2 тысячи 320  Ronaldinho, чтобы покрыть расстояние в 42 км марафона";
        }

        private void forRonaldinho_pic_Click(object sender, EventArgs e)
        {
            picForSpeed_Distance.Image = Image.FromFile(@"Resourse\Create2\ronaldinho.jpg");
            nameObject.Text = forRonaldinho_pic.Text;
            label18.Text = "Длина Ronaldinho 1.81 м. Это займет 2 тысячи 320  Ronaldinho, чтобы покрыть расстояние в 42 км марафона";
        }

        private void Back_n_Click(object sender, EventArgs e)
        {
            opacity.op = false;
            Close();
        }
    }
}
