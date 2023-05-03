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
    /// Logique d'interaction pour CreerTravail.xaml
    /// </summary>
    public partial class CreerTravail : Window
    {
        ProgramVM vm;
        public CreerTravail()
        {
            InitializeComponent();
            vm = new ProgramVM();
            this.DataContext = vm;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool check = true;
            DateTime d = new DateTime();
            int p = 0;
            try
            {
                 d = new DateTime(Convert.ToInt32(DateRemise.Text));
            }
            catch(Exception ex)
            {
                check = false;
                Message m = new Message("Format de date invalide");
                m.Show();
            }

            try
            {
               p=Convert.ToInt32(Ponderation.Text);
            }
            catch (Exception ex)
            {
                check = false;

                Message m = new Message("ponderation doit être un chiffre");
                m.Show();
            }

            if (check)
                vm.CreerTravail(p, d);
            

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
