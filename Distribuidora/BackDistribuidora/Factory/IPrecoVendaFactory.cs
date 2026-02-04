using BackDistribuidora.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackDistribuidora.Factory
{
    public interface IPrecoVendaFactory
    {
        PrecoVenda CriarPrecoVenda(Produto produto, decimal valorVenda ,DateTime dataInicio, DateTime? dataFim );
    }
}
