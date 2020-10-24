using System;
using System.Collections.Generic;
using System.Text;

namespace Prática_cadastro.Entitites
{
    class PedidoItens
    {
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public Produto Produto { get; set; }

        public PedidoItens ()
        {

        }

        public PedidoItens(int quantidade, double preco, Produto produto)
        {
            Quantidade = quantidade;
            Preco = preco;
            Produto = produto;
        }

        public double SubTotal()
        {
            return Preco * Quantidade;
        }

        public override string ToString()
        {
            return Quantidade + ", " +
                Produto.ProdutoNome +
                "- R$ " + Preco;
        }

    }
}
