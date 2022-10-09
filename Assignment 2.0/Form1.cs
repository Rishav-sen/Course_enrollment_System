using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Assignment_2._0
{
    public partial class Form1 : Form
    {
        public const decimal CSharpFundamentals = 900m;
        public const decimal CSharpBasics = 1500m;
        public const decimal CSharpIntermediate = 1800m;
        public const decimal CSharpAdv = 2300m;
        public const decimal ASPPart1 = 1250m;
        public const decimal ASPPart2 = 1250m;

        public const String Course1 = "C# Fundamentals";
        public const String Course2 = "C# Basics for Beginners";
        public const String Course3 = "C# Intermediate";
        public const String Course4 = "C# Advanced";
        public const String Course5 = "ASP.NET with C# Part A";
        public const String Course6 = "ASP.NET with C# Part B";

        public string SelectedCourse = "";


        public const decimal BelmulletPrice = 219.99m;
        public const decimal ClifdenPrice = 119.99m;
        public const decimal CorkPrice = 149.99m;
        public const decimal DublinPrice = 179.99m;
        public const decimal KillameyPrice = 149.99m;
        public const decimal LetterkennyPrice = 89.99m;
        public const decimal SligoPrice = 119.99m;

        public const String Location1 = "Belmullet";
        public const String Location2 = "Clifden";
        public const String Location3 = "Cork";
        public const String Location4 = "Dublin";
        public const String Location5 = "Killamey";
        public const String Location6 = "Letterkenny";
        public const String Location7 = "Sligo";

        public string SelectedLocation = "";


        public decimal TotalCourseFees = 0m;
        public decimal TotalLocationFees = 0m;
        public decimal NumberOfParticipants = 0;
        public Form1()
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
                                TotalCourseFees = BelmulletPrice;
                                SelectedCourse = Course1;
                                MessageBox.Show(TotalCourseFees.ToString());
                                break;
                            }
                        case 1:
                            {
                                TotalCourseFees = CSharpBasics;
                                SelectedCourse = Course2;
                                MessageBox.Show(TotalCourseFees.ToString());
                                break;
                            }
                        case 2:
                            {
                                TotalCourseFees = CSharpIntermediate;
                                SelectedCourse = Course3;
                                MessageBox.Show(TotalCourseFees.ToString()); ;
                                break;
                            }
                        case 3:
                            {
                                TotalCourseFees = CSharpAdv;
                                SelectedCourse = Course4;
                                MessageBox.Show(TotalCourseFees.ToString());
                                break;
                            }
                        case 4:
                            {
                                TotalCourseFees = ASPPart1;
                                SelectedCourse = Course5;
                                MessageBox.Show(TotalCourseFees.ToString());
                                break;
                            }
                        case 5:
                            {
                                TotalCourseFees = ASPPart2;
                                SelectedCourse = Course6;
                                MessageBox.Show(TotalCourseFees.ToString());
                                break;
                            }

                    }

                    switch (locationIndex)
                    {
                        case 0:
                            {
                                TotalLocationFees = BelmulletPrice;
                                SelectedLocation = Location1;
                                MessageBox.Show(TotalLocationFees.ToString());
                                break;
                            }
                        case 1:
                            {
                                TotalLocationFees = ClifdenPrice;
                                SelectedLocation = Location2;
                                MessageBox.Show(TotalLocationFees.ToString());
                                break;
                            }
                        case 2:
                            {
                                TotalLocationFees = CorkPrice;
                                SelectedLocation = Location3;
                                MessageBox.Show(TotalLocationFees.ToString()); ;
                                break;
                            }
                        case 3:
                            {
                                TotalLocationFees = DublinPrice;
                                SelectedLocation = Location4;
                                MessageBox.Show(TotalLocationFees.ToString());
                                break;
                            }
                        case 4:
                            {
                                TotalLocationFees = KillameyPrice;
                                SelectedLocation = Location5;
                                MessageBox.Show(TotalLocationFees.ToString());
                                break;
                            }
                        case 5:
                            {
                                TotalLocationFees = LetterkennyPrice;
                                SelectedLocation = Location6;
                                MessageBox.Show(TotalLocationFees.ToString());
                                break;
                            }
                        case 6:
                            {
                                TotalLocationFees = SligoPrice;
                                SelectedLocation = Location7;
                                MessageBox.Show(TotalLocationFees.ToString());
                                break;
                            }


                    }
                    if(No) 
                    { ;}


                }
                else { MessageBox.Show("Please select a Location you wish to Attend the course", 
                    "Location Selection Needed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            }
            else
            {
                MessageBox.Show("Please select a Course you wish to enroll",
                    "Course Selection Needed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            

            /*string curLocation = LocationListBox.SelectedItem.ToString();
            string[] curLocationTokens = curLocation.Split(' ');
            String location = curLocationTokens[0];
            switch (location)
            {
                case "1":
                    {
                        TotalLocationFees += BelmulletPrice;
                        MessageBox.Show(TotalLocationFees.ToString());
                        break;
                    }
                case "2":
                    {
                        TotalLocationFees += ClifdenPrice;
                        MessageBox.Show(TotalLocationFees.ToString());
                        break;
                    }
                case "3":
                    {
                        TotalLocationFees += CorkPrice;
                        MessageBox.Show(TotalLocationFees.ToString()); ;
                        break;
                    }
                case "4":
                    {
                        TotalLocationFees += DublinPrice;
                        MessageBox.Show(TotalLocationFees.ToString());
                        break;
                    }
                case "5":
                    {
                        TotalLocationFees += KillameyPrice;
                        MessageBox.Show(TotalLocationFees.ToString());
                        break;
                    }
                case "6":
                    {
                        TotalLocationFees += LetterkennyPrice;
                        MessageBox.Show(TotalLocationFees.ToString());
                        break;
                    }
                case "7":{
                        TotalLocationFees += SligoPrice;
                        MessageBox.Show(TotalLocationFees.ToString());
                        break;
                    }


            }*/


        }

        
    }
}