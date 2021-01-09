namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.label1KeyPresser = new System.Windows.Forms.Label();
            this.button1Start = new System.Windows.Forms.Button();
            this.button1Stop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1KeyPresser
            // 
            this.label1KeyPresser.AutoSize = true;
            this.label1KeyPresser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1KeyPresser.Location = new System.Drawing.Point(78, 24);
            this.label1KeyPresser.Name = "label1KeyPresser";
            this.label1KeyPresser.Size = new System.Drawing.Size(165, 31);
            this.label1KeyPresser.TabIndex = 0;
            this.label1KeyPresser.Text = "KeyPresser";
            // 
            // button1Start
            // 
            this.button1Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1Start.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Start.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1Start.Location = new System.Drawing.Point(12, 78);
            this.button1Start.Name = "button1Start";
            this.button1Start.Size = new System.Drawing.Size(130, 66);
            this.button1Start.TabIndex = 1;
            this.button1Start.Text = "Start";
            this.button1Start.UseVisualStyleBackColor = false;
            this.button1Start.Click += new System.EventHandler(this.button1Start_Click);
            // 
            // button1Stop
            // 
            this.button1Stop.BackColor = System.Drawing.Color.Red;
            this.button1Stop.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Stop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1Stop.Location = new System.Drawing.Point(181, 78);
            this.button1Stop.Name = "button1Stop";
            this.button1Stop.Size = new System.Drawing.Size(130, 66);
            this.button1Stop.TabIndex = 2;
            this.button1Stop.Text = "Stop";
            this.button1Stop.UseVisualStyleBackColor = false;
            this.button1Stop.Click += new System.EventHandler(this.button1Stop_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 165);
            this.Controls.Add(this.button1Stop);
            this.Controls.Add(this.button1Start);
            this.Controls.Add(this.label1KeyPresser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1KeyPresser;
        private System.Windows.Forms.Button button1Start;
        private System.Windows.Forms.Button button1Stop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

