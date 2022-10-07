using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Assignment_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DisplayButtonClick(object sender, MouseEventArgs e)
        {
            string curItem = CourseListBox.SelectedItem.ToString();
            Regex re = new Regex("€[0-9]+(?:\\.[0-9]+)?");
            
            if (re.IsMatch(curItem))
                MessageBox.Show(re.Group);
            else
                MessageBox.Show("FAILED");

        }
    }
}