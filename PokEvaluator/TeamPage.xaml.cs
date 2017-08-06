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
        public Team team = new Team(true);
        public TeamViewModel viewModel = new TeamViewModel();

        public List<Pokemon> Pokemons
        {
            get { return Pokedex.Pokemons; }
        }

        public TeamPage()
        {
            InitializeComponent();
          
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            viewModel.Team = team;
            DataContext = viewModel;
            AddHandlers();
            InitChamps();
        }

        /// <summary>
        /// Solution temporaire au binding qui foire
        /// </summary>
        private void InitChamps()
        {
            cbxFirstPokemon.SelectedValue = viewModel.FirstPokemon != null ? viewModel.FirstPokemon.Name : String.Empty;
            cbxSecondPokemon.SelectedValue = viewModel.SecondPokemon != null ? viewModel.SecondPokemon.Name : String.Empty;
            cbxThirdPokemon.SelectedValue = viewModel.ThirdPokemon != null ? viewModel.ThirdPokemon.Name : String.Empty;
            cbxForthPokemon.SelectedValue = viewModel.ForthPokemon != null ? viewModel.ForthPokemon.Name : String.Empty;
            cbxFifthPokemon.SelectedValue = viewModel.FifthPokemon != null ? viewModel.FifthPokemon.Name : String.Empty;
            cbxSixthPokemon.SelectedValue = viewModel.SixthPokemon != null ? viewModel.SixthPokemon.Name : String.Empty;
        }

        private void AddHandlers()
        {
            cbxFirstPokemon.SelectionChanged += (sender,ev) =>{ SetItemsSource(((ComboBox)sender).SelectedItem as Pokemon, icFirst); };
            cbxSecondPokemon.SelectionChanged += (sender, ev) => { SetItemsSource(((ComboBox)sender).SelectedItem as Pokemon, icSecond); };
            cbxThirdPokemon.SelectionChanged += (sender, ev) => { SetItemsSource(((ComboBox)sender).SelectedItem as Pokemon, icThird); };
            cbxForthPokemon.SelectionChanged += (sender, ev) => { SetItemsSource(((ComboBox)sender).SelectedItem as Pokemon, icForth); };
            cbxFifthPokemon.SelectionChanged += (sender, ev) => { SetItemsSource(((ComboBox)sender).SelectedItem as Pokemon, icFifth); };
            cbxSixthPokemon.SelectionChanged += (sender, ev) => { SetItemsSource(((ComboBox)sender).SelectedItem as Pokemon, icSixth); };

            //Save team
            btnSave.Click += (_, __) =>
            {
                try
                {
                    team.Save();
                    MessageBox.Show("Team saved!", "Save", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Oups ! an error occured during the saving : " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            };
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
