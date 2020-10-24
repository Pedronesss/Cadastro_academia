using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Prática_cadastro
{
    class Cadastro
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Altura { get; set; }
        public int Plano { get; set; }
        public string Peso { get; set; }
        public DateTime HoraDiacadastro { get; set; }

        public Cadastro()
        {

        }

        public Cadastro(string nome, DateTime dataNascimento, string altura, string peso,  DateTime horaDiacadastro)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Altura = altura;
            Peso = peso;
            HoraDiacadastro = horaDiacadastro;
        }

        public override string ToString()
        {
            return "Nome: " + Nome +
                " / Data de nascimento: " + DataNascimento.ToString("dd/MM/yyyy") +
                " / Altura: " + Altura + "cm" +
                " / Peso: " + Peso + "Kg";
        }

    }

    
}
