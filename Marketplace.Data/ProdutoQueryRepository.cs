using Dapper.Contrib.Extensions;
using Marketplace.Domain.Entities;
using Marketplace.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace.Data
{
    public class ProdutoQueryRepository : IProdutoQueryRepository
    {
        private readonly IDbConnection _dbConnection;

        public ProdutoQueryRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<List<Produto>> GetAllAsync()
        {
            var resultado = await _dbConnection.GetAllAsync<Produto>();
            return resultado.ToList();
        }
    }
}
