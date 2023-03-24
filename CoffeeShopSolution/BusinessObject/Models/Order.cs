using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public int UserId { get; set; }

    public string Phone { get; set; } = null!;

    public decimal Total { get; set; }

    public string Status { get; set; } = null!;

    public virtual ICollection<OrderDetail> OrderDetails { get; } = new List<OrderDetail>();

    public virtual User User { get; set; } = null!;
}
