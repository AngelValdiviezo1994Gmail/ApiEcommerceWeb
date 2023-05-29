using ApiEcommerceWeb.Domain.Entities.Carrito;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiEcommerceWeb.Domain.Entities.MetodoPagos;

[Table("EC_MetodoPago", Schema = "dbo")]
public class MetodoPago
{
    [Key]
    [Column("id", Order = 0, TypeName = "uniqueidentifier")]
    public Guid Id { get; set; }

    [Column("descripcion", Order = 1, TypeName = "varchar(50)")]
    public string Descripcion { get; set; }

    [Column("estado", Order = 2, TypeName = "varchar")]
    [StringLength(1)]
    public string Estado { get; set; }

    [Column("usuarioCreacion", Order = 3, TypeName = "varchar(50)")]
    public string UsuarioCreacion { get; set; } = string.Empty;

    [Column("fechaCreacion", Order = 4, TypeName = "datetime2")]
    public DateTime FechaCreacion { get; set; } = DateTime.Now;

    [Column("usuarioModificacion", Order = 5, TypeName = "varchar(50)")]
    public string UsuarioModificacion { get; set; } = string.Empty;

    [Column("fechaModificacion", Order = 6, TypeName = "datetime2")]
    public DateTime? FechaModificacion { get; set; }

    [Column("urlImage", Order = 7, TypeName = "varchar")]
    public string UrlImage { get; set; }

    public virtual ICollection<Transaccion> Transaccion { get; set; }
}

