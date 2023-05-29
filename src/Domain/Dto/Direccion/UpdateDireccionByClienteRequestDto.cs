using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiEcommerceWeb.Domain.Dto.Direccion;

public class UpdateDireccionByClienteRequestDto
{
    public int IdEmpresa { get; set; }
    public int IdCliente { get; set; }
    public int IdClienteDireccion { get; set; }
    public string Descripcion { get; set; }
    public string Direccion { get; set; }
    public bool EsPrincipal { get; set; }
    public object Latitud { get; set; }
    public object Longitud { get; set; }
}

