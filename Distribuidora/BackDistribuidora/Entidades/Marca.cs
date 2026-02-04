using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackDistribuidora.Entidades
{
    public class Marca
    {
        public int Id { get; private set; }
        public string Nome { get;  set; }

        public ICollection<Produto> Produtos { get; private set; }

        public ICollection<MarcaCategoria> MarcaCategorias { get; private set; }

        protected Marca() { }
        public Marca(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("O nome da marca não pode ser vazio.");
            if (nome.Length < 2 || nome.Length > 100)
                throw new ArgumentException("O nome da marca deve ter entre 2 e 100 caracteres.");
            Nome = nome;
            Produtos = new List<Produto>();
        }
        public void AtualizarNome(string novoNome)
        {
            if (string.IsNullOrWhiteSpace(novoNome))
                throw new ArgumentException("O nome da marca não pode ser vazio.");
            if (novoNome.Length < 2 || novoNome.Length > 100)
                throw new ArgumentException("O nome da marca deve ter entre 2 e 100 caracteres.");
            Nome = novoNome;
        }
        public override string ToString()
        {
            return $"Marca: {Nome}";
        }

    }
}
