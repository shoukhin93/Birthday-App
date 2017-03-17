using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;
using System.Media;
using System.Collections;

namespace Birthday_App
{
    public partial class Form1 : Form
    {
        const int FORM_WIDTH = 160;
        const int FORM_HEIGHT = 150;
        const int INCREMENT_DECREMENT = 20;
        public int x = 300, y = 130;

        public int originalX, originalY;
        public ArrayList movement;
        public string image;
        public int movementAmmount;

        SoundPlayer d;

        FormMovement formMover;
        private bool movementFlag = false;

        Form2[] obj = new Form2[12];

        public Form1()
        {
            InitializeComponent();
            initilize();
            locations();
            initialImage();
            d.Play();

        }

        private void initialImage()
        {
            this.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(this.image + "0");

            for(int i = 0; i < 12; i++)
                obj[i].BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(obj[i].image + "0");
        }

 

        private void initilize()
        {
            d = new SoundPlayer(Properties.Resources.music_2);

            this.Width = FORM_WIDTH;
            this.Height = FORM_HEIGHT;
            this.movement = new ArrayList();
            this.Icon = Properties.Resources.Kzzu_Surprise_Gift_4;

            for (int i = 0; i < 12; i++)
            {
                obj[i] = new Form2();
                obj[i].Width = FORM_WIDTH;
                obj[i].Height = FORM_HEIGHT;
                obj[i].movement = new ArrayList();
            }

            formMover = new FormMovement();
        }
        private void locations()
        {
            FormCharacteristics characteristics = new FormCharacteristics();

            //initializing locations and other charactaristics of this form
            this.x = this.originalX = 300;
            this.y = this.originalY = 130;
            this.Location = new Point(this.x, this.y);
            this.image = "h";
            this.movement.Add("x--");
            this.movement.Add("y--");
            this.movementAmmount = INCREMENT_DECREMENT;

            //initializing locations and other charactaristics of other forms
            int x = 300;
            for (int i = 0; i < 4; i++)
            {
                x += (FORM_WIDTH + 4);
                obj[i].Show();
                obj[i].x = obj[i].originalX = x;
                obj[i].y = obj[i].originalY = 130;
                obj[i].Location = new Point(obj[i].x, obj[i].y);

                obj[i].image = characteristics.imageName[i];
                obj[i].movement.Add(characteristics.movemenCharactaristics[i, 0]);
                obj[i].movement.Add(characteristics.movemenCharactaristics[i, 1]);

                if (i == 0 || i == 2)
                    obj[i].movementAmmount = INCREMENT_DECREMENT + 5;
                else
                    obj[i].movementAmmount = INCREMENT_DECREMENT;
            }

            x = -120;
            for (int i = 4; i < 12; i++)
            {
                x += (FORM_WIDTH + 4);
                obj[i].x = obj[i].originalX = x;
                obj[i].y = obj[i].originalY = 300;
                obj[i].Location = new Point(obj[i].x, obj[i].y);

                obj[i].image = characteristics.imageName[i];
                obj[i].movement.Add(characteristics.movemenCharactaristics[i, 0]);
                obj[i].movement.Add(characteristics.movemenCharactaristics[i, 1]);

                obj[i].movementAmmount = INCREMENT_DECREMENT;

                obj[i].Show();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Moving Forms
        private void formMovement()
        {
            formMover.moveForm(this);

            for (int i = 0; i < 12; i++)
                formMover.moveForm(obj[i]);

        }

        //Function To Change Background Image
        private void changePicture(int variable)
        {
            this.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(this.image + variable);

            for(int i = 0; i < 12; i++)
                obj[i].BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(obj[i].image + variable);


        }

        int n = 1;
        int imageChange = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            n++;
            if (movementFlag)
                formMovement();
            if(n == 100)
            {
                d.Stop();
                d = new SoundPlayer(Properties.Resources.music1);
                d.Play();
            }
            else if(n == 340)
            {
                d.Stop();
                d = new SoundPlayer(Properties.Resources.music);
                d.Play();
            }

            else if(n == 610)
            {
                d.Stop();
                d = new SoundPlayer(Properties.Resources.music3);
                d.Play();
            }

            if (n >= 30)
            {
                if (n == 60)
                    startMovement();

                if (n % 5 == 0)
                {
                    imageChange++;
                    if (imageChange > 3)
                        imageChange = 0;
                    changePicture(imageChange);
                }

                //Reversing Form's Movement
                if (n == 100)
                {
                    reverseMovement();
                    PicturesAndQutationShow o = new PicturesAndQutationShow(this);
                    o.Show();
                }

                else if (n % 100 == 0)
                    reverseMovement();  


            }
        }

        private void reverseMovement()
        {
            formMover.reverseMovement(this);
            for (int i = 0; i < 12; i++)
                formMover.reverseMovement(obj[i]);
        }

        public void startMovement()
        {
            movementFlag = true;
        }
        public void stopMovement()
        {
            movementFlag = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MessageBox.Show(n.ToString());
        }

        
    }
}
