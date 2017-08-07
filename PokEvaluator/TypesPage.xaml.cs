using PokEvaluator.Objects;
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

    public partial class TypesPage : Page
    {
        private PokemonViewModel viewModel = new PokemonViewModel();

        public TypesPage()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cbxPokemons.ItemsSource = Pokedex.Pokemons;
            cbxPokemons.SelectionChanged += CbxPokemons_SelectionChanged;
            cbxPokemons.SelectedIndex = 0;
        }

        void CbxPokemons_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Pokemon selectedPokemon = cbxPokemons.SelectedItem as Pokemon;
            if (selectedPokemon == null)
                return;

            DataContext = new PokemonViewModel(selectedPokemon);



        }
    }
}
