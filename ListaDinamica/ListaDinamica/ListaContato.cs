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
                if(aux.Nome.CompareTo(Tail.Nome) >= 0) // INSERIR NOVO ULTIMO ELEMENTO
                {
                    Tail.Proximo = aux;
                    Tail = aux;
                }
            }
        }

        public void Print(){
            if(Vazia())
                Console.WriteLine("Lista Vazia!");
            else{
                Pessoa aux = Head;
                do{
                    Console.WriteLine(aux.ToString());
                    aux = aux.Proximo;
                }while(aux != null);
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
