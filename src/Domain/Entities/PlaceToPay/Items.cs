using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiEcommerceWeb.Domain.Entities.PlaceToPay;

public class Items
{
    public string Sku { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public string Qty { get; set; }
    public decimal Price { get; set; }
    public decimal Tax { get; set; }
}

