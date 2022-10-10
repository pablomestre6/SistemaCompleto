using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PjIO.Businnes.Models
{
    public class Fornecedor : Entity
    {
        public string Name { get; set; }

        public string Documentos { get; set; }

        public string CNPJ { get; set; }

        public TipodeFornecedor TipodeFornecedor { get; set; }

        public Endereco Endereco { get; set; }

        public bool Ativo { get; set; }

      
        /* EF Relations */
        public IEnumerable<Produto> Produtos { get; set; }
    }
}
