using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDinamica
{
    class Pessoa
    {
        public string Nome { get; set; }
        public Telefone[] telefone { get; set; }
        public Pessoa Proximo { get; set; }

        public override string ToString()
        {
            return "Nome: "+ Nome + "Telefone: " + telefone.ToString() + "\n";
        }
    }
}
