using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Airplane_Chicken1stA.VC
{
    public partial class Play_Airplane_Chicken : Form
    {
        //Instantiate sounds and methods for resetting gameplay and exiting game
        SoundPlayer mySoundbackground2 = new SoundPlayer(ResourceFile.BackgroundSound2);
        SoundPlayer mySoundBackground = new SoundPlayer(ResourceFile.Airplane_Ambience);
        SoundPlayer mySoundLoseGame = new SoundPlayer(ResourceFile.LosingSound);
        SoundPlayer mySoundWonGame = new SoundPlayer(ResourceFile.TaDa);
        SoundPlayer mySoundLay = new SoundPlayer(ResourceFile.Laying_Egg);
        ResetGame myResetGame = new ResetGame();
        NiceFunctions myExitGame = new NiceFunctions();
        RandomNumberGenerator myRandomNumberGenerator = new RandomNumberGenerator();
        
                
        public Play_Airplane_Chicken()
        {
            InitializeComponent();

            //Sets form in center of the screen
            StartPosition = FormStartPosition.CenterScreen;
        }
        
        private void Play_Airplane_Chicken_Load(object sender, EventArgs e)
        {
           //Plays background sound for game 
           mySoundbackground2.Play();
        }

        //Load button that generates a random number for the game "Spin Chmabers"
        private void btnEnterRunway_Click(object sender, EventArgs e)
        { 
            //Sets buttons to clickable and visable state
            rdoEggsRunway.Visible = true;
            rdoEggsOnGrass.Visible = true;
            rdoEggsRunway.Enabled = true;
            rdoEggsOnGrass.Enabled = true;
                        
            //Calls class RandomNumberGenerator to create a random number
            myRandomNumberGenerator.RDNSelected = myRandomNumberGenerator.RandomNumber;
            
            //Shows image in runway position
            pbEnterRunway.Image = ResourceFile.MiniChicken3;
            btnLayEggs.Enabled = false;
          
            //Setting count, shootaway count and shootaway boolean to false
            myRandomNumberGenerator.count = 0;
            myRandomNumberGenerator.LayGrassCount = 2; 
            myRandomNumberGenerator.IsOnGrass = false;

        }

    
        private void btnLayEggs_Click(object sender, EventArgs e)
        {
            //Increments count by 1 
            myRandomNumberGenerator.count++;   
          
            //___________________________Shootaway________________________________________ 

            //If when replaying game the Random Number gets set to 0 it resets a new random number
            if (myRandomNumberGenerator.RDNSelected == 0)
            { 
                //Generates a new random number
                myRandomNumberGenerator.RDNSelected = myRandomNumberGenerator.RandomNumber;

                //This button sometimes is set to false, so set it to true
                btnEnterRunway.Enabled = true;
                MessageBox.Show("Click Enter Runway first");

                rdoEggsOnGrass.Enabled = true;
                rdoEggsRunway.Enabled = true;
                             
                return; //Stops processing
            }
            
            //Checks if button is selected & the lay grass count is higher than 0
            if ((rdoEggsOnGrass.Checked) && (myRandomNumberGenerator.LayGrassCount > 0))
            {
                //Decremennnts shootaway count down 1, displays result to label
                myRandomNumberGenerator.LayGrassCount--;
                lbLayGrassCount.Text = Convert.ToString(myRandomNumberGenerator.LayGrassCount);
                myRandomNumberGenerator.IsOnGrass = true;
            }                                                                                                  
            else if((rdoEggsOnGrass.Checked) && (myRandomNumberGenerator.LayGrassCount == 0))
            {
                //Gets buttons ready for next game 
                myRandomNumberGenerator.IsOnGrass = false;
                rdoEggsRunway.Enabled = true;
                rdoEggsRunway.Checked = true;
                rdoEggsOnGrass.Enabled = false;
            }
         
            //_____________________________Fire_________________________________________        
            
                                                                                        
            //Checks if count is equal to the number generated
            if (myRandomNumberGenerator.count == myRandomNumberGenerator.RDNSelected)
            {
                if (myRandomNumberGenerator.IsOnGrass)
                {
                    //Plays winning sound, shows user message, adds 1 to Win count label
                    mySoundWonGame.Play();
                    MessageBox.Show("You Win!! :)");
                    myRandomNumberGenerator.countwin++;
                    lbWinScore.Text = ": " + myRandomNumberGenerator.countwin;

                    //Stops gameplay until 'PlayAgain' button is clicked                                                             
                    btnLayEggs.Enabled = false; 
                    rdoEggsRunway.Enabled = false;
                    rdoEggsOnGrass.Enabled = false;
                }
                else if (myRandomNumberGenerator.IsOnGrass == false)
                {
                   //Plays losing sound, shows user message, adds 1 to Win count label
                    mySoundLoseGame.Play();
                    MessageBox.Show("You lose :(");
                    myRandomNumberGenerator.countlose++;
                    lbLossScore.Text = ": " + myRandomNumberGenerator.countlose;
                                      
                    //Stops gameplay until 'PlayAgain' button is clicked                                      
                    btnLayEggs.Enabled = false; 
                    rdoEggsRunway.Enabled = false;
                    rdoEggsOnGrass.Enabled = false;
                }
                                            
            }
            //Plays laying egg sound when count is not equal to Random number 
            if (myRandomNumberGenerator.count != myRandomNumberGenerator.RDNSelected)
            {
                mySoundLay.Play();
            }
        }
        
        private void rdoAllRadioButtons(object sender, EventArgs e)
        {
            RadioButton fakeRB = (RadioButton) sender;

                if (fakeRB.Name == "rdoEggsRunway")
                {
                    //Displays chicken picture in Runway position when clicked & clears other image positions
                    pbOnRunway.Image = ResourceFile.MiniChicken3;
                    pbEnterRunway.Image = null;
                    pbOnGrass.Image = null;
                }
                else if (fakeRB.Name == "rdoEggsOnGrass")
                {
                    //Displays chicken picture in Grass position when clicked & clears other image positions
                    pbOnRunway.Image = null;
                    pbOnGrass.Image = ResourceFile.MiniChicken3;
                    pbEnterRunway.Image = null;
                }
                
           btnLayEggs.Enabled = true;
        }
             
        private void btnClearScores_Click(object sender, EventArgs e)
        {
            //Clears win and loss totals
            lbLossScore.Text = "";
            lbWinScore.Text = "";
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            //Removes checked icon off buttons too make gameplay clearer
            if ((rdoEggsOnGrass.Checked) || (rdoEggsRunway.Checked))
            {
                //Sets buttons to unchecked
                rdoEggsOnGrass.Checked = false;
                rdoEggsRunway.Checked = false;                          
            }
            
            //Resets variables/buttons/images/labels/sound back to original/playable state for new game

            //Variables
            myRandomNumberGenerator.RDNSelected = myResetGame.RDNSelected;
            myRandomNumberGenerator.count = myResetGame.count;
            myRandomNumberGenerator.LayGrassCount = myResetGame.LayGrasscount;
            myRandomNumberGenerator.RDNSelected = myResetGame._RandomNumber;
            myRandomNumberGenerator.IsOnGrass = myResetGame.IsOnGrass;

            //Butons
            rdoEggsOnGrass.Enabled = true;
            rdoEggsRunway.Enabled = true;
            btnEnterRunway.Enabled = true;
            rdoEggsOnGrass = myResetGame.ResetRb1();
            rdoEggsRunway = myResetGame.ResetRb2();
            rdoEggsOnGrass.Enabled = Visible;
                       
            //Images
            pbOnGrass.Image = null;
            pbOnRunway.Image = null;
            pbEnterRunway.Image = null;
          
            //label 
            lbLayGrassCount.Text = "2";
  
            //Background Sound
            mySoundbackground2.Play();
        }

        private void btnExitToMenu_Click(object sender, EventArgs e)
        {
            //Returns back to first form
            Close();
            myExitGame.ExitGame();
           
            //Switches background music back from 2nd form to 1st form
            mySoundbackground2.Stop();
            mySoundBackground.Play();
        }
    }
}



    
