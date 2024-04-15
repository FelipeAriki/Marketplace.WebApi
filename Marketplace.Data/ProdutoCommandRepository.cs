using Marketplace.Domain.Entities;
using Marketplace.Domain.Repository;
using Dapper;
using Dapper.Contrib.Extensions;
using System.Data;

namespace Marketplace.Data
{
    public class ProdutoCommandRepository : IProdutoCommandRepository
    {
        private readonly IDbConnection _dbConnection;

        public ProdutoCommandRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task CreateAsync(Produto produto)
        {
            var comandoSql = @"INSERT INTO Produto (""Nome"", ""Preco"") 
                               VALUES (@Nome, @Preco)";

            await _dbConnection.ExecuteAsync(comandoSql, produto);
        }

        public async Task DeleteAsync(int id, List<Produto> listaRegistros)
        {
            var produto = listaRegistros.FirstOrDefault(x => x.Id.Equals(id));

            if (produto != null)
            {
                await _dbConnection.DeleteAsync(produto);
            }
        }

        public async Task UpdateAsync(Produto produto, List<Produto> listaRegistros)
        {
            var produtoExistente = listaRegistros.FirstOrDefault(x => x.Id.Equals(produto.Id));

            if (produtoExistente != null)
            {
                produtoExistente.Nome = produto.Nome;
                produtoExistente.Preco = produto.Preco;

                await _dbConnection.UpdateAsync<Produto>(produtoExistente);
            }
        }

        
    }
}
