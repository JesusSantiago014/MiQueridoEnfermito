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
    /// Lógica de interacción para Clientes.xaml
    /// </summary>
    public partial class Clientes : Window
    {
        RepositorioCliente repositorio;
        bool esNuevo;
        public Clientes()
        {
            InitializeComponent();
            repositorio = new RepositorioCliente();
            HabilitarCajas(false);
            HabilitarBotones(true);
            ActualizarTabla();

        }

        private void ActualizarTabla()
        {
            dtgTabla1.ItemsSource = null;
            dtgTabla1.ItemsSource = repositorio.LeerClientes();
        }

        private void HabilitarBotones(bool habilitados)
        {
            btnNuevo.IsEnabled = habilitados;
            btnEditar.IsEnabled = habilitados;
            btnEliminar.IsEnabled = habilitados;
            btnGuardar.IsEnabled = !habilitados;
            btnCancelar.IsEnabled = !habilitados;

        }

        private void HabilitarCajas(bool habilitadas)
        {
            txbApellido.Clear();
            txbRFC.Clear();
            txbCorreo.Clear();
            txbDireccion.Clear();
            txbNombre.Clear();
            txbTelefono.Clear();
            txbApellido.IsEnabled = habilitadas;
            txbCorreo.IsEnabled = habilitadas;
            txbNombre.IsEnabled = habilitadas;
            txbRFC.IsEnabled = habilitadas;
            txbTelefono.IsEnabled = habilitadas;
        }

        private void btnNuevo_Click(object sender, RoutedEventArgs e)
        {
            HabilitarCajas(true);
            HabilitarBotones(false);
            esNuevo = true;
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrEmpty(txbNombre.Text) || string.IsNullOrEmpty(txbApellido.Text) || string.IsNullOrEmpty(txbRFC.Text))
            {
                MessageBox.Show("Faltan datos", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }

            if (esNuevo)
            {

                Cliente a = new Cliente()
                {
                    Apellidos = txbApellido.Text,
                    RFC = txbRFC.Text,
                    Email = txbCorreo.Text,
                    Direccion=txbDireccion.Text,
                    Nombre = txbNombre.Text,
                    Telefono = txbTelefono.Text
                };
                if (repositorio.AgregarCliente(a))
                {
                    MessageBox.Show("Guardado con Éxito", "Nombre", MessageBoxButton.OK, MessageBoxImage.Information);
                    ActualizarTabla();
                    HabilitarBotones(true);
                    HabilitarCajas(false);
                }
                else
                {
                    MessageBox.Show("Error al guardar a el cliente, contactarte a ti mismo ya que tu hiciste este programa", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                Cliente original = dtgTabla1.SelectedItem as Cliente;
                Cliente a = new Cliente();
                a.Apellidos = txbApellido.Text;
                a.RFC = txbRFC.Text;
                a.Email = txbCorreo.Text;
                a.Nombre = txbNombre.Text;
                a.Direccion = txbDireccion.Text;
                a.Telefono = txbTelefono.Text;
                if (repositorio.ModificarCliente(original, a))
                {
                    HabilitarBotones(true);
                    HabilitarCajas(false);
                    ActualizarTabla();
                    MessageBox.Show("El cliente a sido actualizado", "Compas", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Error al guardar a el cliente, contactarte a ti mismo ya que tu hiciste este programa", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

        }


       
        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
            if (repositorio.LeerClientes().Count == 0)
            {
                MessageBox.Show("No tienes clientes aun...", "No tienes clientes", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (dtgTabla1.SelectedItem != null)
                {
                    Cliente a = dtgTabla1.SelectedItem as Cliente;
                    HabilitarCajas(true);
                    txbApellido.Text = a.Apellidos;
                    txbRFC.Text = a.RFC;
                    txbCorreo.Text = a.Email;
                    txbNombre.Text = a.Nombre;
                    txbTelefono.Text = a.Telefono;
                    txbDireccion.Text = a.Direccion;
                    HabilitarBotones(false);
                    esNuevo = false;
                }
                else
                {
                    MessageBox.Show("¿A Quien???", "Compa", MessageBoxButton.OK, MessageBoxImage.Question);
                }
            }


        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            HabilitarCajas(false);
            HabilitarBotones(true);


        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if (repositorio.LeerClientes().Count == 0)
            {
                MessageBox.Show("No tienes clientes...", "No tienes clientes", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (dtgTabla1.SelectedItem != null)
                {
                    Cliente a = dtgTabla1.SelectedItem as Cliente;
                    if (MessageBox.Show("Realmente deseas eliminar a " + a.Nombre + "?", "Eliminar????", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        if (repositorio.EliminarCliente(a))
                        {
                            MessageBox.Show("Tu cliente ha sido removido", "cliente", MessageBoxButton.OK, MessageBoxImage.Information);
                            ActualizarTabla();
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar al cliente", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("¿A Quien???", ".", MessageBoxButton.OK, MessageBoxImage.Question);
                }
            }
        }
    }
}
