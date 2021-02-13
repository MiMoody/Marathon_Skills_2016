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
    public partial class BMR : Form
    {
        public BMR()
        {
            InitializeComponent();
        }

        private void BMR_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(200, 50);
            this.ControlBox = false;
            timer_start_marathon.Start();
            forExercises1_3.BackColor = Color.Transparent;
            checkMale.BackColor = Color.FromArgb(235, 235, 235, 235);
            checkFemale.BackColor = Color.FromArgb(235, 235, 235, 235);
            this.gender_male.BackColor = Color.FromArgb(235, 235, 235, 235);
            this.gender_female.BackColor = Color.FromArgb(235, 235, 235, 235);
            checkMale.Checked = true;
        }

        

        

        private void timer_start_marathon_Tick(object sender, EventArgs e)
        {

            if (timer_start_marathon.Interval == 1)
            {
                timer_start_marathon.Interval = 3;
            }
            clockStartMarathon.Text = DateTimeTickcs.date;
        }

        private void checkMale_Click(object sender, EventArgs e)
        {
            checkFemale.Checked = false;
            checkMale.Checked = true;
        }

        private void checkFemale_Click(object sender, EventArgs e)
        {
            checkMale.Checked = false;
            checkFemale.Checked = true;
        }

        private void textHeight_TextChanged(object sender, EventArgs e)
        {
            textHeight.MaxLength = 3;
        }

        private void textWeight_TextChanged(object sender, EventArgs e)
        {
            textWeight.MaxLength = 3;
        }

        private void Back_n_Click(object sender, EventArgs e)
        {
            opacity.op = false;
            Close();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            int bmr = 0;
            if (checkMale.Checked)
            {
                bmr = Convert.ToInt32(Math.Round(13.397 * int.Parse(textWeight.Text) + 4.799 * int.Parse(textHeight.Text) - 5.677 * int.Parse(textAge.Text) + 88.362));
                quantity_cal.Text = Convert.ToString(bmr);
            }
            if (checkFemale.Checked)
            {
                bmr = Convert.ToInt32(Math.Round(9.247 * int.Parse(textWeight.Text) + 3.098 * int.Parse(textHeight.Text) - 4.330 * int.Parse(textAge.Text) + 447.593));
                quantity_cal.Text = Convert.ToString(bmr);
            }
            forLowExercises.Text = Convert.ToString(Math.Round(bmr + bmr * 19.9 / 100));
            forExercises1_3.Text = Convert.ToString(Math.Round(bmr + bmr * 37.5 / 100));
            forExercises4_5.Text = Convert.ToString(Math.Round(bmr + bmr * 46.5 / 100));
            forExercises_intence.Text = Convert.ToString(Math.Round(bmr + bmr * 54.9 / 100));
            forIntense6_7.Text = Convert.ToString(Math.Round(bmr + bmr * 72.5 / 100));
            forSuper_intense.Text = Convert.ToString(Math.Round(bmr + bmr * 89.9 / 100));
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            forLowExercises.Text = "";
            forExercises1_3.Text = "";
            forExercises4_5.Text = "";
            forExercises_intence.Text = "";
            forIntense6_7.Text = "";
            forSuper_intense.Text = "";
            quantity_cal.Text = "";
            textHeight.Text = "";
            textWeight.Text = "";
            textAge.Text = "";
            checkMale.Checked = true;
            checkFemale.Checked = false;
        }
    }
}
