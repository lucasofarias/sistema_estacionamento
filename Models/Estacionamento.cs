using System;

namespace sistema_estacionamento.Models {
    public class Estacionamento {
        public double PrecoInicial { get; set; }
        public double PrecoHora { get; set; }
        public string PlacaVeiculo { get; set; }
        List<string> listaVeiculos = new List<string>();

        public Estacionamento(double precoInicial, double precoHora) {
            PrecoInicial = precoInicial;
            PrecoHora = precoHora;
        }

        public Estacionamento(string placaVeiculo) {
            PlacaVeiculo = placaVeiculo;
        }

        public void AdicionarVeiculo() {
            Console.Write("Digite a placa do veículo: ");
            string placaVeiculo = Console.ReadLine();

            listaVeiculos.Add(placaVeiculo);
        }

        public void RemoverVeiculo() {
            if(listaVeiculos.Any()) {
                Console.Write("Digite a placa do veículo para remover: ");
                string placaVeiculo = Console.ReadLine();

                if(listaVeiculos.Any(placa => placa == placaVeiculo)) {
                    Console.Write("Entre com a quantidade de horas que o veículo permaneceu no estacionamento: ");
                    int horas = int.Parse(Console.ReadLine());
                        
                    Console.WriteLine("O veículo foi removido! O preço total é de: R$" + CalcularPreco(horas).ToString("F2"));
                    listaVeiculos.Remove(placaVeiculo);
                }

                else {
                    Console.WriteLine("O veículo com a placa {0} não foi encontrado.", placaVeiculo);
                }
            }
            
            else {
                Console.WriteLine("Não há veículos estacionados!");
            }
        }

        public void ListarVeiculos() {
            if(listaVeiculos.Any()) {
                Console.WriteLine("Veículos estacionados");
                Console.WriteLine("---------------------");
                Console.WriteLine();

                foreach(string placa in listaVeiculos) {
                    Console.WriteLine(placa);
                }
            }

            else {
                Console.WriteLine("Não há veículos estacionados!");
            }
        }

        public double CalcularPreco(int qtdHoras) {
            return qtdHoras * PrecoHora + PrecoInicial;
        }
    }
}