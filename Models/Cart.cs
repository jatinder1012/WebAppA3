using System.Collections.Generic;

namespace WebAppA3.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public ICollection<CartItem> CartItems { get; set; }

        public User User { get; set; }
    }
}
