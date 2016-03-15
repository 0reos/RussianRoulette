using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Airplane_Chicken1stA.VC
{
    public partial class Form1: Form
    {/// <summary>
    /// ghjgfhjghj
    /// </summary>
        //Initializing background sound 
        SoundPlayer mySoundBackground = new SoundPlayer(ResourceFile.Airplane_Ambience); 
        NiceFunctions myNiceFunctions = new NiceFunctions();
        
        public Form1()
        {
            InitializeComponent();

            //Sets form in center of the screen
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //Opens game (in second form) while hiding current one
            Hide();
            myNiceFunctions.PlayAirplaneChicken();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           //Plays background music for first form
           mySoundBackground.Play();
        }
    }
}
