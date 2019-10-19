using System;
using System.Collections.Generic;

namespace ElevenExample
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Pokemon> ashPokemonjai = initializePokemons();

            // Minden pokémonnak van neve és típusa.
            // Bizonyos tipusok hatásosak más típusokkal szemben, pl. víz hatásos tűz ellen.

            // Ash-nek van néhány pokémonja.
            // Felbukkant egy vad pokémon!

            Pokemon vadPokemon = new Pokemon("Oddish", "fű", "víz");

            // Melyik pokémonját válassza Ash a küzdelemhez?

            Pokemon hero = ashPokemonjai[0];
            foreach (var item in ashPokemonjai)
            {
                if (item.hatasosEllene(vadPokemon))
                {
                    hero = item;
                }

            }


            Console.WriteLine($"{hero.Nev}, téged választalak!");
        }

        private static List<Pokemon> initializePokemons()
        {
            List<Pokemon> pokemon = new List<Pokemon>();

            pokemon.Add(new Pokemon("Balbasaur", "fű", "víz"));
            pokemon.Add(new Pokemon("Pikatchu", "elektromos", "víz"));
            pokemon.Add(new Pokemon("Charizard", "tűz", "fű"));
            pokemon.Add(new Pokemon("Balbasaur", "víz", "tűz"));
            pokemon.Add(new Pokemon("Kingler", "víz", "tűz"));

            return pokemon;
        }
    }
}
