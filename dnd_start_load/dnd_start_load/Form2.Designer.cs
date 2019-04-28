namespace dnd_start_load
{
    partial class Form2
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.encounterScreen1 = new dnd_start_load.EncounterScreen();
            this.gameManager1 = new dnd_start_load.gameManager();
            this.treasureGenScreen1 = new dnd_start_load.TreasureGenScreen();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 797);
            this.panel2.TabIndex = 1;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button7.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.button7.Location = new System.Drawing.Point(0, 96);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(200, 55);
            this.button7.TabIndex = 6;
            this.button7.Text = "Edit Game";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            this.button7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_MouseClick);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button6.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.button6.Location = new System.Drawing.Point(0, 206);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(200, 55);
            this.button6.TabIndex = 5;
            this.button6.Text = "Die Roll";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            this.button6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_MouseClick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F);
            this.button5.Location = new System.Drawing.Point(0, 151);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 55);
            this.button5.TabIndex = 4;
            this.button5.Text = "Treasure Generator";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_MouseClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 55);
            this.button1.TabIndex = 3;
            this.button1.Text = "Encounter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1290, 44);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(478, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dungeon Master Assistant";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(200, 44);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1024, 656);
            this.panel3.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(380, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 55);
            this.label2.TabIndex = 0;
            this.label2.Text = "Welcome";
            // 
            // encounterScreen1
            // 
            this.encounterScreen1.BackColor = System.Drawing.Color.DimGray;
            this.encounterScreen1.Location = new System.Drawing.Point(200, 44);
            this.encounterScreen1.Margin = new System.Windows.Forms.Padding(4);
            this.encounterScreen1.Name = "encounterScreen1";
            this.encounterScreen1.Size = new System.Drawing.Size(1007, 653);
            this.encounterScreen1.TabIndex = 4;
            this.encounterScreen1.Load += new System.EventHandler(this.encounterScreen1_Load);
            // 
            // gameManager1
            // 
            this.gameManager1.Location = new System.Drawing.Point(201, 45);
            this.gameManager1.Margin = new System.Windows.Forms.Padding(4);
            this.gameManager1.Name = "gameManager1";
            this.gameManager1.Size = new System.Drawing.Size(1024, 690);
            this.gameManager1.TabIndex = 3;
            this.gameManager1.Load += new System.EventHandler(this.gameManager1_Load);
            // 
            // treasureGenScreen1
            // 
            this.treasureGenScreen1.Location = new System.Drawing.Point(200, 44);
            this.treasureGenScreen1.Margin = new System.Windows.Forms.Padding(4);
            this.treasureGenScreen1.Name = "treasureGenScreen1";
            this.treasureGenScreen1.Size = new System.Drawing.Size(1024, 690);
            this.treasureGenScreen1.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1206, 695);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.encounterScreen1);
            this.Controls.Add(this.gameManager1);
            this.Controls.Add(this.treasureGenScreen1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1222, 734);
            this.MinimumSize = new System.Drawing.Size(1222, 726);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private gameManager gameManager1;
        private EncounterScreen encounterScreen1;
        private System.Windows.Forms.Label label1;
        private TreasureGenScreen treasureGenScreen1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
    }
}