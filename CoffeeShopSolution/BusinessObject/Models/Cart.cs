using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class Cart
{
    public string ItemId { get; set; } = null!;

    public int UserId { get; set; }

    public string ItemName { get; set; } = null!;

    public decimal Price { get; set; }

    public int Quantity { get; set; }

    public DateTime OrderDate { get; set; }

    public virtual Item Item { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
