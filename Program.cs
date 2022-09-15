using System;
using sistema_estacionamento.Models;

namespace sistema_estacionamento;

class Program {
    static void Main(string[] args) {

        Console.WriteLine("Sistema de estacionamento");
        Console.WriteLine("-------------------------"); 
        Console.WriteLine();

        Console.WriteLine("Seja bem-vindo(a)!");
        Console.WriteLine();

        Console.Write("Entre com o preço inicial: ");
        double precoInicial = double.Parse(Console.ReadLine());

        Console.Write("Agora entre com o preço por hora: ");
        double precoHora = double.Parse(Console.ReadLine());

        Estacionamento estacionamento = new Estacionamento(precoInicial, precoHora);

        int opcaoMenu;

        do {

            Console.WriteLine("Menu do sistema de estacionamento");
            Console.WriteLine("---------------------------------");
            Console.WriteLine();

            Console.WriteLine("1) Cadastrar veículo");
            Console.WriteLine("2) Remover veículo");
            Console.WriteLine("3) Listar veículos");
            Console.WriteLine("4) Encerrar");
            Console.WriteLine();

            Console.Write("Opção -> ");
            opcaoMenu = int.Parse(Console.ReadLine());

            switch(opcaoMenu) {

                case 1:
                    estacionamento.AdicionarVeiculo();
                break;

                case 2:
                    estacionamento.RemoverVeiculo();
                break;

                case 3:
                    estacionamento.ListarVeiculos();
                break;

                case 4:
                break;

                default:
                    Console.WriteLine("Por favor, digite uma opção válida.");
                break;
            }

            Console.ReadLine();
            Console.Clear();

        } while(opcaoMenu != 4);
    }
}