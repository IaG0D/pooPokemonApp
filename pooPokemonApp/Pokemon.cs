using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPokemonApp {
    public class Pokemon {
        public Pokemon() {
            this.nome = "";
            this.descricao = "";
        }

        public Pokemon(string nome, string descricao) {
            this.nome=nome.ToUpper();
            this.descricao= descricao.ToUpper();
        }
        private String nome;
        public String _nome {
            get { return nome; }
            set {
                String texto = value.ToUpper();
                nome = texto; }
        }

        private String descricao;

        public String _descricao {
            get { return this.descricao; }
            set { this.descricao = value.ToUpper(); }
        }

        public void ExibirDadosPokemon() {
            Console.WriteLine("Nome do Pokémon: " + this.nome);
            Console.WriteLine("Descrição do Pokémon: " + this.descricao);

        }
        public void ExibirDadosPokemon(bool formatado) {
            if(formatado = true) {
                Console.WriteLine("Pokemón " + this.nome + " " + this.descricao.ToLower());
            }
            else {
                Console.WriteLine("Nome do Pokémon: " + this.nome);
                Console.WriteLine("Descrição do Pokémon: " + this.descricao);
            }

        }

    }
}
