using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Airplane_Chicken1stA.VC
{
    class RandomNumberGenerator
    {
        public int RandomNum2 = 0;
        public int count = 0;
        public int countwin = 0;                                             // For win and lose under btnLayEggs
        public int countlose = 0;
        public int Shotawaycount = 2;
        private int _RandomNumber;

        public int RandomNumber 
        {
            get
            {
               //Generates Random number
                Random RND = new Random();
               _RandomNumber = RND.Next(1, 7);
               return _RandomNumber;
            }
        }
    }
}



