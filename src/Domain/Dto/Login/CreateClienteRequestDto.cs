using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiEcommerceWeb.Domain.Dto.Login;


public class CreateClienteRequestDto
{
    public int IdEmpresa { get; set; }
    public int IdTipoIdentificacion { get; set; }
    public string Identificacion { get; set; }
    public string Descripcion { get; set; }
    public string RazonSocial { get; set; }
    public string CorreoElectronico { get; set; }
    public int CreditoCupo { get; set; }
    public int CreditoDisponible { get; set; }
    public string Direccion { get; set; }
    public string Telefono { get; set; }
    public string Password { get; set; }
    public string ConfirmarPassword { get; set; }
    public string FechaNacimiento { get; set; }
    public int IdAlianza { get; set; }
    public string Genero { get; set; }
    public int Activo { get; set; }
    public int IdArea { get; set; }
    public int IdCanal { get; set; }
}
