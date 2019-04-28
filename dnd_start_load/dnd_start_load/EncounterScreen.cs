using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dnd_start_load
{
    public partial class EncounterScreen : UserControl
    {





        //Form2 form;
        List<Player> players;
        List<Monster> monsters;


        List<Button> buttons = new List<Button>();

        public void place_button(int x, int y, String img_target, Monster title)
        {

            Point newLoc = new Point(x, y); // Set whatever you want for initial location
            int same_loc_flag = 0;
            Button b = new Button();
            string curdir = AppDomain.CurrentDomain.BaseDirectory;

                b.Name = title.getName();
            

            if (img_target != null)
            {
                b.BackgroundImage = System.Drawing.Image.FromFile(curdir + "Images\\" + img_target + ".jpg");
                b.BackgroundImageLayout = ImageLayout.Stretch;
            }
            b.Location = newLoc;


            foreach (Button n in buttons)
            {

                if (n.Location == b.Location)
                {

                    same_loc_flag = 1;
                    break;
                }

            }

            if (same_loc_flag == 0)
            {

                buttons.Add(b);

            }


            b.MouseClick += (sender, e) => button_opt(sender, e, title.getName());
            //Controls.Add(b);
            //*
            foreach (Button z in buttons)
            {
                Controls.Add(z);
               
                z.Size = new Size(175, 125);

            }
            //*/
        }
        public void button_opt(object s, EventArgs e,String i)
        {
            textBox1.Text = null;
            textBox1.Text = i;


        }
        public void remove_button(String name) {

            foreach (Button b in buttons)
            {
                if (b.Name == name) {

                    buttons.Remove(b);
                }
            }
        }





        public EncounterScreen()
        {
            InitializeComponent();
            updatebutton.Hide();
        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            Form2 form = (Form2)this.Parent;
            players = form.game.getPlayers();
            monsters = form.game.getMonsters();
            int x = 300;
            int y = 50;

            foreach (Monster n in monsters)
            {
                place_button(x, y, "Monster_2", n);
                x = x + 180;


            }
            foreach (Button n in buttons)
            {

                n.BringToFront();

            }


            string s = "";
            foreach (Player p in players)
            {
                s = String.Concat(s,"player: " + p.getName() + "\tinit: " + p.getinit() + Environment.NewLine + Environment.NewLine);
            }
            
            playernames.Text = s;
            startbutton.Hide();
            updatebutton.Visible = true;
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
           
            Form2 form = (Form2)this.Parent;
            players = form.game.getPlayers();

            string s = "";
            foreach (Player p in players)
            {
                s = String.Concat(s, "player: " + p.getName() + "\tinit: " + p.getinit() + Environment.NewLine + Environment.NewLine);
            }

            playernames.Text = s;

        }

        private void playernames_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void playerRotationDisplay_TextChanged(object sender, EventArgs e)
        {

        }
    }

    
}
