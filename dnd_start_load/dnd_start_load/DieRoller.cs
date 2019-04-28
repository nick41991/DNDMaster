/**
 * @author Brent Kernohan
 * 
 * @description Simulates die rolls with the Random class which is based on statistical requirements.
 * Once the die object is created with the Random class, an interval from 1 to selected die sides is instantiated.
 * i.e. if the d100 die is selected for the simulation, the interval used would be from 1 - 100.
 * Furthermore, the random generated roll can be added with a constant defined by the players or the DM.
 * 
 * To roll multiple times, the user can select desired die and then that value will be stored in the process label.
 * That stored value can then be added onto with another die roll which can be done by clicking another desired die.
 *
 * @todo
 *  -none
 *
 * @bugs
 *  -none
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

namespace dnd_start_load
{
    public partial class DieRoller : Form
    {
        int value = 0;
        int dieRolls = 0;
        //dieRolls = Int32.Parse(display.Text);
        bool operation_pressed = false;
        bool dnum_pressed = false;
        String operation = "";
        String dieNum;

        public DieRoller()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, EventArgs e)
        {
            if ((display.Text == "0") || (operation_pressed))
            {
                display.Clear();
            }
            operation_pressed = false;
            Button b = (Button)sender;
            display.Text = display.Text + b.Text;           
        }
        private void clear_Entry(object sender, EventArgs e)
        {
            display.Text = "0";
            process.Text = "";
        }
        private void dieClick(object sender, EventArgs e)
        {
            if (display.Text == "0")
            {
                display.Clear();
            }
            Button b = (Button)sender;
            dieNum = b.Text;
            if (dnum_pressed == true){
                display.Clear();
                dnum_pressed = false;
            }
            switch (dieNum)
            {
                case ("d100"):
                    Random d100 = new Random();
                    display.Text = display.Text + d100.Next(1, 100).ToString();
                    dnum_pressed = true;
                    //i++;
                    break;
                case ("d20"):
                    Random d20 = new Random();
                    display.Text = display.Text + d20.Next(1, 20).ToString();
                    dnum_pressed = true;
                    //i++;
                    break;
                case ("d12"):
                    Random d12 = new Random();
                    display.Text = display.Text + d12.Next(1, 12).ToString();
                    dnum_pressed = true;
                    //i++;
                    break;
                case ("d10"):
                    Random d10 = new Random();
                    display.Text = display.Text + d10.Next(1, 10).ToString();
                    dnum_pressed = true;
                    //i++;
                    break;
                case ("d8"):
                    Random d8 = new Random();
                    display.Text = display.Text + d8.Next(1, 8).ToString();
                    dnum_pressed = true;
                    //i++;
                    break;
                case ("d6"):
                    Random d6 = new Random();
                    display.Text = display.Text + d6.Next(1, 6).ToString();
                    dnum_pressed = true;
                    //i++;
                    break;
                case ("d4"):
                    Random d4 = new Random();
                    display.Text = display.Text + d4.Next(1, 4).ToString();
                    dnum_pressed = true;
                    //i++;
                    break;
                default:
                    //i++;
                    break;
            }//end of d-switch cas
        }
        private void operation_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = int.Parse(display.Text);
            operation_pressed = true;
            process.Text = value + operation;
        }
        private void equals(object sender, EventArgs e)
        {
            switch(operation)
            { 
                case "+":
                    display.Text = (value + int.Parse(display.Text)).ToString();
                    break;
                case "/":
                   display.Text = (value / int.Parse(display.Text)).ToString();
                    break;
                case "*":
                    display.Text = (value * int.Parse(display.Text)).ToString();
                    break;
                case "-":
                    display.Text = (value - int.Parse(display.Text)).ToString();
                    break;
                default:
                    break;
            }
        }
    }
}