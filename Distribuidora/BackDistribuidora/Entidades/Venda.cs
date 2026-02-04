using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackDistribuidora.Entidades;

public class Venda
{
    public int Id{ get; private set; }
    public DateTime DataVenda { get; internal set; }
    public IReadOnlyCollection<ItemVenda> Itens => _itens.AsReadOnly();

    public readonly List<ItemVenda> _itens = new List<ItemVenda>();
    public decimal Total => _itens.Sum(i => i.SubTotal);
    internal Venda() { }

    public Venda(DateTime dataVenda, List<ItemVenda> itens)
    {
        if (itens == null || itens.Count == 0)
            throw new ArgumentException("A venda deve conter pelo menos um item.", nameof(itens));
        DataVenda = dataVenda;
        _itens = itens;
    }
    public void AdicionarItem(ItemVenda item)
    {
        if (item == null)
            throw new ArgumentNullException(nameof(item), "O item da venda não pode ser nulo.");
        _itens.AddRange(item);
    }
    public void RemoverItem(ItemVenda item)
    {
        if (item == null)
            throw new ArgumentNullException(nameof(item), "O item da venda não pode ser nulo.");
        _itens.Remove(item);
    }
    public void CancelarVenda()
    {
        _itens.Clear();
    }
}
