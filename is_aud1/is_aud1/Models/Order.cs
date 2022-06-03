using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace is_aud1.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        public string UserId { get; set; }

        //for 1:M relationship
        public ShopApplicationUser OrderedBy { get; set; }
        public List<ProductsInOrder> Products { get; set; }
    }
}
