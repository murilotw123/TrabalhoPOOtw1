namespace trabalho_POO
{
    class Program
    {
        static void Main()
        {
            

          
            Cargo cargo = new Cargo();
            cargo.LerDadosCargo();



            Funcionario func = new Funcionario();

            func.LerDadosFunc();
            func.Cargo = cargo;
           

            Setor setor = new Setor();
            setor.LerDadosSetor();
            setor.Chefe = func;
            func.Setor = setor;

            func.MostrarDados();
          
            Console.ReadKey();
            Console.Clear();

            

        }
    }
}
