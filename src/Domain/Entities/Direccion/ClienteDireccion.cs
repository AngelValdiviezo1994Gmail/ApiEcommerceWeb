using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiEcommerceWeb.Domain.Entities.Direccion;

public class ClienteDireccion
{
    public int? IdEmpresa { get; set; }
    public int? IdCliente { get; set; }
    public int? IdClienteDireccion { get; set; }
    public string Descripcion { get; set; }
    public string Direccion { get; set; }
    public bool? EsPrincipal { get; set; }
    public object Latitud { get; set; }
    public object Longitud { get; set; }
    public object Foto { get; set; }
    public int? Activo { get; set; }
    public int? Color { get; set; }
    public int? MarkerIndex { get; set; }
    public int? MarkerZIndex { get; set; }
    public int? MarkerStart { get; set; }
    public int? IdUbicacion { get; set; }
    public string Titulo { get; set; }
}

