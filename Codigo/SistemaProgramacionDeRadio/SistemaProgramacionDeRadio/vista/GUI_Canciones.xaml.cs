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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SistemaProgramacionDeRadio.vista
{
    /// <summary>
    /// Lógica de interacción para GUI_Canciones.xaml
    /// </summary>
    public partial class GUI_Canciones : Page
    {
        public GUI_Canciones()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GUI_Categorias gUI_Categorias = new GUI_Categorias();
            gUI_Categorias.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            GUI_Generos gUI_Generos = new GUI_Generos();
            gUI_Generos.ShowDialog();
        }
    }
}
