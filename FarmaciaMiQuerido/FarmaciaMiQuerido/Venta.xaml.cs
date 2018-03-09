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

namespace FarmaciaMiQuerido
{
    /// <summary>
    /// Lógica de interacción para Venta.xaml
    /// </summary>
    public partial class Venta : Window
    {
        RepositorioCliente repositorioCliente;
        RepositorioEmpleados repositorioEmpleados;
        RepositorioProductos repositorioProductos;
        Venta venta;

        public Venta()
        {
            InitializeComponent();

            repositorioCliente = new RepositorioCliente();
            repositorioEmpleados = new RepositorioEmpleados();
            repositorioProductos = new RepositorioProductos();
            venta = null;
            cmbProducto.ItemsSource = repositorioProductos.LeerProductos();
            cmbNombreCliente.ItemsSource = repositorioCliente.LeerClientes();
            cmbEmpleado.ItemsSource = repositorioEmpleados.LeerEmpleados();
            ActualizarTabla();
            BloquearBotones();
        }

        private void BloquearBotones()
        {
            btnAgregar.IsEnabled = false;
            btnCancelar.IsEnabled = false;
            btnComprar.IsEnabled = false;
            btnNuevo.IsEnabled = true;
            dtgTabla.IsEnabled = false;
            cmbEmpleado.IsEnabled = false;
            cmbNombreCliente.IsEnabled = false;
            cmbProducto.IsEnabled = false;
        }

        private void ActualizarTabla()
        {
            dtgTabla.ItemsSource = null;
           // dtgTabla.ItemsSource = repositorioVentas.ventas;

        }

        private void btnNuevo_Click(object sender, RoutedEventArgs e)
        {
            btnAgregar.IsEnabled = true;
            btnCancelar.IsEnabled = true;
            btnComprar.IsEnabled = true;
            btnNuevo.IsEnabled = true;
            dtgTabla.IsEnabled = true;
            cmbEmpleado.IsEnabled = true;
            cmbNombreCliente.IsEnabled = true;
            cmbProducto.IsEnabled = true;


        }

        private void DesbloquearBotones()
        {
            

        }
        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            venta = new Venta();
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
         


        }

        private void btnComprar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Venta exitosa ", "Venta exitosa", MessageBoxButton.OK, MessageBoxImage.Information);
          

        }
    }
}
