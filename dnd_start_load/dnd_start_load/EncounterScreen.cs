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

        List<Character> turnOrder;
        int turnPosition;

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


            b.MouseClick += (sender, e) => button_opt(sender, e, title);
            //Controls.Add(b);
            //*
            foreach (Button z in buttons)
            {
                Controls.Add(z);
               
                z.Size = new Size(175, 125);

            }
            //*/
        }
        public void button_opt(object s, EventArgs e, Monster monster)
        {
            textBox1.Text = null;
            textBox1.Text = monster.getName() + Environment.NewLine + "Health: " + monster.getHp() + Environment.NewLine +"init:" + monster.getinit();

        }
        public void remove_button(String name) {

            bool flag = false;
            Button n = null;

            foreach (Button b in buttons)
            {
                if (b.Name.Equals(name)) {

                    flag = true;
                    n = b;
                }
            }
            if (flag) {
                buttons.Remove(n);
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
            draw_update();

            string s = "";
            foreach (Player p in players)
            {
                s = String.Concat(s,"player: " + p.getName() + "\tinit: " + p.getinit() + Environment.NewLine + Environment.NewLine);
            }

            turnOrder = form.game.generateTurnOrder();
            turnPosition = 0;
            playerRotationDisplay.Text = turnOrder.ElementAt(turnPosition).getName() + "'s Turn";
            
            playernames.Text = s;
            startbutton.Hide();
            updatebutton.Visible = true;
        }
        public void draw_update() {

            Form2 form = (Form2)this.Parent;
            monsters = form.game.getMonsters();
            int x = 105;
            int y = 70;

            foreach (Monster n in monsters)
            {


                if (x + 180 <= 1000)
                {
                    x = x + 180;
                }
                else
                {

                    x = 285;
                    y = y + 125;
                }

                place_button(x, y, "Monster_2", n);

            }
            foreach (Button n in buttons)
            {

                n.BringToFront();

            }






        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
           
            Form2 form = (Form2)this.Parent;
            gameManager gm = new gameManager();
            players = form.game.getPlayers();
            draw_update();
            
            remove_button("a");
            form.game.deleteMonster("a");
            draw_update();

            string s = "";
            foreach (Player p in players)
            {
                s = String.Concat(s, "player: " + p.getName() + "\tinit: " + p.getinit() + Environment.NewLine + Environment.NewLine);
            }

            playernames.Text = s;

            String cur = turnOrder.ElementAt(turnPosition).getName();
            turnOrder = form.game.generateTurnOrder();
            turnPosition = 0;
            foreach(Character c in turnOrder) /*Dom't skip the player who's turn it is*/
            {
                if (cur.Equals(c.getName()))
                {
                    break;
                }
                turnPosition++;
            }
            playerRotationDisplay.Text = turnOrder.ElementAt(turnPosition).getName() + "'s Turn";

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

        private void updateTurnOrder_Click(object sender, EventArgs e)
        {
            turnPosition++;
            if(turnPosition >= turnOrder.Count)
            {
                turnPosition = 0;
            }
            playerRotationDisplay.Text = turnOrder.ElementAt(turnPosition).getName() + "'s Turn";
        }
    }

    
}
