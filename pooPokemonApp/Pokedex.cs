using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPokemonApp {
	public class Pokedex {
		public Pokedex() {
			this.InicializaLista();
		}
		private List<PokemonPlus> pokemons;

		public List<PokemonPlus> _pokemons {
			get { return this.pokemons; }
		}

		private void InicializaLista() { /*Registre pokemons aqui*/
			this.pokemons = new List<PokemonPlus>();
			PokemonPlus p = new PokemonPlus("Bulbasauro", "é um pokémon tipo planta...", 10);
			this.pokemons.Add(p);
			p = new PokemonPlus("Charizard", "é um pokémon tipo fogo", 25);
			this.pokemons.Add(p);
			p = new PokemonPlus("Pikachu", "é um pokémon tipo choque", 12);
			this.pokemons.Add(p);
			p = new PokemonPlus("Paras", "é um pokémon tipo inseto", 9);
			this.pokemons.Add(p);
			p = new PokemonPlus("Giratina", "é um pokémon tipo lendário", 40);
			this.pokemons.Add(p);
			p = new PokemonPlus("Blastoise", "é um pokémon tipo agua",20);
			this.pokemons.Add(p);
			p = new PokemonPlus("Charmander", "é um pokémon tipo fogo",10);
			this.pokemons.Add(p);
			p = new PokemonPlus("Chimchar", "é um pokémon tipo fogo",15);
			this.pokemons.Add(p);
			p = new PokemonPlus("Dragonair", "é um pokémon tipo dragão", 20);
			this.pokemons.Add(p);
			p = new PokemonPlus("Anivia", "é um pokémon tipo voador", 15);
			this.pokemons.Add(p);
			p = new PokemonPlus("Metapod", "é um pokémon tipo metal", 10);
			this.pokemons.Add(p);
			p = new PokemonPlus("Mewtwo", "é um pokémon tipo lendário", 50);
			this.pokemons.Add(p);
		}
		public void ListarPokemons() {
            for (int i = 0; i < this.pokemons.Count; i++) {
				Console.Write("({0}) - ", i+1);
				this._pokemons[i].ExibirDadosPokemon(true);
            }
        }

	}
}
