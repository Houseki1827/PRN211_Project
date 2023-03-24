using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class Item
{
    public string ItemId { get; set; } = null!;

    public int CategoryId { get; set; }

    public string ItemName { get; set; } = null!;

    public decimal Price { get; set; }

    public virtual ICollection<Cart> Carts { get; } = new List<Cart>();

    public virtual Category Category { get; set; } = null!;
}
