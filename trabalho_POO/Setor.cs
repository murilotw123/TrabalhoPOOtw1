using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_POO
{
    class Setor
    {
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public Funcionario Chefe { get; set; }

        public Setor() { }

        public void LerDadosSetor()
        {
            Console.WriteLine("Qual o nome do setor: ");
            Nome = Console.ReadLine();
            Console.WriteLine("Qual a sigla desse setor: ");
            Sigla = Console.ReadLine();
        }
        public void MostrarDados()
        {
            Console.WriteLine($"O Setor Desse funcionario é: {Nome}");
            Console.WriteLine($"A Sigla desse setor é: {Sigla}");
            Console.WriteLine($"O funcionario Chefe desse setor é: {Chefe.Nome}");

        }
    }
}
