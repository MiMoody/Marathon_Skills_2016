namespace Marathon_Skills_2016
{
    partial class BMI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BMI));
            this.Head = new System.Windows.Forms.Label();
            this.timeForStartMarathon = new System.Windows.Forms.Label();
            this.nameBMI = new System.Windows.Forms.Label();
            this.infoAboutBMI = new System.Windows.Forms.Label();
            this.gender_male = new System.Windows.Forms.Label();
            this.gender_female = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.Label();
            this.text_height = new System.Windows.Forms.TextBox();
            this.text_weight = new System.Windows.Forms.TextBox();
            this.units_kg = new System.Windows.Forms.Label();
            this.units_cm = new System.Windows.Forms.Label();
            this.checkMale = new System.Windows.Forms.CheckBox();
            this.checkFemale = new System.Windows.Forms.CheckBox();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.health_picture = new System.Windows.Forms.PictureBox();
            this.body_viev = new System.Windows.Forms.PictureBox();
            this.figures = new System.Windows.Forms.Label();
            this.health = new System.Windows.Forms.Label();
            this.ClockForStart = new System.Windows.Forms.Timer(this.components);
            this.Back_n = new Marathon_Skills_2016.RoundButton();
            this.calculate = new Marathon_Skills_2016.RoundButton();
            this.Cancel = new Marathon_Skills_2016.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.health_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.body_viev)).BeginInit();
            this.SuspendLayout();
            // 
            // Head
            // 
            this.Head.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Head.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Head.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Head.Location = new System.Drawing.Point(-4, 1);
            this.Head.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Head.Name = "Head";
            this.Head.Size = new System.Drawing.Size(989, 49);
            this.Head.TabIndex = 2;
            this.Head.Text = "                               MARATHON SKILLS 2016";
            this.Head.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timeForStartMarathon
            // 
            this.timeForStartMarathon.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.timeForStartMarathon.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeForStartMarathon.ForeColor = System.Drawing.Color.Transparent;
            this.timeForStartMarathon.Location = new System.Drawing.Point(-4, 658);
            this.timeForStartMarathon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeForStartMarathon.Name = "timeForStartMarathon";
            this.timeForStartMarathon.Size = new System.Drawing.Size(990, 28);
            this.timeForStartMarathon.TabIndex = 12;
            this.timeForStartMarathon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameBMI
            // 
            this.nameBMI.AutoSize = true;
            this.nameBMI.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameBMI.Location = new System.Drawing.Point(438, 61);
            this.nameBMI.Name = "nameBMI";
            this.nameBMI.Size = new System.Drawing.Size(178, 29);
            this.nameBMI.TabIndex = 13;
            this.nameBMI.Text = "BMI калькулятор";
            // 
            // infoAboutBMI
            // 
            this.infoAboutBMI.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoAboutBMI.Location = new System.Drawing.Point(12, 113);
            this.infoAboutBMI.Name = "infoAboutBMI";
            this.infoAboutBMI.Size = new System.Drawing.Size(552, 195);
            this.infoAboutBMI.TabIndex = 14;
            this.infoAboutBMI.Text = resources.GetString("infoAboutBMI.Text");
            // 
            // gender_male
            // 
            this.gender_male.AutoSize = true;
            this.gender_male.BackColor = System.Drawing.SystemColors.Control;
            this.gender_male.Location = new System.Drawing.Point(97, 396);
            this.gender_male.Name = "gender_male";
            this.gender_male.Size = new System.Drawing.Size(53, 13);
            this.gender_male.TabIndex = 17;
            this.gender_male.Text = "Мужской";
            // 
            // gender_female
            // 
            this.gender_female.AutoSize = true;
            this.gender_female.BackColor = System.Drawing.SystemColors.Control;
            this.gender_female.Location = new System.Drawing.Point(211, 396);
            this.gender_female.Name = "gender_female";
            this.gender_female.Size = new System.Drawing.Size(54, 13);
            this.gender_female.TabIndex = 18;
            this.gender_female.Text = "Женский";
            // 
            // height
            // 
            this.height.AutoSize = true;
            this.height.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.height.Location = new System.Drawing.Point(106, 438);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(45, 18);
            this.height.TabIndex = 19;
            this.height.Text = "Рост:";
            // 
            // weight
            // 
            this.weight.AutoSize = true;
            this.weight.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weight.Location = new System.Drawing.Point(111, 478);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(40, 18);
            this.weight.TabIndex = 20;
            this.weight.Text = "Вес:";
            // 
            // text_height
            // 
            this.text_height.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_height.Location = new System.Drawing.Point(153, 435);
            this.text_height.Name = "text_height";
            this.text_height.Size = new System.Drawing.Size(61, 25);
            this.text_height.TabIndex = 21;
            this.text_height.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_height.TextChanged += new System.EventHandler(this.text_height_TextChanged);
            // 
            // text_weight
            // 
            this.text_weight.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_weight.Location = new System.Drawing.Point(153, 473);
            this.text_weight.Name = "text_weight";
            this.text_weight.Size = new System.Drawing.Size(61, 25);
            this.text_weight.TabIndex = 22;
            this.text_weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_weight.TextChanged += new System.EventHandler(this.text_weight_TextChanged);
            // 
            // units_kg
            // 
            this.units_kg.AutoSize = true;
            this.units_kg.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.units_kg.Location = new System.Drawing.Point(218, 478);
            this.units_kg.Name = "units_kg";
            this.units_kg.Size = new System.Drawing.Size(22, 18);
            this.units_kg.TabIndex = 24;
            this.units_kg.Text = "кг";
            // 
            // units_cm
            // 
            this.units_cm.AutoSize = true;
            this.units_cm.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.units_cm.Location = new System.Drawing.Point(217, 437);
            this.units_cm.Name = "units_cm";
            this.units_cm.Size = new System.Drawing.Size(27, 18);
            this.units_cm.TabIndex = 23;
            this.units_cm.Text = "см";
            // 
            // checkMale
            // 
            this.checkMale.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkMale.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkMale.BackgroundImage")));
            this.checkMale.Location = new System.Drawing.Point(67, 299);
            this.checkMale.Name = "checkMale";
            this.checkMale.Size = new System.Drawing.Size(110, 116);
            this.checkMale.TabIndex = 25;
            this.checkMale.UseVisualStyleBackColor = true;
            this.checkMale.CheckedChanged += new System.EventHandler(this.checkMale_CheckedChanged);
            // 
            // checkFemale
            // 
            this.checkFemale.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkFemale.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkFemale.BackgroundImage")));
            this.checkFemale.Location = new System.Drawing.Point(183, 299);
            this.checkFemale.Name = "checkFemale";
            this.checkFemale.Size = new System.Drawing.Size(110, 116);
            this.checkFemale.TabIndex = 26;
            this.checkFemale.UseVisualStyleBackColor = true;
            this.checkFemale.CheckedChanged += new System.EventHandler(this.checkFemale_CheckedChanged);
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(502, 460);
            this.trackBar.Maximum = 35;
            this.trackBar.Minimum = 13;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(467, 45);
            this.trackBar.TabIndex = 27;
            this.trackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar.Value = 20;
            // 
            // health_picture
            // 
            this.health_picture.BackColor = System.Drawing.SystemColors.Control;
            this.health_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.health_picture.Image = ((System.Drawing.Image)(resources.GetObject("health_picture.Image")));
            this.health_picture.Location = new System.Drawing.Point(615, 113);
            this.health_picture.Name = "health_picture";
            this.health_picture.Size = new System.Drawing.Size(253, 302);
            this.health_picture.TabIndex = 28;
            this.health_picture.TabStop = false;
            // 
            // body_viev
            // 
            this.body_viev.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("body_viev.BackgroundImage")));
            this.body_viev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.body_viev.Location = new System.Drawing.Point(502, 483);
            this.body_viev.Name = "body_viev";
            this.body_viev.Size = new System.Drawing.Size(459, 134);
            this.body_viev.TabIndex = 29;
            this.body_viev.TabStop = false;
            // 
            // figures
            // 
            this.figures.AutoSize = true;
            this.figures.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.figures.Location = new System.Drawing.Point(735, 426);
            this.figures.Name = "figures";
            this.figures.Size = new System.Drawing.Size(27, 19);
            this.figures.TabIndex = 30;
            this.figures.Text = "20";
            // 
            // health
            // 
            this.health.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.health.Location = new System.Drawing.Point(636, 376);
            this.health.Name = "health";
            this.health.Size = new System.Drawing.Size(216, 23);
            this.health.TabIndex = 33;
            this.health.Text = "Здоровый";
            this.health.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClockForStart
            // 
            this.ClockForStart.Tick += new System.EventHandler(this.ClockForStart_Tick);
            // 
            // Back_n
            // 
            this.Back_n.BackColor = System.Drawing.Color.Gainsboro;
            this.Back_n.BackColor2 = System.Drawing.Color.Silver;
            this.Back_n.ButtonBorderColor = System.Drawing.Color.Black;
            this.Back_n.ButtonHighlightColor = System.Drawing.Color.Linen;
            this.Back_n.ButtonHighlightColor2 = System.Drawing.Color.Silver;
            this.Back_n.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.Back_n.ButtonPressedColor = System.Drawing.Color.DarkGray;
            this.Back_n.ButtonPressedColor2 = System.Drawing.Color.DarkGray;
            this.Back_n.ButtonPressedForeColor = System.Drawing.Color.White;
            this.Back_n.ButtonRoundRadius = 30;
            this.Back_n.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back_n.Location = new System.Drawing.Point(26, 12);
            this.Back_n.Name = "Back_n";
            this.Back_n.Size = new System.Drawing.Size(72, 27);
            this.Back_n.TabIndex = 34;
            this.Back_n.Text = "Назад";
            this.Back_n.Click += new System.EventHandler(this.Back_n_Click);
            // 
            // calculate
            // 
            this.calculate.BackColor = System.Drawing.Color.Gainsboro;
            this.calculate.BackColor2 = System.Drawing.Color.Silver;
            this.calculate.ButtonBorderColor = System.Drawing.Color.Black;
            this.calculate.ButtonHighlightColor = System.Drawing.Color.Linen;
            this.calculate.ButtonHighlightColor2 = System.Drawing.Color.Silver;
            this.calculate.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.calculate.ButtonPressedColor = System.Drawing.Color.DarkGray;
            this.calculate.ButtonPressedColor2 = System.Drawing.Color.DarkGray;
            this.calculate.ButtonPressedForeColor = System.Drawing.Color.White;
            this.calculate.ButtonRoundRadius = 30;
            this.calculate.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculate.Location = new System.Drawing.Point(61, 518);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(116, 46);
            this.calculate.TabIndex = 67;
            this.calculate.Text = "Рассчитать";
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.Gainsboro;
            this.Cancel.BackColor2 = System.Drawing.Color.Silver;
            this.Cancel.ButtonBorderColor = System.Drawing.Color.Black;
            this.Cancel.ButtonHighlightColor = System.Drawing.Color.Linen;
            this.Cancel.ButtonHighlightColor2 = System.Drawing.Color.Silver;
            this.Cancel.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.Cancel.ButtonPressedColor = System.Drawing.Color.DarkGray;
            this.Cancel.ButtonPressedColor2 = System.Drawing.Color.DarkGray;
            this.Cancel.ButtonPressedForeColor = System.Drawing.Color.White;
            this.Cancel.ButtonRoundRadius = 30;
            this.Cancel.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel.Location = new System.Drawing.Point(192, 518);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(116, 46);
            this.Cancel.TabIndex = 68;
            this.Cancel.Text = "Отмена";
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // BMI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 686);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.Back_n);
            this.Controls.Add(this.health);
            this.Controls.Add(this.figures);
            this.Controls.Add(this.body_viev);
            this.Controls.Add(this.health_picture);
            this.Controls.Add(this.gender_female);
            this.Controls.Add(this.gender_male);
            this.Controls.Add(this.checkMale);
            this.Controls.Add(this.checkFemale);
            this.Controls.Add(this.units_kg);
            this.Controls.Add(this.units_cm);
            this.Controls.Add(this.text_weight);
            this.Controls.Add(this.text_height);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.height);
            this.Controls.Add(this.infoAboutBMI);
            this.Controls.Add(this.nameBMI);
            this.Controls.Add(this.timeForStartMarathon);
            this.Controls.Add(this.Head);
            this.Controls.Add(this.trackBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BMI";
            this.Text = "Marathon Skills 2016 - BMI calculator ";
            this.Load += new System.EventHandler(this.BMI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.health_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.body_viev)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Head;
        private System.Windows.Forms.Label timeForStartMarathon;
        private System.Windows.Forms.Label nameBMI;
        private System.Windows.Forms.Label infoAboutBMI;
        private System.Windows.Forms.Label gender_male;
        private System.Windows.Forms.Label gender_female;
        private System.Windows.Forms.Label height;
        private System.Windows.Forms.Label weight;
        private System.Windows.Forms.TextBox text_height;
        private System.Windows.Forms.TextBox text_weight;
        private System.Windows.Forms.Label units_kg;
        private System.Windows.Forms.Label units_cm;
        private System.Windows.Forms.CheckBox checkMale;
        private System.Windows.Forms.CheckBox checkFemale;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.PictureBox health_picture;
        private System.Windows.Forms.PictureBox body_viev;
        private System.Windows.Forms.Label figures;
        private System.Windows.Forms.Label health;
        private System.Windows.Forms.Timer ClockForStart;
        private RoundButton Back_n;
        private RoundButton calculate;
        private RoundButton Cancel;
    }
}