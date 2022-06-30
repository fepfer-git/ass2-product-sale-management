using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Models
{
    public class OrderStatistic
    {
        public int OrderId { get; set; }
        public int? MemberId { get; set; }
        public int TotalProdcut { get; set; }
        public int TotalPrice { get; set; }
        public decimal? Freight { get; set; }

    }
}
