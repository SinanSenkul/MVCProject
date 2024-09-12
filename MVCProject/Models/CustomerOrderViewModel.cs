using MVCProject.Models;

namespace MVCProject.Models
{
    public class CustomerOrderViewModel
    {
        public Customer Customer { get; set; }
        /*public Order Order { get; set; }*/
        public List<Order> Orders { get; set;}
    }
}