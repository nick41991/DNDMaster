namespace dnd_start_load
{
    partial class gameManager
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.monster_init = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.monster_image = new System.Windows.Forms.Button();
            this.add_monster = new System.Windows.Forms.Button();
            this.monster_name = new System.Windows.Forms.TextBox();
            this.monster_hp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.add_p = new System.Windows.Forms.Button();
            this.player_init = new System.Windows.Forms.TextBox();
            this.player_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.remove_p = new System.Windows.Forms.Button();
            this.playerdrop = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.remove_m = new System.Windows.Forms.Button();
            this.monsterdrop = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.monster_init);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.monster_image);
            this.panel1.Controls.Add(this.add_monster);
            this.panel1.Controls.Add(this.monster_name);
            this.panel1.Controls.Add(this.monster_hp);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(548, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 295);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_2);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(4, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 23);
            this.label12.TabIndex = 9;
            this.label12.Text = "Inititiative";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // monster_init
            // 
            this.monster_init.Location = new System.Drawing.Point(1, 168);
            this.monster_init.Name = "monster_init";
            this.monster_init.Size = new System.Drawing.Size(357, 20);
            this.monster_init.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 23);
            this.label10.TabIndex = 7;
            this.label10.Text = "Monster Image";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 23);
            this.label9.TabIndex = 7;
            this.label9.Text = "Hit Points";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "Monster Name";
            // 
            // monster_image
            // 
            this.monster_image.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monster_image.Location = new System.Drawing.Point(9, 222);
            this.monster_image.Name = "monster_image";
            this.monster_image.Size = new System.Drawing.Size(84, 29);
            this.monster_image.TabIndex = 6;
            this.monster_image.Text = "Select";
            this.monster_image.UseVisualStyleBackColor = true;
            // 
            // add_monster
            // 
            this.add_monster.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_monster.Location = new System.Drawing.Point(239, 257);
            this.add_monster.Name = "add_monster";
            this.add_monster.Size = new System.Drawing.Size(119, 38);
            this.add_monster.TabIndex = 5;
            this.add_monster.Text = "Add";
            this.add_monster.UseVisualStyleBackColor = true;
            this.add_monster.Click += new System.EventHandler(this.add_monster_Click);
            // 
            // monster_name
            // 
            this.monster_name.Location = new System.Drawing.Point(1, 70);
            this.monster_name.Name = "monster_name";
            this.monster_name.Size = new System.Drawing.Size(357, 20);
            this.monster_name.TabIndex = 4;
            // 
            // monster_hp
            // 
            this.monster_hp.Location = new System.Drawing.Point(1, 119);
            this.monster_hp.Name = "monster_hp";
            this.monster_hp.Size = new System.Drawing.Size(357, 20);
            this.monster_hp.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Add Monster";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.add_p);
            this.panel2.Controls.Add(this.player_init);
            this.panel2.Controls.Add(this.player_name);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(98, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(358, 295);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Inititiative";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Player Name";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // add_p
            // 
            this.add_p.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_p.Location = new System.Drawing.Point(239, 257);
            this.add_p.Name = "add_p";
            this.add_p.Size = new System.Drawing.Size(119, 38);
            this.add_p.TabIndex = 4;
            this.add_p.Text = "Add";
            this.add_p.UseVisualStyleBackColor = true;
            this.add_p.Click += new System.EventHandler(this.button1_Click);
            // 
            // player_init
            // 
            this.player_init.Location = new System.Drawing.Point(1, 119);
            this.player_init.Name = "player_init";
            this.player_init.Size = new System.Drawing.Size(357, 20);
            this.player_init.TabIndex = 3;
            // 
            // player_name
            // 
            this.player_name.Location = new System.Drawing.Point(1, 70);
            this.player_name.Name = "player_name";
            this.player_name.Size = new System.Drawing.Size(357, 20);
            this.player_name.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Player";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.remove_p);
            this.panel3.Controls.Add(this.playerdrop);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(98, 361);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(358, 187);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Player Name";
            // 
            // remove_p
            // 
            this.remove_p.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_p.Location = new System.Drawing.Point(239, 149);
            this.remove_p.Name = "remove_p";
            this.remove_p.Size = new System.Drawing.Size(119, 38);
            this.remove_p.TabIndex = 5;
            this.remove_p.Text = "Remove";
            this.remove_p.UseVisualStyleBackColor = true;
            // 
            // playerdrop
            // 
            this.playerdrop.FormattingEnabled = true;
            this.playerdrop.Location = new System.Drawing.Point(1, 79);
            this.playerdrop.Name = "playerdrop";
            this.playerdrop.Size = new System.Drawing.Size(357, 21);
            this.playerdrop.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 39);
            this.label3.TabIndex = 0;
            this.label3.Text = "Remove Player";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.remove_m);
            this.panel4.Controls.Add(this.monsterdrop);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(548, 361);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(358, 187);
            this.panel4.TabIndex = 0;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 23);
            this.label11.TabIndex = 7;
            this.label11.Text = "Monster Name";
            // 
            // remove_m
            // 
            this.remove_m.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_m.Location = new System.Drawing.Point(239, 149);
            this.remove_m.Name = "remove_m";
            this.remove_m.Size = new System.Drawing.Size(119, 38);
            this.remove_m.TabIndex = 6;
            this.remove_m.Text = "Remove";
            this.remove_m.UseVisualStyleBackColor = true;
            this.remove_m.Click += new System.EventHandler(this.remove_m_Click);
            // 
            // monsterdrop
            // 
            this.monsterdrop.FormattingEnabled = true;
            this.monsterdrop.Location = new System.Drawing.Point(1, 79);
            this.monsterdrop.Name = "monsterdrop";
            this.monsterdrop.Size = new System.Drawing.Size(357, 21);
            this.monsterdrop.TabIndex = 3;
            this.monsterdrop.SelectedIndexChanged += new System.EventHandler(this.monsterdrop_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 39);
            this.label4.TabIndex = 0;
            this.label4.Text = "Remove Monster";
            // 
            // gameManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "gameManager";
            this.Size = new System.Drawing.Size(1024, 690);
            this.Load += new System.EventHandler(this.gameManager_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox monster_name;
        private System.Windows.Forms.TextBox monster_hp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button add_p;
        private System.Windows.Forms.TextBox player_init;
        private System.Windows.Forms.TextBox player_name;
        private System.Windows.Forms.ComboBox playerdrop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox monsterdrop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button add_monster;
        private System.Windows.Forms.Button remove_p;
        private System.Windows.Forms.Button remove_m;
        private System.Windows.Forms.Button monster_image;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox monster_init;
    }
}
