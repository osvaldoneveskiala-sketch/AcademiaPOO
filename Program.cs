using AcademiaPOO.Exceptions;
using AcademiaPOO.Models;
using AcademiaPOO.Services;
using System;

namespace AcademiaPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GestorAcademia gestor = new GestorAcademia();

            int opcao = -1;

            while (opcao != 0)
            {
                Console.Clear();

                Console.WriteLine("===== SISTEMA DA ACADEMIA =====");
                Console.WriteLine("1 - Cadastrar Sócio");
                Console.WriteLine("2 - Criar Aula");
                Console.WriteLine("3 - Listar Sócios");
                Console.WriteLine("4 - Registar Pagamento");
                Console.WriteLine("5 - Fazer Inscrição");
                Console.WriteLine("0 - Sair");

                Console.Write("Escolha: ");
                opcao = int.Parse(Console.ReadLine());

                try
                {
                    switch (opcao)
                    {
                        case 1:

                            Console.Write("ID: ");
                            int id = int.Parse(Console.ReadLine());

                            Console.Write("Nome: ");
                            string nome = Console.ReadLine();

                            Console.Write("Telefone: ");
                            string telefone = Console.ReadLine();

                            Console.WriteLine("1 - Musculacao");
                            Console.WriteLine("2 - Cardio");
                            Console.WriteLine("3 - Misto");

                            Console.Write("Plano: ");
                            int planoOpcao = int.Parse(Console.ReadLine());

                            TipoPlano plano = TipoPlano.Musculacao;

                            if (planoOpcao == 2)
                            {
                                plano = TipoPlano.Cardio;
                            }
                            else if (planoOpcao == 3)
                            {
                                plano = TipoPlano.Misto;
                            }

                            Socio socio = new Socio(id, nome, telefone, plano);

                            gestor.AdicionarSocio(socio);

                            Console.WriteLine("Sócio cadastrado com sucesso.");
                            break;

                        case 2:

                            Console.Write("Nome da Aula: ");
                            string nomeAula = Console.ReadLine();

                            Console.Write("Número de vagas: ");
                            int vagas = int.Parse(Console.ReadLine());

                            AulaColectiva aula = new AulaColectiva(nomeAula, vagas);

                            gestor.AdicionarAula(aula);

                            Console.WriteLine("Aula criada com sucesso.");
                            break;

                        case 3:

                            gestor.ListarSocios();
                            break;

                        case 4:

                            Console.Write("ID do Sócio: ");
                            int socioPagamento = int.Parse(Console.ReadLine());

                            gestor.RegistarPagamento(socioPagamento);

                            Console.WriteLine("Pagamento registado.");
                            break;

                        case 5:

                            Console.Write("ID do Sócio: ");
                            int socioId = int.Parse(Console.ReadLine());

                            Console.Write("Nome da Aula: ");
                            string aulaNome = Console.ReadLine();

                            AulaColectiva novaAula = new AulaColectiva(aulaNome, 1);

                            gestor.FazerInscricao(socioId, novaAula);

                            Console.WriteLine("Inscrição realizada.");
                            break;

                        case 0:

                            Console.WriteLine("Sistema encerrado.");
                            break;

                        default:

                            Console.WriteLine("Opção inválida.");
                            break;
                    }
                }
                catch (SocioNaoEncontradoException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (AulaLotadaException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (PagamentoEmAtrasoException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception)
                {
                    Console.WriteLine("Erro no sistema.");
                }

                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para continuar...");
                Console.ReadLine();
            }
        }
    }
}