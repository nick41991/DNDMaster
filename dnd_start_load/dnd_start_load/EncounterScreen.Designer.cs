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
            this.panel2 = new System.Windows.Forms.Panel();
            this.playernames = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OrangeRed;
            this.panel2.Location = new System.Drawing.Point(869, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(155, 690);
            this.panel2.TabIndex = 1;
            // 
            // playernames
            // 
            this.playernames.BackColor = System.Drawing.Color.OrangeRed;
            this.playernames.Location = new System.Drawing.Point(0, 0);
            this.playernames.Multiline = true;
            this.playernames.Name = "playernames";
            this.playernames.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.playernames.Size = new System.Drawing.Size(172, 690);
            this.playernames.TabIndex = 0;
            // 
            // EncounterScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.playernames);
            this.Controls.Add(this.panel2);
            this.Name = "EncounterScreen";
            this.Size = new System.Drawing.Size(1024, 690);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox playernames;
    }
}
