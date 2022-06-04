using EShop.Domain.DomainModels;
using EShop.Service.Interface;
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
        private readonly IShoppingCartService _shoppingCartService;

        public ShoppingCartController(IShoppingCartService shoppingCartService)
        {
            _shoppingCartService = shoppingCartService;
        }
        public IActionResult Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var model = _shoppingCartService.GetShoppingCartInfo(userId);

            return View(model);
        }

        // the parameter is called id and not ProductId because Startup.cs requires so.
        // you should either use id here, or change it in Startup.cs
        public IActionResult DeleteFromShoppingCart(int id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            _shoppingCartService.DeleteProductFromShoppingCart(userId, id);

            return RedirectToAction("Index");
        }

        public IActionResult OrderNow()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            _shoppingCartService.OrderNow(userId);

            return RedirectToAction("Index");

        }
    }
}
