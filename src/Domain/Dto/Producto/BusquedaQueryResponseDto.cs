using ApiEcommerceWeb.Domain.Entities.Producto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiEcommerceWeb.Domain.Dto.Producto;

public class BusquedaQueryResponseDto
{
    public List<Banner> Banners { get; set; } = new List<Banner>();
    public List<Categoria> Categorias { get; set; } = new List<Categoria>();


}