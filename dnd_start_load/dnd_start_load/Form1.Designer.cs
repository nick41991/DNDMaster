namespace dnd_start_load
{
    partial class Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Banner = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Corner_menu = new System.Windows.Forms.Panel();
            this.New_game = new System.Windows.Forms.Button();
            this.Load_button = new System.Windows.Forms.Button();
            this.Banner.SuspendLayout();
            this.Corner_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Banner
            // 
            this.Banner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Banner.Controls.Add(this.panel2);
            this.Banner.Dock = System.Windows.Forms.DockStyle.Top;
            this.Banner.Location = new System.Drawing.Point(0, 0);
            this.Banner.Name = "Banner";
            this.Banner.Size = new System.Drawing.Size(1284, 40);
            this.Banner.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 0;
            // 
            // Corner_menu
            // 
            this.Corner_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Corner_menu.Controls.Add(this.Load_button);
            this.Corner_menu.Controls.Add(this.New_game);
            this.Corner_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Corner_menu.Location = new System.Drawing.Point(0, 40);
            this.Corner_menu.Name = "Corner_menu";
            this.Corner_menu.Size = new System.Drawing.Size(200, 556);
            this.Corner_menu.TabIndex = 1;
            // 
            // New_game
            // 
            this.New_game.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.New_game.Location = new System.Drawing.Point(12, 66);
            this.New_game.Name = "New_game";
            this.New_game.Size = new System.Drawing.Size(165, 62);
            this.New_game.TabIndex = 2;
            this.New_game.Text = "New game";
            this.New_game.UseVisualStyleBackColor = false;
            // 
            // Load_button
            // 
            this.Load_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Load_button.Location = new System.Drawing.Point(12, 167);
            this.Load_button.Name = "Load_button";
            this.Load_button.Size = new System.Drawing.Size(165, 62);
            this.Load_button.TabIndex = 3;
            this.Load_button.Text = "Load Game";
            this.Load_button.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1284, 596);
            this.Controls.Add(this.Corner_menu);
            this.Controls.Add(this.Banner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Form1";
            this.Banner.ResumeLayout(false);
            this.Corner_menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Banner;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel Corner_menu;
        private System.Windows.Forms.Button Load_button;
        private System.Windows.Forms.Button New_game;
    }
}

