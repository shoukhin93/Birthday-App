using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using Add_And_Remove_Programme_To_Or_From_Startup;

namespace Birthday_App
{
    public partial class Main_Form : Form
    {
        //Birthday For The Gifted Person
        private const int birthYear = 2017; //Year is to fix a specific year to run this app only that year
        private const int birthMonth = 01;
        private const int birthDay = 15;
        private const int birthHour = 21;
        private const int birthMinute = 3;
        private const int birthSecond = 0;
        public static string BIRTHDAY_PERSON_NAME = "ASD";

        private const string startupKey = "GIFT";
        public static bool CLOSING_FLAG = false;

        DateTime birthDate;
        DateTime currentDate;

        TimeSpan DateDifference;


        public Main_Form()
        {
            InitializeComponent();
            mainFormTimer.Start();
            this.Location = new Point(400, 50);

            //Adding Programme To StartUp
            Startup.AddProgrammeToStartUp(startupKey);

            //icon
            this.Icon = Properties.Resources.Kzzu_Surprise_Gift_4;
            
        }


        //Changes Screen According To Remaing Time
        private void changeScreeen()
        {
            string day = DateDifference.Days.ToString();
            string hour = DateDifference.Hours.ToString();
            string minute = DateDifference.Minutes.ToString();
            string second = DateDifference.Seconds.ToString();

            if (day.Length == 1)
            {
                dayPictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject("_" + "0");
                dayPictureBox2.Image = (Image)Properties.Resources.ResourceManager.GetObject("_" + "0");
                dayPictureBox3.Image = (Image)Properties.Resources.ResourceManager.GetObject("_" + day[0]);

            }                
            else if (day.Length == 2)
            {
                dayPictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject("_" + "0");
                dayPictureBox2.Image = (Image)Properties.Resources.ResourceManager.GetObject("_" + day[0]);
                dayPictureBox3.Image = (Image)Properties.Resources.ResourceManager.GetObject("_" + day[1]);
            }
            else
            {
                dayPictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject("_" + day[0]);
                dayPictureBox2.Image = (Image)Properties.Resources.ResourceManager.GetObject("_" + day[1]);
                dayPictureBox3.Image = (Image)Properties.Resources.ResourceManager.GetObject("_" + day[2]);
            }
                

            if (hour.Length == 1)
            {
                hourPictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject("_" + "0");
                hourPictureBox2.Image = (Image)Properties.Resources.ResourceManager.GetObject("_" + hour[0]);
            }
            else
            {
                hourPictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject("_" + hour[0]);
                hourPictureBox2.Image = (Image)Properties.Resources.ResourceManager.GetObject("_" + hour[1]);
            }
                

            if (minute.Length == 1)
            {
                minutePictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject("_" + "0");
                minutePictureBox2.Image = (Image)Properties.Resources.ResourceManager.GetObject("_" + minute[0]);
            }
            else
            {
                minutePictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject("_" + minute[0]);
                minutePictureBox2.Image = (Image)Properties.Resources.ResourceManager.GetObject("_" + minute[1]);
            }


            if (second.Length == 1)
            {
                secondPictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject("_" + "0");
                secondPictureBox2.Image = (Image)Properties.Resources.ResourceManager.GetObject("_" + second[0]);
            }
            else
            {
                secondPictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject("_" + second[0]);
                secondPictureBox2.Image = (Image)Properties.Resources.ResourceManager.GetObject("_" + second[1]);
            }
                



        }

        //Check How Much Time Remaining
        private bool checkIfBirthday()
        {
            birthDate = new DateTime(birthYear, birthMonth, birthDay, birthHour, birthMinute, birthSecond);
            currentDate = DateTime.Now;

            DateDifference = birthDate.Subtract(currentDate);

            changeScreeen();

            if (DateDifference.Days < 0)
            {
                Startup.RemoveApplicationFromStartup(startupKey);
                CLOSING_FLAG = true;
                //MessageBox.Show("This Software Is No Longer Available For U");
                Application.Exit();
            }

            if (DateDifference.Days == 0 && DateDifference.Hours <= 0 && DateDifference.Minutes <= 0 && DateDifference.Seconds <= 0)
                return true;

            //Removing From Startup If Date Is Passed
            

            return false;
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void mainFormTimer_Tick(object sender, EventArgs e)
        {
            if (checkIfBirthday() == true)
            {
                mainFormTimer.Stop();
                Form1 obj = new Form1();
                this.Hide();
                obj.ShowDialog();
                this.Close();

               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            About obj = new About();
            this.Hide();
            obj.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Even If U Hide This, It Will Be Activated In Correct Time");
            this.Hide();
        }

        private void Main_Form_Resize(object sender, EventArgs e)
        {
            

           
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CLOSING_FLAG)
                Application.Exit();
            else
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void notifyIcon1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
