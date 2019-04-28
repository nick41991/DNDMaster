namespace dnd_start_load
{
    partial class EncounterScreen
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
            this.playernames = new System.Windows.Forms.TextBox();
            this.startbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.updatebutton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.playerRotationDisplay = new System.Windows.Forms.TextBox();
            this.updateTurnOrder = new System.Windows.Forms.Button();
            this.hpbutton = new System.Windows.Forms.Button();
            this.hpbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // playernames
            // 
            this.playernames.BackColor = System.Drawing.SystemColors.ControlLight;
            this.playernames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playernames.Location = new System.Drawing.Point(-2, 67);
            this.playernames.Multiline = true;
            this.playernames.Name = "playernames";
            this.playernames.ReadOnly = true;
            this.playernames.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.playernames.Size = new System.Drawing.Size(279, 205);
            this.playernames.TabIndex = 0;
            this.playernames.TextChanged += new System.EventHandler(this.playernames_TextChanged);
            // 
            // startbutton
            // 
            this.startbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startbutton.Location = new System.Drawing.Point(582, 215);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(162, 46);
            this.startbutton.TabIndex = 2;
            this.startbutton.Text = "Start";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.OrangeRed;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 68);
            this.label1.TabIndex = 3;
            this.label1.Text = "Players";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updatebutton
            // 
            this.updatebutton.Location = new System.Drawing.Point(911, 577);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(97, 44);
            this.updatebutton.TabIndex = 4;
            this.updatebutton.Text = "Update Characters";
            this.updatebutton.UseVisualStyleBackColor = true;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(-2, 338);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(279, 282);
            this.textBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.OrangeRed;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-1, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 68);
            this.label2.TabIndex = 6;
            this.label2.Text = "Monster Stats";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerRotationDisplay
            // 
            this.playerRotationDisplay.BackColor = System.Drawing.Color.Black;
            this.playerRotationDisplay.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerRotationDisplay.ForeColor = System.Drawing.Color.White;
            this.playerRotationDisplay.Location = new System.Drawing.Point(276, 0);
            this.playerRotationDisplay.Multiline = true;
            this.playerRotationDisplay.Name = "playerRotationDisplay";
            this.playerRotationDisplay.ReadOnly = true;
            this.playerRotationDisplay.Size = new System.Drawing.Size(732, 68);
            this.playerRotationDisplay.TabIndex = 7;
            this.playerRotationDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.playerRotationDisplay.TextChanged += new System.EventHandler(this.playerRotationDisplay_TextChanged);
            // 
            // updateTurnOrder
            // 
            this.updateTurnOrder.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateTurnOrder.Location = new System.Drawing.Point(880, 1);
            this.updateTurnOrder.Name = "updateTurnOrder";
            this.updateTurnOrder.Size = new System.Drawing.Size(127, 65);
            this.updateTurnOrder.TabIndex = 8;
            this.updateTurnOrder.Text = "Advance Turn";
            this.updateTurnOrder.UseVisualStyleBackColor = true;
            this.updateTurnOrder.Click += new System.EventHandler(this.updateTurnOrder_Click);
            // 
            // hpbutton
            // 
            this.hpbutton.Location = new System.Drawing.Point(130, 571);
            this.hpbutton.Name = "hpbutton";
            this.hpbutton.Size = new System.Drawing.Size(115, 46);
            this.hpbutton.TabIndex = 9;
            this.hpbutton.Text = "Change HP";
            this.hpbutton.UseVisualStyleBackColor = true;
            this.hpbutton.Click += new System.EventHandler(this.hpbutton_Click);
            // 
            // hpbox
            // 
            this.hpbox.Location = new System.Drawing.Point(14, 585);
            this.hpbox.Name = "hpbox";
            this.hpbox.Size = new System.Drawing.Size(100, 20);
            this.hpbox.TabIndex = 10;
            // 
            // EncounterScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.hpbox);
            this.Controls.Add(this.hpbutton);
            this.Controls.Add(this.updateTurnOrder);
            this.Controls.Add(this.playerRotationDisplay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.playernames);
            this.Name = "EncounterScreen";
            this.Size = new System.Drawing.Size(1007, 620);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox playernames;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox playerRotationDisplay;
        private System.Windows.Forms.Button updateTurnOrder;
        private System.Windows.Forms.Button hpbutton;
        private System.Windows.Forms.TextBox hpbox;
    }
}
