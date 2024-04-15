using Marketplace.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace.Domain.Interfaces
{
    public interface IProdutoService
    {
        public Task CreateAsync(Produto produto);

        public Task UpdateAsync(Produto produto);

        public Task DeleteAsync(int id);

        public Task<IList<Produto>> ObterTodos();
    }
}
