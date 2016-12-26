using DataModel.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataModel
{
    public class Event
    {
       public  int Id { get; set; }

        // Name of the event
        public string Name { get; set; }

        public Region Region { get; set; }

        public EventLevel EventLevl { get; set; }

        public DateTime StartDateTime { get; set; }

        public DateTime EndDateTime { get; set; }

        public List<Challenges> HostedChallenges { get; set; }

        public List <Team> Teams { get; set; }    
    }
}
