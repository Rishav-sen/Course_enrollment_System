using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Assignment_2._0
{
    public partial class form1 : Form
    {
        public const decimal CSHARPFUNDAMENTALS  = 900m;
        public const decimal CSHARPBASICS = 1500m;
        public const decimal CSHARPINTERMEDIATE = 1800m;
        public const decimal CSharpAdv = 2300m;
        public const decimal ASPPART1 = 1250m;
        public const decimal ASPPART2 = 1250m;

        public const String COURSE1 = "C# Fundamentals";
        public const String COURSE2 = "C# Basics for Beginners";
        public const String COURSE3 = "C# Intermediate";
        public const String COURSE4 = "C# Advanced";
        public const String COURSE5 = "ASP.NET with C# Part A";
        public const String COURSE6 = "ASP.NET with C# Part B";

        public string SelectedCourse = "";


        public const decimal BELMULLETPRICE = 219.99m;
        public const decimal CLIFDENPRICE = 119.99m;
        public const decimal CORKPRICE = 149.99m;
        public const decimal DUBLINPRICE = 179.99m;
        public const decimal KILLAMEYPRICE = 149.99m;
        public const decimal LETTERKENNYPRICE = 89.99m;
        public const decimal SLIGOPRICE = 119.99m;

        public const String LOCATION1 = "Belmullet";
        public const String LOCATION2 = "Clifden";
        public const String LOCATION3 = "Cork";
        public const String LOCATION4 = "Dublin";
        public const String LOCATION5 = "Killamey";
        public const String LOCATION6 = "Letterkenny";
        public const String LOCATION7 = "Sligo";

        public string SelectedLocation = "";


        public decimal TotalCourseFees = 0m;
        public decimal TotalLocationFees = 0m;
        public decimal NumberOfParticipants = 1;
        public form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DisplayButtonClick(object sender, MouseEventArgs e)
        {
            if(CourseListBox.SelectedIndex != -1)
            {
                if(LocationListBox.SelectedIndex != -1)
                {
                    int courseIndex = CourseListBox.SelectedIndex;
                    int locationIndex = LocationListBox.SelectedIndex;

                    switch (courseIndex)
                    {
                        case 0:
                            {
                                TotalCourseFees = CSHARPFUNDAMENTALS;
                                SelectedCourse = COURSE1;
                                MessageBox.Show(TotalCourseFees.ToString());
                                break;
                            }
                        case 1:
                            {
                                TotalCourseFees = CSHARPBASICS;
                                SelectedCourse = COURSE2;
                                MessageBox.Show(TotalCourseFees.ToString());
                                break;
                            }
                        case 2:
                            {
                                TotalCourseFees = CSHARPINTERMEDIATE;
                                SelectedCourse = COURSE3;
                                MessageBox.Show(TotalCourseFees.ToString()); ;
                                break;
                            }
                        case 3:
                            {
                                TotalCourseFees = CSharpAdv;
                                SelectedCourse = COURSE4;
                                MessageBox.Show(TotalCourseFees.ToString());
                                break;
                            }
                        case 4:
                            {
                                TotalCourseFees = ASPPART1;
                                SelectedCourse = COURSE5;
                                MessageBox.Show(TotalCourseFees.ToString());
                                break;
                            }
                        case 5:
                            {
                                TotalCourseFees = ASPPART2;
                                SelectedCourse = COURSE6;
                                MessageBox.Show(TotalCourseFees.ToString());
                                break;
                            }

                    }

                    switch (locationIndex)
                    {
                        case 0:
                            {
                                TotalLocationFees = BELMULLETPRICE;
                                SelectedLocation = LOCATION1;
                                MessageBox.Show(TotalLocationFees.ToString());
                                break;
                            }
                        case 1:
                            {
                                TotalLocationFees = CLIFDENPRICE;
                                SelectedLocation = LOCATION2;
                                MessageBox.Show(TotalLocationFees.ToString());
                                break;
                            }
                        case 2:
                            {
                                TotalLocationFees = CORKPRICE;
                                SelectedLocation = LOCATION3;
                                MessageBox.Show(TotalLocationFees.ToString()); ;
                                break;
                            }
                        case 3:
                            {
                                TotalLocationFees = DUBLINPRICE;
                                SelectedLocation = LOCATION4;
                                MessageBox.Show(TotalLocationFees.ToString());
                                break;
                            }
                        case 4:
                            {
                                TotalLocationFees = KILLAMEYPRICE;
                                SelectedLocation = LOCATION5;
                                MessageBox.Show(TotalLocationFees.ToString());
                                break;
                            }
                        case 5:
                            {
                                TotalLocationFees = LETTERKENNYPRICE;
                                SelectedLocation = LOCATION6;
                                MessageBox.Show(TotalLocationFees.ToString());
                                break;
                            }
                        case 6:
                            {
                                TotalLocationFees = SLIGOPRICE;
                                SelectedLocation = LOCATION7;
                                MessageBox.Show(TotalLocationFees.ToString());
                                break;
                            }


                    }
                    try
                    {
                        if (int.Parse(NoParticipantsTextBox.Text.ToString()) > 0 &&
                            int.Parse(NoParticipantsTextBox.Text.ToString()) <= 10)
                        {
                            NumberOfParticipants = int.Parse(NoParticipantsTextBox.Text.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Minimum 1 & Max of 10 participants allowed!",
                            "Incorrect input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    catch  {
                        
                        if (!NoParticipantsTextBox.Text.All(Char.IsDigit) 
                            || String.IsNullOrEmpty(NoParticipantsTextBox.Text))
                        { MessageBox.Show("Please enter numerical data for number of participants", "Input Error", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error); }

                    }

                }
                else { MessageBox.Show("Please select a Location you wish to Attend the course", 
                    "Location Selection Needed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            }
            else
            {
                MessageBox.Show("Please select a Course you wish to enroll",
                    "Course Selection Needed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }



        }

        
    }
}