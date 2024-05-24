using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_POO
{
    class Funcionario
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public Cargo Cargo { get; set; }
        public Setor Setor { get; set; }

        public Funcionario() { }

        public void LerDadosFunc()
        {
            Console.WriteLine("Qual o nome do funcionario: ");
            Nome = Console.ReadLine();
            Console.WriteLine("Qual o endereço do funcionario: ");
            Endereco = Console.ReadLine();
            Console.WriteLine("Qual O Telefone desse funcionario: ");
            Telefone = Console.ReadLine();

        }

        public void MostrarDados()
        {
            Console.WriteLine($"O Nome do funcionario é: {Nome}");
            Console.WriteLine($"O endereço do funcionario é: {Endereco}");
            Console.WriteLine($"O Telefone do funcionario é: {Telefone}");
            Console.WriteLine($"O Cargo do funcionario é: {Cargo.Nome}");
            Console.WriteLine($"O Salario do funcionario é: {Cargo.Salario}");
            Setor.MostrarDados();
        }
       
    }
}
