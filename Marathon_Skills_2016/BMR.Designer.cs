namespace Marathon_Skills_2016
{
    partial class BMR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BMR));
            this.Name_BMR = new System.Windows.Forms.Label();
            this.head = new System.Windows.Forms.Label();
            this.infoAboutBMR = new System.Windows.Forms.Label();
            this.gender_female = new System.Windows.Forms.Label();
            this.gender_male = new System.Windows.Forms.Label();
            this.checkMale = new System.Windows.Forms.CheckBox();
            this.checkFemale = new System.Windows.Forms.CheckBox();
            this.units_kg = new System.Windows.Forms.Label();
            this.units_cm = new System.Windows.Forms.Label();
            this.textWeight = new System.Windows.Forms.TextBox();
            this.textHeight = new System.Windows.Forms.TextBox();
            this.weight = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.Label();
            this.textAge = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.Label();
            this.lowExercises = new System.Windows.Forms.Label();
            this.Exercises1_3 = new System.Windows.Forms.Label();
            this.Exercises4_5 = new System.Windows.Forms.Label();
            this.Exercises_intence = new System.Windows.Forms.Label();
            this.Intense6_7 = new System.Windows.Forms.Label();
            this.Super_intense = new System.Windows.Forms.Label();
            this.forLowExercises = new System.Windows.Forms.Label();
            this.forExercises1_3 = new System.Windows.Forms.Label();
            this.forExercises4_5 = new System.Windows.Forms.Label();
            this.forExercises_intence = new System.Windows.Forms.Label();
            this.forIntense6_7 = new System.Windows.Forms.Label();
            this.forSuper_intense = new System.Windows.Forms.Label();
            this.BMR_lab = new System.Windows.Forms.Label();
            this.quantity_cal = new System.Windows.Forms.Label();
            this.designations = new System.Windows.Forms.Label();
            this.levelActive = new System.Windows.Forms.Label();
            this.calories = new System.Windows.Forms.Label();
            this.clockStartMarathon = new System.Windows.Forms.Label();
            this.timer_start_marathon = new System.Windows.Forms.Timer(this.components);
            this.Back_n = new Marathon_Skills_2016.RoundButton();
            this.calculate = new Marathon_Skills_2016.RoundButton();
            this.cancel = new Marathon_Skills_2016.RoundButton();
            this.SuspendLayout();
            // 
            // Name_BMR
            // 
            this.Name_BMR.AutoSize = true;
            this.Name_BMR.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_BMR.Location = new System.Drawing.Point(443, 58);
            this.Name_BMR.Name = "Name_BMR";
            this.Name_BMR.Size = new System.Drawing.Size(187, 29);
            this.Name_BMR.TabIndex = 16;
            this.Name_BMR.Text = "BMR калькулятор";
            // 
            // head
            // 
            this.head.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.head.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.head.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.head.Location = new System.Drawing.Point(1, -2);
            this.head.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(989, 49);
            this.head.TabIndex = 14;
            this.head.Text = "                MARATHON SKILLS 2016";
            this.head.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // infoAboutBMR
            // 
            this.infoAboutBMR.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoAboutBMR.Location = new System.Drawing.Point(13, 101);
            this.infoAboutBMR.Name = "infoAboutBMR";
            this.infoAboutBMR.Size = new System.Drawing.Size(964, 142);
            this.infoAboutBMR.TabIndex = 17;
            this.infoAboutBMR.Text = resources.GetString("infoAboutBMR.Text");
            // 
            // gender_female
            // 
            this.gender_female.AutoSize = true;
            this.gender_female.BackColor = System.Drawing.SystemColors.Control;
            this.gender_female.Location = new System.Drawing.Point(261, 343);
            this.gender_female.Name = "gender_female";
            this.gender_female.Size = new System.Drawing.Size(54, 13);
            this.gender_female.TabIndex = 34;
            this.gender_female.Text = "Женский";
            // 
            // gender_male
            // 
            this.gender_male.AutoSize = true;
            this.gender_male.BackColor = System.Drawing.SystemColors.Control;
            this.gender_male.Location = new System.Drawing.Point(147, 343);
            this.gender_male.Name = "gender_male";
            this.gender_male.Size = new System.Drawing.Size(53, 13);
            this.gender_male.TabIndex = 33;
            this.gender_male.Text = "Мужской";
            // 
            // checkMale
            // 
            this.checkMale.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkMale.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkMale.BackgroundImage")));
            this.checkMale.Location = new System.Drawing.Point(117, 246);
            this.checkMale.Name = "checkMale";
            this.checkMale.Size = new System.Drawing.Size(110, 116);
            this.checkMale.TabIndex = 41;
            this.checkMale.UseVisualStyleBackColor = true;
            this.checkMale.Click += new System.EventHandler(this.checkMale_Click);
            // 
            // checkFemale
            // 
            this.checkFemale.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkFemale.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkFemale.BackgroundImage")));
            this.checkFemale.Location = new System.Drawing.Point(233, 246);
            this.checkFemale.Name = "checkFemale";
            this.checkFemale.Size = new System.Drawing.Size(110, 116);
            this.checkFemale.TabIndex = 42;
            this.checkFemale.UseVisualStyleBackColor = true;
            this.checkFemale.Click += new System.EventHandler(this.checkFemale_Click);
            // 
            // units_kg
            // 
            this.units_kg.AutoSize = true;
            this.units_kg.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.units_kg.Location = new System.Drawing.Point(268, 433);
            this.units_kg.Name = "units_kg";
            this.units_kg.Size = new System.Drawing.Size(22, 18);
            this.units_kg.TabIndex = 40;
            this.units_kg.Text = "кг";
            // 
            // units_cm
            // 
            this.units_cm.AutoSize = true;
            this.units_cm.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.units_cm.Location = new System.Drawing.Point(267, 384);
            this.units_cm.Name = "units_cm";
            this.units_cm.Size = new System.Drawing.Size(27, 18);
            this.units_cm.TabIndex = 39;
            this.units_cm.Text = "см";
            // 
            // textWeight
            // 
            this.textWeight.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textWeight.Location = new System.Drawing.Point(203, 428);
            this.textWeight.Name = "textWeight";
            this.textWeight.Size = new System.Drawing.Size(61, 25);
            this.textWeight.TabIndex = 38;
            this.textWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textWeight.TextChanged += new System.EventHandler(this.textWeight_TextChanged);
            // 
            // textHeight
            // 
            this.textHeight.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textHeight.Location = new System.Drawing.Point(203, 382);
            this.textHeight.Name = "textHeight";
            this.textHeight.Size = new System.Drawing.Size(61, 25);
            this.textHeight.TabIndex = 37;
            this.textHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textHeight.TextChanged += new System.EventHandler(this.textHeight_TextChanged);
            // 
            // weight
            // 
            this.weight.AutoSize = true;
            this.weight.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weight.Location = new System.Drawing.Point(161, 433);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(40, 18);
            this.weight.TabIndex = 36;
            this.weight.Text = "Вес:";
            // 
            // height
            // 
            this.height.AutoSize = true;
            this.height.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.height.Location = new System.Drawing.Point(156, 385);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(45, 18);
            this.height.TabIndex = 35;
            this.height.Text = "Рост:";
            // 
            // textAge
            // 
            this.textAge.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textAge.Location = new System.Drawing.Point(203, 472);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(61, 25);
            this.textAge.TabIndex = 46;
            this.textAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.age.Location = new System.Drawing.Point(130, 476);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(70, 18);
            this.age.TabIndex = 45;
            this.age.Text = "Возраст:";
            // 
            // lowExercises
            // 
            this.lowExercises.AutoSize = true;
            this.lowExercises.Font = new System.Drawing.Font("Arial Narrow", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lowExercises.ForeColor = System.Drawing.Color.Blue;
            this.lowExercises.Location = new System.Drawing.Point(442, 322);
            this.lowExercises.Name = "lowExercises";
            this.lowExercises.Size = new System.Drawing.Size(270, 22);
            this.lowExercises.TabIndex = 47;
            this.lowExercises.Text = "Сидячий: мало или нет упражнений";
            // 
            // Exercises1_3
            // 
            this.Exercises1_3.AutoSize = true;
            this.Exercises1_3.Font = new System.Drawing.Font("Arial Narrow", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exercises1_3.ForeColor = System.Drawing.Color.LimeGreen;
            this.Exercises1_3.Location = new System.Drawing.Point(442, 355);
            this.Exercises1_3.Name = "Exercises1_3";
            this.Exercises1_3.Size = new System.Drawing.Size(227, 22);
            this.Exercises1_3.TabIndex = 48;
            this.Exercises1_3.Text = "Упражнения 1-3 раза в неделю";
            // 
            // Exercises4_5
            // 
            this.Exercises4_5.AutoSize = true;
            this.Exercises4_5.Font = new System.Drawing.Font("Arial Narrow", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exercises4_5.ForeColor = System.Drawing.Color.Green;
            this.Exercises4_5.Location = new System.Drawing.Point(442, 389);
            this.Exercises4_5.Name = "Exercises4_5";
            this.Exercises4_5.Size = new System.Drawing.Size(219, 22);
            this.Exercises4_5.TabIndex = 49;
            this.Exercises4_5.Text = "Упражнения 4-5 раз в неделю";
            // 
            // Exercises_intence
            // 
            this.Exercises_intence.Font = new System.Drawing.Font("Arial Narrow", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exercises_intence.ForeColor = System.Drawing.Color.Peru;
            this.Exercises_intence.Location = new System.Drawing.Point(442, 426);
            this.Exercises_intence.Name = "Exercises_intence";
            this.Exercises_intence.Size = new System.Drawing.Size(231, 44);
            this.Exercises_intence.TabIndex = 50;
            this.Exercises_intence.Text = "Ежедневные упражнения или интенсивные упражнения 3-4 раза в неделю\t";
            // 
            // Intense6_7
            // 
            this.Intense6_7.AutoSize = true;
            this.Intense6_7.Font = new System.Drawing.Font("Arial Narrow", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Intense6_7.ForeColor = System.Drawing.Color.IndianRed;
            this.Intense6_7.Location = new System.Drawing.Point(442, 487);
            this.Intense6_7.Name = "Intense6_7";
            this.Intense6_7.Size = new System.Drawing.Size(321, 22);
            this.Intense6_7.TabIndex = 51;
            this.Intense6_7.Text = "Интенсивные упражнения 6-7 раз в неделю";
            // 
            // Super_intense
            // 
            this.Super_intense.Font = new System.Drawing.Font("Arial Narrow", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Super_intense.ForeColor = System.Drawing.Color.Red;
            this.Super_intense.Location = new System.Drawing.Point(442, 521);
            this.Super_intense.Name = "Super_intense";
            this.Super_intense.Size = new System.Drawing.Size(231, 44);
            this.Super_intense.TabIndex = 52;
            this.Super_intense.Text = "Очень интенсивные упражнения ежедневно или физическая работа";
            // 
            // forLowExercises
            // 
            this.forLowExercises.AutoSize = true;
            this.forLowExercises.Font = new System.Drawing.Font("Arial Narrow", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.forLowExercises.ForeColor = System.Drawing.Color.Blue;
            this.forLowExercises.Location = new System.Drawing.Point(863, 321);
            this.forLowExercises.Name = "forLowExercises";
            this.forLowExercises.Size = new System.Drawing.Size(18, 22);
            this.forLowExercises.TabIndex = 53;
            this.forLowExercises.Text = "0";
            // 
            // forExercises1_3
            // 
            this.forExercises1_3.AutoSize = true;
            this.forExercises1_3.Font = new System.Drawing.Font("Arial Narrow", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.forExercises1_3.ForeColor = System.Drawing.Color.LimeGreen;
            this.forExercises1_3.Location = new System.Drawing.Point(863, 356);
            this.forExercises1_3.Name = "forExercises1_3";
            this.forExercises1_3.Size = new System.Drawing.Size(18, 22);
            this.forExercises1_3.TabIndex = 54;
            this.forExercises1_3.Text = "0";
            // 
            // forExercises4_5
            // 
            this.forExercises4_5.AutoSize = true;
            this.forExercises4_5.Font = new System.Drawing.Font("Arial Narrow", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.forExercises4_5.ForeColor = System.Drawing.Color.Green;
            this.forExercises4_5.Location = new System.Drawing.Point(863, 389);
            this.forExercises4_5.Name = "forExercises4_5";
            this.forExercises4_5.Size = new System.Drawing.Size(18, 22);
            this.forExercises4_5.TabIndex = 55;
            this.forExercises4_5.Text = "0";
            // 
            // forExercises_intence
            // 
            this.forExercises_intence.AutoSize = true;
            this.forExercises_intence.Font = new System.Drawing.Font("Arial Narrow", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.forExercises_intence.ForeColor = System.Drawing.Color.Peru;
            this.forExercises_intence.Location = new System.Drawing.Point(863, 434);
            this.forExercises_intence.Name = "forExercises_intence";
            this.forExercises_intence.Size = new System.Drawing.Size(18, 22);
            this.forExercises_intence.TabIndex = 56;
            this.forExercises_intence.Text = "0";
            // 
            // forIntense6_7
            // 
            this.forIntense6_7.AutoSize = true;
            this.forIntense6_7.Font = new System.Drawing.Font("Arial Narrow", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.forIntense6_7.ForeColor = System.Drawing.Color.IndianRed;
            this.forIntense6_7.Location = new System.Drawing.Point(863, 487);
            this.forIntense6_7.Name = "forIntense6_7";
            this.forIntense6_7.Size = new System.Drawing.Size(18, 22);
            this.forIntense6_7.TabIndex = 57;
            this.forIntense6_7.Text = "0";
            // 
            // forSuper_intense
            // 
            this.forSuper_intense.AutoSize = true;
            this.forSuper_intense.Font = new System.Drawing.Font("Arial Narrow", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.forSuper_intense.ForeColor = System.Drawing.Color.Red;
            this.forSuper_intense.Location = new System.Drawing.Point(863, 542);
            this.forSuper_intense.Name = "forSuper_intense";
            this.forSuper_intense.Size = new System.Drawing.Size(18, 22);
            this.forSuper_intense.TabIndex = 58;
            this.forSuper_intense.Text = "0";
            // 
            // BMR_lab
            // 
            this.BMR_lab.AutoSize = true;
            this.BMR_lab.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BMR_lab.ForeColor = System.Drawing.SystemColors.GrayText;
            this.BMR_lab.Location = new System.Drawing.Point(578, 243);
            this.BMR_lab.Name = "BMR_lab";
            this.BMR_lab.Size = new System.Drawing.Size(76, 23);
            this.BMR_lab.TabIndex = 59;
            this.BMR_lab.Text = "BMR = ";
            // 
            // quantity_cal
            // 
            this.quantity_cal.AutoSize = true;
            this.quantity_cal.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantity_cal.ForeColor = System.Drawing.SystemColors.GrayText;
            this.quantity_cal.Location = new System.Drawing.Point(659, 243);
            this.quantity_cal.Name = "quantity_cal";
            this.quantity_cal.Size = new System.Drawing.Size(21, 23);
            this.quantity_cal.TabIndex = 60;
            this.quantity_cal.Text = "0";
            // 
            // designations
            // 
            this.designations.AutoSize = true;
            this.designations.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.designations.ForeColor = System.Drawing.SystemColors.GrayText;
            this.designations.Location = new System.Drawing.Point(715, 243);
            this.designations.Name = "designations";
            this.designations.Size = new System.Drawing.Size(156, 23);
            this.designations.TabIndex = 61;
            this.designations.Text = "Каллорий\\день";
            // 
            // levelActive
            // 
            this.levelActive.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.levelActive.Location = new System.Drawing.Point(448, 285);
            this.levelActive.Name = "levelActive";
            this.levelActive.Size = new System.Drawing.Size(315, 23);
            this.levelActive.TabIndex = 62;
            this.levelActive.Text = "Уровень активности ";
            this.levelActive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calories
            // 
            this.calories.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calories.Location = new System.Drawing.Point(797, 285);
            this.calories.Name = "calories";
            this.calories.Size = new System.Drawing.Size(180, 23);
            this.calories.TabIndex = 63;
            this.calories.Text = "Каллории";
            this.calories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clockStartMarathon
            // 
            this.clockStartMarathon.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clockStartMarathon.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clockStartMarathon.ForeColor = System.Drawing.Color.Transparent;
            this.clockStartMarathon.Location = new System.Drawing.Point(0, 659);
            this.clockStartMarathon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.clockStartMarathon.Name = "clockStartMarathon";
            this.clockStartMarathon.Size = new System.Drawing.Size(990, 28);
            this.clockStartMarathon.TabIndex = 64;
            this.clockStartMarathon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer_start_marathon
            // 
            this.timer_start_marathon.Tick += new System.EventHandler(this.timer_start_marathon_Tick);
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
            this.Back_n.Location = new System.Drawing.Point(12, 12);
            this.Back_n.Name = "Back_n";
            this.Back_n.Size = new System.Drawing.Size(72, 27);
            this.Back_n.TabIndex = 65;
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
            this.calculate.Location = new System.Drawing.Point(117, 518);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(116, 46);
            this.calculate.TabIndex = 66;
            this.calculate.Text = "Рассчитать";
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.Gainsboro;
            this.cancel.BackColor2 = System.Drawing.Color.Silver;
            this.cancel.ButtonBorderColor = System.Drawing.Color.Black;
            this.cancel.ButtonHighlightColor = System.Drawing.Color.Linen;
            this.cancel.ButtonHighlightColor2 = System.Drawing.Color.Silver;
            this.cancel.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.cancel.ButtonPressedColor = System.Drawing.Color.DarkGray;
            this.cancel.ButtonPressedColor2 = System.Drawing.Color.DarkGray;
            this.cancel.ButtonPressedForeColor = System.Drawing.Color.White;
            this.cancel.ButtonRoundRadius = 30;
            this.cancel.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancel.Location = new System.Drawing.Point(239, 518);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(116, 46);
            this.cancel.TabIndex = 67;
            this.cancel.Text = "Отмена";
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // BMR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 686);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.Back_n);
            this.Controls.Add(this.clockStartMarathon);
            this.Controls.Add(this.calories);
            this.Controls.Add(this.levelActive);
            this.Controls.Add(this.designations);
            this.Controls.Add(this.quantity_cal);
            this.Controls.Add(this.BMR_lab);
            this.Controls.Add(this.forSuper_intense);
            this.Controls.Add(this.forIntense6_7);
            this.Controls.Add(this.forExercises_intence);
            this.Controls.Add(this.forExercises4_5);
            this.Controls.Add(this.forExercises1_3);
            this.Controls.Add(this.forLowExercises);
            this.Controls.Add(this.Super_intense);
            this.Controls.Add(this.Intense6_7);
            this.Controls.Add(this.Exercises_intence);
            this.Controls.Add(this.Exercises4_5);
            this.Controls.Add(this.Exercises1_3);
            this.Controls.Add(this.lowExercises);
            this.Controls.Add(this.textAge);
            this.Controls.Add(this.age);
            this.Controls.Add(this.gender_female);
            this.Controls.Add(this.gender_male);
            this.Controls.Add(this.checkMale);
            this.Controls.Add(this.checkFemale);
            this.Controls.Add(this.units_kg);
            this.Controls.Add(this.units_cm);
            this.Controls.Add(this.textWeight);
            this.Controls.Add(this.textHeight);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.height);
            this.Controls.Add(this.infoAboutBMR);
            this.Controls.Add(this.Name_BMR);
            this.Controls.Add(this.head);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BMR";
            this.Text = "Marathon Skills 2016 - BMR calculator";
            this.Load += new System.EventHandler(this.BMR_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name_BMR;
        private System.Windows.Forms.Label head;
        private System.Windows.Forms.Label infoAboutBMR;
        private System.Windows.Forms.Label gender_female;
        private System.Windows.Forms.Label gender_male;
        private System.Windows.Forms.CheckBox checkMale;
        private System.Windows.Forms.CheckBox checkFemale;
        private System.Windows.Forms.Label units_kg;
        private System.Windows.Forms.Label units_cm;
        private System.Windows.Forms.TextBox textWeight;
        private System.Windows.Forms.TextBox textHeight;
        private System.Windows.Forms.Label weight;
        private System.Windows.Forms.Label height;
        private System.Windows.Forms.TextBox textAge;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label lowExercises;
        private System.Windows.Forms.Label Exercises1_3;
        private System.Windows.Forms.Label Exercises4_5;
        private System.Windows.Forms.Label Exercises_intence;
        private System.Windows.Forms.Label Intense6_7;
        private System.Windows.Forms.Label Super_intense;
        private System.Windows.Forms.Label forLowExercises;
        private System.Windows.Forms.Label forExercises1_3;
        private System.Windows.Forms.Label forExercises4_5;
        private System.Windows.Forms.Label forExercises_intence;
        private System.Windows.Forms.Label forIntense6_7;
        private System.Windows.Forms.Label forSuper_intense;
        private System.Windows.Forms.Label BMR_lab;
        private System.Windows.Forms.Label quantity_cal;
        private System.Windows.Forms.Label designations;
        private System.Windows.Forms.Label levelActive;
        private System.Windows.Forms.Label calories;
        private System.Windows.Forms.Label clockStartMarathon;
        private System.Windows.Forms.Timer timer_start_marathon;
        private RoundButton Back_n;
        private RoundButton calculate;
        private RoundButton cancel;
    }
}