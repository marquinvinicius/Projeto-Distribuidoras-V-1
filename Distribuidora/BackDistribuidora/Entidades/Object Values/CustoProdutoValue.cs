using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distribuidora.Back.Entidades.Object_Values
{
    public class CustoProdutoValue
    {
        public decimal Valor { get; }

        public CustoProdutoValue(decimal preco)
        {

            if (preco < 0)

                throw new ArgumentException("Preço não pode ser negativo.", nameof(preco));

            Valor = preco;

        }
        public override string ToString() => Valor.ToString("C");

        public override bool Equals(object obj) => obj is CustoProdutoValue other && Valor == other.Valor;

        public override int GetHashCode() => Valor.GetHashCode();
        protected CustoProdutoValue() { } 

    }
}

