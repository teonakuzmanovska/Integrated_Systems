using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Domain.DomainModels
{
    public class ShoppingCart
    {
        [Key]
        public int CartId { get; set; }
        public string ApplictaionUserId { get; set; }
        public ICollection<ProductsInShoppingCart> ProductsInShoppingCarts { get; set; }
    }
}
