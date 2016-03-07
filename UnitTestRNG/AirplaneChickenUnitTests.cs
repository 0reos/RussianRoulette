using System;
using System.Security.Cryptography;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Airplane_Chicken1stA;
using Airplane_Chicken1stA.VC;
using RandomNumberGenerator = Airplane_Chicken1stA.VC.RandomNumberGenerator;

namespace Airplane_Chicken_Unit_Tests
{
    [TestClass]
    public class UnitTest1
    {
        //public int RandomNum2 = 0;
        //public int count = 0;
        //public int countwin = 0;                                             
        //public int countlose = 0;
        //public int Shotawaycount = 2;
        //private int _RandomNumber;

        [TestMethod]
        public void RandomNumber()
        {
           RandomNumberGenerator myRandomNumberGenerator = new RandomNumberGenerator();

           Assert.IsTrue((myRandomNumberGenerator.RandomNumber < 7) && (myRandomNumberGenerator.RandomNumber > 0));
        }
        
        [TestMethod]
        public void ResetCount()
        {
            ResetGame myReset = new ResetGame();

            Assert.AreEqual(0, myReset.count);
          
        }
        
    }
}
