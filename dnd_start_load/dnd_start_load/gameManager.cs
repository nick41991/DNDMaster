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
    public partial class gameManager : UserControl
    {
        //Form2 form;
        public gameManager()
        {
            InitializeComponent();
            //form = (Form2)this.Parent;
        }

       /* private void add_p_Click(object sender, EventArgs e)
        {
            form.game.addPlayer(player_name.Text, player_init.Text);
            player_name.Clear();
            player_init.Clear(); 
        }*/

        private void gameManager_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = (Form2)this.Parent;
            form.game.addPlayer(player_name.Text, player_init.Text);
            playerdrop.Items.Add(player_name.Text);
            player_name.Clear();
            player_init.Clear();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void add_monster_Click(object sender, EventArgs e)
        {
            Form2 form = (Form2)this.Parent;
            form.game.addMonster(new Monster(monster_name.Text, monster_init.Text, monster_hp.Text));
            monsterdrop.Items.Add(monster_name.Text);
            monster_name.Clear();
            monster_init.Clear();
            monster_hp.Clear();
            
           
        }

        private void remove_p_Click(object sender, EventArgs e)
        {
            Form2 form = (Form2)this.Parent;
            form.game.deletePlayer(playerdrop.Text);
            playerdrop.Items.Remove(playerdrop.Text);
            playerdrop.Text = "";
        }

        private void monsterdrop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void remove_m_Click(object sender, EventArgs e)
        {
            Form2 form = (Form2)this.Parent;
            form.game.deleteMonster(monsterdrop.Text);
            monsterdrop.Items.Remove(monsterdrop.Text);
            monsterdrop.Text = "";
        }
    }
}
