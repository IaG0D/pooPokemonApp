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
		private List<Pokemon> pokemons;

		public List<Pokemon> _pokemons {
			get { return this.pokemons; }
		}

		private void InicializaLista() {
			this.pokemons = new List<Pokemon>();
			Pokemon p = new Pokemon("Bulbasauro", "é um pokémon tipo planta...");
			this.pokemons.Add(p);
			p = new Pokemon("Charizard", "é um pokémon tipo fogo");
			this.pokemons.Add(p);
			p = new Pokemon("Pikachu", "é um pokémon tipo choque");
			this.pokemons.Add(p);
			p = new Pokemon("Paras", "é um pokémon tipo inseto");
			this.pokemons.Add(p);
			p = new Pokemon("Giratina", "é um pokémon tipo lendário");
			this.pokemons.Add(p);
			p = new Pokemon("Blastoise", "é um pokémon tipo agua");
			this.pokemons.Add(p);
			p = new Pokemon("Charmander", "é um pokémon tipo fogo");
			this.pokemons.Add(p);
			p = new Pokemon("Chimchar", "é um pokémon tipo fogo");
			this.pokemons.Add(p);
			p = new Pokemon("Dragonair", "é um pokémon tipo dragão");
			this.pokemons.Add(p);
			p = new Pokemon("Anivia", "é um pokémon tipo voador");
			this.pokemons.Add(p);
			p = new Pokemon("Metapod", "é um pokémon tipo metal");
			this.pokemons.Add(p);
			p = new Pokemon("Mewtwo", "é um pokémon tipo lendário");
			this.pokemons.Add(p);
		}
		public void ListarPokemons() {
            for (int i = 0; i < this.pokemons.Count; i++) {
				this._pokemons[i].ExibirDadosPokemon(true);
            }
        }

	}
}
