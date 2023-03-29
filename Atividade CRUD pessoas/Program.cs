using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Crie um programa em C# que permita realizar as operações CRUD (Create, Read, Update e Delete) de pessoas. Cada pessoa deve possuir um identificador único (ID),
 * um nome e um número de telefone. Os dados devem ser armazenados em uma lista em memória.

O programa deve permitir a inserção de novas pessoas na lista, a exibição de todas as pessoas cadastradas, 
a atualização dos dados de uma pessoa existente e a exclusão de uma pessoa da lista.

Ao iniciar o programa, deve ser exibido um menu com as opções disponíveis e o usuário deve ser capaz de escolher a operação que deseja realizar.
Após cada operação, o programa deve voltar ao menu principal para que o usuário possa escolher a próxima ação a ser executada.
*/
namespace Atividade_CRUD_pessoas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PessoasRepository pessoasRepository = new PessoasRepository();

            //pergunta pro usuario qual ação ele deseja fazer
            while (true)
            {
                Console.WriteLine("Selecione a opreção que deseha realizar:");
                Console.WriteLine("1- Adicionar pessoa");
                Console.WriteLine("2- Listar todas as pessoas");
                Console.WriteLine("3- Atualizar dados de uma pessoa");
                Console.WriteLine("4- Excluir uma pessoa");
                Console.WriteLine("0- Sair");

                string opcaoMenu = Console.ReadLine();
                Console.WriteLine();

                switch (opcaoMenu)
                {
                    case "1":
                        Console.WriteLine("Informe o nome da pessoa: ");
                        string nome = Console.ReadLine();

                        Console.WriteLine("Informe o telefone da pessoa: ");
                        string telefone = Console.ReadLine();

                        Pessoas pessoas = new Pessoas(pessoasRepository.GetAll().Count + 1, nome, telefone);
                        pessoasRepository.Add(pessoas);

                        Console.WriteLine("Pessoa adicionada com sucesso!");
                        break;

                    case "2":
                        var todasPessoas = pessoasRepository.GetAll();
                        Console.WriteLine("Lista de todas as pessoas cadastradas: ");

                        foreach (var Pessoas in todasPessoas) 
                        {
                            Console.WriteLine("ID: " + Pessoas.Id);
                            Console.WriteLine("Nome: " + Pessoas.Nome);
                            Console.WriteLine("Telefone: " + Pessoas.Telefone);
                            Console.WriteLine();
                        }
                        break;

                    case "3":
                        Console.WriteLine("Informe o ID da pessoa que deseja atualizar: ");
                        int id = int.Parse(Console.ReadLine());

                        var pessoasParaAtulizar = pessoasRepository.GetAll().Find(x => x.Id == id);

                        if (pessoasParaAtulizar != null) 
                        {
                            Console.WriteLine("Informe o novo nome da pessoa: ");
                            string novoNome = Console.ReadLine();

                            Console.WriteLine("Informe o novo telefone da pessoa: ");
                            string novoTelefone = Console.ReadLine();

                            Pessoas novasPessoas = new Pessoas(id, novoNome, novoTelefone);
                            pessoasRepository.Update(novasPessoas);

                            Console.WriteLine("Dados da pessoa atualizados com sucesso!");

                        }
                        else
                        {
                            Console.WriteLine("Não existe pessoa cadastrada com o ID informado!");
                        }
                        break;

                        case "4":
                        Console.WriteLine("Informe o ID da pessoa que deseja excluir: ");
                        int deletarId = int.Parse(Console.ReadLine());

                        var pessoasParaDeletar = pessoasRepository.GetAll().Find(x => x.Id == deletarId);


                        if (pessoasParaDeletar != null) 
                        {
                            pessoasRepository.Delete(pessoasParaDeletar);
                            Console.WriteLine("Pessoa excluída com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Não existe pessoa cadastrada com o ID informado!");
                        }
                        break;

                        case "5":
                        Console.WriteLine("Programa Encerrado.");
                        Environment.Exit(0);
                        break;

                        default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }    
            }
        }
    }
}
