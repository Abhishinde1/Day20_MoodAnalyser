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
        [TestCategory("Empty Exception")]
        public void Method3()
        {
            string expected = "Message can not be Empty";
            try
            {
                string message = "";
                UC1_MoodAnalyser mood = new UC1_MoodAnalyser(message);
                string actual = mood.Mood();
            }
            catch (MoodAnalyzerException ex)
            {
                Console.WriteLine("Custom Exception: " + ex);
                Assert.AreEqual(expected, ex.Message);
            }
        }
        [TestMethod]
        [TestCategory("Null Exception")]

        public void Method4()
        {
            string expected = "Message can not be Null";
            try
            {
                string message = null;
                UC1_MoodAnalyser mood = new UC1_MoodAnalyser(message);
                string actual = mood.Mood();
            }
            catch (MoodAnalyzerException ex)
            {
                Console.WriteLine("Custom Exception " + ex);
                Assert.AreEqual(expected, ex.Message);
            }
        }

    }
}