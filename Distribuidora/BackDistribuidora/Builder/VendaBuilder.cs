using BackDistribuidora.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackDistribuidora.Builder
{
    //Teste
    public class VendaBuilder
    {
        private readonly Venda _venda = new();
        public VendaBuilder ComDataVenda(DateTime dataVenda) { _venda.DataVenda = dataVenda; return this; }
        public VendaBuilder AdicionarItem(ItemVenda itemVenda) { _venda.AdicionarItem(itemVenda); return this; }
        public VendaBuilder RemoverItem (ItemVenda itemVenda) { _venda.RemoverItem(itemVenda); return this; }
        public VendaBuilder Cancelar (Venda venda) { _venda.CancelarVenda(); return this; }
        public Venda Criar() => _venda;
    }
}
