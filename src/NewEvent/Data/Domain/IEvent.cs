using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewEvent.Models.Domain
{
    public interface IEvent 
    {
        string Name { get; set; }
        string Country { get; set; }
        IRegion Region { get; set; }
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }
    }
}
