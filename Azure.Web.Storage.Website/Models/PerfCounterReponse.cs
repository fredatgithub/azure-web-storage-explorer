﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Azure.Web.Storage.Website.Models
{
    public class PerfCounterReponse
    {
        public string CounterName { get; set; }
        public IEnumerable<PerfCounterEntry> Values { get; set; }
    }
}