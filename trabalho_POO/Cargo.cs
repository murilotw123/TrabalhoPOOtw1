using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_POO
{
    class Cargo
    {
        public float Salario {  get; set; }
        public string Nome {  get; set; }

        public Cargo() { }

        public void LerDadosCargo()
        {
            Console.WriteLine("O nome desse cargo é: ");
            Nome = Console.ReadLine();
            Console.WriteLine("O Salario desse cargo é: ");
            Salario = float.Parse(Console.ReadLine());
        }
    }
}
