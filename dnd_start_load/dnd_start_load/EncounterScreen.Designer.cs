﻿namespace dnd_start_load
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 734);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OrangeRed;
            this.panel2.Location = new System.Drawing.Point(608, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(155, 734);
            this.panel2.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(0, 401);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(155, 27);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // EncounterScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "EncounterScreen";
            this.Size = new System.Drawing.Size(1007, 653);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listView1;
    }
}
