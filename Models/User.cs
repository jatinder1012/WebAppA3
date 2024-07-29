using System.Collections.Generic;

namespace WebAppA3.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public string ShippingAddress { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
