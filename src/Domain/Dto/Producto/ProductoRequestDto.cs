using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiEcommerceWeb.Domain.Dto.Producto;

public class ProductoRequestDto
{

    public string Sku { get; set; }

    public string Terms { get; set; }

    public int IdListaPrecio { get; set; }

    public int IdPuntoOperacion { get; set; }

    public bool PermiteVenta { get; set; } = false;

    public bool PermiteCompra { get; set; } = false;

    public bool IncluirImagen { get; set; } = false;

    public string IdCategoria { get; set; }

    public string AuthToken { get; set; }
}