using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewEvent.Models.Domain
{
    public interface IChallenge
    {
        Types.Challenges Challenge { get; set; }

    }
}
