﻿namespace Screen_Shot
{
    partial class Form1
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
            this.button1take = new System.Windows.Forms.Button();
            this.button2move = new System.Windows.Forms.Button();
            this.counter_title = new System.Windows.Forms.Label();
            this.counter_Number_label = new System.Windows.Forms.Label();
            this.output_Label = new System.Windows.Forms.Label();
            this.output_number_label1 = new System.Windows.Forms.Label();
            this.point = new System.Windows.Forms.Label();
            this.output_number_label2 = new System.Windows.Forms.Label();
            this.button3move = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1take
            // 
            this.button1take.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1take.Location = new System.Drawing.Point(12, 50);
            this.button1take.Name = "button1take";
            this.button1take.Size = new System.Drawing.Size(93, 83);
            this.button1take.TabIndex = 0;
            this.button1take.Text = "take ScreenShot";
            this.button1take.UseVisualStyleBackColor = true;
            this.button1take.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2move
            // 
            this.button2move.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2move.Location = new System.Drawing.Point(111, 51);
            this.button2move.Name = "button2move";
            this.button2move.Size = new System.Drawing.Size(85, 83);
            this.button2move.TabIndex = 1;
            this.button2move.Text = "left click pixel ";
            this.button2move.UseVisualStyleBackColor = true;
            this.button2move.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Button2findPixelLocation_MouseClick);
            // 
            // counter_title
            // 
            this.counter_title.AutoSize = true;
            this.counter_title.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counter_title.Location = new System.Drawing.Point(72, 9);
            this.counter_title.Name = "counter_title";
            this.counter_title.Size = new System.Drawing.Size(98, 28);
            this.counter_title.TabIndex = 2;
            this.counter_title.Text = "Counter:";
            // 
            // counter_Number_label
            // 
            this.counter_Number_label.AutoSize = true;
            this.counter_Number_label.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counter_Number_label.Location = new System.Drawing.Point(170, 9);
            this.counter_Number_label.Name = "counter_Number_label";
            this.counter_Number_label.Size = new System.Drawing.Size(0, 28);
            this.counter_Number_label.TabIndex = 3;
            // 
            // output_Label
            // 
            this.output_Label.AutoSize = true;
            this.output_Label.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_Label.Location = new System.Drawing.Point(72, 149);
            this.output_Label.Name = "output_Label";
            this.output_Label.Size = new System.Drawing.Size(85, 28);
            this.output_Label.TabIndex = 4;
            this.output_Label.Text = "output:";
            // 
            // output_number_label1
            // 
            this.output_number_label1.AutoSize = true;
            this.output_number_label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_number_label1.Location = new System.Drawing.Point(163, 149);
            this.output_number_label1.Name = "output_number_label1";
            this.output_number_label1.Size = new System.Drawing.Size(24, 28);
            this.output_number_label1.TabIndex = 5;
            this.output_number_label1.Text = "0";
            // 
            // point
            // 
            this.point.AutoSize = true;
            this.point.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.point.Location = new System.Drawing.Point(187, 149);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(17, 28);
            this.point.TabIndex = 6;
            this.point.Text = ",";
            // 
            // output_number_label2
            // 
            this.output_number_label2.AutoSize = true;
            this.output_number_label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_number_label2.Location = new System.Drawing.Point(210, 149);
            this.output_number_label2.Name = "output_number_label2";
            this.output_number_label2.Size = new System.Drawing.Size(24, 28);
            this.output_number_label2.TabIndex = 7;
            this.output_number_label2.Text = "0";
            // 
            // button3move
            // 
            this.button3move.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3move.Location = new System.Drawing.Point(201, 51);
            this.button3move.Name = "button3move";
            this.button3move.Size = new System.Drawing.Size(83, 83);
            this.button3move.TabIndex = 8;
            this.button3move.Text = "right click pixel ";
            this.button3move.UseVisualStyleBackColor = true;
            this.button3move.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Button3move_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(304, 202);
            this.Controls.Add(this.button3move);
            this.Controls.Add(this.output_number_label2);
            this.Controls.Add(this.point);
            this.Controls.Add(this.output_number_label1);
            this.Controls.Add(this.output_Label);
            this.Controls.Add(this.counter_Number_label);
            this.Controls.Add(this.counter_title);
            this.Controls.Add(this.button2move);
            this.Controls.Add(this.button1take);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1take;
        private System.Windows.Forms.Button button2move;
        private System.Windows.Forms.Label counter_title;
        private System.Windows.Forms.Label counter_Number_label;
        private System.Windows.Forms.Label output_Label;
        private System.Windows.Forms.Label output_number_label1;
        private System.Windows.Forms.Label point;
        private System.Windows.Forms.Label output_number_label2;
        private System.Windows.Forms.Button button3move;
    }
}

