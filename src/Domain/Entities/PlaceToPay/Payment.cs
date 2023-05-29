using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiEcommerceWeb.Domain.Entities.PlaceToPay;

public class Payment
{
    public string Reference { get; set; }
    public string Description { get; set; }
    public Amount Amount { get; set; }
    public bool AllowPartial { get; set; }
    public Shipping Shipping { get; set; }
    public List<Items> Items { get; set; }
    public List<Fields> Fields { get; set; }
    public Recurring Recurring { get; set; }
    public bool Subscribe { get; set; }
    public List<Dispersion> Dispersion { get; set; }
    public List<Modifiers> Modifiers { get; set; }
}
