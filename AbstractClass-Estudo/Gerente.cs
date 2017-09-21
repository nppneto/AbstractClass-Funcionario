using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_Estudo
{
    class Gerente : Funcionario
    {
        public string Usuario { get; set; }

        public string Senha { get; set; }

        public override void ImprimeDados()
        {
            Console.WriteLine("DADOS DOS FUNCIONÁRIOS");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Código: " + this.Codigo);
        }
    }
}
