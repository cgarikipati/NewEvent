using DataModel.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataModel
{
    public class Rank
    {
        public EventLevel Level { get; set; }
        public int number { get; set; }
        public DateTime AssignedDateTime { get; set; }
    }
}
