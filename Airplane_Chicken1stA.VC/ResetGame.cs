using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airplane_Chicken1stA.VC
{
    public class ResetGame
    {
        //Variables
        public int RDNSelected = 0;
        public int RandomNum2 = 0;
        public int count = 0;
        public int countwin = 0;                                             
        public int countlose = 0;
        public int LayGrasscount = 2;
        public int _RandomNumber;
        public bool IsOnGrass = true;

        
        public RadioButton ResetRb1()
        {
            //Radio Button OnGrass (myRB)
            RadioButton myRB = new RadioButton();
            myRB.Checked = false;
            return myRB;
        }

        public RadioButton ResetRb2()
        {
            //Radio Button OnRunway (myRB2)
            RadioButton myRB2 = new RadioButton();
            myRB2.Checked = false;
            return myRB2;
        }
        
    }
}
