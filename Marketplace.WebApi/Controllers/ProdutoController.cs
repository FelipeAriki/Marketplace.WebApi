using Marketplace.Application.Services;
using Marketplace.Domain.Entities;
using Marketplace.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Marketplace.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var resultado = await _produtoService.ObterTodos();

            if (resultado is null || !resultado.Any())
            {
                return Ok(new List<Produto>());
            }

            return Ok(resultado);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(Produto produto)
        {
            await _produtoService.CreateAsync(produto);
            return Created();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync([FromQuery] int id)
        {
            await _produtoService.DeleteAsync(id);
            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAsync(Produto produto)
        {
            await _produtoService.UpdateAsync(produto);
            return Ok(produto);
        }
    }
}
