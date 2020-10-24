using System;
using System.Collections.Generic;
using System.Text;

namespace Prática_cadastro.Entitites
{
    class Produto
    {
        public string ProdutoNome { get; set; }
        public double Preco { get; set; }

        public Produto ()
        {

        }

        public Produto(string produtoNome, double preco)
        {
            ProdutoNome = produtoNome;
            Preco = preco;
        }
    }
}
