using Marketplace.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Marketplace.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly ProdutoService _produtoService;
        public ProdutoController(ProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpGet]
        public async void ObterProdutos()
        {
            await _produtoService.ObterProdutos();
        }

        [HttpGet]
        public async void ObterProduto()
        {
            await _produtoService.ObterProduto();
        }

        [HttpPost]
        public async void CriarProduto()
        {
            await _produtoService.CriarProduto();
        }

        [HttpDelete]
        public async void ExcluirProduto()
        {
            await _produtoService.ExcluirProduto();
        }

        [HttpPut]
        public async void AtualizarProduto()
        {
            await _produtoService.AtualizarProduto();
        }
    }
}
