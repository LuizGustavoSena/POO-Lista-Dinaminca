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
        public int Qtd { get; set; }

        public void Push(Pessoa aux)
        {
            Qtd++;

            if (Vazia()) // SE FOR VAZIA
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
                    Console.WriteLine("Elemento inserido por ultimo");
                }
                else if (aux.Nome.CompareTo(Head.Nome) < 0) // INSERIR NOVO PRIMEIRO ELEMENTO
                {
                    aux.Proximo = Head;
                    Head = aux;
                    Console.WriteLine("Elemento inserido no começo");
                }
                else // INSERIR NOVO MEIO ELEMENTO
                {
                    // VARIAVEIS
                    Pessoa aux1 = Head;
                    do
                    {
                        if (aux.Nome.CompareTo(aux1.Proximo.Nome) < 0)
                        {
                            aux.Proximo = aux1.Proximo;
                            aux1.Proximo = aux;
                            Console.WriteLine("Elemento inserido no meio");
                            break;
                        }
                        aux1 = aux1.Proximo; // PERCORRER

                    } while (true);
                }
            }
        }

        public void Pop(string aux)
        {
            if (Vazia())
                Console.WriteLine("Lista Vazia!");
            else
            {
                if(aux.CompareTo(Head.Nome) == 0) { // REMOVER DO INICIO
                    if(Head.Proximo != null) { // SE TER MAIS ELEMENTOS
                        Head = Head.Proximo;
                        Console.WriteLine("Elemento removido no começo");
                    }
                    else // SE NÃO TER MAIS ELEMENTOS
                    {
                        Head = null;
                        Tail = null;
                        Console.WriteLine("Elemento removido e lista passa a ser vazia");
                    }
                    Qtd--;
                }
                else // REMOVER DO MEIO OU FIM
                {
                    // VARIAVEIS
                    Pessoa aux1 = Head;
                    bool encontrou = false;
                    do
                    {
                        if(aux1.Proximo != null) // SE O PROXIMO EXISTIR
                            if(aux.CompareTo(aux1.Proximo.Nome) == 0) { // COMPARA COM O PROXIMO PARA PODER REMOVER 
                                if (aux1.Proximo == Tail) // SE O 2° FOR O ULTIMO LINKA O PRIMEIRO A HEAD E TAIL
                                    Tail = aux1;
                                aux1.Proximo = aux1.Proximo.Proximo; // PULA O OBJETO A SER REMOVIDO
                                Console.WriteLine("Elemento removido no meio");
                                encontrou = true;
                                Qtd--;
                                break;
                            }
                        aux1 = aux1.Proximo; // PERCORRER
                    } while (aux1 != null);

                    if (!encontrou)
                        Console.WriteLine("Contato não encontrado");
                }
            }
        }

        public void buscar(string aux)
        {
            if (Vazia())
                Console.WriteLine("Lista vazia!");
            else if (aux.CompareTo(Tail.Nome) == 0) // VERIFICA SE FOR O ULTIMO NEM PERCORRE A LISTA
                Console.WriteLine("CONTATO ENCONTRADO\n" + Tail.ToString());
            else
            {
                // VARIAVEIS
                Pessoa aux1 = Head;
                bool encontrou = false;
                do
                {
                    if(aux.CompareTo(aux1.Nome) == 0)
                    {
                        Console.WriteLine("CONTATO ENCONTRADO\n" + aux1.ToString());
                        encontrou = true;
                        break;
                    }
                    aux1 = aux1.Proximo; // PERCORRER
                } while (aux1 != null);

                if (!encontrou)
                    Console.WriteLine("Contato não encontrado");
            }
        }

        public void Print(){
            if(Vazia())
                Console.WriteLine("Lista Vazia!");
            else{
                // VARIAVEIS
                Pessoa aux = Head;
                Console.WriteLine("IMPRESSÃO LISTA");
                do{
                    Console.WriteLine(aux.ToString());
                    aux = aux.Proximo; // PERCORRER
                } while(aux != null);
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
