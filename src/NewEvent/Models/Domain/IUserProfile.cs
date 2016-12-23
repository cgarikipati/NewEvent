﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewEvent.Models.Domain
{
    interface IUserProfile
    {
        string FirstName {get;set;}
        string LastName { get; set; }
        DateTime BirthDate { get; set; }

        Types.Gender Gender { get; set; }


        string AvatarUrl { get; set; }

    }
}
