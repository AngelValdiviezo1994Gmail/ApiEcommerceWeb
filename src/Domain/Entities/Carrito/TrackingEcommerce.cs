
namespace ApiEcommerceWeb.Domain.Entities.Carrito;

public class TrackingEcommerce
{
    public int IdEmpresa { get; set; }

    public int IdPuntoOperacion { get; set; }

    public string TipoTransaccion { get; set; }

    public int IdTransaccion { get; set; }

    public int Secuencia { get; set; }

    public DateTime Fecha { get; set; }

    public int EstadoEntregaTabla { get; set; }

    public string EstadoEntrega { get; set; }

    public string EstadoEntregaDescripcion { get; set; }

    public string Comentario { get; set; }

    public string FormatoTransaccion { get; set; }


    public string IdUsuario { get; set; }
}

