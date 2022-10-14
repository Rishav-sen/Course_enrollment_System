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
        public const decimal CSHARPADV = 2300m;
        public const decimal ASPPART1 = 1250m;
        public const decimal ASPPART2 = 1250m;

        public const String COURSE1 = "C# Fundamentals";
        public const String COURSE2 = "C# Basics for Beginners";
        public const String COURSE3 = "C# Intermediate";
        public const String COURSE4 = "C# Advanced";
        public const String COURSE5 = "ASP.NET with C# Part A";
        public const String COURSE6 = "ASP.NET with C# Part B";

        public const int DAYSCOURSE1 = 2;
        public const int DAYSCOURSE2 = 4;
        public const int DAYSCOURSE3 = 4;
        public const int DAYSCOURSE4 = 2;
        public const int DAYSCOURSE5 = 5;
        public const int DAYSCOURSE6 = 5;

        public int NumberOfCourseDays = 1;
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

        public const String MASTERSUITE = "Master Suite";
        public const String EXECUTIVESUITE = "Executive Suite";
        public const String JUNIORSUITE = "Junior Suite";

        public const decimal MASTERSUITEPRICE = 99.99m;
        public const decimal EXECUTIVESUITEPRICE = 69.99m;
        public const decimal JUNIORSUITEPRICE = 49.99m;

        public const decimal DIGITALCERT = 39.99m;

        
        public int SummaryTotalBookings = 0;
        public decimal SummaryEnrollmentFees = 0m;
        public decimal SummaryTotalLodgingFees = 0m;
        public decimal SummaryAvgRevenue = 0m;
        public decimal SummaryTotalOptionalRevenue = 0m;
        public int SummaryTotalBookingsWithDiscount = 0;
        public decimal SummaryGrandTotal = 0m;
        
        //global variables to use in local 
        public decimal CourseEnrollmentFees = 0m;
        public decimal LodgingFees = 0m;
        public decimal RoomUpgradeCost = 0m;
        public String RoomUpgradeType = "";
        public decimal DigitalCertPrice = 0;
        public decimal GrandTotal = 0m;
        public decimal Discount = 0m;
        public Boolean DiscountBit = false;
        


        public form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SummaryGroupBox.Location = DisplayBookingDetailGroupBox.Location ;
            DisplayBookingDetailGroupBox.Visible = false;
            SummaryGroupBox.Visible = false;
            SummaryButton.Enabled = false;
            
        }

        public void DisplayButtonClick(object sender, MouseEventArgs e)
        {
            Boolean failbit = false;
            int NumberOfParticipants = 0;
            /*decimal CourseEnrollmentFees = 0m;
            decimal LodgingFees = 0m;*/
            if (CourseListBox.SelectedIndex != -1)
            {
                if(LocationListBox.SelectedIndex != -1)
                {
                    int courseIndex = CourseListBox.SelectedIndex;
                    int locationIndex = LocationListBox.SelectedIndex;

                    switch (courseIndex)
                    {
                        case 0:
                            {
                                CourseEnrollmentFees = CSHARPFUNDAMENTALS;
                                SelectedCourse = COURSE1;
                                NumberOfCourseDays = DAYSCOURSE1;
                                break;
                            }
                        case 1:
                            {
                                CourseEnrollmentFees = CSHARPBASICS;
                                SelectedCourse = COURSE2;
                                NumberOfCourseDays = DAYSCOURSE2;
                                break;
                            }
                        case 2:
                            {
                                CourseEnrollmentFees = CSHARPINTERMEDIATE;
                                SelectedCourse = COURSE3;
                                NumberOfCourseDays = DAYSCOURSE3;
                                break;
                            }
                        case 3:
                            {
                                CourseEnrollmentFees = CSHARPADV;
                                SelectedCourse = COURSE4;
                                NumberOfCourseDays = DAYSCOURSE4;
                                break;
                            }
                        case 4:
                            {
                                CourseEnrollmentFees = ASPPART1;
                                SelectedCourse = COURSE5;
                                NumberOfCourseDays = DAYSCOURSE5;
                                break;
                            }
                        case 5:
                            {
                                CourseEnrollmentFees = ASPPART2;
                                SelectedCourse = COURSE6;
                                NumberOfCourseDays = DAYSCOURSE6;
                                break;
                            }

                    }

                    switch (locationIndex)
                    {
                        case 0:
                            {
                                LodgingFees = BELMULLETPRICE;
                                SelectedLocation = LOCATION1;
                                break;
                            }
                        case 1:
                            {
                                LodgingFees = CLIFDENPRICE;
                                SelectedLocation = LOCATION2;
                                break;
                            }
                        case 2:
                            {
                                LodgingFees = CORKPRICE;
                                SelectedLocation = LOCATION3;
                                break;
                            }
                        case 3:
                            {
                                LodgingFees = DUBLINPRICE;
                                SelectedLocation = LOCATION4;
                                break;
                            }
                        case 4:
                            {
                                LodgingFees = KILLAMEYPRICE;
                                SelectedLocation = LOCATION5;
                                break;
                            }
                        case 5:
                            {
                                LodgingFees = LETTERKENNYPRICE;
                                SelectedLocation = LOCATION6;
                                break;
                            }
                        case 6:
                            {
                                LodgingFees = SLIGOPRICE;
                                SelectedLocation = LOCATION7;
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
                            failbit = true;
                            MessageBox.Show("Minimum 1 & Max of 10 participants allowed!",
                            "Incorrect input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    catch  {
                        
                        if (!NoParticipantsTextBox.Text.All(Char.IsDigit) 
                            || String.IsNullOrEmpty(NoParticipantsTextBox.Text))
                        {
                            failbit = true;
                            MessageBox.Show("Please enter numerical data for number of participants", "Input Error", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error); }

                    }

                }
                else {
                    failbit = true;
                    MessageBox.Show("Please select a Location you wish to Attend the course", 
                    "Location Selection Needed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            }
            else
            {
                failbit = true;
                MessageBox.Show("Please select a Course you wish to enroll",
                    "Course Selection Needed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            /*decimal RoomUpgradeCost = 0m;
            String RoomUpgradeType = "";
            decimal DigitalCertPrice = 0;*/

            if (MasterSuiteRadioButton.Checked == true) {
                RoomUpgradeCost = MASTERSUITEPRICE;
                RoomUpgradeType = MASTERSUITE;

            }
            else if (ExecutiveSuiteRadioButton.Checked == true){
                RoomUpgradeCost = EXECUTIVESUITEPRICE;
                RoomUpgradeType = EXECUTIVESUITE;
            }
            else if (JuniorSuiteRadioButton.Checked == true){
                RoomUpgradeCost = JUNIORSUITEPRICE;
                RoomUpgradeType = JUNIORSUITE;
            }

            if (DigitalCertCheckBox.Checked)
            {
                DigitalCertPrice = DIGITALCERT;
            }
            int participants = NumberOfParticipants;
            if (failbit == false)
            {
                CourseEnrollmentFees *= participants;
                LodgingFees = LodgingFees * participants * NumberOfCourseDays;
                RoomUpgradeCost = RoomUpgradeCost * participants * NumberOfCourseDays;
                DigitalCertPrice = DigitalCertPrice * participants;
                GrandTotal = CourseEnrollmentFees
                                    + LodgingFees
                                    + RoomUpgradeCost
                                    + DigitalCertPrice;

                if (participants >= 3 && RoomUpgradeType != "")
                {
                    DiscountBit = true;
                    Discount = GrandTotal * 0.075m;
                    GrandTotal *= 0.925m;
                    DiscAppliedDisplayTextBox.Text = "-" + (Discount.ToString("c"));
                                       

                }
                else
                {
                    DiscAppliedDisplayTextBox.Text = "0";

                }

                CourseSelectionDisplayTextBox.Text = NumberOfCourseDays + " Days course of " + SelectedCourse + " at " + SelectedLocation + ".";
                NoPArticipantsDisplayTextBox.Text = NoParticipantsTextBox.Text;
                EnrollmentFeesDisplayTextBox.Text = CourseEnrollmentFees.ToString("c");
                LodgingCostDisplayTextBox.Text = LodgingFees.ToString("c");
                RoomUpgradeTypeDisplayTextBox.Text = RoomUpgradeType.ToString();
                RoomUpgradeCostDisplayTextBox.Text = RoomUpgradeCost.ToString("c");
                DigiCertValueDisplayTextBox.Text = DigitalCertPrice.ToString("c");
                GrandTotalDisplayTextBox.Text = GrandTotal.ToString("c");

                
                //
                DisplayBookingDetailGroupBox.Visible  = true;
                CourseMenuGroupBox.Enabled = false;
                LocationGroupBox.Enabled = false;
                DisplayButton.Enabled = false;
                //ExitButton.Enabled = false;
                CertCollectGroupBox.Enabled = false;
                ParticipantsCollectGroupBox.Enabled = false;
                RoomUpgradeGroupBox.Enabled = false;
                //ClearButton.Enabled = false;
                BannerOne.Enabled = false;
                SummaryButton.Enabled = false;

            }

        }
        private void BookCourseButtonOnClick(object sender, MouseEventArgs e)
        {
            MessageBoxButtons ChoiceButtons = MessageBoxButtons.YesNo;
            DialogResult Choice = MessageBox.Show("Do you want to confirm the Booking?", "Final Booking Confirmation!", ChoiceButtons);
            if (Choice == DialogResult.Yes)
            {
                //Global Variables
                SummaryTotalBookings++;
                SummaryEnrollmentFees += CourseEnrollmentFees;
                SummaryTotalLodgingFees += LodgingFees;
                SummaryTotalOptionalRevenue = SummaryTotalOptionalRevenue
                                                + RoomUpgradeCost
                                                + DigitalCertPrice;
                if (DiscountBit ==  true)
                {
                    SummaryTotalBookingsWithDiscount++;
                }
                
                SummaryGrandTotal = SummaryEnrollmentFees + SummaryTotalLodgingFees + SummaryTotalOptionalRevenue;
                SummaryAvgRevenue = SummaryGrandTotal / SummaryTotalBookings;
                

                MessageBox.Show("Your Booking as has been Processed.",
                     "Booking Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearSlate();
                SummaryButton.Enabled = true;
                CourseEnrollmentFees = 0m;
                LodgingFees = 0m;
                RoomUpgradeCost = 0m;
                RoomUpgradeType = "";
                DigitalCertPrice = 0;
                GrandTotal = 0m;
                DiscountBit = false;


            }
            else
            {
                ClearSlate();
                
            }
            
              

        }

        private void ExitButtonClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
               

        private void ClearButtonOnClick(object sender, MouseEventArgs e)
        {
            ClearSlate();
            // Resetting Globalvaribales
            CourseEnrollmentFees = 0m;
            LodgingFees = 0m;
            RoomUpgradeCost = 0m;
            RoomUpgradeType = "";
            DigitalCertPrice = 0;
            GrandTotal = 0m;
            DiscountBit = false;
            if(SummaryTotalBookings > 0)
            {
                SummaryButton.Enabled = true;
            }

        }

        private void ClearSlate()
        {
            DisplayButton.Enabled = true;
            DisplayBookingDetailGroupBox.Visible = false;
            CourseMenuGroupBox.Enabled = true;
            LocationGroupBox.Enabled = true;
            DisplayButton.Enabled = true;
            //ExitButton.Enabled = false;
            CertCollectGroupBox.Enabled = true;
            ParticipantsCollectGroupBox.Enabled = true;
            RoomUpgradeGroupBox.Enabled = true;
            //ClearButton.Enabled = false;
            BannerOne.Enabled = false;
            SummaryButton.Enabled = false;

            CourseMenuGroupBox.Visible = true;
            LocationGroupBox.Visible = true;
            DisplayButton.Visible = true;
            ExitButton.Visible = true;
            CertCollectGroupBox.Visible = true;
            ParticipantsCollectGroupBox.Visible = true;
            RoomUpgradeGroupBox.Visible = true;
            CourseListBox.SelectedIndex = -1;
            LocationListBox.SelectedIndex = -1;
            MasterSuiteRadioButton.Checked = false;
            ExecutiveSuiteRadioButton.Checked = false;
            JuniorSuiteRadioButton.Checked = false;
            DigitalCertCheckBox.Checked = false;
            DisplayBookingDetailGroupBox.Visible = false;
            NoParticipantsTextBox.Text = "";
            SummaryButton.Visible = true;
            SummaryGroupBox.Visible = false;    
            
        }

        private void SummaryButtonOnClick(object sender, MouseEventArgs e)
        {
            DisplayButton.Enabled = false;
            SummaryGroupBox.Visible = true;
            SummaryTotalNumberOfBookingsDisplay.Text = SummaryTotalBookings.ToString();
            SummaryCourseEnrollmentDisplay.Text =  SummaryEnrollmentFees.ToString("c");
            SummaryTotalLodgingRevenueDisplay.Text = SummaryTotalLodgingFees.ToString("c");
            SummaryAverageRevenueDisplay.Text = SummaryAvgRevenue.ToString("c");
            SummaryOptionalRevenueDisplay.Text = SummaryTotalOptionalRevenue.ToString("c");
            SummaryTotalTransWithDiscsDisplay.Text = SummaryTotalBookingsWithDiscount.ToString();
            SummaryTotalRvenueDisplay.Text = SummaryGrandTotal.ToString("c");

            DisplayBookingDetailGroupBox.Visible = true;
            CourseMenuGroupBox.Enabled = false;
            LocationGroupBox.Enabled = false;
            CertCollectGroupBox.Enabled = false;
            ParticipantsCollectGroupBox.Enabled = false;
            RoomUpgradeGroupBox.Enabled = false;
            
        }

        
    }
}