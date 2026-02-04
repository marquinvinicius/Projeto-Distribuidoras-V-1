using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontDistribuidora.Telas.Preços.Margem.Grids
{
    public class GridGeralPronto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public decimal ValorVenda { get; set; }

        public string ValorVendaString
        {
            get { return ValorVenda.ToString("C2"); }
        }
    }
}
