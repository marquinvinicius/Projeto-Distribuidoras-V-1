using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackDistribuidora.Entidades.Enums
{
    public enum TipoTransacao
    {
        [Description("Entrada de mercadoria")]
        Entrada = 1,

        [Description("Entrada por bonificação")]
        Bonificacao = 2,

        [Description("Saida por Venda")]
        SaidaVenda = 3,

        [Description("Saida por Perda/Troca")]
        SaidaPerdaTroca = 4,

        [Description("Ajuste de Estoque")]
        AjusteEstoque = 5
    }
}
