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
       
        //Instantiate or initialize??
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
            StartPosition = FormStartPosition.CenterScreen;
            mySoundbackground2.Play(); 
        }

        public static implicit operator Guid(Play_Airplane_Chicken v)
        {
            throw new NotImplementedException();
        }

        private void Play_Airplane_Chicken_Load(object sender, EventArgs e)
        {
            rdoEggsRunway.Enabled = false;
            rdoEggsOnGrass.Enabled = false;
        }

        //Load button that generates a new game
        private void btnEnterRunway_Click(object sender, EventArgs e)
            //Spin Chambers
        {
            rdoEggsRunway.Visible = true;
            rdoEggsOnGrass.Visible = true;
            rdoEggsRunway.Enabled = true;
            rdoEggsOnGrass.Enabled = true;
            
            


            //Calls class RandomNumberGenerator to create a random number
            myRandomNumberGenerator.RDNSelected = myRandomNumberGenerator._RandomNumber; //added 4:08pm 7/3/16

            //Shows image in runway position
            pbEnterRunway.Image = ResourceFile.MiniChicken3;
            btnLayEggs.Enabled = false;
          
            myRandomNumberGenerator.count = 0;
            myRandomNumberGenerator.LayGrassCount = 2; 
            myRandomNumberGenerator.IsOnGrass = false;
            this.Text = Convert.ToString("Ran Num =" + (myRandomNumberGenerator.RDNSelected) + "  Count=" + myRandomNumberGenerator.count.ToString());
        }

    
        private void btnLayEggs_Click(object sender, EventArgs e)
            //Fire
        {
                       myRandomNumberGenerator.count++;   
 this.Text = Convert.ToString("Ran Num =" + (myRandomNumberGenerator.RDNSelected) +"  Count=" +  myRandomNumberGenerator.count.ToString());

            //Shootaway 

  //When replaying game the Random Number seems to set at 0 this resets it again
            if (myRandomNumberGenerator.RDNSelected == 0)
            { 
                //generate new number
                myRandomNumberGenerator.RDNSelected = myRandomNumberGenerator.RandomNumber;
                //this button sometimes set to false so set it to true
                btnEnterRunway.Enabled = true;
                MessageBox.Show("Click Enter Runway first");

                return; //stop all processing
            }





            //Checks if button is selected & the lay grass count is higher than 0
            if ((rdoEggsOnGrass.Checked) && (myRandomNumberGenerator.LayGrassCount > 0))
            {
                myRandomNumberGenerator.LayGrassCount--;
                lbLayGrassCount.Text = Convert.ToString(myRandomNumberGenerator.LayGrassCount);
                myRandomNumberGenerator.IsOnGrass = true;
             //   rdoEggsOnGrass.Enabled = false;
            }                                                                                                  
            else if((rdoEggsOnGrass.Checked) && (myRandomNumberGenerator.LayGrassCount == 0))
            {
                myRandomNumberGenerator.IsOnGrass = false;
                rdoEggsRunway.Enabled = true;
                rdoEggsRunway.Checked = true;
                rdoEggsOnGrass.Enabled = false;
            }
         
            //Fire                                                                                      
         
            //Checks if count is equal to the  number generated
            if (myRandomNumberGenerator.count == myRandomNumberGenerator.RDNSelected)
            {
                if (myRandomNumberGenerator.IsOnGrass)
                {
                    //Plays winning sound, shows user message, adds 1 to Win count label
                    mySoundWonGame.Play();
                    MessageBox.Show("You Win!! :)");
                    myRandomNumberGenerator.countwin++;
                    lbWinScore.Text = ": " + myRandomNumberGenerator.countwin;
                    btnLayEggs.Enabled = false; //stop gameplay button from working
                    //  rdoEggsRunway.Enabled = false;
                }
                else if (myRandomNumberGenerator.IsOnGrass == false)
                {
                    //Plays losing sound, shows user message, adds 1 to Win count label
                    mySoundLoseGame.Play();
                    MessageBox.Show("You lose :(");
                    myRandomNumberGenerator.countlose++;
                    lbLossScore.Text = ": " + myRandomNumberGenerator.countlose;
                    btnLayEggs.Enabled = false;
                }
                mySoundLay.Play();
            }
        }
        
        private void rdoAllRadioButtons(object sender, EventArgs e)
            
        {
            RadioButton fakeRB = (RadioButton) sender;

            
            if (fakeRB.Name == "rdoEggsRunway")
                {
                    pbOnRunway.Image = ResourceFile.MiniChicken3;
                    pbEnterRunway.Image = null;
                    pbOnGrass.Image = null;
                }
                else if (fakeRB.Name == "rdoEggsOnGrass")
                {
                    pbOnRunway.Image = null;
                    pbOnGrass.Image = ResourceFile.MiniChicken3;
                    pbEnterRunway.Image = null;
                }

         //   btnLayEggs.Enabled = true;
         //   btnEnterRunway.Enabled = false;                                        //added
        }


        //private
        //    void rdoEggsOnGrass_CheckedChanged 
        //    (object sender, EventArgs e)
        //    {

        //    if (rdoEggsOnGrass.Checked)
        //        {
        //            //Displays picture in OnGrass postion and removes on runway position
        //            pbOnGrass.Image = ResourceFile.MiniChicken3;
        //            pbEnterRunway.Image = null;
        //        }
        //        else
        //        {
        //            pbOnGrass.Image = null;
        //        }
        //    }

        

        private void btnClearScores_Click(object sender, EventArgs e)
        {
            //Clears win and loss totals
            lbLossScore.Text = "";
            lbWinScore.Text = "";
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)

        {
            if ((rdoEggsOnGrass.Checked) || (rdoEggsRunway.Checked))
            {
                rdoEggsOnGrass.Checked = false;
                rdoEggsRunway.Checked = false;                          

            }
            
            if ((rdoEggsOnGrass.Enabled) && (rdoEggsRunway.Enabled))
            {
                rdoEggsRunway.Visible = false;
                rdoEggsOnGrass.Visible = false;
            }

            btnEnterRunway.Visible = true;
            btnEnterRunway.Enabled = true;

            //Resets variables/images/buttons back to original values
            myRandomNumberGenerator.RDNSelected = myResetGame.RDNSelected;
            myRandomNumberGenerator.count = myResetGame.count;
            myRandomNumberGenerator.LayGrassCount = myResetGame.LayGrasscount;
            myRandomNumberGenerator.RDNSelected = myResetGame._RandomNumber;
            myRandomNumberGenerator.IsOnGrass = myResetGame.IsOnGrass;
      
            rdoEggsRunway.Enabled = true;
            
            pbOnGrass.Image = null;
            pbOnRunway.Image = null;
            pbEnterRunway.Image = null;
            rdoEggsOnGrass.Enabled = Visible;
            rdoEggsOnGrass = myResetGame.ResetRb1();
            rdoEggsRunway = myResetGame.ResetRb2();
            lbLayGrassCount.Text = "2";
            Text = "0";
        }

        private void btnExitToMenu_Click 
            (object sender, EventArgs e)
            {
                //Returns back to first form
                Close();
                myExitGame.ExitGame();
           
                //Switches music back from 2nd form "Play_Airplane_Chicken 
                mySoundbackground2.Stop();
                mySoundBackground.Play();
            }
    }
}



    
