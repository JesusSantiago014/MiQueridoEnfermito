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
    /// Lógica de interacción para Empleados.xaml
    /// </summary>

    public partial class Empleados : Window
    {
        RepositorioEmpleados repositorio;
        bool esNuevo;
        public Empleados()
        {
            InitializeComponent();
            repositorio = new RepositorioEmpleados();
            HabilitarCajas(false);
            HabilitarBotones(true);
            ActualizarTabla();
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
            txbNombreEmpleado.Clear();
            txbSexo.Clear();

            txbNombreEmpleado.IsEnabled = habilitadas;
            txbSexo.IsEnabled = habilitadas;

        }

        private void btnNuevo_Click(object sender, RoutedEventArgs e)
        {
            HabilitarCajas(true);
            HabilitarBotones(false);
            esNuevo = true;

        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txbNombreEmpleado.Text) || string.IsNullOrEmpty(txbSexo.Text))
            {
                MessageBox.Show("Faltan datos", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }

            if (esNuevo)
            {

                Empleado a = new Empleado()
                {
                    NombreEmpleado = txbNombreEmpleado.Text,
                    Sexo = txbSexo.Text

                };
                if (repositorio.AgregarEmpleado(a))
                {
                    MessageBox.Show("Guardado con Éxito", "Nombre", MessageBoxButton.OK, MessageBoxImage.Information);
                    ActualizarTabla();
                    HabilitarBotones(true);
                    HabilitarCajas(false);
                }
                else
                {
                    MessageBox.Show("Error al guardar a el empleado", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                Empleado original = dtgTabla.SelectedItem as Empleado;
                Empleado a = new Empleado();
                a.NombreEmpleado = txbNombreEmpleado.Text;
                a.Sexo = txbSexo.Text;
                if (repositorio.ModificarEmpleado(original, a))
                {
                    HabilitarBotones(true);
                    HabilitarCajas(false);
                    ActualizarTabla();
                    MessageBox.Show("El empleado a sido actualizado", ".", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Error al guardar a el empleado", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

        }



        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
            if (repositorio.LeerEmpleados().Count == 0)
            {
                MessageBox.Show("No tienes Empleados aun...", "No tienes empleados", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (dtgTabla.SelectedItem != null)
                {
                    Empleado a = dtgTabla.SelectedItem as Empleado;
                    HabilitarCajas(true);
                    txbNombreEmpleado.Text = a.NombreEmpleado;
                    txbSexo.Text = a.Sexo;

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
        private void ActualizarTabla()
        {
            dtgTabla.ItemsSource = null;
            dtgTabla.ItemsSource = repositorio.LeerEmpleados();
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if (repositorio.LeerEmpleados().Count == 0)
            {
                MessageBox.Show("No tienes Empleados...", "No tienes empleados", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (dtgTabla.SelectedItem != null)
                {
                    Empleado a = dtgTabla.SelectedItem as Empleado;
                    if (MessageBox.Show("Realmente deseas eliminar a " + a.NombreEmpleado + "?", "Eliminar????", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        if (repositorio.EliminarEmpleado(a))
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
