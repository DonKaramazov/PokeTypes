using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokEvaluator.Objects
{
    public static class FirePokemons
    {
        public static List<Pokemon> GetAllPokemons()
        {
            List<Pokemon> pokemons = new List<Pokemon>();
            GetOnlyFirePokemons(pokemons);


            return pokemons;
        }

        private static void GetOnlyFirePokemons(List<Pokemon> pokemons)
        {
            pokemons.Add(new Pokemon("Charmander", Element.FIRE));
            pokemons.Add(new Pokemon("Charmeleon", Element.FIRE));
            pokemons.Add(new Pokemon("Vulpix", Element.FIRE));
            pokemons.Add(new Pokemon("Ninetales", Element.FIRE));
            pokemons.Add(new Pokemon("Growlithe", Element.FIRE));
            pokemons.Add(new Pokemon("Ponyta", Element.FIRE));
            pokemons.Add(new Pokemon("Rapidash", Element.FIRE));
            pokemons.Add(new Pokemon("Magmar", Element.FIRE));
            pokemons.Add(new Pokemon("Flareon", Element.FIRE));
            pokemons.Add(new Pokemon("Cyndaquil", Element.FIRE));
            pokemons.Add(new Pokemon("Quilava", Element.FIRE));
            pokemons.Add(new Pokemon("Cyndaquil", Element.FIRE));
            pokemons.Add(new Pokemon("Typhlosion", Element.FIRE));
            pokemons.Add(new Pokemon("Slugma", Element.FIRE));
            pokemons.Add(new Pokemon("Magby", Element.FIRE));
            pokemons.Add(new Pokemon("Entei", Element.FIRE));
            pokemons.Add(new Pokemon("Torchic", Element.FIRE));
            pokemons.Add(new Pokemon("Torkoal", Element.FIRE));
            pokemons.Add(new Pokemon("Chimchar", Element.FIRE));
            pokemons.Add(new Pokemon("Magmortar", Element.FIRE));
            pokemons.Add(new Pokemon("Tepig", Element.FIRE));
            pokemons.Add(new Pokemon("Pansear", Element.FIRE));
            pokemons.Add(new Pokemon("Simisear", Element.FIRE));
            pokemons.Add(new Pokemon("Darumaka", Element.FIRE));
            pokemons.Add(new Pokemon("Darmanitan", Element.FIRE));
            pokemons.Add(new Pokemon("Heatmor", Element.FIRE));
            pokemons.Add(new Pokemon("Fennekin", Element.FIRE));
            pokemons.Add(new Pokemon("Braixen", Element.FIRE));
        }
    }
}
