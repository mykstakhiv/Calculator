﻿namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Display = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            Equal = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            SuspendLayout();
            // 
            // Display
            // 
            Display.Location = new Point(12, 12);
            Display.Name = "Display";
            Display.Size = new Size(411, 27);
            Display.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(329, 164);
            button1.Name = "button1";
            button1.Size = new Size(94, 90);
            button1.TabIndex = 1;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Multiply;
            // 
            // button2
            // 
            button2.Location = new Point(29, 164);
            button2.Name = "button2";
            button2.Size = new Size(94, 90);
            button2.TabIndex = 2;
            button2.Text = "7";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Seven;
            // 
            // button3
            // 
            button3.Location = new Point(129, 164);
            button3.Name = "button3";
            button3.Size = new Size(94, 90);
            button3.TabIndex = 3;
            button3.Text = "8";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Eight;
            // 
            // Equal
            // 
            Equal.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Equal.Location = new Point(329, 452);
            Equal.Name = "Equal";
            Equal.Size = new Size(94, 90);
            Equal.TabIndex = 4;
            Equal.Text = "=";
            Equal.UseVisualStyleBackColor = true;
            Equal.Click += End;
            // 
            // button4
            // 
            button4.Location = new Point(229, 164);
            button4.Name = "button4";
            button4.Size = new Size(94, 90);
            button4.TabIndex = 5;
            button4.Text = "9";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Nine;
            // 
            // button5
            // 
            button5.Location = new Point(329, 68);
            button5.Name = "button5";
            button5.Size = new Size(94, 90);
            button5.TabIndex = 6;
            button5.Text = "/";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Division;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(329, 260);
            button6.Name = "button6";
            button6.Size = new Size(94, 90);
            button6.TabIndex = 7;
            button6.Text = "-";
            button6.UseVisualStyleBackColor = true;
            button6.Click += Subtarction;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Location = new Point(329, 356);
            button7.Name = "button7";
            button7.Size = new Size(94, 90);
            button7.TabIndex = 8;
            button7.Text = "+";
            button7.UseVisualStyleBackColor = true;
            button7.Click += Addition;
            // 
            // button8
            // 
            button8.Location = new Point(29, 260);
            button8.Name = "button8";
            button8.Size = new Size(94, 90);
            button8.TabIndex = 9;
            button8.Text = "4";
            button8.UseVisualStyleBackColor = true;
            button8.Click += Four;
            // 
            // button9
            // 
            button9.Location = new Point(129, 260);
            button9.Name = "button9";
            button9.Size = new Size(94, 90);
            button9.TabIndex = 10;
            button9.Text = "5";
            button9.UseVisualStyleBackColor = true;
            button9.Click += Five;
            // 
            // button10
            // 
            button10.Location = new Point(229, 260);
            button10.Name = "button10";
            button10.Size = new Size(94, 90);
            button10.TabIndex = 11;
            button10.Text = "6";
            button10.UseVisualStyleBackColor = true;
            button10.Click += Six;
            // 
            // button11
            // 
            button11.Location = new Point(29, 356);
            button11.Name = "button11";
            button11.Size = new Size(94, 90);
            button11.TabIndex = 12;
            button11.Text = "1";
            button11.UseVisualStyleBackColor = true;
            button11.Click += One;
            // 
            // button12
            // 
            button12.Location = new Point(129, 356);
            button12.Name = "button12";
            button12.Size = new Size(94, 90);
            button12.TabIndex = 13;
            button12.Text = "2";
            button12.UseVisualStyleBackColor = true;
            button12.Click += Two;
            // 
            // button13
            // 
            button13.Location = new Point(229, 356);
            button13.Name = "button13";
            button13.Size = new Size(94, 90);
            button13.TabIndex = 14;
            button13.Text = "3";
            button13.UseVisualStyleBackColor = true;
            button13.Click += Three;
            // 
            // button14
            // 
            button14.Location = new Point(129, 452);
            button14.Name = "button14";
            button14.Size = new Size(94, 90);
            button14.TabIndex = 15;
            button14.Text = "0";
            button14.UseVisualStyleBackColor = true;
            button14.Click += Zero;
            // 
            // button15
            // 
            button15.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button15.Location = new Point(229, 452);
            button15.Name = "button15";
            button15.Size = new Size(94, 90);
            button15.TabIndex = 16;
            button15.Text = ".";
            button15.UseVisualStyleBackColor = true;
            button15.Click += Dote;
            // 
            // button16
            // 
            button16.Location = new Point(229, 68);
            button16.Name = "button16";
            button16.Size = new Size(94, 90);
            button16.TabIndex = 17;
            button16.Text = "<x";
            button16.UseVisualStyleBackColor = true;
            button16.Click += DeleteLast;
            // 
            // button17
            // 
            button17.Location = new Point(129, 68);
            button17.Name = "button17";
            button17.Size = new Size(94, 90);
            button17.TabIndex = 18;
            button17.Text = "AC";
            button17.UseVisualStyleBackColor = true;
            button17.Click += DeleteAll;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 586);
            Controls.Add(button17);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(Equal);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Display);
            Name = "Form1";
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Display;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button Equal;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
    }
}
