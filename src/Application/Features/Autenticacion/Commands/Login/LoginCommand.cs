using ApiEcommerceWeb.Application.Common.Exceptions;
using ApiEcommerceWeb.Application.Common.Wrappers;
using ApiEcommerceWeb.Application.Features.Autenticacion.Dto;
using ApiEcommerceWeb.Domain.Dto.Login;
using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiEcommerceWeb.Application.Features.Autenticacion.Commands.Login;

public record LoginCommand(LoginRequest request) : IRequest<ResponseType<LoginResponse>>;

public class LoginCommandHandler : IRequestHandler<LoginCommand, ResponseType<LoginResponse>>
{
    private readonly ICliente _repositoryAsync;
    private readonly IMapper _mapper;
    private readonly ILogger<LoginRequestDto> _log;

    public LoginCommandHandler(ICliente repository, IMapper mapper, ILogger<LoginRequestDto> log)
    {
        _repositoryAsync = repository;
        _mapper = mapper;
        _log = log;
    }

    public async Task<ResponseType<LoginResponse>> Handle(LoginCommand objCommand, CancellationToken cancellationToken)
    {
        try
        {
            var entity = _mapper.Map<LoginRequestDto>(objCommand.request);
            var objResult = await _repositoryAsync.AutenticacionUsuario(entity, cancellationToken);
            if (objResult.IsValid)
            {
                var objLoginResponse = _mapper.Map<LoginResponse>(objResult.Data);
                return new ResponseType<LoginResponse>() { Succeeded = true, Data = objLoginResponse, Message = CodeMessageResponse.GetMessageByCode("100"), StatusCode = "100" };
            }

            return new ResponseType<LoginResponse>() { Succeeded = true, Data = null, Message = CodeMessageResponse.GetMessageByCode("101"), StatusCode = "101" };
        }
        catch (Exception ex)
        {
            _log.LogError(ex, string.Empty);
            return new ResponseType<LoginResponse>() { Succeeded = false, Data = null, Message = CodeMessageResponse.GetMessageByCode("102"), StatusCode = "102" };
        }

    }
}
