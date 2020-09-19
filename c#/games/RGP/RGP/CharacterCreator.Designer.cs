namespace RGP
{
    partial class CharacterCreator
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
            this.CharacterName = new System.Windows.Forms.Label();
            this.txt_CaharcterName = new System.Windows.Forms.TextBox();
            this.GenderGroupBox = new System.Windows.Forms.GroupBox();
            this.Male = new System.Windows.Forms.RadioButton();
            this.female = new System.Windows.Forms.RadioButton();
            this.CharacterClass = new System.Windows.Forms.ComboBox();
            this.GenderGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CharacterName
            // 
            this.CharacterName.AutoSize = true;
            this.CharacterName.Location = new System.Drawing.Point(12, 9);
            this.CharacterName.Name = "CharacterName";
            this.CharacterName.Size = new System.Drawing.Size(84, 13);
            this.CharacterName.TabIndex = 0;
            this.CharacterName.Text = "Character Name";
            // 
            // txt_CaharcterName
            // 
            this.txt_CaharcterName.Location = new System.Drawing.Point(102, 9);
            this.txt_CaharcterName.Name = "txt_CaharcterName";
            this.txt_CaharcterName.Size = new System.Drawing.Size(185, 20);
            this.txt_CaharcterName.TabIndex = 1;
            this.txt_CaharcterName.TextChanged += new System.EventHandler(this.Txt_CaharcterName_TextChanged);
            // 
            // GenderGroupBox
            // 
            this.GenderGroupBox.Controls.Add(this.female);
            this.GenderGroupBox.Controls.Add(this.Male);
            this.GenderGroupBox.Location = new System.Drawing.Point(15, 65);
            this.GenderGroupBox.Name = "GenderGroupBox";
            this.GenderGroupBox.Size = new System.Drawing.Size(365, 53);
            this.GenderGroupBox.TabIndex = 2;
            this.GenderGroupBox.TabStop = false;
            this.GenderGroupBox.Text = "Gendre";
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.Location = new System.Drawing.Point(219, 19);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(48, 17);
            this.Male.TabIndex = 0;
            this.Male.TabStop = true;
            this.Male.Text = "Male";
            this.Male.UseVisualStyleBackColor = true;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(81, 19);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(59, 17);
            this.female.TabIndex = 1;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // CharacterClass
            // 
            this.CharacterClass.FormattingEnabled = true;
            this.CharacterClass.Items.AddRange(new object[] {
            "Worrier",
            "Mage",
            "Rogue",
            "Cleric"});
            this.CharacterClass.Location = new System.Drawing.Point(15, 142);
            this.CharacterClass.Name = "CharacterClass";
            this.CharacterClass.Size = new System.Drawing.Size(121, 21);
            this.CharacterClass.TabIndex = 3;
            this.CharacterClass.Text = "character Class";
            // 
            // CharacterCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CharacterClass);
            this.Controls.Add(this.GenderGroupBox);
            this.Controls.Add(this.txt_CaharcterName);
            this.Controls.Add(this.CharacterName);
            this.Name = "CharacterCreator";
            this.Text = "CharacterCreator";
            this.Load += new System.EventHandler(this.CharacterCreator_Load);
            this.GenderGroupBox.ResumeLayout(false);
            this.GenderGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CharacterName;
        private System.Windows.Forms.TextBox txt_CaharcterName;
        private System.Windows.Forms.GroupBox GenderGroupBox;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.ComboBox CharacterClass;
    }
}