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
    /// Lógica de interacción para Productos.xaml
    /// </summary>
    public partial class Productos : Window
    {
        RepositorioProductos repositorio;
        bool esNuevo;
        public Productos()
        {
            InitializeComponent();
            repositorio = new RepositorioProductos();
            HabilitarCajas(false);
            HabilitarBotones(true);
            ActualizarTabla();
        }

        private void HabilitarCajas(bool habilitadas)
        {
            txbNombre.Clear();
            txbCategoria.Clear();
            txbDescripcion.Clear();
            txbPcompra.Clear();
            txbPventa.Clear();
            txbActual.Clear();
            txbNombre.IsEnabled = habilitadas;
            txbCategoria.IsEnabled = habilitadas;
            txbDescripcion.IsEnabled = habilitadas;
            txbPventa.IsEnabled = habilitadas;
            txbActual.IsEnabled = habilitadas;
        }
        private void HabilitarBotones(bool habilitados)
        {
            btnNuevo.IsEnabled = habilitados;
            btnEditar.IsEnabled = habilitados;
            btnEliminar.IsEnabled = habilitados;
            btnGuardar.IsEnabled = !habilitados;
            btnCancelar.IsEnabled = !habilitados;
        }

        private void btnNuevo_Click(object sender, RoutedEventArgs e)
        {
            HabilitarCajas(true);
            HabilitarBotones(false);
            esNuevo = true;
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txbNombre.Text) || string.IsNullOrEmpty(txbNombre.Text) || string.IsNullOrEmpty(txbCategoria.Text))
            {
                MessageBox.Show("Faltan datos", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }

            if (esNuevo)
            {

                Producto a = new Producto()
                {
                    Mercancia = txbNombre.Text,
                    Categoria = txbCategoria.Text,
                    Descripcion = txbDescripcion.Text,
                    PrecioC = txbPcompra.Text,
                    PrecioV = txbPventa.Text,
                    ProductoE = txbActual.Text
                };
                if (repositorio.AgregarProducto(a))
                {
                    MessageBox.Show("Guardado con Éxito", "producto", MessageBoxButton.OK, MessageBoxImage.Information);
                    ActualizarTabla();
                    HabilitarBotones(true);
                    HabilitarCajas(false);
                }
                else
                {
                    MessageBox.Show("Error al guardar el producto", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                Producto original = dtgTabla.SelectedItem as Producto;
                Producto a = new Producto();
                a.Mercancia = txbNombre.Text;
                a.Categoria = txbCategoria.Text;
                a.Descripcion = txbDescripcion.Text;
                a.PrecioC = txbPcompra.Text;
                a.PrecioV = txbPventa.Text;
                a.ProductoE = txbActual.Text;
                
                if (repositorio.ModificarProducto(original, a))
                {
                    HabilitarBotones(true);
                    HabilitarCajas(false);
                    ActualizarTabla();
                    MessageBox.Show("El producto a sido actualizado", "Producto actualizado", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Error al guardar EL producto", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }


        }

        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
            if (repositorio.LeerProductos().Count == 0)
            {
                MessageBox.Show("error...", "No tienes productos", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (dtgTabla.SelectedItem != null)
                {
                    Producto a = dtgTabla.SelectedItem as Producto;
                    HabilitarCajas(true);
                    txbNombre.Text = a.Mercancia;
                    txbCategoria.Text = a.Categoria;
                    txbDescripcion.Text = a.Descripcion;
                    txbPventa.Text = a.PrecioV;
                    txbPcompra.Text = a.PrecioC;
                    txbActual.Text = a.ProductoE;

                    HabilitarBotones(false);
                    esNuevo = false;
                }
                else
                {
                    MessageBox.Show("¿A Quien???", ".", MessageBoxButton.OK, MessageBoxImage.Question);
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
            dtgTabla.ItemsSource = repositorio.LeerProductos();
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if (repositorio.LeerProductos().Count == 0)
            {
                MessageBox.Show("No tiene prodcutos...", "No tiene pdoructos ", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (dtgTabla.SelectedItem != null)
                {
                    Producto a = dtgTabla.SelectedItem as Producto;
                    if (MessageBox.Show("Realmente deseas eliminar a " + a.Mercancia + "?", "Eliminar????", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        if (repositorio.EliminarProducto(a))
                        {
                            MessageBox.Show("El producto ha sido removido", "El producto ha sido removido", MessageBoxButton.OK, MessageBoxImage.Information);
                            ActualizarTabla();
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar el producto ", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
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
