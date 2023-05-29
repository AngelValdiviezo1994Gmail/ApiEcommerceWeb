using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiEcommerceWeb.Domain.Entities.PlaceToPay;

public class Shipping
{
    public string Document { get; set; }
    public string DocumentType { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Company { get; set; }
    public string Email { get; set; }
    public string Mobile { get; set; }
    public Address Address { get; set; }
}

