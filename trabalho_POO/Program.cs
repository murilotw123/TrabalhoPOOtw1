namespace trabalho_POO
{
    class Program
    {
        static void Main()
        {
            /*Trabalho do Murilo Moraes De Assis  RA: 20233184 
                                   E
                          Pedro Gonçalves Capelin RA:20224348
             */
            Cargo cargo = new Cargo();
            Console.WriteLine("O nome desse cargo é: ");
            cargo.Nome = Console.ReadLine();
            Console.WriteLine("O Salario desse cargo é: ");
            cargo.Salario = float.Parse(Console.ReadLine());



            Funcionario func = new Funcionario();

            Console.WriteLine("Qual o nome do funcionario: ");
            func.Nome = Console.ReadLine();
            Console.WriteLine("Qual o endereço do funcionario: ");
            func.Endereco = Console.ReadLine();
            Console.WriteLine("Qual O Telefone desse funcionario: ");
            func.Telefone = Console.ReadLine();
            func.Cargo = cargo;
           

            Setor setor = new Setor();
            Console.WriteLine("Qual o nome do setor: ");
            setor.Nome = Console.ReadLine();
            Console.WriteLine("Qual a sigla desse setor: ");
            setor.Sigla = Console.ReadLine();
            setor.Chefe = func;
            func.Setor = setor;

            func.MostrarDados();
          
            Console.ReadKey();
            Console.Clear();

            

        }
    }
}
