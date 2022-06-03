using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace is_aud1.Models
{
    public class ShoppingCartDto
    {
        public List<ProductsInShoppingCart> ProductsInShoppingCarts { get; set; }
        public int TotalPrice { get; set; }
    }
}
