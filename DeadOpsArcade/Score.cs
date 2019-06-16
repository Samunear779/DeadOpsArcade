using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadOpsArcade
{
    public class Score
    {
        //score class for saving to xml 
        public string score;
        public string name;

        public Score(string _name, string _score)
        {
            name = _name;
            score = _score;
        }
    }
}
