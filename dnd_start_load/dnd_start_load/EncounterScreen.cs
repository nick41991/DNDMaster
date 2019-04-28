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

        List<Button> buttons = new List<Button>();

        public void place_button(int x, int y, String img_target)
        {

            Point newLoc = new Point(x, y); // Set whatever you want for initial location
            int same_loc_flag = 0;
            Button b = new Button();
            string curdir = AppDomain.CurrentDomain.BaseDirectory;
            int test_var = 0;

            if (img_target != null)
            {
                b.Image = System.Drawing.Image.FromFile(curdir + "Images\\" + img_target + ".jpg");
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

            //Controls.Add(b);
            //*
            foreach (Button z in buttons)
            {
                test_var = 300;
                Controls.Add(z);
                //z.Click += (sender, e) => button_opt(sender, e, test_var);
                test_var = test_var + 300;
                z.Size = new Size(175, 125);


                z.Name = "YO";
            }
            //*/
        }
        public void button_opt(object s, EventArgs e, int i)
        {

            place_button(i + 10, i, "Monster_2");

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
    }

    
}
