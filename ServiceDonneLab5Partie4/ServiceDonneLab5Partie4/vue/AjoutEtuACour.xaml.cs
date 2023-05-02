using ServiceDonneLab5Partie4.vue_model;
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
    /// Logique d'interaction pour AjoutEtuACour.xaml
    /// </summary>
    public partial class AjoutEtuACour : Window
    {

        ProgramVM vm;
        public AjoutEtuACour()
        {
            InitializeComponent();
            vm = new ProgramVM();
            this.DataContext = vm;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Prenom.Text != "" && Nom.Text != "")
            {
                vm.AjouterEtuCour(Prenom.Text, Nom.Text, Sigle.Text);
            }    
            else
            {
                vm.AjouterEtuCour("qwertyuipasdfghklxzcvbnmINVLIDCODEPERMANANTqwertyuiopasdfghjklzxcvbnm", "qwertyuipasdfghklxzcvbnmINVLIDCODEPERMANANTqwertyuiopasdfghjklzxcvbnm", "qwertyuipasdfghklxzcvbnmINVLIDCODEPERMANANTqwertyuiopasdfghjklzxcvbnm");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
