using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore1.Models
{
    public class Cart
    {
      
        //public string Id { get; set; }

        //cartId will be set to GuestSessionId
        [Required]
        public string SessionId { get; set; }
        public virtual Session Session { get; set; }
        [Required]
        public string GameId { get; set; }
        public int Quantity { get; set; }
        public virtual Game Game { get; set; }
    }
}
