using Gildo.lojaVirtual.Dominio.Entidades;
using System.Collections.Generic;

namespace Gildo.lojaVirtual.Dominio.Repositorio
{
    public class ProdutosRepositorio
    {
        private readonly EfDbContext _context = new EfDbContext();                
        
        public IEnumerable<Produto> Produtos
        {
            get { return _context.Produtos; }
        }
      
    }
}
