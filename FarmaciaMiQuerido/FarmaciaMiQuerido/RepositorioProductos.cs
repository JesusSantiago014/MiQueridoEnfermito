using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaMiQuerido
{
    public class RepositorioProductos
    {
        ManejadorDeArchivos archivoProductos;

        List<Producto> Productos;
        public RepositorioProductos()
        {
            archivoProductos = new ManejadorDeArchivos("MisProductos.text");
            Productos = new List<Producto>();
        }

        public bool AgregarProducto(Producto producto)
        {
            Productos.Add(producto);
            bool resultado = ActualizarArchivo();
            Productos = LeerProductos();
            return resultado;
        }

        public bool EliminarProducto(Producto producto)
        {
            Producto temporal = new Producto();
            foreach (var item in Productos)
            {
                if (item.Categoria == producto.Categoria)
                {
                    temporal = item;
                }
            }
            Productos.Remove(temporal);
            bool resultado = ActualizarArchivo();
            Productos = LeerProductos();
            return resultado;
        }

        public bool ModificarProducto(Producto original, Producto modificado)
        {
            Producto temporal = new Producto();
            foreach (var item in Productos)
            {
                if (original.Categoria == item.Categoria)
                {
                    temporal = item;
                }
            }
            temporal.Mercancia = modificado.Mercancia;
            temporal.Categoria = modificado.Categoria;
            temporal.Descripcion = modificado.Descripcion;
            temporal.PrecioV = modificado.PrecioV;
            temporal.PrecioC = modificado.PrecioC;
            temporal.ProductoE = modificado.ProductoE;
            bool resultado = ActualizarArchivo();
            Productos = LeerProductos();
            return resultado;
        }
        private bool ActualizarArchivo()
        {
            string datos = "";
            foreach (Producto item in Productos)
            {
                datos += string.Format("{0}|{1}|{2}|{3}|{4}|{5}\n", item.Mercancia, item.Categoria, item.Descripcion, item.PrecioV, item.PrecioC,item.ProductoE);
            }
            return archivoProductos.Guardar(datos);
        }
        public List<Producto> LeerProductos()
        {
            string datos = archivoProductos.Leer();
            if (datos != null)
            {
                List<Producto> productos = new List<Producto>();
                string[] lineas = datos.Split('\n');
                for (int i = 0; i < lineas.Length-1 ; i++)
                {
                    string[] campos = lineas[i].Split('|');
                    Producto a = new Producto()
                    {
                        Mercancia = campos[0],
                        Categoria = campos[1],
                        Descripcion = campos[2],
                        PrecioV = campos[3],
                        PrecioC = campos[4],
                        ProductoE=campos[5]
                    };
                    productos.Add(a);
                }
                Productos = productos;
                return productos;
            }
            else
            {
                return null;
            }
        }




    }
}
