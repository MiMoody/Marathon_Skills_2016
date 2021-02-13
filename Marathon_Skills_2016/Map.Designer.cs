namespace Marathon_Skills_2016
{
    partial class Map
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Map));
            this.Head = new System.Windows.Forms.Label();
            this.CheckPoint_1 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.forCheckPoint = new System.Windows.Forms.Label();
            this.picForDescription_1 = new System.Windows.Forms.PictureBox();
            this.picForDescription_2 = new System.Windows.Forms.PictureBox();
            this.Close = new System.Windows.Forms.Label();
            this.CheckPoint_2 = new System.Windows.Forms.Label();
            this.CheckPoint_3 = new System.Windows.Forms.Label();
            this.CheckPoint_4 = new System.Windows.Forms.Label();
            this.CheckPoint_5 = new System.Windows.Forms.Label();
            this.CheckPoint_6 = new System.Windows.Forms.Label();
            this.CheckPoint_7 = new System.Windows.Forms.Label();
            this.CheckPoint_8 = new System.Windows.Forms.Label();
            this.Finish = new System.Windows.Forms.Label();
            this.time_start_marathon = new System.Windows.Forms.Label();
            this.timerForStartMarathon = new System.Windows.Forms.Timer(this.components);
            this.Back_n = new Marathon_Skills_2016.RoundButton();
            this.picForDescription_3 = new System.Windows.Forms.PictureBox();
            this.picForDescription_4 = new System.Windows.Forms.PictureBox();
            this.picForDescription_5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picForDescription_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picForDescription_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picForDescription_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picForDescription_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picForDescription_5)).BeginInit();
            this.SuspendLayout();
            // 
            // Head
            // 
            this.Head.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Head.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Head.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Head.Location = new System.Drawing.Point(0, 1);
            this.Head.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Head.Name = "Head";
            this.Head.Size = new System.Drawing.Size(989, 49);
            this.Head.TabIndex = 2;
            this.Head.Text = "Интерактивная карта MARATHON SKILLS 2016";
            this.Head.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CheckPoint_1
            // 
            this.CheckPoint_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckPoint_1.Location = new System.Drawing.Point(328, 138);
            this.CheckPoint_1.Name = "CheckPoint_1";
            this.CheckPoint_1.Size = new System.Drawing.Size(52, 48);
            this.CheckPoint_1.TabIndex = 5;
            this.CheckPoint_1.Click += new System.EventHandler(this.CheckPoint_1_Click);
            // 
            // description
            // 
            this.description.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.description.Location = new System.Drawing.Point(628, 90);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(295, 166);
            this.description.TabIndex = 6;
            // 
            // forCheckPoint
            // 
            this.forCheckPoint.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.forCheckPoint.Location = new System.Drawing.Point(628, 67);
            this.forCheckPoint.Name = "forCheckPoint";
            this.forCheckPoint.Size = new System.Drawing.Size(294, 23);
            this.forCheckPoint.TabIndex = 7;
            this.forCheckPoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picForDescription_1
            // 
            this.picForDescription_1.BackColor = System.Drawing.SystemColors.Window;
            this.picForDescription_1.Location = new System.Drawing.Point(633, 270);
            this.picForDescription_1.Name = "picForDescription_1";
            this.picForDescription_1.Size = new System.Drawing.Size(140, 111);
            this.picForDescription_1.TabIndex = 8;
            this.picForDescription_1.TabStop = false;
            // 
            // picForDescription_2
            // 
            this.picForDescription_2.BackColor = System.Drawing.SystemColors.Window;
            this.picForDescription_2.Location = new System.Drawing.Point(785, 270);
            this.picForDescription_2.Name = "picForDescription_2";
            this.picForDescription_2.Size = new System.Drawing.Size(140, 111);
            this.picForDescription_2.TabIndex = 9;
            this.picForDescription_2.TabStop = false;
            // 
            // Close
            // 
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close.ForeColor = System.Drawing.Color.Red;
            this.Close.Location = new System.Drawing.Point(893, 67);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(30, 30);
            this.Close.TabIndex = 10;
            this.Close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // CheckPoint_2
            // 
            this.CheckPoint_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckPoint_2.Location = new System.Drawing.Point(380, 279);
            this.CheckPoint_2.Name = "CheckPoint_2";
            this.CheckPoint_2.Size = new System.Drawing.Size(52, 48);
            this.CheckPoint_2.TabIndex = 11;
            this.CheckPoint_2.Click += new System.EventHandler(this.CheckPoint_2_Click);
            // 
            // CheckPoint_3
            // 
            this.CheckPoint_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckPoint_3.Location = new System.Drawing.Point(370, 376);
            this.CheckPoint_3.Name = "CheckPoint_3";
            this.CheckPoint_3.Size = new System.Drawing.Size(52, 48);
            this.CheckPoint_3.TabIndex = 12;
            this.CheckPoint_3.Click += new System.EventHandler(this.CheckPoint_3_Click);
            // 
            // CheckPoint_4
            // 
            this.CheckPoint_4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckPoint_4.Location = new System.Drawing.Point(479, 481);
            this.CheckPoint_4.Name = "CheckPoint_4";
            this.CheckPoint_4.Size = new System.Drawing.Size(52, 48);
            this.CheckPoint_4.TabIndex = 13;
            this.CheckPoint_4.Click += new System.EventHandler(this.CheckPoint_4_Click);
            // 
            // CheckPoint_5
            // 
            this.CheckPoint_5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckPoint_5.Location = new System.Drawing.Point(299, 551);
            this.CheckPoint_5.Name = "CheckPoint_5";
            this.CheckPoint_5.Size = new System.Drawing.Size(52, 48);
            this.CheckPoint_5.TabIndex = 14;
            this.CheckPoint_5.Click += new System.EventHandler(this.CheckPoint_5_Click);
            // 
            // CheckPoint_6
            // 
            this.CheckPoint_6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckPoint_6.Location = new System.Drawing.Point(156, 504);
            this.CheckPoint_6.Name = "CheckPoint_6";
            this.CheckPoint_6.Size = new System.Drawing.Size(52, 48);
            this.CheckPoint_6.TabIndex = 15;
            this.CheckPoint_6.Click += new System.EventHandler(this.CheckPoint_6_Click);
            // 
            // CheckPoint_7
            // 
            this.CheckPoint_7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckPoint_7.Location = new System.Drawing.Point(120, 419);
            this.CheckPoint_7.Name = "CheckPoint_7";
            this.CheckPoint_7.Size = new System.Drawing.Size(52, 48);
            this.CheckPoint_7.TabIndex = 16;
            this.CheckPoint_7.Click += new System.EventHandler(this.CheckPoint_7_Click);
            // 
            // CheckPoint_8
            // 
            this.CheckPoint_8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckPoint_8.Location = new System.Drawing.Point(102, 270);
            this.CheckPoint_8.Name = "CheckPoint_8";
            this.CheckPoint_8.Size = new System.Drawing.Size(52, 48);
            this.CheckPoint_8.TabIndex = 17;
            this.CheckPoint_8.Click += new System.EventHandler(this.CheckPoint_8_Click);
            // 
            // Finish
            // 
            this.Finish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Finish.Location = new System.Drawing.Point(199, 138);
            this.Finish.Name = "Finish";
            this.Finish.Size = new System.Drawing.Size(32, 80);
            this.Finish.TabIndex = 18;
            this.Finish.Click += new System.EventHandler(this.Finish_Click);
            // 
            // time_start_marathon
            // 
            this.time_start_marathon.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.time_start_marathon.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time_start_marathon.ForeColor = System.Drawing.Color.Transparent;
            this.time_start_marathon.Location = new System.Drawing.Point(1, 655);
            this.time_start_marathon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.time_start_marathon.Name = "time_start_marathon";
            this.time_start_marathon.Size = new System.Drawing.Size(990, 28);
            this.time_start_marathon.TabIndex = 19;
            this.time_start_marathon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerForStartMarathon
            // 
            this.timerForStartMarathon.Tick += new System.EventHandler(this.timerForStartMarathon_Tick);
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
            this.Back_n.Location = new System.Drawing.Point(36, 12);
            this.Back_n.Name = "Back_n";
            this.Back_n.Size = new System.Drawing.Size(72, 27);
            this.Back_n.TabIndex = 20;
            this.Back_n.Text = "Назад";
            this.Back_n.Click += new System.EventHandler(this.Back_n_Click);
            // 
            // picForDescription_3
            // 
            this.picForDescription_3.BackColor = System.Drawing.SystemColors.Window;
            this.picForDescription_3.Location = new System.Drawing.Point(633, 387);
            this.picForDescription_3.Name = "picForDescription_3";
            this.picForDescription_3.Size = new System.Drawing.Size(140, 111);
            this.picForDescription_3.TabIndex = 22;
            this.picForDescription_3.TabStop = false;
            // 
            // picForDescription_4
            // 
            this.picForDescription_4.BackColor = System.Drawing.SystemColors.Window;
            this.picForDescription_4.Location = new System.Drawing.Point(785, 387);
            this.picForDescription_4.Name = "picForDescription_4";
            this.picForDescription_4.Size = new System.Drawing.Size(140, 111);
            this.picForDescription_4.TabIndex = 23;
            this.picForDescription_4.TabStop = false;
            // 
            // picForDescription_5
            // 
            this.picForDescription_5.BackColor = System.Drawing.SystemColors.Window;
            this.picForDescription_5.Location = new System.Drawing.Point(709, 504);
            this.picForDescription_5.Name = "picForDescription_5";
            this.picForDescription_5.Size = new System.Drawing.Size(140, 111);
            this.picForDescription_5.TabIndex = 24;
            this.picForDescription_5.TabStop = false;
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(989, 686);
            this.Controls.Add(this.picForDescription_5);
            this.Controls.Add(this.picForDescription_4);
            this.Controls.Add(this.picForDescription_3);
            this.Controls.Add(this.Back_n);
            this.Controls.Add(this.time_start_marathon);
            this.Controls.Add(this.Finish);
            this.Controls.Add(this.CheckPoint_8);
            this.Controls.Add(this.CheckPoint_7);
            this.Controls.Add(this.CheckPoint_6);
            this.Controls.Add(this.CheckPoint_5);
            this.Controls.Add(this.CheckPoint_4);
            this.Controls.Add(this.CheckPoint_3);
            this.Controls.Add(this.CheckPoint_2);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.picForDescription_2);
            this.Controls.Add(this.picForDescription_1);
            this.Controls.Add(this.forCheckPoint);
            this.Controls.Add(this.description);
            this.Controls.Add(this.CheckPoint_1);
            this.Controls.Add(this.Head);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Map";
            this.Text = "Marathon Skills 2016 - Interactive map";
            this.Load += new System.EventHandler(this.Map_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picForDescription_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picForDescription_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picForDescription_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picForDescription_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picForDescription_5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Head;
        private System.Windows.Forms.Label CheckPoint_1;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label forCheckPoint;
        private System.Windows.Forms.PictureBox picForDescription_1;
        private System.Windows.Forms.PictureBox picForDescription_2;
        private System.Windows.Forms.Label Close;
        private System.Windows.Forms.Label CheckPoint_2;
        private System.Windows.Forms.Label CheckPoint_3;
        private System.Windows.Forms.Label CheckPoint_4;
        private System.Windows.Forms.Label CheckPoint_5;
        private System.Windows.Forms.Label CheckPoint_6;
        private System.Windows.Forms.Label CheckPoint_7;
        private System.Windows.Forms.Label CheckPoint_8;
        private System.Windows.Forms.Label Finish;
        private System.Windows.Forms.Label time_start_marathon;
        private System.Windows.Forms.Timer timerForStartMarathon;
        private RoundButton Back_n;
        private System.Windows.Forms.PictureBox picForDescription_3;
        private System.Windows.Forms.PictureBox picForDescription_4;
        private System.Windows.Forms.PictureBox picForDescription_5;
    }
}