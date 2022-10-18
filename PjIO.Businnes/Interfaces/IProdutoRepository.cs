using PjIO.Businnes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PjIO.Businnes.Interfaces
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        Task<IEnumerable<Produto>> ObterProdutosPorFornecedor(Guid id);

        Task<IEnumerable<Produto>> ObterProdutosFornecedor();

        Task<Produto> ObterProdutosFornecedor (Guid id);
    }
}
