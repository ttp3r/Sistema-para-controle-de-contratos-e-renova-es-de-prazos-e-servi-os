using System;
 
namespace SISTEMADECONTRATOS
{
    public class Contrato
    {
        public double Valor { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataVencimento { get; set; }
 
        public Contrato(double valor, DateTime dataInicio, DateTime dataVencimento)
        {
            Valor = valor;
            DataInicio = dataInicio;
            DataVencimento = dataVencimento;
        }
 
        public int DiasParaVencer()
        {
            return (DataVencimento - DateTime.Today).Days;
        }
 
        public void ExibirResultado()
        {
            int dias = DiasParaVencer();
 
            Console.WriteLine($"\nValor: R$ {Valor:F2}");
            Console.WriteLine($"Início: {DataInicio:dd/MM/yyyy}");
            Console.WriteLine($"Vencimento: {DataVencimento:dd/MM/yyyy}");
 
            if (dias < 0)
            {
                Console.WriteLine($"Status: VENCIDO há {Math.Abs(dias)} dias");
            }
            else if (dias <= 30)
            {
                Console.WriteLine($"Status: VENCE EM {dias} DIAS — Renovação urgente!");
            }
            else
            {
                Console.WriteLine($"Status: Vigente ({dias} dias restantes)");
            }
        }
    }
}
