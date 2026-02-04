using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distribuidora.Back.Entidades.Object_Values
{
    public class QuantidadeFardoValue
    {
        public int Valor { get; private set; }
        public QuantidadeFardoValue(int quantidade)
        {
            if (quantidade <= 1)
                throw new ArgumentException("A quantidade por fardo deve ser maior que 1.", nameof(quantidade));
            Valor = quantidade;
        }
        protected QuantidadeFardoValue() { } 
        public override string ToString() => Valor.ToString();
    }
}
