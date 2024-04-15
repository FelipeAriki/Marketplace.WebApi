using Marketplace.Domain.Entities;

namespace Marketplace.Domain.Interfaces
{
    public interface IProdutoQueryRepository
    {
        public Task<List<Produto>> GetAllAsync();
    }
}
