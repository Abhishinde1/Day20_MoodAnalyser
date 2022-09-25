namespace Mood_Analyser
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("happy mood")]
        public void TestMethod1()
        {
            UC1_MoodAnalyser mood = new UC1_MoodAnalyser();
            string message = "I am in happy mood";
            string expected = "happy";
            var actual = mood.Mood(message);
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }

        [TestMethod]
        [TestCategory("sad mood")]

        public void TestMethod2()
        {
            UC1_MoodAnalyser mood = new UC1_MoodAnalyser();
            string message = "I am in sad mood";
            string expected = "sad";
            var actual = mood.Mood(message);
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }
    }
}