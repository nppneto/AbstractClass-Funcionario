using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_Estudo
{
    abstract class Funcionario
    {
        public int Codigo { get; set; }

        public abstract void ImprimeDados();
    }
}
