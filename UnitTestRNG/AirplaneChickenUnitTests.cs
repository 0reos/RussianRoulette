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
         
        [TestMethod]
        public void RandomNumber()
        {
           RandomNumberGenerator myRandomNumberGenerator = new RandomNumberGenerator();

            //Tests if the random number generated is between 0 and 7 is true 
           Assert.IsTrue((myRandomNumberGenerator.RandomNumber < 7) && (myRandomNumberGenerator.RandomNumber > 0));
        }
        
        [TestMethod]
        public void ResetCount()
        {
            ResetGame myReset = new ResetGame();

            //Tests if 0 is equal to count
            Assert.AreEqual(0, myReset.count);
          
        }
        
    }
}
