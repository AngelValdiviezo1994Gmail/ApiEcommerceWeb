using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiEcommerceWeb.Domain.Entities.Producto;

public class Producto
{
    public int IdBanner { get; set; }
    public string Sku { get; set; }
    public string CodigoExterno { get; set; }
    public string CodigoEAN { get; set; }
    public string CodigoUPC { get; set; }
    public string Descripcion { get; set; }
    public string UnidadMedida { get; set; }
    public decimal? PrecioUnitario { get; set; }
    public decimal? CostoUnitario { get; set; }
    public decimal? CostoUltimaCompra { get; set; }
    public decimal? CostoBultoPromedio { get; set; }
    public decimal? CostoPromedio { get; set; }
    public int IdImpuesto { get; set; }
    public string UnidadMedidaDescripcion { get; set; }
    public decimal? PorcentajeImpuesto { get; set; }
    public bool AplicaImpuesto { get; set; } = false;
    public decimal? PrecioUnitarioListaPrecio { get; set; }
    public decimal? PrecioUnitarioFinal { get; set; }
    public double Stock { get; set; }
    public double Cantidad { get; set; }
    public bool PermiteVenta { get; set; }
    public bool PermiteCompra { get; set; }

    public string Grupo { get; set; }
    public string SubGrupo { get; set; }
    //   "Grupo": "FRUTAS Y LEGUMBRES",
    //   "SubGrupo": "LEGUMBRES",

    public string Marca { get; set; }
    public string Tipo { get; set; }
    public string Imagen { get; set; }
    public string ImagenUrl { get; set; }
    public decimal? PrecioSinDescuento { get; set; }
    public bool TieneDescuento { get; set; }

}

