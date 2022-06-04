//using is_aud1.Data;
//using EShop.Domain.DomainModels;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Claims;
//using System.Threading.Tasks;

//namespace is_aud1.Controllers
//{
//    public class ShoppingCartController : Controller
//    {
//        private readonly ApplicationDbContext _context;

//        public ShoppingCartController(ApplicationDbContext context)
//        {
//            _context = context;
//        }
//        public IActionResult Index()
//        {
//            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

//            var user = _context.Users.Where(z => z.Id == userId)
//                .Include("UserShoppingCart.ProductsInShoppingCarts")
//                .Include("UserShoppingCart.ProductsInShoppingCarts.Product")
//                .FirstOrDefault();

//            var userShoppingCart = user.UserShoppingCart;

//            var productList = userShoppingCart.ProductsInShoppingCarts.Select(z => new
//            {
//                Quantity = z.Quantity,
//                ProductPrice = z.Product.ProductPrice
//            });

//            int totalPrice = 0;

//            foreach (var item in productList)
//            {
//                totalPrice += item.ProductPrice * item.Quantity;
//            }

//            // some kind of constructor - "set method option"
//            ShoppingCartDto model = new ShoppingCartDto
//            {
//                ProductsInShoppingCarts = userShoppingCart.ProductsInShoppingCarts.ToList(),
//                TotalPrice = totalPrice

//            };

//            return View(model);
//        }

//        // the parameter is called id and not ProductId because Startup.cs requires so.
//        // you should either use id here, or change it in Startup.cs
//        public IActionResult DeleteFromShoppingCart(int id)
//        {
//            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

//            var user = _context.Users.Where(z => z.Id == userId)
//                .Include("UserShoppingCart.ProductsInShoppingCarts")
//                .Include("UserShoppingCart.ProductsInShoppingCarts.Product")
//                .FirstOrDefault();

//            var userShoppingCart = user.UserShoppingCart;

//            var forRemoval = userShoppingCart.ProductsInShoppingCarts.Where(z => z.ProductId == id).FirstOrDefault();
//            userShoppingCart.ProductsInShoppingCarts.Remove(forRemoval);

//            _context.Update(userShoppingCart);
//            _context.SaveChanges();

//            return RedirectToAction("Index");
//        }

//        public IActionResult OrderNow()
//        {
//            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

//            var user = _context.Users.Where(z => z.Id == userId)
//                .Include("UserShoppingCart.ProductsInShoppingCarts")
//                .Include("UserShoppingCart.ProductsInShoppingCarts.Product")
//                .FirstOrDefault();

//            var userShoppingCart = user.UserShoppingCart;

//            Order newOrder = new Order
//            {
//                UserId = user.Id,
//                OrderedBy = user
//            };

//            _context.Add(newOrder);
//            _context.SaveChanges();

//            //orderId has not already been saved to the database. It will be transfered as soon as it saves. No need to save to database this soon
//            List<ProductsInOrder> productsInOrders = userShoppingCart.ProductsInShoppingCarts.Select(z => new ProductsInOrder
//            {
//                Product = z.Product,
//                ProductId = z.ProductId,
//                Order = newOrder,
//                OrderId = newOrder.OrderId
//            }).ToList();

//            foreach (var item in productsInOrders)
//            {
//                _context.Add(item);
//            }

//            user.UserShoppingCart.ProductsInShoppingCarts.Clear();
//            _context.Update(user);
//            _context.SaveChanges();

//            return RedirectToAction("Index");

//        }
//    }
//}
