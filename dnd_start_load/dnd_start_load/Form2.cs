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
    

    public partial class Form2 : Form
    {
        int signal = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            signal = 4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            signal = 1;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            signal = 5;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            signal = 7;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            signal = 6;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_MouseClick(object sender, MouseEventArgs e)
        {

            if (signal == 1)
            {
                button1.ForeColor = System.Drawing.Color.Orange;
                button5.ForeColor = System.Drawing.Color.Black;
                button6.ForeColor = System.Drawing.Color.Black;
                button7.ForeColor = System.Drawing.Color.Black;

            }
            if (signal == 5)
            {
                button1.ForeColor = System.Drawing.Color.Black;
                button5.ForeColor = System.Drawing.Color.Orange;
                button6.ForeColor = System.Drawing.Color.Black;
                button7.ForeColor = System.Drawing.Color.Black;

            }
            if (signal == 6)
            {
                button1.ForeColor = System.Drawing.Color.Black;
                button5.ForeColor = System.Drawing.Color.Black;
                button6.ForeColor = System.Drawing.Color.Orange;
                button7.ForeColor = System.Drawing.Color.Black;

            }
            if (signal == 7)
            {
                button7.ForeColor = System.Drawing.Color.Orange;
                button5.ForeColor = System.Drawing.Color.Black;
                button6.ForeColor = System.Drawing.Color.Black;
                button1.ForeColor = System.Drawing.Color.Black;

            }
        }

       
    }
}
