using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;

namespace Notepad_X
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Absolute path to file (eg: c:\folder1\file.txt)
        /// </summary>
        private string filePath = null;

        /// <summary>
        /// Form2 instance/object/value container
        /// </summary>
        private Form2 form2;

        /// <summary>
        /// Form1 constructor
        /// </summary>
        public Form1()
        {
            // initialises the current form
            // without this, the form will not be setup or visible
            InitializeComponent();

            // create a new Form2 instance/object/value
            form2 = new Form2();
            // tell it to show itself
            form2.Show();
        }

        /// <summary>
        /// Triggered when About menu item is clicked
        /// </summary>
        /// <param name="sender">The component that triggered this method</param>
        /// <param name="e">Event/Action information</param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // display a simple message box
            MessageBox.Show("Made by Squirrels... With Love!", "About Notepad X");
        }

        /// <summary>
        /// Triggered when Exit menu item is clicked
        /// </summary>
        /// <param name="sender">The component that triggered this method</param>
        /// <param name="e">Event/Action information</param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // close the current form
            // as it is the main form, it will close the entire application
            Close();
        }

        /// <summary>
        /// Triggered when Open menu item is clicked
        /// </summary>
        /// <param name="sender">The component that triggered this method</param>
        /// <param name="e">Event/Action information</param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // show the open file dialog window
            openFileDialog.ShowDialog();
        }

        /// <summary>
        /// Triggered when the user clicks the OK button on the Open File Dialog window
        /// </summary>
        /// <param name="sender">The component that triggered this method</param>
        /// <param name="e">Event/Action information</param>
        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            // remember the file path the user just selected
            filePath = openFileDialog.FileName;
            // use the File tool to open the file, extract its contents,
            // and add it to the text box' Text property to be displayed to the user
            textBox1.Text = File.ReadAllText(filePath);
        }

        /// <summary>
        /// Saves the contents of the text box to the currently opened file.
        /// If no file is open, it will trigger the save file dialog window.
        /// </summary>
        private void saveToFile ()
        {
            // if there is no file currently open
            if (filePath == null)
            {
                // trigger the save file dilog window
                saveFileDialog.ShowDialog();
                // stop the rest of the method
                return;
            }

            // use the File tool to open and write to the selected file
            // the contents of the text box; if the file does not exist,
            // it will be created
            File.WriteAllText(filePath, textBox1.Text);

            // display a simple message box
            MessageBox.Show("File has been saved successfully!", "Success!");
        }

        /// <summary>
        /// Triggered when Save menu item is clicked
        /// </summary>
        /// <param name="sender">The component that triggered this method</param>
        /// <param name="e">Event/Action information</param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // if there is no file currently open
            if (filePath == null)
            {
                // trigger the save file dialog window
                saveFileDialog.ShowDialog();
                // stop the rest of the method
                return;
            }

            // trigger the saveToFile() method
            saveToFile();
        }

        /// <summary>
        /// Triggered when Save As menu item is clicked
        /// </summary>
        /// <param name="sender">The component that triggered this method</param>
        /// <param name="e">Event/Action information</param>
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // show the save file dialog window
            saveFileDialog.ShowDialog();
        }

        /// <summary>
        /// Triggered when the user clicks the OK button on the Save File Dialog window
        /// </summary>
        /// <param name="sender">The component that triggered this method</param>
        /// <param name="e">Event/Action information</param>
        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            // remember the file path the user just selected
            filePath = saveFileDialog.FileName;
            // trigger the saveToFile() method
            saveToFile();
        }

        /// <summary>
        /// Triggered when New menu item is clicked
        /// </summary>
        /// <param name="sender">The component that triggered this method</param>
        /// <param name="e">Event/Action information</param>
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // trigger the check to establish whether the text box contents
            // needs to be saved before clearing everything
            checkIfTextNeedsToBeSaved();

            // clear the path value
            filePath = null;
            // clear the text box
            textBox1.Text = "";
        }

        /// <summary>
        /// Establish whether the text box contents needs to be saved, and do so if necessary
        /// </summary>
        private void checkIfTextNeedsToBeSaved()
        {
            // if the text box is empty
            if (textBox1.Text == "")
            {
                // do nothing, all OK
                return;
            }

            // otherwise, prompt the user
            DialogResult result = MessageBox.Show("Would you like to save the file?", "Save?", MessageBoxButtons.YesNo);

            // if they want to save, then ...
            if (result == DialogResult.Yes)
            {
                // trugger the saveToFile() method
                saveToFile();
            }
        }
    }
}
