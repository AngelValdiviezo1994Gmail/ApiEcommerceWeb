using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiEcommerceWeb.Domain.Entities.PlaceToPay;

public class Authentication
{
    public string Login { get; set; }
    public string TranKey { get; set; }
    public string Nonce { get; set; }
    public string Seed { get; set; }

}

