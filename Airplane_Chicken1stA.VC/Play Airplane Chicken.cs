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

namespace Airplane_Chicken1stA.VC
{
    public partial class Play_Airplane_Chicken : Form
    {
        private RandomNumberGenerator myRandomNumberGenerator = new RandomNumberGenerator();

        SoundPlayer mySoundbackground2 = new SoundPlayer(ResourceFile.BackgroundSound2);
        SoundPlayer mySoundBackground = new SoundPlayer(ResourceFile.Airplane_Ambience);
        
        
        public Play_Airplane_Chicken()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            mySoundbackground2.Play();                                                                  //Add 
        }

        public static implicit operator Guid(Play_Airplane_Chicken v)
        {
            throw new NotImplementedException();
        }

        private void Play_Airplane_Chicken_Load(object sender, EventArgs e)
        {

        }

        private void btnEnterRunway_Click(object sender, EventArgs e)
            //Spin Chambers
        {
            //Calls class RandomNumberGenerator to create a random number
            myRandomNumberGenerator.RandomNum2 = myRandomNumberGenerator.RandomNumber;

  
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
            //Reset Game
        {
            //Add way to reset game
            //maybe reloading the form could work?

        }

        private void btnLayEggs_Click(object sender, EventArgs e)
            //Fire
        {
                                                                                //Count probelms for two shootaway options and not losing when alwasy on runway??                                           and adding scores to labels
                                                                                //Need one more Unit test propbably of this part once its working
                                                                                //Problem with no result after winning or losing once? 
                                                                                
                                                                      

                                                                            

            if (rdoEggsOnGrass.Checked == true)
            {
                myRandomNumberGenerator.Shotawaycount --;

                if (myRandomNumberGenerator.Shotawaycount == 0)
                {
                    rdoEggsOnGrass.Checked = false;
                }

            }
            
            myRandomNumberGenerator.count++;
            //if else statements (if count = yess and shootaway = yes - you live) (if no - you die)                                                                                   
            if (myRandomNumberGenerator.count == myRandomNumberGenerator.RandomNum2)
            {
                if (rdoEggsOnGrass.Checked == true)
                {
                    MessageBox.Show("You Win!!");
                    myRandomNumberGenerator.countwin++;
                    lbWinScore.Text = ": " + myRandomNumberGenerator.countwin++;
                }
                else
                {
                    MessageBox.Show("You Lose");
                    myRandomNumberGenerator.countlose++;
                    lbLossScore.Text = ": " + myRandomNumberGenerator.countlose++;
                }
               
               this.Text = " " + "Count = " + myRandomNumberGenerator.countwin.ToString();
            }
          
        }

        private void rdoEggsRunway_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoEggsRunway.Checked)
            {
                //Show a picture box with a chicken become visible

            }
        }

        private void rdoEggsOnGrass_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoEggsOnGrass.Checked)
            {
                
            }
        }

        private void btnExitToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 exitGame = new Form1();
            exitGame.Show();

            mySoundbackground2.Stop();
            mySoundBackground.Play();
        }
    }
    
}

    
