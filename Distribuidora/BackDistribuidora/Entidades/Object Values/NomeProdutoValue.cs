using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distribuidora.Back.Entidades.Object_Values
{
    public class NomeProdutoValue
    {
        public string Valor { get; }
        public NomeProdutoValue(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("Nome do produto não pode ser vazio ou nulo.");
            if (nome.Length < 3 || nome.Length > 100)
                throw new ArgumentException("Nome do produto deve ter entre 3 e 100 caracteres.");
            nome = nome.Trim();
            Valor = nome;
        }

        public override string ToString() => Valor;
        public override bool Equals(object obj) =>
        obj is NomeProdutoValue other &&
        string.Equals(Valor, other.Valor, StringComparison.OrdinalIgnoreCase);

        public override int GetHashCode() =>
            StringComparer.OrdinalIgnoreCase.GetHashCode(Valor);

        protected NomeProdutoValue() { } 
    }
}
