using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToroslarCam.Domain.Entities
{
    public class Order
    {
        public string Id { get; set; }
        public string OrderCode { get; set; }
        public string Description { get; set; }
        public DateTime OrderDate { get; set; }
        public IEnumerable<OrderDetail> Details { get; set; }
    }
}
