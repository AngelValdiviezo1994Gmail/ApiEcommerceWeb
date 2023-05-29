using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiEcommerceWeb.Domain.Entities.Carrito;

public class DetalleCarrito
{
    public int IdEmpresa { get; set; }
    public int IdPuntoOperacion { get; set; }
    public string TipoTransaccion { get; set; }
    public int IdTransaccion { get; set; }
    public DateTime Fecha { get; set; }
    public int? IdCaja { get; set; }
    public int? IdNumeroLocalSRI { get; set; }
    public int? IdNumeroCajaSRI { get; set; }
    public int? IdNumeroMovimientoSRI { get; set; }
    public string FormatoTransaccion { get; set; }
    public int IdCliente { get; set; }
    public int IdClienteDireccion { get; set; }
    public int TipoTransaccionTabla { get; set; }
    public DateTime? FechaEntrega { get; set; }
    public string Comentario { get; set; } = string.Empty;
    public decimal Cantidad { get; set; }
    public decimal BaseGravada { get; set; }
    public decimal BaseExenta { get; set; }
    public decimal Subtotal { get; set; }
    public decimal DescuentoManual { get; set; }
    public decimal DescuentoAutomatico { get; set; }
    public decimal SubtotalSinImpuesto { get; set; }
    public decimal Impuesto { get; set; }
    public decimal Total { get; set; }
    public bool EsMayorista { get; set; } = false;
    public int EstadoTabla { get; set; }
    public string Estado { get; set; }
    public string UsrIng { get; set; }
    public DateTime FecIng { get; set; }
    public string UsrMod { get; set; }
    public DateTime FecMod { get; set; }
    public string IdPuntoOperacionRef { get; set; } = string.Empty;
    public string TipoTransaccionRef { get; set; } = string.Empty;
    public string IdTransaccionRef { get; set; } = string.Empty;
    public string FormatoTransaccionRef { get; set; } = string.Empty;
    public decimal Saldo { get; set; }
    public decimal Cambio { get; set; }
    public string Cliente { get; set; }
    public string Caja { get; set; } = string.Empty;
    public string PuntoOperacion { get; set; }
    public string ClienteDireccion { get; set; }
    public string Direccion { get; set; }
    public string EstadoDescripcion { get; set; }
    public string IdListaPrecio { get; set; } = string.Empty;
    public string ListaPrecio { get; set; } = string.Empty;
    public string Vendedor { get; set; }
    public string CorreoElectronico { get; set; }
    public string IdDiaEntrega { get; set; } = string.Empty;
    public string IdHorarioEntrega { get; set; } = string.Empty;
    public string Identificacion { get; set; }
    public string Telefono { get; set; }
    public string Empresa { get; set; }
    public string Alianza { get; set; }
    public string EstadoEntregaTabla { get; set; } = string.Empty;
    public string EstadoEntrega { get; set; } = string.Empty;
    public string EstadoEntregaDescripcion { get; set; } = string.Empty;
    public string TipoEnvioTabla { get; set; } = string.Empty;
    public string TipoEnvio { get; set; } = string.Empty;
    public string TipoEnvioDescripcion { get; set; } = string.Empty;
    public string DiaEntrega { get; set; } = string.Empty;
    public string HorarioEntrega { get; set; } = string.Empty;
    public string IdPuntoOperacionRetiro { get; set; } = string.Empty;
    public List<ProductosCarrito> Detalles { get; set; } = new List<ProductosCarrito>();
    public string[] Cobros { get; set; }
    public List<TrackingEcommerce> Trackings { get; set; } = new List<TrackingEcommerce>();
    public string[] Cupones { get; set; }
    public decimal BaseRetencionRenta { get; set; }
    public decimal BaseRetencionIva { get; set; }
    public decimal TotalForCobro { get; set; }
}

