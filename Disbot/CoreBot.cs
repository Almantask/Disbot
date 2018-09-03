using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disbot
{
    public class CoreBot
    {
        public readonly List<string> PossibleCurses;
        public CoreBot()
        {
            PossibleCurses = new List<string>();
        }

        public void Add(string curse)
        {
            PossibleCurses.Add(curse);
        }

        public string PickResponse(string context)
        {
            if (context.ToLower().Contains("why"))
                return PossibleCurses[0];
            return "";
        }
    }
}
