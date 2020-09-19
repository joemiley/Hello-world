using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGP
{
    public partial class frm_Menu : Form
    {
        public frm_Menu()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void CreateCharacter_Click(object sender, EventArgs e)
        {
            CharacterCreator CharacterCreator  = new CharacterCreator();
            CharacterCreator.Show();
        }
    }
}
