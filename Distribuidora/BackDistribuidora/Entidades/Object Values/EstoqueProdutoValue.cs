using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distribuidora.Back.Entidades.Object_Values
{
    public class EstoqueProdutoValue
    {
        public int Valor { get; set; }
        public EstoqueProdutoValue(int quantidade)
        {
            if (quantidade < 0)
                throw new ArgumentException("Quantidade não pode ser negativa.", nameof(quantidade));
            Valor = quantidade;
        }
        public override string ToString() => Valor.ToString();
        public override bool Equals(object obj) => obj is EstoqueProdutoValue other && Valor == other.Valor;
        public override int GetHashCode() => Valor.GetHashCode();

        protected EstoqueProdutoValue() { } 
    }
}
