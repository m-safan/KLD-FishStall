using System;
using System.Collections.Generic;

namespace KLDFishStall.Model.Models
{
    public partial class User
    {
        public User()
        {
            OrderFkIdUserConfirmedByNavigation = new HashSet<Order>();
            OrderFkIdUserDeleveredByNavigation = new HashSet<Order>();
            OrderFkIdUserOrderedByNavigation = new HashSet<Order>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string ImageUrl { get; set; }

        public ICollection<Order> OrderFkIdUserConfirmedByNavigation { get; set; }
        public ICollection<Order> OrderFkIdUserDeleveredByNavigation { get; set; }
        public ICollection<Order> OrderFkIdUserOrderedByNavigation { get; set; }
    }
}
