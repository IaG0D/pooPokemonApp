using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPokemonApp {
    public class PokemonPlus: Pokemon {
        public PokemonPlus() : base() {
            this.Poder = 0;
        }
        public PokemonPlus(string nome, string descricao,int poder):base(nome,descricao) {

            this.Poder = poder;
        }
        public int Poder { get; set; }
        public void ExibirDadosPokemonPlus() {
            Console.WriteLine("Nome do Pokémon: " + this._nome );
            Console.WriteLine("Descrição do Pokémon: " + this._descricao );
            Console.WriteLine("Poder:" + this.Poder);

        }
    }
}
