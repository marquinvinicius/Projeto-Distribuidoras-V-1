using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontDistribuidora.Telas.Recebimento
{
    public class GridReceberMercadoria
    {
        public string Nome { get; set; }
        public decimal PrecoCusto { get; set; }
        public int Quantidade { get; set; }
        public DateTime UltimoPedido { get; set; }
    }
}
