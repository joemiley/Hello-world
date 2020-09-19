namespace RGP
{
    partial class frm_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.CreateCharacter = new System.Windows.Forms.Button();
            this.LoadGame = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "LBL_title";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // CreateCharacter
            // 
            this.CreateCharacter.Location = new System.Drawing.Point(30, 187);
            this.CreateCharacter.Name = "CreateCharacter";
            this.CreateCharacter.Size = new System.Drawing.Size(125, 72);
            this.CreateCharacter.TabIndex = 1;
            this.CreateCharacter.Text = "BTN_CreateCharacter";
            this.CreateCharacter.UseVisualStyleBackColor = true;
            this.CreateCharacter.Click += new System.EventHandler(this.CreateCharacter_Click);
            // 
            // LoadGame
            // 
            this.LoadGame.Location = new System.Drawing.Point(218, 187);
            this.LoadGame.Name = "LoadGame";
            this.LoadGame.Size = new System.Drawing.Size(125, 72);
            this.LoadGame.TabIndex = 2;
            this.LoadGame.Text = "Load Game";
            this.LoadGame.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(415, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 72);
            this.button1.TabIndex = 3;
            this.button1.Text = "Load Game";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LoadGame);
            this.Controls.Add(this.CreateCharacter);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Menu";
            this.Text = "RPG Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CreateCharacter;
        private System.Windows.Forms.Button LoadGame;
        private System.Windows.Forms.Button button1;
    }
}

