using Marketplace.Domain.Entities;

namespace Marketplace.Domain.Repository
{
    public interface IProdutoCommandRepository
    {
        public Task CreateAsync(Produto produto);

        public Task UpdateAsync(Produto produto, List<Produto> listaRegistros);

        public Task DeleteAsync(int id, List<Produto> listaRegistros);
    }
}
