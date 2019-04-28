﻿/**
 * @author Brent Kernohan
 * 
 * @description File designs the form to be implemented to make use of Form1_DieRoll.cs.
 * 
 *  @todo/bugs The Interface for the die roll simulation seems to be working fine 
 * but refer to DieRoller.cs for specific details about the die roll subsystem
 *
 */

namespace dnd_start_load
{
    partial class DieRoller
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.TextBox();
            this.button13 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.process = new System.Windows.Forms.Label();
            this.button24 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Gray;
            this.button1.Location = new System.Drawing.Point(1, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 65);
            this.button1.TabIndex = 0;
            this.button1.Text = "7";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Gray;
            this.button2.Location = new System.Drawing.Point(66, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 65);
            this.button2.TabIndex = 1;
            this.button2.Text = "8";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Maroon;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Gray;
            this.button3.Location = new System.Drawing.Point(131, 111);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 65);
            this.button3.TabIndex = 2;
            this.button3.Text = "9";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Maroon;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Gray;
            this.button4.Location = new System.Drawing.Point(261, 176);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(65, 65);
            this.button4.TabIndex = 3;
            this.button4.Text = "d12";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.dieClick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Maroon;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.Gray;
            this.button5.Location = new System.Drawing.Point(1, 176);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(65, 65);
            this.button5.TabIndex = 4;
            this.button5.Text = "4";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Maroon;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.Gray;
            this.button6.Location = new System.Drawing.Point(66, 176);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(65, 65);
            this.button6.TabIndex = 5;
            this.button6.Text = "5";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Maroon;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button7.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.Gray;
            this.button7.Location = new System.Drawing.Point(131, 176);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(65, 65);
            this.button7.TabIndex = 6;
            this.button7.Text = "6";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Maroon;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button8.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.Color.Gray;
            this.button8.Location = new System.Drawing.Point(196, 176);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(65, 65);
            this.button8.TabIndex = 7;
            this.button8.Text = "d20";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.dieClick);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Maroon;
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button9.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.Color.Gray;
            this.button9.Location = new System.Drawing.Point(1, 241);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(65, 65);
            this.button9.TabIndex = 8;
            this.button9.Text = "1";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Maroon;
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button10.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.ForeColor = System.Drawing.Color.Gray;
            this.button10.Location = new System.Drawing.Point(66, 241);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(65, 65);
            this.button10.TabIndex = 9;
            this.button10.Text = "2";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Maroon;
            this.button11.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button11.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.ForeColor = System.Drawing.Color.Gray;
            this.button11.Location = new System.Drawing.Point(131, 241);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(65, 65);
            this.button11.TabIndex = 10;
            this.button11.Text = "3";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Maroon;
            this.button12.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button12.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.ForeColor = System.Drawing.Color.Gray;
            this.button12.Location = new System.Drawing.Point(261, 111);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(65, 65);
            this.button12.TabIndex = 11;
            this.button12.Text = "d100";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.dieClick);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Maroon;
            this.button14.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button14.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.ForeColor = System.Drawing.Color.Gray;
            this.button14.Location = new System.Drawing.Point(1, 306);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(130, 65);
            this.button14.TabIndex = 13;
            this.button14.Text = "0";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Maroon;
            this.button16.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button16.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.ForeColor = System.Drawing.Color.Gray;
            this.button16.Location = new System.Drawing.Point(131, 306);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(65, 65);
            this.button16.TabIndex = 15;
            this.button16.Text = "=";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.equals);
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.SystemColors.ControlText;
            this.display.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.display.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.display.Location = new System.Drawing.Point(0, 0);
            this.display.Margin = new System.Windows.Forms.Padding(0);
            this.display.Multiline = true;
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(326, 45);
            this.display.TabIndex = 16;
            this.display.Text = "0";
            this.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Maroon;
            this.button13.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button13.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.ForeColor = System.Drawing.Color.Gray;
            this.button13.Location = new System.Drawing.Point(196, 241);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(65, 65);
            this.button13.TabIndex = 20;
            this.button13.Text = "d10";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.dieClick);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Maroon;
            this.button15.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button15.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.ForeColor = System.Drawing.Color.Gray;
            this.button15.Location = new System.Drawing.Point(261, 241);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(65, 65);
            this.button15.TabIndex = 19;
            this.button15.Text = "d8";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.dieClick);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.Maroon;
            this.button17.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button17.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.ForeColor = System.Drawing.Color.Gray;
            this.button17.Location = new System.Drawing.Point(196, 306);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(65, 65);
            this.button17.TabIndex = 18;
            this.button17.Text = "d6";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.dieClick);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.Maroon;
            this.button18.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button18.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.ForeColor = System.Drawing.Color.Gray;
            this.button18.Location = new System.Drawing.Point(261, 306);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(65, 65);
            this.button18.TabIndex = 17;
            this.button18.Text = "d4";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.dieClick);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.Maroon;
            this.button19.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button19.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.ForeColor = System.Drawing.Color.Gray;
            this.button19.Location = new System.Drawing.Point(196, 46);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(130, 65);
            this.button19.TabIndex = 21;
            this.button19.Text = "CE";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.clear_Entry);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.Maroon;
            this.button20.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button20.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.ForeColor = System.Drawing.Color.Gray;
            this.button20.Location = new System.Drawing.Point(196, 111);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(65, 65);
            this.button20.TabIndex = 22;
            this.button20.Text = "+";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.operation_click);
            // 
            // process
            // 
            this.process.BackColor = System.Drawing.SystemColors.ControlText;
            this.process.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.process.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.process.Location = new System.Drawing.Point(6, 6);
            this.process.Name = "process";
            this.process.Size = new System.Drawing.Size(88, 22);
            this.process.TabIndex = 23;
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.Maroon;
            this.button24.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button24.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button24.ForeColor = System.Drawing.Color.Gray;
            this.button24.Location = new System.Drawing.Point(66, 46);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(65, 65);
            this.button24.TabIndex = 27;
            this.button24.Text = "*";
            this.button24.UseVisualStyleBackColor = false;
            this.button24.Click += new System.EventHandler(this.operation_click);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.Maroon;
            this.button21.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button21.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button21.ForeColor = System.Drawing.Color.Gray;
            this.button21.Location = new System.Drawing.Point(1, 46);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(65, 65);
            this.button21.TabIndex = 28;
            this.button21.Text = "/";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.operation_click);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.Maroon;
            this.button22.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button22.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button22.ForeColor = System.Drawing.Color.Gray;
            this.button22.Location = new System.Drawing.Point(131, 46);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(65, 65);
            this.button22.TabIndex = 29;
            this.button22.Text = "-";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.operation_click);
            // 
            // DieRoller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(321, 372);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.process);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.display);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "DieRoller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "D&D Die Roller";
            this.TransparencyKey = System.Drawing.Color.White;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Label process;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
    }
}

