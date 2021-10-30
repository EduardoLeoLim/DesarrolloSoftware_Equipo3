using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SistemaProgramacionDeRadio.vista
{
    /// <summary>
    /// Lógica de interacción para GUI_InicioSesion.xaml
    /// </summary>
    public partial class GUI_InicioSesion : Window
    {
        public GUI_InicioSesion()
        {
            InitializeComponent();
        }

        private void IniciarSesion(object sender, RoutedEventArgs e)
        {

            //Reemplazar
            GUI_MenuPrincipal gui_MenuPrincipal = new GUI_MenuPrincipal();
            gui_MenuPrincipal.Show();
            this.Close();
        }
    }
}
