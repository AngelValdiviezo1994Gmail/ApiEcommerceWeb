using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiEcommerceWeb.Domain.Entities.PlaceToPay;


public class Sesion
{
    public string Locale { get; set; } = "es_EC";
    public Authentication Auth { get; set; }
    public Payer Payer { get; set; }
    public Buyer Buyer { get; set; }
    public Payment Payment { get; set; }
    public string PaymentMethod { get; set; }
    public string Expiration { get; set; }
    public string ReturnUrl { get; set; }
    public string CancelUrl { get; set; }
    public string IpAddress { get; set; } = "127.0.0.1";
    public string UserAgent { get; set; }
    public bool SkipResult { get; set; } = false;
    public bool NoBuyerFill { get; set; } = false;
    public string Type { get; set; } = "checkin";
}

