using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDinamica
{
    class ListaContato
    {
        public Pessoa Head { get; set; }
        public Pessoa Tail { get; set; }

        public void Push(Pessoa aux)
        {
            if (Vazia())
            {
                Head = aux;
                Tail = aux;
            }
            else
            {

            }
        }


        public bool Vazia()
        {
            if (Head == null && Tail == null)
                return true;
            return false;
        }
    }
}
