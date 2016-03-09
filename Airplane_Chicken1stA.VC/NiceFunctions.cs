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
            //Shows gameplay form (Play_Airplane_Chicken)
           Play_Airplane_Chicken myPlayAirplaneChicken = new Play_Airplane_Chicken();
           myPlayAirplaneChicken.ShowDialog();
       }

      public void ExitGame()
       {
           //Exits game and returns to first form (Form1)
           Form1 exitGame = new Form1();
           exitGame.Show();
       }  
    }
}
