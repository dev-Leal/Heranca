using System;

namespace Herança
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CPF cpf = new CPF();

            cpf.nome = "Beatriz";
            System.Console.WriteLine( cpf.FazerSaudacao());

            cpf.cpf = "000.030.000-2";
            System.Console.WriteLine( cpf.ValidarCPF());
        
        
        }
    }
}
