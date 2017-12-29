using Fire_FM_Parse_Calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_FM_Parse_Calculator.Abstracts
{
    public abstract class ParseModel
    {
        public TimeSpan Duration { get; }

        public ParseModel(int hours, int mins, int secs)
        {
            Duration = new TimeSpan(hours, mins, secs);
        }

        public ParseModel(int mins, int secs)
        {
            Duration = new TimeSpan(0, mins, secs);
        }

        public ParseModel(int ticks)
        {
            Duration = new TimeSpan(ticks);
        }

        public ParseModel(TimeSpan duration)
        {
            Duration = new TimeSpan(duration.Ticks);
        }

        public abstract IEnumerable<ParseCountModel> CalculateParse();
    }
}
