using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiEcommerceWeb.Domain.Entities.PlaceToPay;

public class Amount
{
    public string Currency { get; set; }
    public decimal Total { get; set; }
    public List<Taxes> Taxes { get; set; }
    public List<Details> Details { get; set; }
}

