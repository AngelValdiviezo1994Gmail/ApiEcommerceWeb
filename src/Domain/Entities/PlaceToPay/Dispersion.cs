using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiEcommerceWeb.Domain.Entities.PlaceToPay;

public class Dispersion
{
    public string Agreement { get; set; }
    public string AgreementType { get; set; }
    public Amount Amount { get; set; }
}
