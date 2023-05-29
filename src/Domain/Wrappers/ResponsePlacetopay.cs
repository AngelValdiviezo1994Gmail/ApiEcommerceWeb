using ApiEcommerceWeb.Domain.Entities.PlaceToPay;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace ApiEcommerceWeb.Domain.Wrappers;


public class ResponseTypePlace<T>
{
    public ResponseTypePlace()
    {

    }
    public Statu Status { get; set; }
    public int RequestId { get; set; }

    public string ProcessUrl { get; set; }
    public T Data { get; set; }

    public Sesion Request { get; set; }
    public object Payment { get; set; }
    public object Subscription { get; set; }
}

public class Statu
{
    public string Status { get; set; }
    public string Reason { get; set; }
    public string Message { get; set; }
    public string Date { get; set; }
}
