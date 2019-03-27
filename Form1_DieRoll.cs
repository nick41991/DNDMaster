/**
 * @author Brent Kernohan
 * 
 * @description Simulates die rolls with the Random class which is based on statistical requirements.
 * Once the die object is created with the Random class, a interval from 1 to selected die sides.
 * i.e. if the d100 die is selected for the simulation, the interval used would be from 1 - 100.
 * Furthermore, the random generated roll can be added with a constant defined by the players or the DM.
 * 
 * @todo
 *  -add in the operations: multiplication, subtraction, and division to add more benefit of using the app 
 *  -add the ability to do multiple die rolls in the form
 *
 * @bugs
 *  -fix the instance when button.dNum is pressed and clear after the re-selection of the button
 *
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int value = 0;
        bool summation_pressed = false;
        String dieNum;

        public Form1()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, EventArgs e)
        {
            if ((display.Text == "0") || (summation_pressed)) {
                display.Clear();
            }
            Button b = (Button)sender;
            display.Text = display.Text + b.Text;           
        }
        private void clear_Entry(object sender, EventArgs e)
        {
            display.Text = "0";
        }
        private void dieClick(object sender, EventArgs e)
        {
            if ((display.Text == "0") || (summation_pressed))
            {
                display.Clear();
            }
            Button b = (Button)sender;
            dieNum = b.Text;
            switch (dieNum)
            {
                case ("d100"):
                    Random d100 = new Random();
                    display.Text = display.Text + (d100.Next(1, 100).ToString());
                    break;
                case ("d20"):
                    Random d20 = new Random();
                    display.Text = display.Text + d20.Next(1, 20).ToString();
                    break;
                case ("d12"):
                    Random d12 = new Random();
                    display.Text = display.Text + d12.Next(1, 12).ToString();
                    break;
                case ("d10"):
                    Random d10 = new Random();
                    display.Text = display.Text + d10.Next(1, 10).ToString();
                    break;
                case ("d8"):
                    Random d8 = new Random();
                    display.Text = display.Text + d8.Next(1, 8).ToString();
                    break;
                case ("d6"):
                    Random d6 = new Random();
                    display.Text = display.Text + d6.Next(1, 6).ToString();
                    break;
                case ("d4"):
                    Random d4 = new Random();
                    display.Text = display.Text + d4.Next(1, 4).ToString();
                    break;
            }
        }
        private void summation(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            value = int.Parse(display.Text);
            summation_pressed = true;
            process.Text = value + " " + b.Text;
        }

        private void equals(object sender, EventArgs e)
        {
            process.Text = "";

            display.Text = (value + int.Parse(display.Text)).ToString();
            summation_pressed = false;
        }
    }
}
