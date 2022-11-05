using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace pooPokemonApp {
    internal class Program {
        static void Main(string[] args) {
            int resp = 100;
            Pokedex pokedex = new Pokedex();
            while (resp != 0) {
                resp = Menu();
                if (resp == 1){
                    pokedex.ListarPokemons();
                }
            }
            Console.ReadKey();
        }

        static int Menu() {
            Console.WriteLine("==Pokedéx==");
            Console.WriteLine("0 - Sair da Pokedéx");
            Console.WriteLine("1 - Listar todos os Pokémons");
            Console.WriteLine("\n Qual opção deseja fazer? :");
            int resp = Convert.ToInt32(Console.ReadLine());
            return resp;
        }
    }
}
