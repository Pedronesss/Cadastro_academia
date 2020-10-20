using Prática_cadastro.Entitites.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Prática_cadastro
{
    class Cadastro
    {
        public string Nome { get; set; }
        public string DataNascimento { get; set; }
        public string Altura { get; set; }
        public int Plano { get; set; }
        public string Peso { get; set; }
        public DateTime HoraDiacadastro { get; set; }
        public double Valorplano { get; set; }
        public Planos Planos { get; set; }

        public void cadastrar(string nome, string datanascimento, string altura, string peso, DateTime horadiacad)
        {
            Nome = nome;
            DataNascimento = datanascimento;
            Altura = altura;
            Peso = peso;
            HoraDiacadastro = horadiacad;

        }

        public void codigoplano(int cod_plano)
        {
            Plano = cod_plano;
            if (Plano < 2)
            {
                Valorplano = 80.00;
            }
            else if (Plano > 2)
            {
                Valorplano = 60.00;
            }
            else
                Valorplano = 70.00;
        }

        public void cadastrarplano(Planos planos)
        {
            Planos = planos;
        }

        public void totalapagarevencimento()
        {
            Console.WriteLine("Total a pagar: R$" + Valorplano);
            DateTime x = DateTime.Now;
            x = x.AddMonths(1);
            Console.WriteLine("Vencimento para próximo pagamento: " + x);
        }

        public override string ToString()
        {
            return "Dados cadastro: " +
                "// Nome: " + Nome +
                " // Data de nascimento: " + DataNascimento +
                " // Altura: " + Altura +
                " // Peso: " + Peso +
                " // Plano adquirido: " + Planos +
                " // Data cadastro: " + HoraDiacadastro;

        }

    }

    
}
