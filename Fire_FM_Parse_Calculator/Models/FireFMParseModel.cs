using Fire_FM_Parse_Calculator.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_FM_Parse_Calculator.Models
{
    public class FireFMParseModel : ParseModel
    {
        #region User Provided Skill Counts

        public int BlazingBeams { get; set; }
        public int Infernos { get; set; }
        public int BlazingPalms { get; set; }
        public int FrostPalms { get; set; }
        public int SmoulderingAsh { get; set; }
        public int MeteorShowers { get; set; }
        public int DualDragons { get; set; }
        public int Dragonblazes { get; set; }
        public int Impacts { get; set; }
        public int ShortFuses { get; set; }

        #endregion

        #region Intemediary Counts

        private int _globalCount
        {
            get
            {
                return BlazingBeams + MeteorShowers / 5 + DualDragons + Dragonblazes + Impacts + ShortFuses;
            }
        }
        private int _palmCount
        {
            get
            {
                return Math.Max(BlazingPalms, FrostPalms);
            }
        }

        #endregion

        public FireFMParseModel (int mins, int secs)
            :base(mins, secs)
        {

        }

        #region Parse Calculators

        public ParseCountModel BBRate
        {
            get
            {
                var count = Duration.TotalSeconds >= 1 
                            ? BlazingBeams / Duration.TotalSeconds
                            : -1;

                return new ParseCountModel("Blazing Beam", count, "second");
            }
        }

        public ParseCountModel InfernoRatio
        {
            get
            {
                double count;

                if (Impacts < 1)
                {
                    if (Infernos < 1)
                    {
                        count = 0;
                    }
                    else
                    {
                        count = -1;
                    }
                }
                else
                {
                    count = (double)Infernos / Impacts;
                }

                return new ParseCountModel("Inferno", count, "Impact");
            }
        }

        public ParseCountModel Rotations
        {
            get
            {
                var count = Duration.TotalSeconds >= 1
                            ? _palmCount / Duration.TotalSeconds 
                            : -1;

                return new ParseCountModel("Rotation", count, "second");
            }
        }

        public ParseCountModel PalmRatio
        {
            get
            {
                var count = FrostPalms > 0
                            ? (double)BlazingPalms / FrostPalms
                            : -1;

                return new ParseCountModel("Blazing Palm", count, "Frost Palm");
            }
        }

        public ParseCountModel GlobalRate
        {
            get
            {
                var count = Duration.TotalSeconds >= 1
                            ? _globalCount / Duration.TotalSeconds
                            : -1;

                return new ParseCountModel("Global Skill", count, "second");
            }
        }

        public ParseCountModel GlobalPerPalm
        {
            get
            {
                var count = _palmCount > 0
                            ? (double)_globalCount / _palmCount
                            : -1;

                return new ParseCountModel("Global Skill", count, "Palm");
            }
        }

        public ParseCountModel DragonblazeUptime
        {
            get
            {
                var count = Duration.TotalSeconds >= 1
                            ? Dragonblazes * 10 / Duration.TotalSeconds * 100
                            : -1;

                return new ParseCountModel("Dragonblaze Uptime", count);
            }
        }

        public ParseCountModel SmoulderingAshUptime
        {
            get
            {
                var count = Duration.TotalSeconds >= 1
                            ? SmoulderingAsh / Duration.TotalSeconds * 100
                            : -1;

                return new ParseCountModel("Smouldering Ash Uptime", count);
            }
        }

        #endregion

        public override IEnumerable<ParseCountModel> CalculateParse()
        {
            return new List<ParseCountModel>()
            {
                BBRate,
                InfernoRatio,
                Rotations,
                PalmRatio,
                GlobalRate,
                GlobalPerPalm, 
                DragonblazeUptime, 
                SmoulderingAshUptime
            };
        }
    }
}
