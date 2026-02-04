using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackDistribuidora.Entidades
{
    public class Categoria
    {
        public int Id { get; private set; }
        public string Nome { get; set; }

        public ICollection<Produto> Produtos { get; private set; }

        public ICollection<MarcaCategoria> MarcaCategorias { get; private set; }

        public Categoria(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("O nome da categoria não pode ser vazio.");
            if (nome.Length < 3 || nome.Length > 100)
                throw new ArgumentException("O nome da categoria deve ter entre 3 e 100 caracteres.");

            Nome = nome;
            Produtos = new List<Produto>();
        }
        protected Categoria() { }
        public override string ToString()
        {
            return $"Categoria: {Nome}";
        }
    }
}
