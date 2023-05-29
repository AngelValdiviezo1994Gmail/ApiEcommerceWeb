using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ApiEcommerceWeb.Domain.Entities.Carrito;


[Table("EC_LogError", Schema = "dbo")]
public class LogError
{
    [Key]
    [Column("id", Order = 0, TypeName = "uniqueidentifier")]
    public Guid Id { get; set; }

    [Column("transaccionId", Order = 1, TypeName = "uniqueidentifier")]
    public Guid TransaccionId { get; set; }
    public Transaccion Transaccion { get; set; }

    [Column("codError", Order = 2, TypeName = "varchar")]
    public string CodError { get; set; }

    [Column("desError", Order = 3, TypeName = "varchar")]
    public string DesError { get; set; }

    [Column("usuarioCreacion", Order = 4, TypeName = "varchar")]
    public string UsuarioCreacion { get; set; } = string.Empty;

    [Column("fechaCreacion", Order = 5, TypeName = "datetime2")]
    public DateTime FechaCreacion { get; set; } = DateTime.Now;
}

