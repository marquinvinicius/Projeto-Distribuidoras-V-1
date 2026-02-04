using BackDistribuidora.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackDistribuidora.Factory
{
    public class PrecoVendaFactory : IPrecoVendaFactory
    {
        public PrecoVenda CriarPrecoVenda(Produto produto, decimal valorVenda, DateTime dataInicio, DateTime? dataFim)
        {
            return new PrecoVenda(produto, valorVenda ,dataInicio, dataFim);
        }

    }
}
