using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiEcommerceWeb.Domain.Dto.Direccion;

public class DeleteDireccionByClienteRequestDto
{
    public int IdEmpresa { get; set; }
    public int IdCliente { get; set; }
    public int IdClienteDireccion { get; set; }
    public int Activo { get; set; }
    public object UsuarioCreacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public object UsuarioActualiza { get; set; }
    public DateTime FechaActualiza { get; set; }
}

