using Prática_cadastro.Entitites.Enums;
using System;
using System.Globalization;

namespace Prática_cadastro
{
    class Program
    {
        static void Main(string[] args)
        {
            Cadastro cad = new Cadastro();
            Console.WriteLine("Boa noite, seja bem-vindo ao Sistema de cadastro da academia MOVE ON!");
            Console.WriteLine("Siga as instruções a seguir para efetuar o seu cadastro inicial.");
            Console.WriteLine("--------------------------------------------------------------------------");
            bool cadastrofeito = false;

            while (cadastrofeito == false)
            {

                Console.Write("Digite seu nome completo: ");
                string nome = Console.ReadLine();
                Console.Write("Digite sua data de nascimento: ");
                string datanascimento = Console.ReadLine();
                Console.Write("Digite sua altura: ");
                string altura = Console.ReadLine();
                Console.Write("Digite seu peso: ");
                string peso = Console.ReadLine();



                if (nome != "" && datanascimento != "" && altura != "" && peso != "")
                {
                    DateTime horadiacadastro = DateTime.Now;
                    cad.cadastrar(nome, datanascimento, altura, peso, horadiacadastro);
                    Console.WriteLine("Cadastro efetuado com sucesso!");
                    Console.WriteLine("Vamos para o próximo passo!");
                    cadastrofeito = true;
                }
                else
                {
                    Console.WriteLine("Cadastro incompleto, tente novamente!");
                }
            }

            if (cadastrofeito = true)
            {
                Console.WriteLine("-----------------------------------------------------------------------");
                Console.WriteLine("Com seu cadastro feito, vamos para a escolha de seu plano de Academia!");
                Console.Write("Livre_acesso R$80,00 cód=1 / Acesso3x R$70,00 cód=2 / Acesso2x R$60,00 cód=3: ");
                Planos planos = Enum.Parse<Planos>(Console.ReadLine());
                Console.Write("Digite o código do plano: ");
                int cod_plano = int.Parse(Console.ReadLine());
                cad.codigoplano(cod_plano);
                cad.cadastrarplano(planos);
                Console.WriteLine("-----------------------------------------------------------------------");
                Console.WriteLine("Deseja efetuar o pagamento agora? (S - Sim N - Não): ");
                string pagar = Console.ReadLine();
                if (pagar == "S")
                {
                    cad.totalapagarevencimento();
                }
                else
                    Console.WriteLine("Poderá dar início as suas aulas assim que efetuar o pagamento!");
            }
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine(cad);
        
        }
    }
}
