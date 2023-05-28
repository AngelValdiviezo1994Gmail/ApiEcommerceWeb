﻿using AutoFixture;
using AutoMapper;
using WebApiTest.Application.Common.Mappings;
using WebApiTest.Application.Common.Wrappers;
using WebApiTest.Application.Features.Wallets.Dto;
using WebApiTest.Application.Features.Wallets.Interfaces;
using WebApiTest.Application.Features.Wallets.Queries.GetCupoCredito;
using WebApiTest.Domain.Entities.Wallet;
using Moq;
using Shouldly;
using Xunit;

namespace WebApiTest.Application.UnitTests.Features.Billeteras.Queries.GetCupoCreditoByIdentificacion;

public class GetCupoCreditoByIdentificacionQueryXUnitTests
{
    private readonly IMapper _mapper;
    private readonly Mock<ICupoCredito> _mockrepository;

    public GetCupoCreditoByIdentificacionQueryXUnitTests()
    {
        var mapperConfig = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile<MappingProfile>();
        });

        _mockrepository = new Mock<ICupoCredito>();
        _mapper = mapperConfig.CreateMapper();
    }

    //[Theory]
    //[InlineData("0951635390")]
    //public async void GetCupoCreditoByIdentificacionAsync_ReturrnType(string token)
    //{
    //    var fixture = new Fixture();
    //    var cupoCredito = fixture.Create<ResponseType<CupoCredito>>();
    //    _mockrepository.Setup(r => r.GetCupoCreditoAsync("0951635390")).ReturnsAsync(cupoCredito);

    //    var handler = new GetCupoCreditoQueryHandler(_mockrepository.Object, _mapper);

    //    var request = new GetCupoCreditoQuery(token);

    //    var result = await handler.Handle(request, CancellationToken.None);

    //    result.ShouldBeOfType<ResponseType<CupoCreditoResponseType>>();
    //}

}
