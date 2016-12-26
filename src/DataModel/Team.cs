using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataModel.Enums;

namespace DataModel
{
    public class Team
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string AvatarUrl { get; set; }
        public Division QualifiedDivision { get; set; }
        public List<Coach> Coaches { get; set; }

        public List<Player> Players { get; set; }
  
        public List<Challenges> Challenges { get; set; }
    }
}
