using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewEvent.Models.Domain
{
    public interface IRegion
    {
        string Country { get; set; }
        int Id { get; set; }

        //Region Name
        string Name { get; set; }
    }
}
