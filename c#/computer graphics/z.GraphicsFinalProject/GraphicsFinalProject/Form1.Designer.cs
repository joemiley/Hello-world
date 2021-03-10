namespace GraphicsFinalProject
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
            this.shapeListBox = new System.Windows.Forms.ListBox();
            this.DisplayTimer = new System.Windows.Forms.Timer(this.components);
            this.button1Delete = new System.Windows.Forms.Button();
            this.button2Resize = new System.Windows.Forms.Button();
            this.panel1EditSizeSquare = new System.Windows.Forms.Panel();
            this.panel1EditSizeSquarebtnEXIT = new System.Windows.Forms.Button();
            this.panel1EditSizeSquareLabel = new System.Windows.Forms.Label();
            this.panel1EditSizeSquarebtnSMALLER = new System.Windows.Forms.Button();
            this.panel1EditSizeSquarebtnBIGGER = new System.Windows.Forms.Button();
            this.panel1EditSizeSquare.SuspendLayout();
            this.SuspendLayout();
            // 
            // shapeListBox
            // 
            this.shapeListBox.FormattingEnabled = true;
            this.shapeListBox.Location = new System.Drawing.Point(655, 41);
            this.shapeListBox.Name = "shapeListBox";
            this.shapeListBox.Size = new System.Drawing.Size(133, 329);
            this.shapeListBox.TabIndex = 0;
            this.shapeListBox.Visible = false;
            // 
            // DisplayTimer
            // 
            this.DisplayTimer.Interval = 250;
            this.DisplayTimer.Tick += new System.EventHandler(this.DisplayTimer_Tick);
            // 
            // button1Delete
            // 
            this.button1Delete.Location = new System.Drawing.Point(655, 13);
            this.button1Delete.Name = "button1Delete";
            this.button1Delete.Size = new System.Drawing.Size(75, 23);
            this.button1Delete.TabIndex = 1;
            this.button1Delete.Text = "Delete";
            this.button1Delete.UseVisualStyleBackColor = true;
            this.button1Delete.Visible = false;
            this.button1Delete.Click += new System.EventHandler(this.button1Delete_Click);
            // 
            // button2Resize
            // 
            this.button2Resize.Location = new System.Drawing.Point(737, 13);
            this.button2Resize.Name = "button2Resize";
            this.button2Resize.Size = new System.Drawing.Size(75, 23);
            this.button2Resize.TabIndex = 2;
            this.button2Resize.Text = "Resize";
            this.button2Resize.UseVisualStyleBackColor = true;
            this.button2Resize.Visible = false;
            this.button2Resize.Click += new System.EventHandler(this.button2Resize_Click);
            // 
            // panel1EditSizeSquare
            // 
            this.panel1EditSizeSquare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1EditSizeSquare.Controls.Add(this.panel1EditSizeSquarebtnEXIT);
            this.panel1EditSizeSquare.Controls.Add(this.panel1EditSizeSquareLabel);
            this.panel1EditSizeSquare.Controls.Add(this.panel1EditSizeSquarebtnSMALLER);
            this.panel1EditSizeSquare.Controls.Add(this.panel1EditSizeSquarebtnBIGGER);
            this.panel1EditSizeSquare.Location = new System.Drawing.Point(429, 13);
            this.panel1EditSizeSquare.Name = "panel1EditSizeSquare";
            this.panel1EditSizeSquare.Size = new System.Drawing.Size(204, 102);
            this.panel1EditSizeSquare.TabIndex = 3;
            this.panel1EditSizeSquare.Visible = false;
            // 
            // panel1EditSizeSquarebtnEXIT
            // 
            this.panel1EditSizeSquarebtnEXIT.Location = new System.Drawing.Point(139, 72);
            this.panel1EditSizeSquarebtnEXIT.Name = "panel1EditSizeSquarebtnEXIT";
            this.panel1EditSizeSquarebtnEXIT.Size = new System.Drawing.Size(60, 23);
            this.panel1EditSizeSquarebtnEXIT.TabIndex = 3;
            this.panel1EditSizeSquarebtnEXIT.Text = "Exit";
            this.panel1EditSizeSquarebtnEXIT.UseVisualStyleBackColor = true;
            this.panel1EditSizeSquarebtnEXIT.Click += new System.EventHandler(this.panel1EditSizeSquarebtnEXIT_Click);
            // 
            // panel1EditSizeSquareLabel
            // 
            this.panel1EditSizeSquareLabel.AutoSize = true;
            this.panel1EditSizeSquareLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1EditSizeSquareLabel.Location = new System.Drawing.Point(3, 0);
            this.panel1EditSizeSquareLabel.Name = "panel1EditSizeSquareLabel";
            this.panel1EditSizeSquareLabel.Size = new System.Drawing.Size(175, 36);
            this.panel1EditSizeSquareLabel.TabIndex = 2;
            this.panel1EditSizeSquareLabel.Text = "please click the button to \r\nscale the Square";
            // 
            // panel1EditSizeSquarebtnSMALLER
            // 
            this.panel1EditSizeSquarebtnSMALLER.Location = new System.Drawing.Point(113, 43);
            this.panel1EditSizeSquarebtnSMALLER.Name = "panel1EditSizeSquarebtnSMALLER";
            this.panel1EditSizeSquarebtnSMALLER.Size = new System.Drawing.Size(60, 23);
            this.panel1EditSizeSquarebtnSMALLER.TabIndex = 1;
            this.panel1EditSizeSquarebtnSMALLER.Text = "Smaller";
            this.panel1EditSizeSquarebtnSMALLER.UseVisualStyleBackColor = true;
            this.panel1EditSizeSquarebtnSMALLER.Click += new System.EventHandler(this.panel1EditSizeSquarebtnSMALLER_Click);
            // 
            // panel1EditSizeSquarebtnBIGGER
            // 
            this.panel1EditSizeSquarebtnBIGGER.Location = new System.Drawing.Point(17, 43);
            this.panel1EditSizeSquarebtnBIGGER.Name = "panel1EditSizeSquarebtnBIGGER";
            this.panel1EditSizeSquarebtnBIGGER.Size = new System.Drawing.Size(62, 23);
            this.panel1EditSizeSquarebtnBIGGER.TabIndex = 0;
            this.panel1EditSizeSquarebtnBIGGER.Text = "Bigger";
            this.panel1EditSizeSquarebtnBIGGER.UseVisualStyleBackColor = true;
            this.panel1EditSizeSquarebtnBIGGER.Click += new System.EventHandler(this.panel1EditSizeSquarebtnBIGGER_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1EditSizeSquare);
            this.Controls.Add(this.button2Resize);
            this.Controls.Add(this.button1Delete);
            this.Controls.Add(this.shapeListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1EditSizeSquare.ResumeLayout(false);
            this.panel1EditSizeSquare.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox shapeListBox;
        private System.Windows.Forms.Timer DisplayTimer;
        private System.Windows.Forms.Button button1Delete;
        private System.Windows.Forms.Button button2Resize;
        private System.Windows.Forms.Panel panel1EditSizeSquare;
        private System.Windows.Forms.Button panel1EditSizeSquarebtnEXIT;
        private System.Windows.Forms.Label panel1EditSizeSquareLabel;
        private System.Windows.Forms.Button panel1EditSizeSquarebtnSMALLER;
        private System.Windows.Forms.Button panel1EditSizeSquarebtnBIGGER;
    }
}

