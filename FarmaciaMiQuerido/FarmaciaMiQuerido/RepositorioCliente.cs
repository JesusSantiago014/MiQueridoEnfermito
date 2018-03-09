using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaMiQuerido
{
    public class RepositorioCliente
    {
        ManejadorDeArchivos ArchivoCliente;
        List<Cliente> Clientes;
        public RepositorioCliente()
        {
            ArchivoCliente = new ManejadorDeArchivos("Cliente.text");
            Clientes = new List <Cliente>();
        }



        public bool AgregarCliente(Cliente cliente)
        {

            Clientes.Add(cliente);
            bool resultado = ActualizarArchivo();
            Clientes = LeerClientes();
            return resultado;

        }




        public bool EliminarCliente(Cliente cliente)
        {
            Cliente temporal = new Cliente();
            foreach (var item in Clientes)
            {
                if (item.Telefono == cliente.Telefono)
                {
                    temporal = item;
                }
            }
            Clientes.Remove(temporal);
            bool resultado = ActualizarArchivo();
            Clientes = LeerClientes();
            return resultado;
        }


        public bool ModificarCliente(Cliente original, Cliente modificado)
        {
            Cliente temporal = new Cliente();
            foreach (var item in Clientes)
            {
                if (original.RFC == item.RFC)
                {
                    temporal = item;
                }
            }
            temporal.Nombre = modificado.Nombre;
            temporal.Apellidos = modificado.Apellidos;
            temporal.Direccion = modificado.Direccion;
            temporal.RFC = modificado.RFC;
            temporal.Telefono = modificado.Telefono;
            temporal.Email = modificado.Email;
            bool resultado = ActualizarArchivo();
            Clientes = LeerClientes();
            return resultado;
        }

        private bool ActualizarArchivo()
        {
            string datos = "";
            foreach (Cliente item in Clientes)
            {
                datos += string.Format("{0}|{1}|{2}|{3}|{4}|{5}\n", item.Nombre, item.Apellidos, item.Direccion, item.RFC, item.Telefono, item.Email);
            }
            return ArchivoCliente.Guardar(datos);
        }

        public List<Cliente> LeerClientes()
        {
            string datos = ArchivoCliente.Leer();
            if (datos != null)
            {
                List<Cliente> clientes = new List<Cliente>();
                string[] lineas = datos.Split('\n');
                for (int i = 0; i < lineas.Length - 1; i++)
                {
                    string[] campos = lineas[i].Split('|');
                    Cliente a = new Cliente()
                    {
                        Nombre = campos[0],
                        Apellidos = campos[1],
                        Direccion = campos[2],
                        RFC = campos[3],
                        Telefono = campos[4],
                        Email = campos[5]
                    };
                    clientes.Add(a);
                }
                Clientes = clientes;
                return clientes;
            }
            else
            {
                return null;
            }
        }



    }
}
