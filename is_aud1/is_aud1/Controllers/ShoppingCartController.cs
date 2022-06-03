using is_aud1.Data;
using is_aud1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace is_aud1.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ShoppingCartController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var user = _context.Users.Where(z => z.Id == userId)
                .Include("UserShoppingCart.ProductsInShoppingCarts")
                .Include("UserShoppingCart.ProductsInShoppingCarts.Product")
                .FirstOrDefault();

            var userShoppingCart = user.UserShoppingCart;

            var productList = userShoppingCart.ProductsInShoppingCarts.Select(z => new
            {
                Quantity = z.Quantity,
                ProductPrice = z.Product.ProductPrice
            });

            int totalPrice = 0;

            foreach (var item in productList)
            {
                totalPrice += item.ProductPrice * item.Quantity;
            }

            // some kind of constructor - "set method option"
            ShoppingCartDto model = new ShoppingCartDto
            {
                ProductsInShoppingCarts = userShoppingCart.ProductsInShoppingCarts.ToList(),
                TotalPrice = totalPrice

            };

            return View(model);
        }
    }
}
