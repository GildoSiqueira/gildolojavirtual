using Gildo.lojaVirtual.Dominio.Entidades;
using System.Collections.Generic;

namespace Gildo.lojaVirtual.Web.Models
{
    public class ProdutosViewModel
    {        
        public IEnumerable<Produto> Produtos { get; set; }
        public Paginacao Paginacao { get; set; }

    }
}