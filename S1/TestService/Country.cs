﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace TestService
{
    [DataContract]
    public class Country
    {
        [DataMember]
        public int CountryId { get; set; }

        [DataMember]
        public string CountryName { get; set; }
    }
}
