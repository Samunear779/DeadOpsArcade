using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadOpsArcade
{
    class Score
    {
        public string score;
        public string name;

        public Score(string _name, string _score)
        {
            name = _name;
            score = _score;
        }
    }
}
