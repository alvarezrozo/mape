using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upb.mape.entity
{
    public class AcceptedDate
    {
        public decimal IDDate { get; set; }

        public decimal IDMaper { get; set; }
        public String MaperName { get; set; }

        public decimal? Cost { get; set; }

        public DateTime? DateD { get; set; }

        public TimeSpan? DateT { get; set; }
    }
}
