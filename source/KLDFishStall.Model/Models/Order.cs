using System;
using System.Collections.Generic;

namespace KLDFishStall.Model.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderItem = new HashSet<OrderItem>();
        }

        public long Id { get; set; }
        public long FkIdUserOrderedBy { get; set; }
        public long FkIdUserConfirmedBy { get; set; }
        public long FkIdUserDeleveredBy { get; set; }
        public DateTimeOffset OrderedOn { get; set; }
        public DateTimeOffset DeliveredOn { get; set; }
        public double? Discount { get; set; }

        public User FkIdUserConfirmedByNavigation { get; set; }
        public User FkIdUserDeleveredByNavigation { get; set; }
        public User FkIdUserOrderedByNavigation { get; set; }
        public ICollection<OrderItem> OrderItem { get; set; }
    }
}
