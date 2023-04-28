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
using System.Windows.Shapes;

namespace ServiceDonneLab5Partie4.vue
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RecupererNomEtu(object sender, RoutedEventArgs e)
        {
            RecupererNom rn = new RecupererNom();
            rn.Show();
        }

        private void RecupererCourEtu(object sender, RoutedEventArgs e)
        {
            RecupererCoursParEtu rcpe = new RecupererCoursParEtu();
            rcpe.Show();
        }

        private void ListeEtuCour(object sender, RoutedEventArgs e)
        {
            RecupererEtuParCour repc = new RecupererEtuParCour();
            repc.Show();
        }

        private void RecupererCourProf(object sender, RoutedEventArgs e)
        {
            RecupererCourParProf rcpp = new RecupererCourParProf();
            rcpp.Show();
        }

        private void RecupererBuletinEtu(object sender, RoutedEventArgs e)
        {
            RecupererBuletin rb = new RecupererBuletin();
            rb.Show();
        }

        private void RecupererDiplome(object sender, RoutedEventArgs e)
        {
            RecupererDiplomeParAnnee rdpa = new RecupererDiplomeParAnnee();
            rdpa.Show();
        }

        private void CreateCour(object sender, RoutedEventArgs e)
        {
            CreerCour cc = new CreerCour();
            cc.Show();
        }

        private void AjoutEtuCour(object sender, RoutedEventArgs e)
        {
            AjoutEtuACour aeac = new AjoutEtuACour();
            aeac.Show();
        }

        private void ModifieNote(object sender, RoutedEventArgs e)
        {
            ModifierNote mn = new ModifierNote();
            mn.Show();
        }

        private void SuppEtu(object sender, RoutedEventArgs e)
        {
           RetirerEtuDeCour redc = new RetirerEtuDeCour();
            redc.Show();
        }

        private void Parametres(object sender, RoutedEventArgs e)
        {
            Parametre p = new Parametre();
            p.Show();
        }
    }
}
