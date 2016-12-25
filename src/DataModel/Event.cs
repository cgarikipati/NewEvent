using DataModel.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataModel
{
    public class Event
    {
        int Id { get; set; }
       
        // Name of the event
        string Name { get; set; }

        Region Region { get; set; }

        EventLevel EventLevl { get; set; }

        DateTime StartDateTime { get; set; }

        DateTime EndDateTime { get; set; }

        List<Challenges> Challenges { get; set; }
    }
}
