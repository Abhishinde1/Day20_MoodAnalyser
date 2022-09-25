namespace Mood_Analyser
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("Happy mood")]
        public void TestMethod1()
        {
            UC1_MoodAnalyser mood = new UC1_MoodAnalyser("I am in happy mood");

            string expected = "happy";
            var actual = mood.Mood();
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }
        [TestMethod]
        [TestCategory("sad mood")]
        public void TestMethod2()
        {
            UC1_MoodAnalyser mood = new UC1_MoodAnalyser("I am in sad mood");

            string expected = "sad";
            var actual = mood.Mood();
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }
        [TestMethod]
        [TestCategory("Null")]
        public void GivenNullShouldReturnHappy()
        {
            string message = null;
            UC1_MoodAnalyser mood = new UC1_MoodAnalyser(message);
            string excepted = "happy";
            var actual = mood.Mood();
            Assert.AreEqual(excepted, actual);
            Console.WriteLine(actual);
        }


    }
}