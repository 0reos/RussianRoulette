using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Airplane_Chicken1stA.VC
{
   public class RandomNumberGenerator
    {
        public int RDNSelected = 0;
        public int count = 0;
        public int countwin = 0;                                           
        public int countlose = 0;
        public int LayGrassCount = 2;
        public int _RandomNumber;
        public bool IsOnGrass = true;

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



