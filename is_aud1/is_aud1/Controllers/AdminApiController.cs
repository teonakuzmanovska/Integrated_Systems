using EShop.Domain.DomainModels;
using EShop.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace is_aud1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminApiController : ControllerBase
    {
        public readonly IOrderService _orderService;

        public AdminApiController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public List<Order> GetAllActiveOrders()
        {
            return _orderService.GetAllOrders();
        }
    }
}
