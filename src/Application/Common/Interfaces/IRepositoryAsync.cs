using Ardalis.Specification;


namespace ApiEcommerceWeb.Application.Common.Interfaces;

public  interface IRepositoryAsync<T> : IRepositoryBase<T> where T: class
{

}

public interface IReadRepositoryAsync<T> : IReadRepositoryBase<T> where T : class
{

}
