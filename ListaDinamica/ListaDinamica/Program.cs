using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDinamica
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaContato lista = new ListaContato
            {
                Head = null,
                Tail = null
            };

            Telefone t = new Telefone
            {
                Ddd = 16,
                Numero = 991243647,
                Tipo = "Claro"
            };
            
            Pessoa p = new Pessoa
            {
                Nome = "Luiz",
                telefone = t,
                Proximo = null
            };
            
        }
    }
}
