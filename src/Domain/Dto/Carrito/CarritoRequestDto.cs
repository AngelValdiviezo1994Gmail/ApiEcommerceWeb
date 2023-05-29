using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiEcommerceWeb.Domain.Dto.Carrito;

public class CarritoRequestDto
{
    public string Sku { get; set; }

    public int Cantidad { get; set; }
}
