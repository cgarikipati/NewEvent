using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewEvent.Models.Domain
{
    public class Ranking
    {
       public IChallenge Challenge { get; set; }
        public int Rank { get; set; }

    }
}
