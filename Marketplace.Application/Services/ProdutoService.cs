using Marketplace.Data;
using Marketplace.Domain.Entities;
using Marketplace.Domain.Interfaces;
using Marketplace.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace.Application.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoCommandRepository _produtoCommandRepository;
        private readonly IProdutoQueryRepository _produtoQueryRepository;
        public ProdutoService(IProdutoCommandRepository produtoCommandRepository, IProdutoQueryRepository produtoQueryRepository)
        {
            _produtoCommandRepository = produtoCommandRepository;
            _produtoQueryRepository = produtoQueryRepository;
        }

        public async Task CreateAsync(Produto produto)
        {
            await _produtoCommandRepository.CreateAsync(produto);
        }

        public async Task DeleteAsync(int id)
        {
            List<Produto> listaRegistros = await _produtoQueryRepository.GetAllAsync();
            await _produtoCommandRepository.DeleteAsync(id, listaRegistros);
        }

        public async Task<IList<Produto>> ObterTodos()
        {
            return await _produtoQueryRepository.GetAllAsync();
        }

        public async Task UpdateAsync(Produto produto)
        {
            List<Produto> listaRegistros = await _produtoQueryRepository.GetAllAsync();
            await _produtoCommandRepository.UpdateAsync(produto, listaRegistros);
        }
    }
}
