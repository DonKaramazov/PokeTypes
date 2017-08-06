using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace PokEvaluator
{
    public class Team : INotifyPropertyChanged
    {
        public static readonly string XML_FILE = "team.xml";

        //[XmlArrayItem("pokemon")]
        //public List<Pokemon> Pokemons { get; set; }

        private List<string> _pokemons;
        [XmlArrayItem("pokemon")]
        public List<String> Pokemons
        {
            get
            {
                //_pokemons = new List<string>() { _firstPokemon?.Name };
                return _pokemons;
            }
            set { _pokemons = value; OnPropertyChanged("Pokemons"); }
        }


        

        public Team()
        {

        }

        public Team(bool loadFromXml)
        {
            if (loadFromXml)
            {
                Team team = LoadTeam();
                Pokemons = team.Pokemons;
            }     
        }

        private Team LoadTeam()
        {
            XmlSerializer ser = new XmlSerializer(typeof(Team));
            Team team;
            try
            {
                using (XmlReader reader = XmlReader.Create(XML_FILE))
                {
                    team = (Team)ser.Deserialize(reader);
                }
            }
            catch (Exception)
            {
                //si le fichier n'existe pas on en créer un vide
                 team = CreateEmptyTeam(); 
            }

            return team;
        }

        private Team CreateEmptyTeam()
        {
            Team t = new Team(false)
            {
                Pokemons = new List<String>()
            };

            XmlSerializer xs = new XmlSerializer(typeof(Team));
            using (StreamWriter wr = new StreamWriter(XML_FILE))
            {
                xs.Serialize(wr, t);
            }

            return t;
        }

        public void Save()
        {

            XmlSerializer xs = new XmlSerializer(typeof(Team));
            using (StreamWriter wr = new StreamWriter(XML_FILE))
            {
                xs.Serialize(wr, this);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string caller)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(caller));
        }
    }
}
