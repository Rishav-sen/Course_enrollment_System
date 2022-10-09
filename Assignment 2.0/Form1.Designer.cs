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
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.ExecutiveSuiteRadioButton = new System.Windows.Forms.RadioButton();
            this.JuniorSuiteRadioButton = new System.Windows.Forms.RadioButton();
            this.MasterSuiteRadioButton = new System.Windows.Forms.RadioButton();
            this.RoomGroupBox = new System.Windows.Forms.GroupBox();
            this.DigitalCertCheckBox = new System.Windows.Forms.CheckBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BannerOne)).BeginInit();
            this.CourseMenuGroupBox.SuspendLayout();
            this.LocationGroupBox.SuspendLayout();
            this.ParticipantGroupBox.SuspendLayout();
            this.RoomGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CourseListBox
            // 
            this.CourseListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CourseListBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CourseListBox.FormattingEnabled = true;
            this.CourseListBox.ItemHeight = 30;
            this.CourseListBox.Items.AddRange(new object[] {
            " C# fundamentals           \t| 2 Days\t| €900                   ",
            " C# Basics for Beginners\t| 4 Days\t| €1,500              ",
            " C# Intermediate            \t| 4 Days\t| €1,800 ",
            " C# Advanced            \t| 2 Days\t| €2,300           ",
            " ASP.NET with C# Part A\t| 5 Days\t| €1,250              ",
            " ASP.NET with C# Part B\t| 5 Days\t| €1,250           "});
            this.CourseListBox.Location = new System.Drawing.Point(8, 191);
            this.CourseListBox.Name = "CourseListBox";
            this.CourseListBox.Size = new System.Drawing.Size(567, 182);
            this.CourseListBox.TabIndex = 0;
            // 
            // BannerOne
            // 
            this.BannerOne.Image = ((System.Drawing.Image)(resources.GetObject("BannerOne.Image")));
            this.BannerOne.Location = new System.Drawing.Point(698, 614);
            this.BannerOne.Name = "BannerOne";
            this.BannerOne.Size = new System.Drawing.Size(248, 122);
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
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox1.Location = new System.Drawing.Point(1353, 623);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(131, 65);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = " Ltd";
            // 
            // CourseMenuGroupBox
            // 
            this.CourseMenuGroupBox.Controls.Add(this.textBox2);
            this.CourseMenuGroupBox.Controls.Add(this.textBox4);
            this.CourseMenuGroupBox.Controls.Add(this.textBox3);
            this.CourseMenuGroupBox.Controls.Add(this.SelectCourseTextBox);
            this.CourseMenuGroupBox.Controls.Add(this.CourseListBox);
            this.CourseMenuGroupBox.Location = new System.Drawing.Point(23, 24);
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
            this.textBox4.Location = new System.Drawing.Point(306, 109);
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
            this.LocationGroupBox.Location = new System.Drawing.Point(626, 24);
            this.LocationGroupBox.Name = "LocationGroupBox";
            this.LocationGroupBox.Size = new System.Drawing.Size(602, 386);
            this.LocationGroupBox.TabIndex = 9;
            this.LocationGroupBox.TabStop = false;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.SeaGreen;
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox5.ForeColor = System.Drawing.Color.White;
            this.textBox5.Location = new System.Drawing.Point(8, 109);
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
            this.LocationListBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LocationListBox.FormattingEnabled = true;
            this.LocationListBox.ItemHeight = 30;
            this.LocationListBox.Items.AddRange(new object[] {
            " Belmullet       \t\t\t|€219.99",
            " Clifden            \t\t\t|€119.99",
            " Cork                \t\t\t|€149.99",
            " Dublin             \t\t\t|€179.99",
            " Killamey         \t\t\t|€149.99",
            " Letterkenny \t\t\t|€89.99",
            " Sligo          \t\t\t|€119.99"});
            this.LocationListBox.Location = new System.Drawing.Point(8, 191);
            this.LocationListBox.Name = "LocationListBox";
            this.LocationListBox.Size = new System.Drawing.Size(569, 182);
            this.LocationListBox.TabIndex = 0;
            // 
            // ParticipantGroupBox
            // 
            this.ParticipantGroupBox.Controls.Add(this.textBox10);
            this.ParticipantGroupBox.Controls.Add(this.textBox9);
            this.ParticipantGroupBox.Controls.Add(this.ExecutiveSuiteRadioButton);
            this.ParticipantGroupBox.Controls.Add(this.JuniorSuiteRadioButton);
            this.ParticipantGroupBox.Controls.Add(this.MasterSuiteRadioButton);
            this.ParticipantGroupBox.Location = new System.Drawing.Point(168, 605);
            this.ParticipantGroupBox.Name = "ParticipantGroupBox";
            this.ParticipantGroupBox.Size = new System.Drawing.Size(278, 274);
            this.ParticipantGroupBox.TabIndex = 10;
            this.ParticipantGroupBox.TabStop = false;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.White;
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox10.Location = new System.Drawing.Point(55, 240);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(170, 24);
            this.textBox10.TabIndex = 13;
            this.textBox10.Text = "*This is an optional upgrade";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.IndianRed;
            this.textBox9.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox9.ForeColor = System.Drawing.Color.White;
            this.textBox9.Location = new System.Drawing.Point(15, 40);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(249, 64);
            this.textBox9.TabIndex = 12;
            this.textBox9.Text = "Room Upgrades*:";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ExecutiveSuiteRadioButton
            // 
            this.ExecutiveSuiteRadioButton.AutoSize = true;
            this.ExecutiveSuiteRadioButton.Location = new System.Drawing.Point(15, 142);
            this.ExecutiveSuiteRadioButton.Name = "ExecutiveSuiteRadioButton";
            this.ExecutiveSuiteRadioButton.Size = new System.Drawing.Size(249, 29);
            this.ExecutiveSuiteRadioButton.TabIndex = 3;
            this.ExecutiveSuiteRadioButton.TabStop = true;
            this.ExecutiveSuiteRadioButton.Text = "Executive Suite @ €69.99";
            this.ExecutiveSuiteRadioButton.UseVisualStyleBackColor = true;
            // 
            // JuniorSuiteRadioButton
            // 
            this.JuniorSuiteRadioButton.AutoSize = true;
            this.JuniorSuiteRadioButton.Location = new System.Drawing.Point(15, 177);
            this.JuniorSuiteRadioButton.Name = "JuniorSuiteRadioButton";
            this.JuniorSuiteRadioButton.Size = new System.Drawing.Size(220, 29);
            this.JuniorSuiteRadioButton.TabIndex = 2;
            this.JuniorSuiteRadioButton.TabStop = true;
            this.JuniorSuiteRadioButton.Text = "Junior Suite @ €49.99";
            this.JuniorSuiteRadioButton.UseVisualStyleBackColor = true;
            // 
            // MasterSuiteRadioButton
            // 
            this.MasterSuiteRadioButton.AutoSize = true;
            this.MasterSuiteRadioButton.Location = new System.Drawing.Point(15, 107);
            this.MasterSuiteRadioButton.Name = "MasterSuiteRadioButton";
            this.MasterSuiteRadioButton.Size = new System.Drawing.Size(226, 29);
            this.MasterSuiteRadioButton.TabIndex = 0;
            this.MasterSuiteRadioButton.TabStop = true;
            this.MasterSuiteRadioButton.Text = "Master Suite @ €99.99";
            this.MasterSuiteRadioButton.UseVisualStyleBackColor = true;
            // 
            // RoomGroupBox
            // 
            this.RoomGroupBox.BackColor = System.Drawing.Color.DarkGray;
            this.RoomGroupBox.Controls.Add(this.DigitalCertCheckBox);
            this.RoomGroupBox.Controls.Add(this.textBox6);
            this.RoomGroupBox.Location = new System.Drawing.Point(23, 416);
            this.RoomGroupBox.Name = "RoomGroupBox";
            this.RoomGroupBox.Size = new System.Drawing.Size(872, 48);
            this.RoomGroupBox.TabIndex = 11;
            this.RoomGroupBox.TabStop = false;
            // 
            // DigitalCertCheckBox
            // 
            this.DigitalCertCheckBox.AutoSize = true;
            this.DigitalCertCheckBox.Location = new System.Drawing.Point(724, 9);
            this.DigitalCertCheckBox.Name = "DigitalCertCheckBox";
            this.DigitalCertCheckBox.Size = new System.Drawing.Size(139, 29);
            this.DigitalCertCheckBox.TabIndex = 17;
            this.DigitalCertCheckBox.Text = "Yes (€39.99)";
            this.DigitalCertCheckBox.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.Black;
            this.textBox6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox6.ForeColor = System.Drawing.Color.White;
            this.textBox6.Location = new System.Drawing.Point(0, 0);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(718, 48);
            this.textBox6.TabIndex = 16;
            this.textBox6.Text = "Do you wish to receive a digital course completion certificate?";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DisplayButton
            // 
            this.DisplayButton.Location = new System.Drawing.Point(626, 562);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(112, 34);
            this.DisplayButton.TabIndex = 12;
            this.DisplayButton.Text = "DISPLAY";
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DisplayButtonClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(675, 747);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 87);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox2.Controls.Add(this.textBox11);
            this.groupBox2.Location = new System.Drawing.Point(23, 481);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(872, 48);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.Black;
            this.textBox11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox11.ForeColor = System.Drawing.Color.White;
            this.textBox11.Location = new System.Drawing.Point(0, 0);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(718, 48);
            this.textBox11.TabIndex = 16;
            this.textBox11.Text = "Do you wish to receive a digital course completion certificate?";
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1559, 1014);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private RadioButton MasterSuiteRadioButton;
        private RadioButton ExecutiveSuiteRadioButton;
        private RadioButton JuniorSuiteRadioButton;
        private RadioButton radioButton2;
        private GroupBox RoomGroupBox;
        private TextBox textBox9;
        private Button DisplayButton;
        private TextBox textBox10;
        private GroupBox groupBox1;
        private TextBox textBox6;
        private CheckBox DigitalCertCheckBox;
        private GroupBox groupBox2;
        private TextBox textBox11;
    }
}