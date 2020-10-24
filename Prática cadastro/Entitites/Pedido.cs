using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Prática_cadastro.Entitites
{
    class Pedido
    {
        public Cadastro Cadastro { get; set; }
        public List<PedidoItens> Itens { get; set; } = new List<PedidoItens>();
        public Pedido()
        {

        }

        public Pedido(Cadastro cadastro)
        {
            Cadastro = cadastro;
        }

        public void Additem(PedidoItens item)
        {
            Itens.Add(item);
        }

        public void Removeitem(PedidoItens item)
        {
            Itens.Remove(item);
        }

        public double Total()
        {
            double sum = 0;
            foreach (PedidoItens item in Itens)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Dados do cliente:");
            sb.Append(Cadastro);
            sb.AppendLine("");
            sb.AppendLine("Produtos: ");
            foreach (PedidoItens item in Itens)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total a pagar: R$" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
