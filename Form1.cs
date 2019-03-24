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