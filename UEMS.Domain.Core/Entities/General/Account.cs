﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UEMS.Domain.Core.Entities
{
    public class Account : User
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Surname { get; set; }

        public DateTime Birthday { get; set; }

        public Gender Gender { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public virtual Nationality Nationality { get; set; }
    }

    public enum Gender
    {
        Male,
        Fimail
    }
}
