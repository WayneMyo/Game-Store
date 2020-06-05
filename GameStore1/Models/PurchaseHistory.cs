using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore1.Models
{
    public class PurchaseHistory
    {
        public int Id { get; set; }

        public string GameId { get; set; }

        public string Total { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
