using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace P_IComparable_StephanieLopez
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Creature> GetCreatures = new List<Creature>();
        public MainWindow()
        {
            InitializeComponent();
            PreLoadList();
            DisplayCreature(GetCreatures, LB_Display);
            RB_ASD.IsChecked = true;
        }

        void PreLoadList()
        {
            GetCreatures.Add(new Creature("Griffin", "Air"));
            GetCreatures.Add(new Creature("Orge", "Earth"));
            GetCreatures.Add(new Creature("Goblin", "N/a"));
            GetCreatures.Add(new Creature("Vampire", "Gravity"));
            GetCreatures.Add(new Creature("Werewolf", "Darkness"));
            GetCreatures.Add(new Creature("Fairy", "Fire"));
            GetCreatures.Add(new Creature("Siren", "Water"));
            GetCreatures.Add(new Creature("Centaur", "Air"));
            GetCreatures.Add(new Creature("Phoenix", "Earth"));
            GetCreatures.Add(new Creature("Fairy", "Nature"));
        }

        public void DisplayCreature(List<Creature> Creaturelist, ListBox listBox)
        {
            listBox.Items.Clear();

            foreach (Creature creature in Creaturelist)
            {
                listBox.Items.Add(creature);
            }
        }

        private void B_Creature_Click(object sender, RoutedEventArgs e)
        {
            GetCreatures.Sort();
            DisplayCreature(GetCreatures, LB_Display);
        }

        private void B_Element_Click(object sender, RoutedEventArgs e)
        {
            Element.SortingOrder order = Element.SortingOrder.Ascending;

            if (!RB_ASD.IsChecked.Value)
            {
                order = Element.SortingOrder.Descending;
            }

            Element Elementsort = new Element(order);
            GetCreatures.Sort(Elementsort);
            DisplayCreatureinfo();
        }

        private void B_Potency_Click(object sender, RoutedEventArgs e)
        {
            Potency.SortingOrder order = Potency.SortingOrder.Ascending;

            if (!RB_ASD.IsChecked.Value)
            {
                order = Potency.SortingOrder.Descending;
            }

            Potency Potencysort = new Potency(order);
            GetCreatures.Sort(Potencysort);
            DisplayCreatureinfo();
        }

        public void DisplayCreatureinfo()
        {
            DisplayCreature(GetCreatures, LB_Display);
        }
    }
}