using ApiEcommerceWeb.Application.Common.Wrappers;
/*
using ApiEcommerceWeb.Application.Features.Acontecimientos.Commands.CreateAcontecimientos;
using ApiEcommerceWeb.Application.Features.Acontecimientos.Dto;
*/
using ApiEcommerceWeb.Application.Features.Clientes.Commands.CreateClientes;
using ApiEcommerceWeb.Application.Features.Clientes.Dto;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace ApiEcommerceWeb.Controllers.v1
{
    [ApiVersion("1.0")]
    public class ClientesController : ApiControllerBase
    {
        [HttpPost("GenerarCliente")]
        [EnableCors("AllowOrigin")]
        [ProducesResponseType(typeof(ResponseType<ClientesResponseType>), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateCliente([FromBody] CreateClientesRequest request, CancellationToken cancellationToken)
        {
            var objResult = await Mediator.Send(new CreateClientesCommand(request), cancellationToken);
            return Ok(objResult);
        }
    }
}
