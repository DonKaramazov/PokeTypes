using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PokEvaluator
{ 
    public partial class TeamPage : Page
    {

        public List<Pokemon> Pokemons
        {
            get { return Pokedex.Pokemons; }
        }

        public TeamPage()
        {
            InitializeComponent();
            DataContext = this;
            AddHandlers();
        }
    

        private void AddHandlers()
        {
            cbxFirstPokemon.SelectionChanged += (sender,ev) =>{ SetItemsSource(((ComboBox)sender).SelectedItem as Pokemon, icFirst); };
            cbxSecondPokemon.SelectionChanged += (sender, ev) => { SetItemsSource(((ComboBox)sender).SelectedItem as Pokemon, icSecond); };
            cbxThirdPokemon.SelectionChanged += (sender, ev) => { SetItemsSource(((ComboBox)sender).SelectedItem as Pokemon, icThird); };
            cbxForthPokemon.SelectionChanged += (sender, ev) => { SetItemsSource(((ComboBox)sender).SelectedItem as Pokemon, icForth); };
            cbxFifthPokemon.SelectionChanged += (sender, ev) => { SetItemsSource(((ComboBox)sender).SelectedItem as Pokemon, icFifth); };
            cbxSixthPokemon.SelectionChanged += (sender, ev) => { SetItemsSource(((ComboBox)sender).SelectedItem as Pokemon, icSixth); };
        }


        private void SetItemsSource(Pokemon pokemon , ItemsControl ic)
        {
            if (pokemon == null)
                return;


            List<Element> source = new List<Element>();
            source.Add(pokemon.Element);

            if (pokemon.Element2.HasValue)
                source.Add(pokemon.Element2.Value);

            ic.ItemsSource = source;
        }
    }
}
