using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiEcommerceWeb.Domain.Entities.Producto;

public class Banner
{
    public int IdBanner { get; set; }
    public string Descripcion { get; set; }
    public string ImagenUrl { get; set; }
    public int Orden { get; set; }

    public List<Producto> Productos { get; set; } = new List<Producto>();
}
