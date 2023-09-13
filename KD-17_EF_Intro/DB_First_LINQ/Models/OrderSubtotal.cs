using System;
using System.Collections.Generic;

namespace DB_First_LINQ.Models;

public partial class OrderSubtotal
{
    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
