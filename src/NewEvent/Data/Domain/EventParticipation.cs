using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewEvent.Models.Domain
{
    public class EventParticipation
    {
        IEvent Event { get; set; }
        IChallenge Challenge { get; set; }
        int Score { get; set; }
        Team Team { get; set; }

    }
}
