using System;
 
namespace SISTEMADECONTRATOS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SISTEMA DE GESTÃO DE CONTRATOS E RENOVAÇÕES ===\n");
 
            int opcao = 0;
            int totalContratos = 0;
 
            while (opcao != 2)
            {
                Console.WriteLine("1 - Cadastrar contrato");
                Console.WriteLine("2 - Sair");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());
 
                if (opcao == 1)
                {
                    totalContratos++;
                    Console.WriteLine($"\n--- Cadastro de Contrato #{totalContratos} ---");
 
                    Console.Write("Data de início (dd/mm/aaaa): ");
                    DateTime dataInicio = DateTime.Parse(Console.ReadLine());
 
                    Console.Write("Data de vencimento (dd/mm/aaaa): ");
                    DateTime dataVencimento = DateTime.Parse(Console.ReadLine());
 
                    Console.Write("Valor mensal (R$): ");
                    double valor = double.Parse(Console.ReadLine());
 
                    Contrato contrato = new Contrato(valor, dataInicio, dataVencimento);
                    contrato.ExibirResultado();
                    Console.WriteLine();
                }
                else if (opcao != 2)
                {
                    Console.WriteLine("Opção inválida. Tente novamente.\n");
                }
            }
 
            Console.WriteLine($"\nSistema encerrado. Total de contratos cadastrados: {totalContratos}");
        }
    }
}
