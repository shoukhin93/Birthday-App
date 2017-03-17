using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Birthday_App
{
    public partial class Form2 : Form
    {
        public int x, y;
        public int originalX, originalY;
        public ArrayList movement;
        public string image;
        public int movementAmmount;
        public Form2()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.Kzzu_Surprise_Gift_4;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
