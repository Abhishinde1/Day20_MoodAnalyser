using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood_Analyser
{
    public class MoodAnalyzerException : Exception
    {
        public Exception type;
        public enum ExceptionType
        {
            NULL_EXCEPTION,
            EMPTY_EXCEPTION,
        }

        public ExceptionType Type;
        public MoodAnalyzerException(ExceptionType type, string Message) : base(Message)
        {
            this.Type = type;
        }

    }
}
