using AutoMapper;
using System.Diagnostics.CodeAnalysis;

namespace ApiEcommerceWeb.Application.Common.Mappings;
public interface IMapFrom<T>
{
    [ExcludeFromCodeCoverage]
    void Mapping(Profile profile) => profile.CreateMap(typeof(T), GetType());
}
