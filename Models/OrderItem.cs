using Dapper.Contrib.Extensions;
using System.Collections.Generic;

namespace Tibox.Models
{
    [Table("[OrderItem]")]
    public class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }

    }
}
