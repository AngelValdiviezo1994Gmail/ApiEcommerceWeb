using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiEcommerceWeb.Domain.Entities.Carrito;


public class ProductosCarrito
{
    public int IdEmpresa { get; set; }
    public int IdPuntoOperacion { get; set; }
    public object TipoTransaccion { get; set; }
    public int IdTransaccion { get; set; }
    public int IdDetalle { get; set; }
    public string Sku { get; set; }
    public double Cantidad { get; set; }
    public double PrecioUnitario { get; set; }
    public double Subtotal { get; set; }
    public double DescuentoManual { get; set; }
    public double DescuentoAutomatico { get; set; }
    public double SubtotalSinImpuesto { get; set; }
    public int IdImpuesto { get; set; }
    public double Impuesto { get; set; }
    public double Total { get; set; }
    public object Comentario { get; set; }
    public object IdVendedor { get; set; }
    public string ImagenUrl { get; set; }
    public string Producto { get; set; }
    public string UnidadMedida { get; set; }
    public double PorcentajeImpuesto { get; set; }
    public bool AplicaImpuesto { get; set; }

}

