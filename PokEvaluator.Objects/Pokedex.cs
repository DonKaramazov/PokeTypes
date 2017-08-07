using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokEvaluator.Objects
{
    public static class Pokedex
    {
        #region Properties
        private static List<PokemonType> _pokemonTypes = null;
        public static List<PokemonType> PokemonTypes
        {
            get
            {
                if (_pokemonTypes == null)
                    _pokemonTypes = GetAllPokemonTypes();

                return _pokemonTypes;
            }
        }

        private static List<Pokemon> _pokemons = null;
        public static List<Pokemon> Pokemons
        {
            get
            {
                if(_pokemons == null)
                    _pokemons = GetAllPokemons();

                return _pokemons;
            }
        } 
        #endregion

        private static List<Pokemon> GetAllPokemons()
        {
            List<Pokemon> pokemons = new List<Pokemon>();

            pokemons.AddRange(FirePokemons.GetAllPokemons());
            pokemons.AddRange(SteelPokemons.GetAllPokemons());
            GetGrassPokemons(pokemons);
            GetDragonPokemons(pokemons);


            return pokemons.OrderBy(p => p.Name).ToList();
        }

        private static void GetDragonPokemons(List<Pokemon> pokemons)
        {
            pokemons.Add(new Pokemon("Dragonite", Element.DRAGON));
            pokemons.Add(new Pokemon("Charizard", Element.DRAGON));
        }

      

        private static void GetGrassPokemons(List<Pokemon> pokemons)
        {
            pokemons.Add(new Pokemon("Bulbizare", Element.GRASS));
            pokemons.Add(new Pokemon("Bulbifleure", Element.GRASS));
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
            BuildSteelAssociatedTypes(types);
        }

        /// <summary>
        /// Add steel & association types
        /// Amount of pokemons : 37 (5,13%)
        /// </summary>
        /// <param name="types"></param>
        private static void BuildSteelAssociatedTypes(List<PokemonType> types)
        {
            //fighting -- 2 pokemons
            types.Add(new PokeBuilder(Element.STEEL, Element.FIGHTING)
              .VulnerableTo(Element.FIGHTING, Element.FIRE, Element.GROUND)
              .ResistantTo(Element.STEEL, Element.DRAGON, Element.ICE, Element.NORMAL, Element.GRASS, Element.DARK)
              .SuperResistantTo(Element.BUG)
              .ImmuneTo(Element.POISON)
              .Build());

            //dragon -- 1 pokemon
            types.Add(new PokeBuilder(Element.STEEL, Element.DRAGON)
              .VulnerableTo(Element.FIGHTING, Element.GROUND)
              .ResistantTo(Element.STEEL, Element.WATER, Element.THUNDER, Element.BUG, Element.NORMAL, Element.PSY, Element.ROCK, Element.FLY)
              .SuperResistantTo(Element.GRASS)
              .ImmuneTo(Element.POISON)
              .Build());

            //water -- 1 pokemon
            types.Add(new PokeBuilder(Element.STEEL, Element.WATER)
            .VulnerableTo(Element.FIGHTING, Element.GROUND, Element.THUNDER)
            .ResistantTo(Element.DRAGON, Element.WATER, Element.FAIRY, Element.BUG, Element.NORMAL, Element.PSY, Element.ROCK, Element.FLY)
            .SuperResistantTo(Element.STEEL, Element.ICE)
            .ImmuneTo(Element.POISON)
            .Build());

            //thunder -- 3 pokemons
            types.Add(new PokeBuilder(Element.STEEL, Element.THUNDER)
            .SuperVulnerableTo(Element.GROUND)
            .VulnerableTo(Element.FIGHTING, Element.FIRE)
            .ResistantTo(Element.DRAGON, Element.THUNDER, Element.FAIRY, Element.ICE, Element.BUG, Element.NORMAL, Element.GRASS, Element.PSY, Element.ROCK)
            .SuperResistantTo(Element.STEEL, Element.FLY)
            .ImmuneTo(Element.POISON)
            .Build());

            //fairy -- 2 pokemons
            types.Add(new PokeBuilder(Element.STEEL, Element.FAIRY)
            .VulnerableTo(Element.FIRE, Element.GROUND)
            .ResistantTo(Element.FAIRY, Element.ICE, Element.NORMAL,Element.GRASS, Element.PSY, Element.ROCK,Element.DARK, Element.FLY)
            .SuperResistantTo(Element.BUG)
            .ImmuneTo(Element.POISON,Element.DRAGON)
            .Build());

            //fire -- 1 pokemon
            types.Add(new PokeBuilder(Element.STEEL, Element.FIRE)
            .SuperVulnerableTo(Element.GROUND)
            .VulnerableTo(Element.FIGHTING,Element.WATER)
            .ResistantTo(Element.DRAGON,Element.NORMAL, Element.PSY, Element.FLY)
            .SuperResistantTo(Element.STEEL,Element.FAIRY,Element.ICE,Element.BUG,Element.GRASS)
            .ImmuneTo(Element.POISON)
            .Build());

            //ice -- none
            types.Add(new PokeBuilder(Element.STEEL, Element.ICE)
            .SuperVulnerableTo(Element.FIGHTING,Element.FIRE)
            .VulnerableTo(Element.GROUND)
            .ResistantTo(Element.DRAGON, Element.FAIRY, Element.BUG, Element.NORMAL,Element.GRASS, Element.PSY, Element.FLY)
            .SuperResistantTo(Element.ICE)
            .ImmuneTo(Element.POISON)
            .Build());

            //bug -- 5 pokemons
            types.Add(new PokeBuilder(Element.STEEL, Element.BUG)
            .SuperVulnerableTo(Element.FIRE)
            .ResistantTo(Element.STEEL, Element.DRAGON, Element.FAIRY,Element.ICE, Element.BUG, Element.NORMAL, Element.PSY)
            .SuperResistantTo(Element.GRASS)
            .ImmuneTo(Element.POISON)
            .Build());

            //grass -- 2 pokemons
            types.Add(new PokeBuilder(Element.STEEL, Element.GRASS)
            .SuperVulnerableTo(Element.FIRE)
            .VulnerableTo(Element.FIGHTING)
            .ResistantTo(Element.STEEL,Element.DRAGON, Element.WATER, Element.THUNDER,Element.FAIRY, Element.NORMAL, Element.PSY, Element.ROCK)
            .SuperResistantTo(Element.GRASS)
            .ImmuneTo(Element.POISON)
            .Build());

            //psy -- 6 pokemons
            types.Add(new PokeBuilder(Element.STEEL, Element.PSY)
            .VulnerableTo(Element.FIRE, Element.GROUND,Element.GHOST,Element.DARK)
            .ResistantTo(Element.STEEL,Element.DRAGON,Element.FAIRY,Element.ICE,Element.NORMAL,Element.GRASS, Element.ROCK, Element.FLY)
            .SuperResistantTo(Element.PSY)
            .ImmuneTo(Element.POISON)
            .Build());

            //rock -- 6 pokemons
            types.Add(new PokeBuilder(Element.STEEL, Element.ROCK)
            .SuperVulnerableTo(Element.FIGHTING,Element.GROUND)
            .VulnerableTo(Element.WATER)
            .ResistantTo(Element.DRAGON, Element.FAIRY, Element.ICE, Element.BUG, Element.PSY, Element.ROCK)
            .SuperResistantTo(Element.NORMAL,Element.FLY)
            .ImmuneTo(Element.POISON)
            .Build());

            //ground -- 2 pokemons
            types.Add(new PokeBuilder(Element.STEEL, Element.GROUND)
            .VulnerableTo(Element.FIGHTING,Element.WATER,Element.GROUND)
            .ResistantTo(Element.STEEL, Element.DRAGON, Element.FAIRY, Element.BUG, Element.NORMAL, Element.PSY, Element.FLY)
            .SuperResistantTo(Element.ROCK)
            .ImmuneTo(Element.THUNDER,Element.POISON)
            .Build());

            //ghost -- 3 pokemons
            types.Add(new PokeBuilder(Element.STEEL, Element.GHOST)
            .VulnerableTo(Element.FIRE, Element.GROUND,Element.GHOST,Element.GHOST)
            .ResistantTo(Element.STEEL, Element.DRAGON,Element.FAIRY,Element.ICE,Element.GRASS,Element.PSY, Element.ROCK, Element.FLY)
            .SuperResistantTo(Element.BUG)
            .ImmuneTo(Element.NORMAL,Element.POISON)
            .Build());
        
            //dark -- 2 pokemons
            types.Add(new PokeBuilder(Element.STEEL, Element.DARK)
            .SuperVulnerableTo(Element.FIGHTING)
            .VulnerableTo(Element.GROUND)
            .ResistantTo(Element.STEEL, Element.DRAGON, Element.ICE, Element.NORMAL, Element.GRASS, Element.ROCK,Element.GHOST,Element.DARK, Element.FLY)
            .ImmuneTo(Element.POISON,Element.PSY)
            .Build());

            //fly -- 1 pokemon
            types.Add(new PokeBuilder(Element.STEEL, Element.FLY)
            .VulnerableTo(Element.THUNDER, Element.FIRE)
            .ResistantTo(Element.STEEL, Element.DRAGON, Element.FAIRY, Element.NORMAL, Element.PSY, Element.FLY)
            .SuperResistantTo(Element.BUG, Element.GRASS)
            .ImmuneTo(Element.POISON,Element.GROUND)
            .Build());
        }
    }
}
