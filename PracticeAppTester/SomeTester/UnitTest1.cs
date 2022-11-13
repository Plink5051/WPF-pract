using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SomeApp;


namespace SomeTester
{
    [TestClass]
    public class PcManagerTests
    {
        PcManager pcManager = new PcManager();
        [TestMethod()]
        public void LoadPcFeatureTest_NumberZero_CPUCannotBeZero()
        {
            //Allert 
            int numberOfCups = 0;
            bool os64 = false;

            string expected = "The number of CPUs cannot be zero";
            //Act 
            var result = pcManager.LoadPcFeature(numberOfCups, os64);
            //Assert 

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void LoadPcFeatureTest_Os64False_Successfully()
        {
            //Allert 
            int numberOfCups = 1;
            bool os64 = false;

            string expected = "PC data has been successfully generated";
            //Act 
            var result = pcManager.LoadPcFeature(numberOfCups, os64);
            //Assert 

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void LoadPcFeatureTest_NegativeNumber_CannotBe()
        {
            //Allert 
            int numberOfCups = -1;
            bool os64 = false;

            string expected = "An error occurred during data generation";
            //Act 
            var result = pcManager.LoadPcFeature(numberOfCups, os64);
            //Assert 

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void LoadPcFeatureTest_BigValue_CannotBe()
        {
            //Allert 
            int numberOfCups = 12345;
            bool os64 = false;

            string expected = "An error occurred during data generation";
            //Act 
            var result = pcManager.LoadPcFeature(numberOfCups, os64);
            //Assert 

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void LoadPcFeatureTest_Os64True_Successfully()
        {
            //Allert 
            int numberOfCups = 1;
            bool os64 = true;

            string expected = "PC data has been successfully generated";
            //Act 
            var result = pcManager.LoadPcFeature(numberOfCups, os64);
            //Assert 

            Assert.AreEqual(expected, result);
        }
    }
}
