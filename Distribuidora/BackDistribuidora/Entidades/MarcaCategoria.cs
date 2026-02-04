using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackDistribuidora.Entidades
{
    public class MarcaCategoria
    { 
        public MarcaCategoria() { }
        public int MarcaId { get; set; }
        public int CategoriaId { get; set; }

        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
    }
}
