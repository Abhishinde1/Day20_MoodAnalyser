using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood_Analyser
{
    public class UC1_MoodAnalyser
    {
        public string Mood(string message)
        {
            if (message.ToLower().Contains("happy"))
            {
                return "happy";
            }
            else
            {
                return "sad";
            }
        }
    }
}
