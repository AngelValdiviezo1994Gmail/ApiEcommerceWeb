using ApiEcommerceWeb.Application.Common.Interfaces;
using ApiEcommerceWeb.Persistence.Contexts;
using Ardalis.Specification.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiEcommerceWeb.Persistence.Repository
{
    public class CustomRepositoryAsync<T> : RepositoryBase<T>, IRepositoryAsync<T> where T : class
    {
        private readonly ApplicationDbContext dbContext;

        public CustomRepositoryAsync(ApplicationDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
