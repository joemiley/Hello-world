using System;
using System.Windows.Forms;

namespace Notepad_X
{
    public partial class Form2 : Form
    {
        /// <summary>
        /// Windows.Forms Timer
        /// </summary>
        Timer timer = new Timer();

        /// <summary>
        /// Form2 constructor
        /// </summary>
        public Form2()
        {
            // initialises the current form
            // without this, the form will not be setup or visible
            InitializeComponent();

            // repeat timer every 3 seconds
            timer.Interval = 3000;
            // start it
            timer.Enabled = true;
            // every 3 seconds, trigger the closeForm2() method
            timer.Tick += closeForm2;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">The Timer instance</param>
        /// <param name="e">Event information</param>
        private void closeForm2(object sender, EventArgs e)
        {
            // stop the timer from repeating
            timer.Stop();
            // close Form2
            Close();
        }
    }
}
