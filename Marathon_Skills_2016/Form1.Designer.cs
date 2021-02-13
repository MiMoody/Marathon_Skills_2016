namespace Marathon_Skills_2016
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.head = new System.Windows.Forms.Label();
            this.clock = new System.Windows.Forms.Label();
            this.infoabout = new System.Windows.Forms.Label();
            this.forOpacity = new System.Windows.Forms.Timer(this.components);
            this.clock_for_start = new System.Windows.Forms.Timer(this.components);
            this.MarSkills2016 = new Marathon_Skills_2016.RoundButton();
            this.How_Long = new Marathon_Skills_2016.RoundButton();
            this.calcBMI = new Marathon_Skills_2016.RoundButton();
            this.calcBMR = new Marathon_Skills_2016.RoundButton();
            this.SuspendLayout();
            // 
            // head
            // 
            this.head.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.head.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.head.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.head.Location = new System.Drawing.Point(0, 0);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(1317, 60);
            this.head.TabIndex = 0;
            this.head.Text = "                                     MARATHON SKILLS 2016";
            this.head.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // clock
            // 
            this.clock.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clock.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clock.ForeColor = System.Drawing.Color.Transparent;
            this.clock.Location = new System.Drawing.Point(1, 809);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(1320, 34);
            this.clock.TabIndex = 1;
            this.clock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoabout
            // 
            this.infoabout.AutoSize = true;
            this.infoabout.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoabout.Location = new System.Drawing.Point(395, 73);
            this.infoabout.Name = "infoabout";
            this.infoabout.Size = new System.Drawing.Size(570, 33);
            this.infoabout.TabIndex = 2;
            this.infoabout.Text = "Информация о MARATHON SKILLS 2016";
            // 
            // forOpacity
            // 
            this.forOpacity.Tick += new System.EventHandler(this.forOpacity_Tick);
            // 
            // clock_for_start
            // 
            this.clock_for_start.Tick += new System.EventHandler(this.clock_for_start_Tick);
            // 
            // MarSkills2016
            // 
            this.MarSkills2016.BackColor = System.Drawing.Color.Gainsboro;
            this.MarSkills2016.BackColor2 = System.Drawing.Color.Silver;
            this.MarSkills2016.ButtonBorderColor = System.Drawing.Color.Black;
            this.MarSkills2016.ButtonHighlightColor = System.Drawing.Color.Linen;
            this.MarSkills2016.ButtonHighlightColor2 = System.Drawing.Color.Silver;
            this.MarSkills2016.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.MarSkills2016.ButtonPressedColor = System.Drawing.Color.DarkGray;
            this.MarSkills2016.ButtonPressedColor2 = System.Drawing.Color.DarkGray;
            this.MarSkills2016.ButtonPressedForeColor = System.Drawing.Color.White;
            this.MarSkills2016.ButtonRoundRadius = 30;
            this.MarSkills2016.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MarSkills2016.Location = new System.Drawing.Point(144, 273);
            this.MarSkills2016.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MarSkills2016.Name = "MarSkills2016";
            this.MarSkills2016.Size = new System.Drawing.Size(493, 98);
            this.MarSkills2016.TabIndex = 8;
            this.MarSkills2016.Text = "Marathon Skills 2016";
            this.MarSkills2016.Click += new System.EventHandler(this.MarSkills2016_Click_1);
            // 
            // How_Long
            // 
            this.How_Long.BackColor = System.Drawing.Color.Gainsboro;
            this.How_Long.BackColor2 = System.Drawing.Color.Silver;
            this.How_Long.ButtonBorderColor = System.Drawing.Color.Black;
            this.How_Long.ButtonHighlightColor = System.Drawing.Color.Linen;
            this.How_Long.ButtonHighlightColor2 = System.Drawing.Color.Silver;
            this.How_Long.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.How_Long.ButtonPressedColor = System.Drawing.Color.DarkGray;
            this.How_Long.ButtonPressedColor2 = System.Drawing.Color.DarkGray;
            this.How_Long.ButtonPressedForeColor = System.Drawing.Color.White;
            this.How_Long.ButtonRoundRadius = 30;
            this.How_Long.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.How_Long.Location = new System.Drawing.Point(661, 273);
            this.How_Long.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.How_Long.Name = "How_Long";
            this.How_Long.Size = new System.Drawing.Size(493, 98);
            this.How_Long.TabIndex = 9;
            this.How_Long.Text = "Насколько долгий марафон ";
            this.How_Long.Click += new System.EventHandler(this.How_Long_Click);
            // 
            // calcBMI
            // 
            this.calcBMI.BackColor = System.Drawing.Color.Gainsboro;
            this.calcBMI.BackColor2 = System.Drawing.Color.Silver;
            this.calcBMI.ButtonBorderColor = System.Drawing.Color.Black;
            this.calcBMI.ButtonHighlightColor = System.Drawing.Color.Linen;
            this.calcBMI.ButtonHighlightColor2 = System.Drawing.Color.Silver;
            this.calcBMI.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.calcBMI.ButtonPressedColor = System.Drawing.Color.DarkGray;
            this.calcBMI.ButtonPressedColor2 = System.Drawing.Color.DarkGray;
            this.calcBMI.ButtonPressedForeColor = System.Drawing.Color.White;
            this.calcBMI.ButtonRoundRadius = 30;
            this.calcBMI.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calcBMI.Location = new System.Drawing.Point(144, 399);
            this.calcBMI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.calcBMI.Name = "calcBMI";
            this.calcBMI.Size = new System.Drawing.Size(493, 98);
            this.calcBMI.TabIndex = 10;
            this.calcBMI.Text = "BMI калькулятор ";
            this.calcBMI.Click += new System.EventHandler(this.calcBMI_Click);
            // 
            // calcBMR
            // 
            this.calcBMR.BackColor = System.Drawing.Color.Gainsboro;
            this.calcBMR.BackColor2 = System.Drawing.Color.Silver;
            this.calcBMR.ButtonBorderColor = System.Drawing.Color.Black;
            this.calcBMR.ButtonHighlightColor = System.Drawing.Color.Linen;
            this.calcBMR.ButtonHighlightColor2 = System.Drawing.Color.Silver;
            this.calcBMR.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.calcBMR.ButtonPressedColor = System.Drawing.Color.DarkGray;
            this.calcBMR.ButtonPressedColor2 = System.Drawing.Color.DarkGray;
            this.calcBMR.ButtonPressedForeColor = System.Drawing.Color.White;
            this.calcBMR.ButtonRoundRadius = 30;
            this.calcBMR.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calcBMR.Location = new System.Drawing.Point(661, 399);
            this.calcBMR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.calcBMR.Name = "calcBMR";
            this.calcBMR.Size = new System.Drawing.Size(493, 98);
            this.calcBMR.TabIndex = 11;
            this.calcBMR.Text = "BMR калькулятор ";
            this.calcBMR.Click += new System.EventHandler(this.calcBMR_Click);
            // 
            // Menu
            // 
            this.AccessibleDescription = "";
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 844);
            this.Controls.Add(this.calcBMR);
            this.Controls.Add(this.calcBMI);
            this.Controls.Add(this.How_Long);
            this.Controls.Add(this.MarSkills2016);
            this.Controls.Add(this.infoabout);
            this.Controls.Add(this.clock);
            this.Controls.Add(this.head);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Menu";
            this.Text = "Marathon Skills 2016 - Find Out more information";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label head;
        private System.Windows.Forms.Label clock;
        private System.Windows.Forms.Label infoabout;
        private System.Windows.Forms.Timer forOpacity;
        private System.Windows.Forms.Timer clock_for_start;
        private RoundButton MarSkills2016;
        private RoundButton How_Long;
        private RoundButton calcBMI;
        private RoundButton calcBMR;
    }
}

