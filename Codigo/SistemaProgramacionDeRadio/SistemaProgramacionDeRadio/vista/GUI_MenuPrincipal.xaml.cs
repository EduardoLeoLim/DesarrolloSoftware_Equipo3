using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Lógica de interacción para GUI_MenuPrincipal.xaml
    /// </summary>
    public partial class GUI_MenuPrincipal : Window
    {
        private GUI_Programas gui_Programas;
        private GUI_Cantantes gui_Cantantes;
        private GUI_Canciones gui_Canciones;
        private GUI_Patrones gui_Patrones;
        private GUI_ProgramacionDiaria gui_ProgramacionDiaria;
        private GUI_Usuarios gui_Usuarios;

        public GUI_MenuPrincipal()
        {
            InitializeComponent();
            gui_Programas = new GUI_Programas();
            gui_Cantantes = new GUI_Cantantes();
            gui_Canciones = new GUI_Canciones();
            gui_Patrones = new GUI_Patrones();
            gui_ProgramacionDiaria = new GUI_ProgramacionDiaria();
            gui_Usuarios = new GUI_Usuarios();
        }

        private void MostrarGUIProgramas(object sender, RoutedEventArgs e)
        {
            pnlPrincipal.Navigate(gui_Programas);
        }

        private void MostrarGUICantantes(object sender, RoutedEventArgs e)
        {
            pnlPrincipal.Navigate(gui_Cantantes);
        }

        private void MostrarGUICanciones(object sender, RoutedEventArgs e)
        {
            pnlPrincipal.Navigate(gui_Canciones);
        }

        private void MostrarGUIPatrones(object sender, RoutedEventArgs e)
        {
            pnlPrincipal.Navigate(gui_Patrones);
        }

        private void MostrarGUIProgramacionDiaria(object sender, RoutedEventArgs e)
        {
            pnlPrincipal.Navigate(gui_ProgramacionDiaria);
        }

        private void MostrarGUIUsuarios(object sender, RoutedEventArgs e)
        {
            pnlPrincipal.Navigate(gui_Usuarios);
        }

        private void CerrarSesion(object sender, RoutedEventArgs e)
        {
            GUI_InicioSesion gui_InicioSesion = new GUI_InicioSesion();
            gui_InicioSesion.Show();
            this.Close();
        }
    }
}
