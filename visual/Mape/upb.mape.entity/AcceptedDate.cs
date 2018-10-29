﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upb.mape.entity
{
    public class AcceptedDate
    {
        public String MaperName { get; set; }

        public decimal? Cost { get; set; }

        public DateTime? DateD { get; set; }

        public TimeSpan? DateT { get; set; }
    }
}