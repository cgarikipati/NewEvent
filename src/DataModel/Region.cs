using DataModel.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataModel
{
    public class Region
    {
        int Id { get; set; }

        CountryNames Country { get; set; }

        GeoLocation Name { get; set; }
    }
}
