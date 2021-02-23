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
            ListaContato meusContatos = new ListaContato
            {
                Head = null,
                Tail = null
            };
            
            Pessoa p = new Pessoa
            {
                Nome = "Luiz",
                telefone = new Telefone[2] { new Telefone { Ddd = 16, Numero = 991243647, Tipo = "Celular"},
                                             new Telefone { Ddd = 16, Numero = 33848946, Tipo = "Casa"} },
                Proximo = null
            };

            meusContatos.Push(p);

            p = new Pessoa
            {
                Nome = "Maria",
                telefone = new Telefone[2] { new Telefone { Ddd = 16, Numero = 991234567, Tipo = "Celular"},
                                             new Telefone { Ddd = 16, Numero = 33847594, Tipo = "Casa"} },
                Proximo = null
            };

            meusContatos.Push(p);

            meusContatos.Print();
            
            Console.ReadKey();
        }
    }
}
