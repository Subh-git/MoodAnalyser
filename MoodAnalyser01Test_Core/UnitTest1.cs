using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser01_Core;

namespace MoodAnalyser01Test_Core
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Givens the sadshouldreturn sad and happysouldreturnhappy method.
        /// TC 1.1 Given?I am in sad mood should return SAD.
        /// </summary>
        [TestMethod]
        public void GivenSadshouldreturnSad()
        {
            //Arrange
            string expected = "SAD";
            string message = "I am in sad mood";
            MoodAnalyser moodAnalysis = new MoodAnalyser(message);

            //Act
            string mood = moodAnalysis.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, mood);
        }

        [TestMethod]

        //TC 1.2 Given? I am in happy mood should return HAPPY.
        public void GivenHappyshouldreturnHappy()
        {
            //Arrange
            string expected = "HAPPY";
            string message = "I am in happy mood";
            MoodAnalyser moodAnalysis = new MoodAnalyser(message);

            //Act
            string mood = moodAnalysis.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, mood);
        }
    }
}
