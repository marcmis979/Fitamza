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

namespace Fitamza
{
    /// <summary>
    /// Logika interakcji dla klasy MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        public MainMenu()
        {
            InitializeComponent();
            lbPlany.Items.Add("Cardio");
            lbPlany.Items.Add("Masa");
        }
        void lbPlany_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //wejdź w aktualny plan do wykonania

        }

        private void btnZacznijTrening_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
