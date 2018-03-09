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

namespace FarmaciaMiQuerido
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnProductos_Click(object sender, RoutedEventArgs e)
        {

            Productos NuevaVentana = new Productos();
            NuevaVentana.Show();
        }

        private void btnCliente_Click(object sender, RoutedEventArgs e)
        {
            Clientes NuevaVentana = new Clientes();
            NuevaVentana.Show();
        }

        private void btnVenta_Click(object sender, RoutedEventArgs e)
        {
            Venta NuevaVentana = new Venta();
            NuevaVentana.Show();
        }

        private void btnEmpleados_Click(object sender, RoutedEventArgs e)
        {
            Empleados NuevaVentana = new Empleados();
            NuevaVentana.Show();

        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
