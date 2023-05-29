using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiEcommerceWeb.Domain.Entities.PlaceToPay;

public class Taxes
{
    public string Kind { get; set; }
    public decimal Amount { get; set; }
    public decimal Base { get; set; }

}