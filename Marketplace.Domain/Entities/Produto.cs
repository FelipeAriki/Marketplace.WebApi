using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace.Domain.Entities
{
    public class Produto
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set;}
        public long Preco { get; set;}
        public int QuantidadeEstoque { get; set;}
        public string? Categoria { get; set;}
        public string? Fornecedor { get; set;}
        public DateTime DataAdicaoInventario { get; set;}

    }
}
