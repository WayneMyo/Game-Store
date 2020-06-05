using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore1.Models
{
    public class ActivationCode
    {
        public int Id { get; set; }
        public int OrderDetailId { get; set; }

        public virtual OrderDetail OrderDetail { get; set; }
        public Guid Activationcode { get; set; }
    }
}
