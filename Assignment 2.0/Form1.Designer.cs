namespace Assignment_2._0
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CourseListBox = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.BannerOne = new System.Windows.Forms.PictureBox();
            this.SelectCourseTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CourseMenuGroupBox = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.LocationGroupBox = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.LocationListBox = new System.Windows.Forms.ListBox();
            this.ParticipantGroupBox = new System.Windows.Forms.GroupBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.RoomGroupBox = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BannerOne)).BeginInit();
            this.CourseMenuGroupBox.SuspendLayout();
            this.LocationGroupBox.SuspendLayout();
            this.ParticipantGroupBox.SuspendLayout();
            this.RoomGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CourseListBox
            // 
            this.CourseListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CourseListBox.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.CourseListBox.FormattingEnabled = true;
            this.CourseListBox.ItemHeight = 30;
            this.CourseListBox.Items.AddRange(new object[] {
            "C# fundamentals           \t| 2 Days\t| €900                   ",
            " C# Basics for Beginners\t| 4 Days\t| €1,500              ",
            " C# Intermediate            \t| 4 Days\t| €1,800             ",
            " ASP.NET with C# Part A\t| 5 Days\t|€1,250              ",
            " ASP.NET with C# Part B\t| 5 Days\t|€1,250           "});
            this.CourseListBox.Location = new System.Drawing.Point(8, 191);
            this.CourseListBox.Name = "CourseListBox";
            this.CourseListBox.Size = new System.Drawing.Size(567, 152);
            this.CourseListBox.TabIndex = 0;
            // 
            // BannerOne
            // 
            this.BannerOne.Image = ((System.Drawing.Image)(resources.GetObject("BannerOne.Image")));
            this.BannerOne.Location = new System.Drawing.Point(516, 3);
            this.BannerOne.Name = "BannerOne";
            this.BannerOne.Size = new System.Drawing.Size(248, 91);
            this.BannerOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BannerOne.TabIndex = 3;
            this.BannerOne.TabStop = false;
            // 
            // SelectCourseTextBox
            // 
            this.SelectCourseTextBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SelectCourseTextBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SelectCourseTextBox.ForeColor = System.Drawing.Color.White;
            this.SelectCourseTextBox.Location = new System.Drawing.Point(8, 39);
            this.SelectCourseTextBox.Multiline = true;
            this.SelectCourseTextBox.Name = "SelectCourseTextBox";
            this.SelectCourseTextBox.ReadOnly = true;
            this.SelectCourseTextBox.Size = new System.Drawing.Size(567, 65);
            this.SelectCourseTextBox.TabIndex = 5;
            this.SelectCourseTextBox.Text = "Select Course:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox1.Location = new System.Drawing.Point(770, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(445, 91);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = " Ltd Est. 1976";
            // 
            // CourseMenuGroupBox
            // 
            this.CourseMenuGroupBox.Controls.Add(this.textBox2);
            this.CourseMenuGroupBox.Controls.Add(this.textBox4);
            this.CourseMenuGroupBox.Controls.Add(this.textBox3);
            this.CourseMenuGroupBox.Controls.Add(this.SelectCourseTextBox);
            this.CourseMenuGroupBox.Controls.Add(this.CourseListBox);
            this.CourseMenuGroupBox.Location = new System.Drawing.Point(28, 107);
            this.CourseMenuGroupBox.Name = "CourseMenuGroupBox";
            this.CourseMenuGroupBox.Size = new System.Drawing.Size(595, 386);
            this.CourseMenuGroupBox.TabIndex = 7;
            this.CourseMenuGroupBox.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(6, 110);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(298, 64);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "Courses:";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(306, 110);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(117, 64);
            this.textBox4.TabIndex = 8;
            this.textBox4.Text = "Training \nDays:";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(429, 111);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(146, 64);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "Enrollment Fees";
            // 
            // LocationGroupBox
            // 
            this.LocationGroupBox.Controls.Add(this.textBox5);
            this.LocationGroupBox.Controls.Add(this.textBox7);
            this.LocationGroupBox.Controls.Add(this.textBox8);
            this.LocationGroupBox.Controls.Add(this.LocationListBox);
            this.LocationGroupBox.Location = new System.Drawing.Point(642, 107);
            this.LocationGroupBox.Name = "LocationGroupBox";
            this.LocationGroupBox.Size = new System.Drawing.Size(595, 386);
            this.LocationGroupBox.TabIndex = 9;
            this.LocationGroupBox.TabStop = false;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.SeaGreen;
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox5.ForeColor = System.Drawing.Color.White;
            this.textBox5.Location = new System.Drawing.Point(8, 110);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(213, 64);
            this.textBox5.TabIndex = 11;
            this.textBox5.Text = "Locations:";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.SeaGreen;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox7.ForeColor = System.Drawing.Color.White;
            this.textBox7.Location = new System.Drawing.Point(227, 110);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(348, 64);
            this.textBox7.TabIndex = 7;
            this.textBox7.Text = "Accomodation Fees Per Day:";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.SeaGreen;
            this.textBox8.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox8.ForeColor = System.Drawing.Color.White;
            this.textBox8.Location = new System.Drawing.Point(8, 39);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(567, 65);
            this.textBox8.TabIndex = 5;
            this.textBox8.Text = "Select Location:";
            // 
            // LocationListBox
            // 
            this.LocationListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LocationListBox.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.LocationListBox.FormattingEnabled = true;
            this.LocationListBox.ItemHeight = 30;
            this.LocationListBox.Items.AddRange(new object[] {
            "Belmullet       \t\t\t|€219.99",
            "Clifden            \t\t\t|€119.99",
            "Cork                \t\t\t|€149.99",
            "Dublin             \t\t\t|€179.99",
            "Killamey         \t\t\t|€149.99",
            "Letterkenny \t\t\t|€89.99",
            "Sligo          \t\t\t|€119.99"});
            this.LocationListBox.Location = new System.Drawing.Point(6, 180);
            this.LocationListBox.Name = "LocationListBox";
            this.LocationListBox.Size = new System.Drawing.Size(569, 182);
            this.LocationListBox.TabIndex = 0;
            // 
            // ParticipantGroupBox
            // 
            this.ParticipantGroupBox.Controls.Add(this.textBox9);
            this.ParticipantGroupBox.Controls.Add(this.radioButton6);
            this.ParticipantGroupBox.Controls.Add(this.radioButton5);
            this.ParticipantGroupBox.Controls.Add(this.radioButton4);
            this.ParticipantGroupBox.Controls.Add(this.radioButton3);
            this.ParticipantGroupBox.Controls.Add(this.radioButton2);
            this.ParticipantGroupBox.Controls.Add(this.radioButton1);
            this.ParticipantGroupBox.Location = new System.Drawing.Point(1261, 107);
            this.ParticipantGroupBox.Name = "ParticipantGroupBox";
            this.ParticipantGroupBox.Size = new System.Drawing.Size(199, 386);
            this.ParticipantGroupBox.TabIndex = 10;
            this.ParticipantGroupBox.TabStop = false;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.IndianRed;
            this.textBox9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox9.ForeColor = System.Drawing.Color.White;
            this.textBox9.Location = new System.Drawing.Point(15, 40);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(168, 64);
            this.textBox9.TabIndex = 12;
            this.textBox9.Text = "Courses:";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(15, 282);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(159, 29);
            this.radioButton6.TabIndex = 5;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "6 Participants ";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(15, 247);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(154, 29);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "5 Participants";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(15, 142);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(154, 29);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "2 Participants";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(15, 177);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(159, 29);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "3 Participants ";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(15, 212);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(154, 29);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "4 Participants";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(15, 107);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(151, 29);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1 Participant ";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // RoomGroupBox
            // 
            this.RoomGroupBox.BackColor = System.Drawing.Color.DarkGray;
            this.RoomGroupBox.Controls.Add(this.checkBox4);
            this.RoomGroupBox.Controls.Add(this.checkBox3);
            this.RoomGroupBox.Controls.Add(this.checkBox2);
            this.RoomGroupBox.Controls.Add(this.checkBox1);
            this.RoomGroupBox.Location = new System.Drawing.Point(480, 535);
            this.RoomGroupBox.Name = "RoomGroupBox";
            this.RoomGroupBox.Size = new System.Drawing.Size(980, 87);
            this.RoomGroupBox.TabIndex = 11;
            this.RoomGroupBox.TabStop = false;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(514, 40);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(221, 29);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Junior Suite @ €49.99";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(254, 40);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(250, 29);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Executive Suite @ €69.99";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 40);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(227, 29);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Master Suite @ €99.99";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // DisplayButton
            // 
            this.DisplayButton.Location = new System.Drawing.Point(569, 668);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(112, 34);
            this.DisplayButton.TabIndex = 12;
            this.DisplayButton.Text = "DISPLAY";
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DisplayButtonClick);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(759, 40);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(147, 29);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "No Upgrade!";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(166, 550);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(166, 31);
            this.textBox6.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1504, 1014);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.DisplayButton);
            this.Controls.Add(this.RoomGroupBox);
            this.Controls.Add(this.ParticipantGroupBox);
            this.Controls.Add(this.LocationGroupBox);
            this.Controls.Add(this.CourseMenuGroupBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BannerOne);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "L2P Ltd.";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BannerOne)).EndInit();
            this.CourseMenuGroupBox.ResumeLayout(false);
            this.CourseMenuGroupBox.PerformLayout();
            this.LocationGroupBox.ResumeLayout(false);
            this.LocationGroupBox.PerformLayout();
            this.ParticipantGroupBox.ResumeLayout(false);
            this.ParticipantGroupBox.PerformLayout();
            this.RoomGroupBox.ResumeLayout(false);
            this.RoomGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox CourseListBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox BannerOne;
        private TextBox SelectCourseTextBox;
        private TextBox textBox1;
        private GroupBox CourseMenuGroupBox;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private GroupBox LocationGroupBox;
        private TextBox textBox5;
        private TextBox textBox7;
        private TextBox textBox8;
        private ListBox LocationListBox;
        private GroupBox ParticipantGroupBox;
        private RadioButton radioButton1;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private GroupBox RoomGroupBox;
        private TextBox textBox9;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Button DisplayButton;
        private CheckBox checkBox4;
        private TextBox textBox6;
    }
}