using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiEcommerceWeb.Domain.Entities.PlaceToPay;

public class Modifiers
{
    public string Type { get; set; }
    public string Code { get; set; }
    public Additional additional { get; set; }
}
