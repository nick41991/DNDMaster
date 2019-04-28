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
    }

    
}
