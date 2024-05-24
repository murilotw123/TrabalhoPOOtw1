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

      /*  public void CadastrarSetor()
        {
            Console.WriteLine("O Nome desse Setor é: ");
            Nome = Console.ReadLine();
            Console.WriteLine("A Sigla desse Setor é: ");
            Sigla = Console.ReadLine();
            Console.WriteLine("O Chefe desse Setor é: ");
            Chefe = (Console.ReadLine());
        }*/
        public void MostrarDados()
        {
            Console.WriteLine($"O Setor Desse funcionario é: {Nome}");
            Console.WriteLine($"A Sigla desse setor é: {Sigla}");
            Console.WriteLine($"O funcionario Chefe desse setor é: {Chefe.Nome}");

        }
    }
}
