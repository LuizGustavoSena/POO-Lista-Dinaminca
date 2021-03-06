﻿using System;
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

        // IMPRESSAO
        public override string ToString()
        {
            string fones = "";
            foreach ( Telefone t in telefone)
                fones = fones + t.ToString();

            return ">>Contato "+ Nome + "<<\n" + fones + "\n";
        }
    }
}
