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

namespace BIndingsList
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Persona> ListaPersona { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            ListaPersona = new List<Persona>();
            ListaPersona.Add(new Persona("Elver", "Gudo"));
            ListaPersona.Add(new Persona("Elma", "Ricon"));
            this.DataContext = this;
        }
    }
}
