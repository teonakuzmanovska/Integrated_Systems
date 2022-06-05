using EShopAdminApp.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EShopAdminApp.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            HttpClient client = new HttpClient();
            string URL = "https://localhost:44359/api/AdminApi/GetAllActiveOrders";

            HttpResponseMessage responseMessage = client.GetAsync(URL).Result;

            var data = responseMessage.Content.ReadAsAsync<List<Order>>().Result;

            return View(data);
        }
        public IActionResult GetOrderDetails(int id)
        {
            HttpClient client = new HttpClient();
            string URL = "https://localhost:44359/api/AdminApi/GetOrderDetails";

            var model = new
            {
                Id = id
            };

            // string because JSON in backend is essentially a string
            // content serializes our model as a json so it can send it to a different api
            HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");

            HttpResponseMessage responseMessage = client.PostAsync(URL, httpContent).Result;

            var data = responseMessage.Content.ReadAsAsync<Order>().Result;

            return View(data);
        }
    }
}
