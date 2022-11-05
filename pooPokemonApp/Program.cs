using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace pooPokemonApp {
    internal class Program {
        static void Main(string[] args) {
            int pokemonselecionado = 100;
            int pokemonselecionado2 = 100;
            int resp = 100;
            Pokedex pokedex = new Pokedex();
            while (resp != 0) {
                resp = Menu();
                if (resp == 1) {
                    pokedex.ListarPokemons();
                }
                if (resp == 2) {
                    pokedex.ListarPokemons();
                    Batalhar();
                }
            }
            Console.ReadKey();
        }

        static int Menu() {
            Console.WriteLine("==Pokedéx/Jogo de Batalha==");
            Console.WriteLine("0 - Sair do Jogo");
            Console.WriteLine("1 - Listar todos os Pokémons da Pokedex");
            Console.WriteLine("2 - Batalhar");
            Console.WriteLine("\n Qual opção deseja fazer? :");
            int resp = Convert.ToInt32(Console.ReadLine());
            return resp;
        }
        static void Batalhar() {  
            Pokedex pokedex = new Pokedex();
            Console.WriteLine("Digite o número do pokemon que deseja batalhar:");
            Console.WriteLine("Pokémon:");
            int pokemonselecionado = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("O Pokemon selecionado foi:");
            Console.WriteLine("Pokemon :");
            pokedex._pokemons[pokemonselecionado - 1].ExibirDadosPokemon();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Selecionando Adversário!");
            Thread.Sleep(2000);
            Random rand = new Random();
            int pokemonselecionado2 = rand.Next(0, pokedex._pokemons.Count());
            Console.WriteLine("Adversário: ");
            pokedex._pokemons[pokemonselecionado2].ExibirDadosPokemon();
            if(pokedex._pokemons[pokemonselecionado - 1].Poder >= pokedex._pokemons[pokemonselecionado2].Poder) {
                Console.WriteLine("\n\nVocê Ganhou! \nSeu poder: {0}\n Poder do Adversário: {1}\n\n\n\n",
                pokedex._pokemons[pokemonselecionado - 1].Poder, pokedex._pokemons[pokemonselecionado2].Poder);

            }
            else {
                Console.WriteLine("\n\nVocê Perdeu! \nSeu poder: {0}\n Poder do Adversário: {1}\n\n\n\n",
                pokedex._pokemons[pokemonselecionado - 1].Poder, pokedex._pokemons[pokemonselecionado2].Poder);
            }



        }
    }
}
