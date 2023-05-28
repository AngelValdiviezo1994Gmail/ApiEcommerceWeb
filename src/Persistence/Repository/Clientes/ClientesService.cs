using ApiEcommerceWeb.Application.Common.Exceptions;
using ApiEcommerceWeb.Application.Common.Interfaces;
using ApiEcommerceWeb.Application.Common.Wrappers;
//using ApiEcommerceWeb.Application.Features.Acontecimientos.Commands.CreateAcontecimientos;
//using ApiEcommerceWeb.Application.Features.Acontecimientos.Dto;
using ApiEcommerceWeb.Application.Features.Clientes.Commands.CreateClientes;
using ApiEcommerceWeb.Application.Features.Clientes.Interfaces;
//using ApiEcommerceWeb.Domain.Entities.Acontecimientos;
using ApiEcommerceWeb.Domain.Entities.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiEcommerceWeb.Persistence.Repository.Clientes
{
    public class ClientesService : IClientes
    {
        private readonly IRepositoryAsync<ClientesModels> _repositoryAcontecimientoAsync;

        public ClientesService(IRepositoryAsync<ClientesModels> repositoryAcontecimientoAsync)
        {
            _repositoryAcontecimientoAsync = repositoryAcontecimientoAsync;
        }

        public async Task<ResponseType<string>> CreateCliente(CreateClientesRequest Request, CancellationToken cancellationToken)
        {
            try
            {
                var marcacionColaborador = DateTime.Now;
                //AcontecimientosResponseType objResultFinal = new();

                ClientesModels objAcont = new()
                {
                    //IdCliente = Request.IdCliente,
                    NombreCliente = Request.NombreCliente,
                    ApellidoCliente= Request.ApellidoCliente,
                    CedulaCliente= Request.CedulaCliente,
                    CorreoCliente= Request.CorreoCliente,
                    CursosCliente= Request.CursosCliente,
                    TelefonoCliente = Request.TelefonoCliente,
                };

                var objResultado = await _repositoryAcontecimientoAsync.AddAsync(objAcont, cancellationToken);
                if (objResultado is null)
                {
                    return new ResponseType<string>() { Message = "No se ha podido registrar su información", StatusCode = "101", Succeeded = true };
                }

                return new ResponseType<string>() { Data = null, Message = "Registro ingresado correctamente", StatusCode = "100", Succeeded = true };

            }
            catch (Exception)
            {
                return new ResponseType<string>() { Message = CodeMessageResponse.GetMessageByCode("102"), StatusCode = "102", Succeeded = false };
            }


        }


    }
}
