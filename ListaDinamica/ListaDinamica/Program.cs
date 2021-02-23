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
            // VARIAVEIS
            ListaContato meusContatos = new ListaContato { Head = null, Tail = null };
            Pessoa pessoa, busca;
            int op;
            string deletar, buscar;
            pessoa = new Pessoa
            {
                Nome = "Luiz",
                telefone = new Telefone[] { new Telefone { Ddd = 16, Numero = 123456789, Tipo = "Celular"},
                                            new Telefone { Ddd = 16, Numero = 33941898, Tipo = "Casa"}},
                Proximo = null
            };
            meusContatos.Push(pessoa);
            pessoa = new Pessoa
            {
                Nome = "Fabio",
                telefone = new Telefone[] { new Telefone { Ddd = 41, Numero = 33847894, Tipo = "Casa"}},
                Proximo = null
            };
            meusContatos.Push(pessoa);
            pessoa = new Pessoa
            {
                Nome = "Leticia",
                telefone = new Telefone[] { new Telefone { Ddd = 16, Numero = 789456185, Tipo = "Celular"},
                                            new Telefone { Ddd = 16, Numero = 33941898, Tipo = "Casa"},
                                            new Telefone { Ddd = 16, Numero = 789456175, Tipo = "Trabalho"}},
                Proximo = null
            };
            meusContatos.Push(pessoa);

            do
            { // LAÇO PROGRAMA

                op = menu(); // MENU

                Console.Clear(); // LIMPA TELA

                switch (op)
                {
                    case 1: // CADASTRO

                        pessoa = lerPessoa(); // CADASTRA CONTATO

                        meusContatos.Push(pessoa); // CADASTRA CONTATO NA LISTA

                        break;
                    case 2: // IMPRIMIR

                        meusContatos.Print(); // IMPRIME LISTA

                        break;
                    case 3: // DELETAR
                        do
                        { // LAÇO NÃO DEIXAR CAMPO VAZIO
                            Console.Write("Qual o Nome do Contato deseja deletar: ");
                            deletar = Console.ReadLine();

                        } while (deletar == "");
                        
                        meusContatos.Pop(deletar); // DELETA DA LISTA

                        break;
                    case 4: // QUANTIDADE

                        Console.WriteLine("Quantidade de Contatos: " + meusContatos.Qtd); // IMPRIME QUANTIDADE DE CONTATOS

                        break;
                    case 5: //BUSCAR

                        do
                        { // LAÇO NÃO DEIXAR CAMPO VAZIO
                            Console.Write("Digite o Nome do Contato: ");
                            buscar = Console.ReadLine();
                        } while (buscar == "");
                        meusContatos.buscar(buscar); // BUSCA NA LISTA E JÁ IMPRIME NO MÉTODO

                        break;
                    case 6: //  BUSCAR COM PAUSA
                        busca = meusContatos.Head;
                        do
                        { // LAÇO IMPRESSAO DE CONTATOS UM POR UM COM CONTROLE DE USUARIO

                            Console.WriteLine(busca.ToString()); // IMPRESSAO

                            Console.WriteLine("Deseja continuar impressão?\n1 - Sim\n0 - Não"); // IMPRESSAO PERGUNTA

                            busca = busca.Proximo; // PERCORRER
                        } while (int.Parse(Console.ReadLine()) == 1 && busca != null); // CONDIÇÃO SE USUARIO QUISER E SE FILA NÃO FOR VAZIA
                        
                        Console.WriteLine("Impressão finalizada");

                        break;
                }
            } while (op != 0);

            Console.ReadKey();
        }

        static int menu()
        {
            try
            {
                int op; // MENU
                Console.WriteLine("--------------------------\n" +
                    "1 - Cadastrar Contato\n" +
                    "2 - Imprimir Contatos\n3 - Deletar Contato\n" +
                    "4 - Quantidade de Contatos\n5 - Buscar Contato\n6 - BuscarPausa\n0 - Sair\n" +
                    "--------------------------");
                op = int.Parse(Console.ReadLine());
                return op;
            }
            catch (Exception)
            {
                return menu(); // LAÇO RODA NOVAMENTE
            }
        }

        static Pessoa lerPessoa()
        {
            try
            {
                // VARIAVEIS
                string nome;
                int[] telefone = new int[6]; // VETORES PARA ARMAZENAMENTO DE INFORMAÇÕES DE CONTATO
                string[] tipo = new string[3];
                int contnum = 0; // CONTADORES PARA O LAÇO
                int contstring = 0;
                int i = 1; // CONTROLE LAÇO

                do // LAÇO PARA NÃO DEIXAR CAMPO VAZIO
                {
                    Console.Write("Digite o Nome do Contato: ");
                    nome = Console.ReadLine();
                } while (nome == "");

                
                do // LEITURA DE NUMEROS DE CONTATO 
                {
                    Console.WriteLine("Digite o " + i + "° telefone: ");

                    Console.Write("DDD: ");
                    telefone[contnum] = int.Parse(Console.ReadLine());
                    if (telefone[contnum] == 0) // SE O DDD FOR ZERO PULA O LAÇO E NÃO FAZ MAIS LEITURA DE NUMEROS DE CONTATO
                        break;
                    contnum++;

                    Console.Write("Número: ");
                    telefone[contnum] = int.Parse(Console.ReadLine());
                    contnum++;

                    Console.Write("Tipo: ");
                    tipo[contstring] = Console.ReadLine();
                    contstring++;

                    i++;
                } while (i < 4);

                return new Pessoa
                {
                    Nome = nome,                    // LEITURA DE NUMEROS DE TELEFONE
                    telefone = new Telefone[] { new Telefone { Ddd = telefone[0], Numero = telefone[1], Tipo = tipo[0]},
                                                new Telefone { Ddd = telefone[2], Numero = telefone[3], Tipo = tipo[1]},
                                                new Telefone { Ddd = telefone[4], Numero = telefone[5], Tipo = tipo[2]}
                    },
                    Proximo = null
                };
                
            }
            catch (Exception)
            {

                Console.WriteLine("Informe os dados corretamente");
                return lerPessoa();
            }
        }
    }
}
