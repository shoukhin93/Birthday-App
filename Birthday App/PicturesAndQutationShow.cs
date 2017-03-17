using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Birthday_App
{
    public partial class PicturesAndQutationShow : Form
    {
        Form1 obj;
        BirthdayQuotes quotes;
        int quotesNum, image;

        public PicturesAndQutationShow(Form1 obj)
        {
            InitializeComponent();
            this.obj = obj;
            Initialize();
        }

        private void Initialize()
        {
            quotes = new BirthdayQuotes();
            this.Icon = Properties.Resources.Kzzu_Surprise_Gift_4;
            this.Location = new Point(200, 200);
            BirthdayPersonNameLbl.Text = Main_Form.BIRTHDAY_PERSON_NAME;
            quotesNum = 0;
            image = 0;
        }

        private void PicturesAndQutationShow_Load(object sender, EventArgs e)
        {

        }

        int n = 1, t, var = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (obj.x == obj.originalX && obj.y == obj.originalY)
            {
                t++;
                obj.stopMovement();
                this.Hide();
            }

            if (var == 6)
            {
                n++;

                if (n == 100)
                {
                    Main_Form.CLOSING_FLAG = true;
                    Application.Exit();
                }
            }

            else if(t == 10)
            {
                t = 0;
                this.Show();
                var++;
                changeBackground(var);
                obj.startMovement();

            }

           
        }

        private void changeBackground(int var)
        {
            labelHide();
            if(var % 2 == 0)
            {
                this.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("qt" + image++);
                
            }
            else
            {
                this.BackgroundImage = null;
                label3.Visible = true;
                label3.Text = quotes.quotes[quotesNum++];
            }

        }

        private void labelHide()
        {
            label1.Visible = false;
            label2.Visible = false;
            BirthdayPersonNameLbl.Visible = false;
            label3.Visible = false;
        }

        private void labelShow()
        {
            label1.Visible = true;
            label2.Visible = true;
            BirthdayPersonNameLbl.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
