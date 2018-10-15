using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upb.mape.entity
{
    public class Date
    {
        public decimal IDDate { get; set; }

        public decimal IDClient { get; set; }

        public decimal IDMaper { get; set; }

        public DateTime? DateD { get; set; }

        public TimeSpan? DateT { get; set; }

        public String Status { get; set; }
    }
}
