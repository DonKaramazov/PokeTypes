using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokEvaluator
{
    public static class Pokedex
    {
        private static List<PokemonType> _pokemonTypes = null;

        public static List<PokemonType> PokemonTypes
        {
            get 
            {
                return _pokemonTypes ?? GetAllPokemonTypes(); 
            }
            set { _pokemonTypes = value; }
        }

        private static List<Pokemon> _pokemons = null;

        public static List<Pokemon> Pokemons
        {
            get
            {
                return _pokemons ?? GetAllPokemons();
            }
            set { _pokemons = value; }
        }

        private static List<Pokemon> GetAllPokemons()
        {
            List<Pokemon> pokemons = new List<Pokemon>();

            GetFirePokemons(pokemons);
            GetGrassPokemons(pokemons);
            GetDragonPokemons(pokemons);

            //Bi-elements
            GetSteelFightingPokemons(pokemons);


            return pokemons.OrderBy(p => p.Name).ToList();
        }

        private static void GetDragonPokemons(List<Pokemon> pokemons)
        {
            pokemons.Add(new Pokemon("Dragonite", Element.DRAGON));
            pokemons.Add(new Pokemon("Charizard", Element.DRAGON));
        }

        private static void GetSteelFightingPokemons(List<Pokemon> pokemons)
        {
            pokemons.Add(new Pokemon("Cobalion", Element.STEEL, Element.FIGHTING));
        }

        private static void GetGrassPokemons(List<Pokemon> pokemons)
        {
            pokemons.Add(new Pokemon("Bulbizare", Element.GRASS));
            pokemons.Add(new Pokemon("Bulbifleure", Element.GRASS));
        }

        private static void GetFirePokemons(List<Pokemon> pokemons)
        {
            pokemons.Add(new Pokemon("Charmander", Element.FIRE));
        }
        

        private static List<PokemonType> GetAllPokemonTypes()
        {
            List<PokemonType> types = new List<PokemonType>();

            BuildSingularTypes(types);
            BuildAssociatedTypes(types);

            return types;
        }

        private static void BuildSingularTypes(List<PokemonType> types)
        {
            PokemonType steel = new PokeBuilder(Element.STEEL)
               .VulnerableTo(Element.FIGHTING, Element.FIRE, Element.GROUND)
               .ResistantTo(Element.STEEL, Element.DRAGON, Element.FAIRY, Element.ICE, Element.BUG, Element.NORMAL,
               Element.GRASS, Element.PSY, Element.ROCK, Element.FLY)
               .ImmuneTo(Element.POISON)
               .Build();

            PokemonType fighting = new PokeBuilder(Element.FIGHTING)
                 .VulnerableTo(Element.FAIRY, Element.PSY, Element.FLY)
                 .ResistantTo(Element.BUG, Element.ROCK, Element.DARK)
                 .Build();

            PokemonType dragon = new PokeBuilder(Element.DRAGON)
                .VulnerableTo(Element.DRAGON, Element.FAIRY, Element.ICE)
                .ResistantTo(Element.WATER, Element.THUNDER, Element.FIRE, Element.GRASS)
                .Build();

            PokemonType water = new PokeBuilder(Element.WATER)
                .VulnerableTo(Element.THUNDER, Element.GRASS)
                .ResistantTo(Element.STEEL, Element.WATER, Element.FIRE, Element.ICE)
                .Build();

            PokemonType thunder = new PokeBuilder(Element.THUNDER)
                .VulnerableTo(Element.GROUND)
                .ResistantTo(Element.STEEL, Element.THUNDER, Element.FLY)
                .Build();

            PokemonType fairy = new PokeBuilder(Element.FAIRY)
                .VulnerableTo(Element.STEEL, Element.POISON)
                .ResistantTo(Element.FIGHTING, Element.BUG, Element.DARK)
                .ImmuneTo(Element.DRAGON)
                .Build();

            PokemonType fire = new PokeBuilder(Element.FIRE)
                .VulnerableTo(Element.WATER, Element.ROCK, Element.GROUND)
                .ResistantTo(Element.STEEL, Element.FAIRY, Element.FIRE, Element.ICE, Element.BUG, Element.GRASS)
                .Build();

            PokemonType ice = new PokeBuilder(Element.ICE)
                .VulnerableTo(Element.STEEL, Element.FIGHTING, Element.FIRE, Element.ROCK)
                .ResistantTo(Element.ICE)
                .Build();

            PokemonType bug = new PokeBuilder(Element.BUG)
                .VulnerableTo(Element.FIRE, Element.ROCK, Element.FLY)
                .ResistantTo(Element.FIGHTING, Element.GRASS, Element.GROUND)
                .Build();

            PokemonType normal = new PokeBuilder(Element.NORMAL)
                .VulnerableTo(Element.FIGHTING)
                .ImmuneTo(Element.GHOST)
                .Build();

            PokemonType grass = new PokeBuilder(Element.GRASS)
                .VulnerableTo(Element.FIRE, Element.ICE, Element.BUG, Element.FLY, Element.POISON)
                .ResistantTo(Element.WATER, Element.THUNDER, Element.GRASS, Element.GROUND)
                .Build();

            PokemonType poison = new PokeBuilder(Element.POISON)
                .VulnerableTo(Element.GROUND, Element.PSY)
                .ResistantTo(Element.FIGHTING, Element.FAIRY, Element.BUG, Element.GRASS, Element.POISON)
                .Build();

            PokemonType psy = new PokeBuilder(Element.PSY)
                .VulnerableTo(Element.BUG, Element.GHOST, Element.DARK)
                .ResistantTo(Element.FIGHTING, Element.PSY)
                .Build();

            PokemonType rock = new PokeBuilder(Element.ROCK)
               .VulnerableTo(Element.STEEL, Element.FIGHTING, Element.WATER, Element.GRASS, Element.GROUND)
               .ResistantTo(Element.FIRE, Element.NORMAL, Element.POISON, Element.FLY)
               .Build();

            PokemonType ground = new PokeBuilder(Element.GROUND)
               .VulnerableTo(Element.WATER, Element.ICE, Element.GRASS)
               .ResistantTo(Element.POISON, Element.ROCK)
               .ImmuneTo(Element.THUNDER)
               .Build();

            PokemonType ghost = new PokeBuilder(Element.GHOST)
                 .VulnerableTo(Element.GHOST, Element.DARK)
                 .ResistantTo(Element.GRASS, Element.POISON)
                 .ImmuneTo(Element.NORMAL, Element.FIGHTING)
                 .Build();

            PokemonType dark = new PokeBuilder(Element.DARK)
                 .VulnerableTo(Element.FIGHTING, Element.FAIRY, Element.BUG)
                 .ResistantTo(Element.GHOST, Element.DARK)
                 .ImmuneTo(Element.PSY)
                 .Build();


            PokemonType fly = new PokeBuilder(Element.FLY)
                 .VulnerableTo(Element.THUNDER, Element.ICE, Element.PSY)
                 .ResistantTo(Element.FIGHTING, Element.BUG, Element.GRASS)
                 .ImmuneTo(Element.GROUND)
                 .Build();

            types.Add(steel); types.Add(fighting); types.Add(dark); types.Add(ground); types.Add(fairy); types.Add(fire); types.Add(water);
            types.Add(grass); types.Add(bug); types.Add(rock); types.Add(psy); types.Add(thunder); types.Add(ghost); types.Add(poison);
            types.Add(normal); types.Add(ice); types.Add(fly); types.Add(dragon);
        }

        private static void BuildAssociatedTypes(List<PokemonType> types)
        {
            //Test bi-elements
            PokemonType steel_fighting = new PokeBuilder(Element.STEEL, Element.FIGHTING)
                .VulnerableTo(Element.FIGHTING, Element.FIRE, Element.GROUND)
                .ResistantTo(Element.STEEL, Element.DRAGON, Element.ICE, Element.NORMAL, Element.GRASS, Element.DARK)
                .SuperResistantTo(Element.BUG)
                .ImmuneTo(Element.POISON)
                .Build();

            types.Add(steel_fighting);
        }
        


    }
}
