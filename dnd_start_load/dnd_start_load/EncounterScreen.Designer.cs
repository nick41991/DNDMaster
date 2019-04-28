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
            this.SuspendLayout();
            // 
            // playernames
            // 
            this.playernames.BackColor = System.Drawing.SystemColors.ControlLight;
            this.playernames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playernames.Location = new System.Drawing.Point(-3, 82);
            this.playernames.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.playernames.Multiline = true;
            this.playernames.Name = "playernames";
            this.playernames.ReadOnly = true;
            this.playernames.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.playernames.Size = new System.Drawing.Size(371, 680);
            this.playernames.TabIndex = 0;
            this.playernames.TextChanged += new System.EventHandler(this.playernames_TextChanged);
            // 
            // startbutton
            // 
            this.startbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startbutton.Location = new System.Drawing.Point(776, 265);
            this.startbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(216, 57);
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
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 84);
            this.label1.TabIndex = 3;
            this.label1.Text = "Players";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updatebutton
            // 
            this.updatebutton.Location = new System.Drawing.Point(1213, 0);
            this.updatebutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(129, 54);
            this.updatebutton.TabIndex = 4;
            this.updatebutton.Text = "Update Players";
            this.updatebutton.UseVisualStyleBackColor = true;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // EncounterScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.playernames);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EncounterScreen";
            this.Size = new System.Drawing.Size(1343, 763);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox playernames;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button updatebutton;
    }
}
