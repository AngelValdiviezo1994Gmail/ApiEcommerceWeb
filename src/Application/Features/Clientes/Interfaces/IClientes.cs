using ApiEcommerceWeb.Application.Common.Wrappers;
using ApiEcommerceWeb.Application.Features.Clientes.Commands.CreateClientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiEcommerceWeb.Application.Features.Clientes.Interfaces
{
    public interface IClientes
    {
        Task<ResponseType<string>> CreateCliente(CreateClientesRequest Request, CancellationToken cancellationToken);
    }
}
