using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore1.Models
{
    public class Order
    {
     
       // public int Id { get; set; }
        public string OrderId { get; set; }
        public string Userusername { get; set; }
        public virtual User user { get; set; }
        public decimal Total { get; set; }
        public DateTime OrderDate { get; set; }
        
        //create navigation property
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
