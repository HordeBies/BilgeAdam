using System;
using System.Collections.Generic;

namespace LINQ.Models;

public partial class MostExpensiveCondiment
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public string SupplierName { get; set; } = null!;
}
