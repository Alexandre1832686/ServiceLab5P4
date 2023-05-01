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
    /// Logique d'interaction pour CreerCour.xaml
    /// </summary>
    public partial class CreerCour : Window
    {
        ProgramVM vm;
        public CreerCour()
        {
            InitializeComponent();
            vm = new ProgramVM();
            this.DataContext = vm;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Sigle.Text != "" && Duree.Text != "" && Titre.Text != "")
                vm.CreeCour(Sigle.Text,Duree.Text,Titre.Text);
            else
                vm.CreeCour("qwertyuipasdfghklxzcvbnmINVLIDCODEPERMANANTqwertyuiopasdfghjklzxcvbnm", "qwertyuipasdfghklxzcvbnmINVLIDCODEPERMANANTqwertyuiopasdfghjklzxcvbnm", "qwertyuipasdfghklxzcvbnmINVLIDCODEPERMANANTqwertyuiopasdfghjklzxcvbnm");

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
