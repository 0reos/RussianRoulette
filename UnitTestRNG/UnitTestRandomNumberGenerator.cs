using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestRNG
{
    [TestClass]
    public class UnitTest1
    {
        public int RandomNum2 = 0;
        public int count = 0;
        public int countwin = 0;                                             
        public int countlose = 0;
        public int Shotawaycount = 2;
        private int _RandomNumber;

        [TestMethod]
        public void RandomNumber()
        {
            Random RND = new Random();
            _RandomNumber = RND.Next(1, 7);
            
            //Testing if the random number is betwen 1-6
            Assert.IsTrue((_RandomNumber < 7) && (_RandomNumber > 0));
        }
    }
}
