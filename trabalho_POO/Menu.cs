using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_POO
{
    class Menu
    {
        public int opc;

        public Menu() { }   

        public void chamarMenu()
        {
            Console.WriteLine("->Cadastro da empresa<-");
            Console.WriteLine("[1]-> Cadastrar Novo Cargo");
            Console.WriteLine("[2]-> Cadastrar Novo Funcionario");
            Console.WriteLine("[3]-> Cadastrar Novo Setor");
        }

    }
}
