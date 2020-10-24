using Prática_cadastro.Entitites;
using System;
using System.Globalization;

namespace Prática_cadastro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Boa noite, seja bem-vindo ao Sistema de cadastro da academia MOVE ON!");
            Console.WriteLine("Siga as instruções a seguir para efetuar o seu cadastro inicial.");
            Console.WriteLine("--------------------------------------------------------------------------");

            Console.Write("Digite seu nome completo: ");
            string nome = Console.ReadLine();
            Console.Write("Digite sua data de nascimento dd/MM/yyyy: ");
            DateTime datanascimento = DateTime.Parse(Console.ReadLine());
            Console.Write("Digite sua altura: ");
            string altura = Console.ReadLine();
            Console.Write("Digite seu peso: ");
            string peso = Console.ReadLine();


            Cadastro cadastro = new Cadastro(nome, datanascimento, altura, peso, DateTime.Now);
            Pedido pedido = new Pedido(cadastro);

            Console.WriteLine("Deseja efetuar o pagamento agora? (S - Sim N - Não): ");
            string pagar = Console.ReadLine();
            if (pagar == "S")
            {
                Console.WriteLine("Digite a quantidade de produtos: ");
                int itens = int.Parse(Console.ReadLine());
                for (int i = 1; i <= itens; i++)
                {
                    Console.WriteLine("Digite o nome do produto: ");
                    string produto_nome = Console.ReadLine();
                    Console.WriteLine("Digite o valor do produto: ");
                    double produto_preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Produto produto = new Produto(produto_nome, produto_preco);
                    
                    Console.WriteLine("Digite a quantidade deste produto: ");
                    int quantidade = int.Parse(Console.ReadLine());

                    PedidoItens pedidos = new PedidoItens(quantidade, produto_preco, produto);
                    pedido.Additem(pedidos);

                }

                Console.WriteLine(pedido);

            }
            else
            {
                Console.WriteLine("Poderá dar início as suas aulas assim que efetuar o pagamento!");
                Console.WriteLine(pedido);
            }
                
                


        }
    }
}
