using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioEstacionamento.Models
{
    public class ClasseEstacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoHora = 0;
        private List<string> veiculos = new List<string>();

            public ClasseEstacionamento(decimal precoInicial, decimal precoHora)
            {
            this.precoInicial = precoInicial;
            this.precoHora = precoHora;
            }
        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veiculo para estacionar");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa para remover:");
            string placaRemove = Console.ReadLine();

            if (veiculos.Any(placa => placa.ToUpper() == placaRemove.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas estacionadas");
                decimal horas = Convert.ToDecimal(Console.ReadLine());
                decimal valorTotal = Convert.ToInt32($"{precoInicial + precoHora * horas}");
                Console.WriteLine($"O veículo {placaRemove} deve pagar o {valorTotal} para ser liberado.");
            }

            else 
            { 
                Console.WriteLine("Desculpe, esse veículo não consta no sistema. Confira se digitou a placa corretamente");
            }
        }
        public void ListarVeiculos()
        {
            Console.WriteLine("Os veículos estacionados são:");
            foreach (string placa in veiculos)
            {
             Console.WriteLine(placa);
            }
           

            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (string placa in veiculos)
                Console.WriteLine(placa);
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
