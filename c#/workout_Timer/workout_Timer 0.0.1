using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace workout_Timer
{
  
    public partial class Timer : Form
    {
        //timers
        public int []countdown = new int[] { 2, 2 };

        public int[] numberOfExercises = new int[] { 0, 0 };
        public int numberOfRounds = 0;

        //count downs; posistion 0 is the master one and posistion 1 is the count down
        public int[] secondsPerExercise =new int[] { 0, 0 };
        public int[] RestPeriod = new int[] { 0, 0 };
        public int[] RestAfterEachRound = new int[] { 0, 0 };


        /*when each input box is filled out with anything other than a zero then it changes
         * to true. if all are true then it moves on
         */
        public bool check1 = false;
        public bool check2 = false;
        public bool check3 = false;
        public bool check4 = false;
        public bool check5 = false;

        public Timer()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //setting the timer
            countdown[1] = 3;

            //set all visability
            _panel1_Menu.Visible = true;
            _panel2_PreStartCountdown.Visible = false;
            _panel3_WorkoutPanel.Visible = false;
            _panel4_Rest.Visible = false;
            _panel5_RoundComplete.Visible = false;
        }

        //on the start button
        private void panel1ButtonStart_Click(object sender, EventArgs e)
        {

            numberOfExercisesTextBox();
            secondsPerExerciseTextBox();
            restBetweenExercisesTextBox();
            restAfterEachRoundTextBox();
            numberOfRoundsTextBox();

            //the true checker to proceed from the starting menu
            if(check1 == true && check2 == true && check3 == true && check4 == true && check5 == true)
            {
                timerCountDownTStart.Start();
                _panel2_PreStartCountdown.Visible = true;
                _panel1_Menu.Visible = false;
                panel2LabelNoOfSeconds.Text = "3";
            }
            else
            {
                return;
            }
        }

        //making the inputs from textboxes into timers and doing the checks before start
        public void numberOfExercisesTextBox()
        {
            //saves them to global ints
            string numberOfExercisesBox;
            numberOfExercisesBox = panel1TextBoxNoOfExercises.Text;
            for(int i=0; i<numberOfExercises.Length; i++)
            {
                Int32.TryParse(numberOfExercisesBox, out numberOfExercises[i]);
            }


            if (numberOfExercises[1] == 0)
            {
                return;
            }
            else
            {
                check1 = true;
            }
        }
        public void secondsPerExerciseTextBox()
        {
            /*saves them to global ints
             * uses the number holder to write to the array (was just running try parse twice 
             * but was worried the first pass was clearing the text box so did this to try to fix problem)
             */

            int numberholder;
            string secondsPerExerciseBox;
            secondsPerExerciseBox = panel1TextBoxSecPerExercise.Text;
            Int32.TryParse(secondsPerExerciseBox, out numberholder);

            for (int i = 0; i < secondsPerExercise.Length; i++)
            {
                secondsPerExercise[i] = numberholder;
            }
        

            if (secondsPerExercise[0] == 0)
            {
                return;
            }
            else
            {
                check2 = true;
            }

        }
        public void restBetweenExercisesTextBox()
        {
            /*saves them to global ints
            * uses the number holder to write to the array (was just running try parse twice 
            * but was worried the first pass was clearing the text box so did this to try to fix problem)
            */
            int numberholder;
            string restBetweenExercisesBox = "";
            restBetweenExercisesBox = panel1TextBoxRestBetweenExercises.Text;
            Int32.TryParse(restBetweenExercisesBox, out numberholder);

            for (int i = 0; i<RestPeriod.Length; i++)
            {
                RestPeriod[i] = numberholder;
            }


            if (RestPeriod[0] == -1)
            {
                return;
            }
            else
            {
                check3 = true;
            }
        }
        public void restAfterEachRoundTextBox()
        {
            /*saves them to global ints
             * uses the number holder to write to the array (was just running try parse twice 
             * but was worried the first pass was clearing the text box so did this to try to fix problem)
            */
            int numberholder;
            string restAfterEachRoundBox;
            restAfterEachRoundBox = panel1TextBoxRestAfterEachRound.Text;
            Int32.TryParse(restAfterEachRoundBox, out numberholder);
            for (int i=0;i<RestAfterEachRound.Length; i++)
            {
                RestAfterEachRound[i] = numberholder;
            }
      

            if (RestAfterEachRound[0] == 0)
            {
                return;
            }
            else
            {
                check4 = true;
            }
        }
        public void numberOfRoundsTextBox()
        {
            string numberofroundsbox;
            numberofroundsbox = panel1TextBoxNoOfRounds.Text;

            Int32.TryParse(numberofroundsbox, out numberOfRounds);

            if (numberOfRounds <= 0)
            {
                return;
            }
            else
            {
                check5 = true;
            }
        }

        //<><><><><><><><><><><><><><><><><><><><><><><><><> timer before the workout <><><><><><><><><><><><><><><><><><>><><><><>
        private void timerCountDownToStart_Tick(object sender, EventArgs e)
        {

            //text to label
            panel2LabelNoOfSeconds.Text = countdown[1].ToString();
            countdown[1]--;

            if (countdown[1] < 0)
            {
                //set visibilities
                _panel3_WorkoutPanel.Visible = true;
                _panel2_PreStartCountdown.Visible = false;
                //sort timers
                timerWork.Start();
                timerCountDownTStart.Stop();
                countdown[1] = countdown[0];
            }


        }

        //<><><><><><><><><><><><><><><><><><><><><><><><><> timers <><><><><><><><><><><><><><><><><><><><><><><><><><>><><><><><
        //timer during te workingout period
        private void timerWork_Tick(object sender, EventArgs e)
        {
          
            //text to label
            panel3LabelTime.Text = secondsPerExercise[1].ToString();
            secondsPerExercise[1]--;

            //-1 to the number of exercises
            if (secondsPerExercise[1] < 0)
            {
                numberOfExercises[1]--;
            }


            //panel transfer to rest 
            if (secondsPerExercise[1] < 0)
            {
                //set visibilities
                _panel3_WorkoutPanel.Visible = false;
                _panel4_Rest.Visible = true;
                //sort timers
                timerRest.Start();
                timerWork.Stop();
                //reset the clock
                secondsPerExercise[1] = secondsPerExercise[0];
            }

            //when number of exercises equals zero sends to round complete
            if (numberOfExercises[1] == 0)
            {
                //once all exercises are done it sends the user back to main menu
                if (numberOfRounds == 1)
                {
                    Escape();
                    
                }
                else
                {
                    //set visibilities
                    _panel3_WorkoutPanel.Visible = false;
                    _panel5_RoundComplete.Visible = true;
                    //sort timers
                    timerRoundComplete.Start();
                    timerWork.Stop();
                    //reset the clock
                    secondsPerExercise[1] = secondsPerExercise[0];
                    //reset the number of exercises
                    numberOfExercises[1] = numberOfExercises[0];
                }

            }


        }

        //timer for rest
        private void timerRest_Tick(object sender, EventArgs e)
        {
            //text to label
            panel4labelTime.Text = RestPeriod[1].ToString();
            RestPeriod[1]--;

            //panel transfer to work
            if (RestPeriod[1] < 0)
            {
                //set visibilities
                _panel3_WorkoutPanel.Visible = true;
                _panel4_Rest.Visible = false;
                //sort timers
                timerWork.Start();
                timerRest.Stop();
                //reset the clock
                RestPeriod[1] = RestPeriod[0];
            }
           

        }

        //timer round complete
        private void timerRoundComplete_Tick(object sender, EventArgs e)
        {

            //text to label
            panel5labelTime.Text = RestAfterEachRound[1].ToString();
            RestAfterEachRound[1]--;

            //panel transfer to work and start the chain again
            if(RestAfterEachRound[1] < 0)
            {
                //set visibilities
                _panel3_WorkoutPanel.Visible = true;
                _panel5_RoundComplete.Visible = false;
                //sort timers
                timerWork.Start();
                timerRoundComplete.Stop();
                //reset the clock
                RestAfterEachRound[1] = RestAfterEachRound[0];
                //-1 to the number of rounds after everything
                numberOfRounds--;
            }

        }

        //<><><><><><><><><><><><><><><><><><><><><><><><><> stop buttons <><><><><><><><><><><><><><><><><><><><><><><><><><><><>
        public void Escape()
        {
            _panel1_Menu.Visible = true;
            _panel2_PreStartCountdown.Visible = false;
            _panel3_WorkoutPanel.Visible = false;
            _panel4_Rest.Visible = false;
            _panel5_RoundComplete.Visible = false;

            timerRest.Stop();
            timerRoundComplete.Stop();
            timerWork.Stop();
            timerCountDownTStart.Stop();
            countdown[1] = 3;
        }        
        private void panel2button_MouseClick(object sender, MouseEventArgs e)
        {
            Escape();
        }
        private void panel3button_MouseClick(object sender, MouseEventArgs e)
        {
            Escape();
        }
        private void panel4button_MouseClick(object sender, MouseEventArgs e)
        {
            Escape();
        }
        private void panel5button_MouseClick(object sender, MouseEventArgs e)
        {
            Escape();
        }


    }
}
