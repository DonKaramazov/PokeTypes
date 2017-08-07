using PokEvaluator.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokEvaluator
{
    public class TeamViewModel : INotifyPropertyChanged
    {
        public Team Team { get; set; }

        private Pokemon _firstPokemon = null;
        public Pokemon FirstPokemon
        {
            get
            {
                return _firstPokemon ?? Pokedex.Pokemons.FirstOrDefault(p => p.Name.Equals(Team.Pokemons[0])); 
            }
            set
            {
                _firstPokemon = value;
                if (value != null)
                    Team.Pokemons[0] = value.Name;

                OnPropertyChanged("FirstPokemon");
            }
        }

        private Pokemon _secondPokemon = null;  
        public Pokemon SecondPokemon
        {
            get
            {
                return _secondPokemon ?? Pokedex.Pokemons.FirstOrDefault(p => p.Name.Equals(Team.Pokemons[1])); ;
            }
            set
            {
                _secondPokemon = value;
                if (value != null)
                    Team.Pokemons[1] = value.Name;

                OnPropertyChanged("SecondPokemon");
            }
        }

        private Pokemon _thirdPokemon;  
        public Pokemon ThirdPokemon
        {
            get
            {
                return _thirdPokemon ?? Pokedex.Pokemons.FirstOrDefault(p => p.Name.Equals(Team.Pokemons[2])); 
            }
            set
            {
                _thirdPokemon = value;
                if (value != null)
                    Team.Pokemons[2] = value.Name;

                OnPropertyChanged("ThirdPokemon");
            }
        }

        private Pokemon _forthPokemon;   
        public Pokemon ForthPokemon
        {
            get
            {
                return _forthPokemon ?? Pokedex.Pokemons.FirstOrDefault(p => p.Name.Equals(Team.Pokemons[3]));
            }
            set
            {
                _forthPokemon = value;
                if (value != null)
                    Team.Pokemons[3] = value.Name;

                OnPropertyChanged("ForthPokemon");
            }
        }

        private Pokemon _fifthPokemon;
        public Pokemon FifthPokemon
        {
            get
            {
                return _fifthPokemon ?? Pokedex.Pokemons.FirstOrDefault(p => p.Name.Equals(Team.Pokemons[4])); ;
            }
            set
            {
                _fifthPokemon = value;
                if (value != null)
                    Team.Pokemons[4] = value.Name;

                OnPropertyChanged("FifthPokemon");
            }
        }

        private Pokemon _sixthPokemon;
        public Pokemon SixthPokemon
        {
            get
            {
                return _sixthPokemon ?? Pokedex.Pokemons.FirstOrDefault(p => p.Name.Equals(Team.Pokemons[5])); ;
            }
            set
            {
                _sixthPokemon = value;
                if (value != null)
                    Team.Pokemons[5] = value.Name;

                OnPropertyChanged("SixthPokemon");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string caller)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(caller));
        }
    }
}
