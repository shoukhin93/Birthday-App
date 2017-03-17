using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Birthday_App
{
    class FormMovement
    {
        public void moveForm(Form2 obj)
        {
            foreach (object o in obj.movement)
            {
                if (o.ToString() == "x++")
                    obj.x += obj.movementAmmount;
                else if (o.ToString() == "x--")
                    obj.x -= obj.movementAmmount;
                else if (o.ToString() == "y++")
                    obj.y += obj.movementAmmount;
                else if (o.ToString() == "y--")
                    obj.y -= obj.movementAmmount;
            }

            obj.Location = new Point(obj.x, obj.y);
        }

        public void moveForm(Form1 obj)
        {
            foreach (object o in obj.movement)
            {
                if (o.ToString() == "x++")
                    obj.x += obj.movementAmmount;
                else if (o.ToString() == "x--")
                    obj.x -= obj.movementAmmount;
                else if (o.ToString() == "y++")
                    obj.y += obj.movementAmmount;
                else if (o.ToString() == "y--")
                    obj.y -= obj.movementAmmount;
            }

            obj.Location = new Point(obj.x, obj.y);
            
        }

        //Function to reverse movement
        public void reverseMovement(Form2 obj)
        {
            int j = 0;
            string[] temp= new string[2];
            foreach (object o in obj.movement)
            {
                temp[j] = o.ToString();
                char[] array = temp[j].ToCharArray();
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == '+')
                        array[i] = '-';
                    else if (array[i] == '-')
                        array[i] = '+';
                }
                temp[j++] = new string(array);
           
            }

            obj.movement.Clear();
            obj.movement.Add(temp[0]);
            obj.movement.Add(temp[1]);
        }

        //Function to reverse movement
        public void reverseMovement(Form1 obj)
        {
            int j = 0;
            string[] temp = new string[2];
            foreach (object o in obj.movement)
            {
                temp[j] = o.ToString();
                char[] array = temp[j].ToCharArray();
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == '+')
                        array[i] = '-';
                    else if (array[i] == '-')
                        array[i] = '+';
                }
                temp[j++] = new string(array);

            }

            obj.movement.Clear();
            obj.movement.Add(temp[0]);
            obj.movement.Add(temp[1]);
        }
    }
}
