using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_Estudo
{
    class TestaFuncionario
    {
        static void Main(string[] args)
        {
            Funcionario f = new Gerente();
            f.Codigo = 123;

            f.ImprimeDados();

            Console.ReadKey();
            
        }
    }
}
