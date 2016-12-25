using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataModel
{
    public class Player : ApplicationUser
    {
        public UserProfile Profile { get; set; }
        public List<Rank> Ranks { get; set; }
        public int points { get; set; }    
    }
}
