using EShop.Domain.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Domain.DomainModels
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
