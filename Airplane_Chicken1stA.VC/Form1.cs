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
    {
        //Adding background sound 
        SoundPlayer mySoundBackground = new SoundPlayer(ResourceFile.Airplane_Ambience); 
        NiceFunctions myNiceFunctions = new NiceFunctions();
        Play_Airplane_Chicken myPlayAirplaneChicken = new Play_Airplane_Chicken();
        
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //Opens game (in second form)
            this.Hide();
            myNiceFunctions.PlayAirplaneChicken();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           mySoundBackground.Play();
        }
    }
}
