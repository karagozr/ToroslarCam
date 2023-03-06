using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToroslarCam.Domain.Entities
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public string OrderId { get; set; }
        public int OrderNum { get; set; }
        public string Description { get; set; }
        public string PoseDesc { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Quantity { get; set; }                       
        public decimal UnitPrice { get; set; } = 0;
        public Order Order { get; set; }
    }
}
