using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokEvaluator.Objects
{
    public static class SteelPokemons
    {
 
        public static List<Pokemon> GetAllPokemons()
        {
            List<Pokemon> pokemons = new List<Pokemon>();
            GetSingularTypePokemons(pokemons);
            GetBiElementsPokemons(pokemons);

            return pokemons;
        }

        private static void GetBiElementsPokemons(List<Pokemon> pokemons )
        {
            pokemons.Add(new Pokemon("Cobalion", Element.STEEL, Element.FIGHTING));
            pokemons.Add(new Pokemon("Dialga", Element.STEEL, Element.DRAGON));
            pokemons.Add(new Pokemon("Mawile", Element.STEEL, Element.FAIRY));
            pokemons.Add(new Pokemon("Klefki", Element.STEEL, Element.FAIRY));
            pokemons.Add(new Pokemon("Beldum", Element.STEEL, Element.PSY));
            pokemons.Add(new Pokemon("Metang", Element.STEEL, Element.PSY));
            pokemons.Add(new Pokemon("Metagross", Element.STEEL, Element.PSY));
            pokemons.Add(new Pokemon("Jirachi", Element.STEEL, Element.PSY));
            pokemons.Add(new Pokemon("Bronzor", Element.STEEL, Element.PSY));
            pokemons.Add(new Pokemon("Bronzong", Element.STEEL, Element.PSY));
            pokemons.Add(new Pokemon("Aron", Element.STEEL, Element.ROCK));
            pokemons.Add(new Pokemon("Lairon", Element.STEEL, Element.ROCK));
            pokemons.Add(new Pokemon("Aggron", Element.STEEL, Element.ROCK));
            pokemons.Add(new Pokemon("Steelix", Element.STEEL, Element.GROUND));
            pokemons.Add(new Pokemon("Honedge", Element.STEEL, Element.GHOST));
            pokemons.Add(new Pokemon("Doublade", Element.STEEL, Element.GHOST));
            pokemons.Add(new Pokemon("Aegislash", Element.STEEL, Element.GHOST));
            pokemons.Add(new Pokemon("Skarmory", Element.STEEL, Element.FLY));
        }

        private static void GetSingularTypePokemons(List<Pokemon> pokemons )
        {
            pokemons.Add(new Pokemon("Registeel", Element.STEEL));
            pokemons.Add(new Pokemon("Klink", Element.STEEL));
            pokemons.Add(new Pokemon("Klang", Element.STEEL));
            pokemons.Add(new Pokemon("KlingKlang", Element.STEEL));

        }
    }
}
