using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upb.mape.entity
{
    public class MaperComment
    {
        public decimal IDComment { get; set; }

        public decimal IDMaper { get; set; }

        public String Comment { get; set; }

        public DateTime DateD { get; set; }

        public decimal Value { get; set; }
    }
}
