using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class OrderDetail
{
    public int OrderId { get; set; }

    public string ItemId { get; set; } = null!;

    public int Quantity { get; set; }

    public DateTime OrderDate { get; set; }

    public virtual Item Item { get; set; } = null!;

    public virtual Order Order { get; set; } = null!;
}
