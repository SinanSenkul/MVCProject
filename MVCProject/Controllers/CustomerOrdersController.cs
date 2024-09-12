using Microsoft.AspNetCore.Mvc;
using MVCProject.Models;

namespace MVCProject.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            var customer = new Customer
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com"
            };
            var order = new Order
            {
                Id=2,
                ProductName="pizza",
                Price=10,
                Quantity=1,
            };
            var order2 = new Order
            {
                Id = 3,
                ProductName = "milkshake",
                Price = 5,
                Quantity = 1,
            };
            var viewModel = new CustomerOrderViewModel
            {
                Customer = customer,
                Orders = {order, order2}
            };
            return View();
        }
    }
}
