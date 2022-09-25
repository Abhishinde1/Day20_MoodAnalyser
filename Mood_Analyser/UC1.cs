using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood_Analyser
{
    public class UC1_MoodAnalyser
    {
        public string Message;
        public UC1_MoodAnalyser(string message)
        {
            this.Message = message;
        }

        public string Mood()
        {
            try
            {
                if (Message.ToLower().Contains("happy"))
                {
                    return "happy";
                }
                else
                {
                    return "sad";
                }

            }
            catch (NullReferenceException)
            {
                Console.WriteLine("parameter can not be Null");
                return "happy";
            }
        }
    }
}
