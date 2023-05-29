using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiEcommerceWeb.Domain.Entities.MetodoPagos;

namespace ApiEcommerceWeb.Domain.Entities.Carrito;


[Table("EC_Transaccion", Schema = "dbo")]
public class Transaccion
{
    [Key]
    [Column("id", Order = 0, TypeName = "uniqueidentifier")]
    public Guid Id { get; set; }

    [Column("metodoPagoId", Order = 1, TypeName = "uniqueidentifier")]
    public Guid MetodoPagoId { get; set; }
    public MetodoPago MetodoPago { get; set; }

    [Column("reference", Order = 2, TypeName = "varchar(32)")]
    public string Reference { get; set; }

    [Column("idTransaccion", Order = 3, TypeName = "varchar(50)")]
    public string IdTransaccion { get; set; }

    [Column("requestId", Order = 4, TypeName = "varchar(50)")]
    public string RequestId { get; set; }

    [Column("referenceInternal", Order = 5, TypeName = "varchar(50)")]
    public string ReferenceInternal { get; set; }

    [Column("total", Order = 6, TypeName = "numeric(18,2)")]
    public decimal Total { get; set; }

    [Column("subtotal", Order = 7, TypeName = "numeric(18,2)")]
    public decimal Subtotal { get; set; }

    [Column("iva", Order = 8, TypeName = "numeric(18,2)")]
    public decimal Iva { get; set; }

    [Column("codeTipoEnvio", Order = 9, TypeName = "varchar")]
    [StringLength(1)]
    public string CodeTipoEnvio { get; set; }

    [Column("estado", Order = 10, TypeName = "varchar(50)")]
    public string Estado { get; set; }

    [Column("processUrl", Order = 11, TypeName = "varchar(250)")]
    public string ProcessUrl { get; set; }

    [Column("usuarioCreacion", Order = 12, TypeName = "varchar(50)")]
    public string UsuarioCreacion { get; set; } = string.Empty;

    [Column("fechaCreacion", Order = 13, TypeName = "datetime2")]
    public DateTime FechaCreacion { get; set; } = DateTime.Now;

    [Column("usuarioModificacion", Order = 14, TypeName = "varchar(50)")]
    public string UsuarioModificacion { get; set; } = string.Empty;

    [Column("fechaModificacion", Order = 15, TypeName = "datetime2")]
    public DateTime? FechaModificacion { get; set; }

    public virtual ICollection<LogTransaccion> LogTransaccion { get; set; }
    public virtual ICollection<LogError> LogError { get; set; }
}
