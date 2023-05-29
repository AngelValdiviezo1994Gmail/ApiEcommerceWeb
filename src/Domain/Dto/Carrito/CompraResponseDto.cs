using ApiEcommerceWeb.Domain.Entities.Carrito;
using ApiEcommerceWeb.Domain.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiEcommerceWeb.Domain.Dto.Carrito;

public class CompraResponseDto
{
    public DetalleCarrito DetalleCarrito { get; set; }
    public ResponseTypePlace<string> Placetopay { get; set; }
}
