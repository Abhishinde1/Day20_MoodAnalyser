using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
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
                else if (Message.Equals(string.Empty))
                {
                    throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.EMPTY_EXCEPTION, "Message can not be Empty");

                }
                else
                {
                    return "sad";
                }

            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Default exception: " + ex.Message);
                throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NULL_EXCEPTION, "Message can not be Null");
            }
        }
    }

}

