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

namespace SistemaProgramacionDeRadio.recursos.controles_WPF
{
    /// <summary>
    /// Lógica de interacción para BotonMenu.xaml
    /// </summary>
    public partial class BotonMenu : UserControl
    {
        public BotonMenu()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public String Text { get; set; }
        public String SourceImage { get; set; }


        public event RoutedEventHandler Click
        {
            add { AddHandler(MouseUpEvent, value); }
            remove { RemoveHandler(MouseUpEvent, value); }
        }
    }
}
