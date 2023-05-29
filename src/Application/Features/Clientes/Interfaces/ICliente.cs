using ApiEcommerceWeb.Application.Common.Wrappers;
using ApiEcommerceWeb.Domain.Dto.Login;
using ApiEcommerceWeb.Domain.Entities.Cliente;
using ApiEcommerceWeb.Domain.Entities.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiEcommerceWeb.Application.Features.Clientes.Interfaces;

public interface ICliente
{

    Task<ResponseType<Login>> AutenticacionUsuario(LoginRequestDto request, CancellationToken cancellationToken);

    Task<Cliente> GetClienteAsync(string token, CancellationToken cancellationToken);



    Task<ResponseType<bool>> CreateClienteAsync(CreateClienteRequestDto request, CancellationToken cancellationToken);



}
