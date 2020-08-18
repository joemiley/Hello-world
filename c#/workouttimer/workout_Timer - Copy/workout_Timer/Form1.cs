using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace workout_Timer
{
  
    public partial class Form1 : Form
    {
        //timers
        public int countdown = 2;
        //textboxes and timers
        public int numberOfExercises = 0;
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

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
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
                _panel2_PreStartCountdown.Visible = true;
                _panel1_Menu.Visible = false;
                timerCountDownTStart.Start();
            }
            else
            {
                return;
            }
        }

        //making the inputs from textboxes into timers
        public void numberOfExercisesTextBox()
        {
            //saves them to global ints
            string numberOfExercisesBox = "";
            numberOfExercisesBox = panel1TextBoxNoOfExercises.Text;
            Int32.TryParse(numberOfExercisesBox, out numberOfExercises);

            if (numberOfExercises == 0)
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
            string secondsPerExerciseBox = "";
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
            string restAfterEachRoundBox = "";
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
            string numberOfROundsBox = "";
            numberOfROundsBox = panel1TextBoxNoOfRounds.Text;
            Int32.TryParse(numberOfROundsBox, out numberOfRounds);

            if (numberOfRounds == 0)
            {
                return;
            }
            else
            {
                check5 = true;
            }
        }
        
        //timer before the workout
        private void timerCountDownTStart_Tick(object sender, EventArgs e)
        {
            if (countdown == 0)
            {
                panel2LabelNoOfSeconds.Visible = false;
                panel2labelStart.Visible = true;
                _panel2_PreStartCountdown.Visible = false;
                _panel3_WorkoutPanel.Visible = true;
                timerWork.Start();
                timerCountDownTStart.Stop();
            }
            else
            {
                panel2LabelNoOfSeconds.Text = countdown.ToString();
                countdown--;
            }
        }
        
        //timer during te workingout period
        private void timerWork_Tick(object sender, EventArgs e)
        {
           /*this counts down the seconds of the workout timer then when they hit 0 it changes panel
            * starts rest timer, stops workouttimer and 
            * tries to reset the rest timer but dont think it does it
            */

            if (secondsPerExercise[1] == 0)
            {
                _panel3_WorkoutPanel.Visible = false;
                _panel4_Rest.Visible = true;
                timerRest.Start();
                timerWork.Stop();
                RestPeriod[1] = RestPeriod[0]; 

            }
           
            else
            {
                panel3LabelTime.Text = secondsPerExercise[1].ToString();
                secondsPerExercise[1]--;

            }

        }

        //timer for rest
        private void timerRest_Tick(object sender, EventArgs e)
        {
            /*this counts down the seconds of the rest timer then when they hit 0 it changes panel
             * starts the workout timer, stops rest timer and 
             * tries to reset the rest timer but dont think it does it
             */
            if (RestPeriod[1] == 0)
            {
                secondsPerExercise[1] = secondsPerExercise[0];
                timerRest.Stop();
                if(numberOfRounds < 0)
                {
                    _panel1_Menu.Visible = true;
                    _panel2_PreStartCountdown.Visible = false;
                    _panel3_WorkoutPanel.Visible = false;
                    _panel4_Rest.Visible = false;
                    _panel5_RoundComplete.Visible = false;
                    
                }
                else
                {

                    _panel3_WorkoutPanel.Visible = true;
                    numberOfRounds--;
                }
            }
            else
            {
                panel4labelTime.Text = RestPeriod[1].ToString();
                RestPeriod[1]--;
                
            }


        }

        //timer round complete
        private void timerRoundComplete_Tick(object sender, EventArgs e)
        {
            /*this counts the rest timer between rounds.
             *once the timer hits 0 it sets the visibility 
             * stops the roundcomplete timer and starts the workout timer
             * it also tries to reset the timer for the round complete timer but i dnt think it does
             */

            if (RestAfterEachRound[1] < 0)
            {

                _panel3_WorkoutPanel.Visible = true;
                timerRoundComplete.Stop();
                timerWork.Start();
                RestAfterEachRound[1] = RestAfterEachRound[0];
            }
            else
            {
                panel5labelTime.Text = RestAfterEachRound.ToString();
                RestAfterEachRound[1]--;
            }
        }

    }
}
