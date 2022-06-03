using EShop.Domain.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Domain.DTO
{
    public class ShoppingCartDto
    {
        public List<ProductsInShoppingCart> ProductsInShoppingCarts { get; set; }
        public int TotalPrice { get; set; }
    }
}
