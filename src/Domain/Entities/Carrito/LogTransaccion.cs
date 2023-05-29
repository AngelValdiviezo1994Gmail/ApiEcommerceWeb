using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ApiEcommerceWeb.Domain.Entities.Carrito;


[Table("EC_LogTransaccion", Schema = "dbo")]
public class LogTransaccion
{
    [Key]
    [Column("id", Order = 0, TypeName = "uniqueidentifier")]
    public Guid Id { get; set; }

    [Column("transaccionId", Order = 1, TypeName = "uniqueidentifier")]
    public Guid TransaccionId { get; set; }
    public Transaccion Transaccion { get; set; }

    [Column("request", Order = 2, TypeName = "NVARCHAR(4000)")]
    public string Request { get; set; }

    [Column("response", Order = 3, TypeName = "NVARCHAR(4000)")]
    public string Response { get; set; }

    [Column("usuarioCreacion", Order = 4, TypeName = "varchar(50)")]
    public string UsuarioCreacion { get; set; } = string.Empty;

    [Column("fechaCreacion", Order = 5, TypeName = "datetime2")]
    public DateTime FechaCreacion { get; set; } = DateTime.Now;

}
