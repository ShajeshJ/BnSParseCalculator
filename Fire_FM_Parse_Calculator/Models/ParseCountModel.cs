using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_FM_Parse_Calculator.Models
{
    public class ParseCountModel
    {
        public string Unit { get; }
        public double Count { get; set; }
        public string Divisions { get; }
        public CountType CountType { get; set; }

        public ParseCountModel(string unit, CountType type)
        {
            Unit = unit;
            Divisions = null;
            CountType = type;
        }

        public ParseCountModel(string unit, double count)
        {
            Unit = unit;
            Count = count;
            CountType = CountType.Percentage;
        }

        public ParseCountModel(string unit, string divisions)
        {
            Unit = unit;
            Divisions = divisions;
            CountType = CountType.Ratio;
        }

        public ParseCountModel(string unit, double count, string divisions)
        {
            Unit = unit;
            Count = count;
            Divisions = divisions;
            CountType = CountType.Ratio;
        }

        public override string ToString()
        {
            string output;

            switch (CountType)
            {
                case CountType.Ratio:
                    output = Count == -1 ? "Undefined" : "" + Math.Round(Count, 4);
                    output += " " + Unit;
                    output += (string.IsNullOrWhiteSpace(Divisions) ? "" : $" / {Divisions}");
                    break;

                case CountType.Percentage:
                    output = Count == -1 ? "Undefined" : Math.Round(Count, 2) + "%";
                    output += " " + Unit;
                    break;

                default:
                    output = "";
                    break;
            }

            return output;
        }
    }

    public enum CountType
    {
        Ratio = 1, 
        Percentage = 2
    }
}
