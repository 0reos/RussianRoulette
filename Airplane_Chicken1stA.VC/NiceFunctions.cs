using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airplane_Chicken1stA.VC
{
   public class NiceFunctions
    {
      
        public void PlayAirplaneChicken()
       {
           Play_Airplane_Chicken myPlayAirplaneChicken = new Play_Airplane_Chicken();
           myPlayAirplaneChicken.ShowDialog();
       }

      public void ExitGame()
       {
           Form1 exitGame = new Form1();
           exitGame.Show();
       }  
    }
}
