using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventarios
{
    class Inventario
    {
        private Producto[] productos = new Producto[20];
        private int referencia = 0;

        /// <summary>
        /// Agregar Producto de tipo PRODUCTO al inventario
        /// </summary>
        /// <param name="producto"></param>
        public string agregar(Producto producto)
        {
            if (referencia < 20)
            {
                productos[referencia] = producto;
                referencia++;
                return "Producto agregado";
            }
            else
                return "Producto no existente";
        }
        /// <summary>
        /// Regresa todos los productos registrados en el inventario
        /// </summary>
        /// <returns></returns>
        public string reporte()
        {
            string infoProducto = "";
            for (int i = 0; i < referencia; i++)
            {
                infoProducto += productos[i].ToString();
            }
            return infoProducto;
        }

        /// <summary>
        /// Busca un producto existente del inventario
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public Producto buscar(string nombre)
        {
            Producto productoEncontrado = null;
            for (int i = 0; i < referencia; i++)
            {
                if (nombre == productos[i].nombre)
                {
                    productoEncontrado =productos[i];
                    break;
                }
            }
            return productoEncontrado;
        }

        /// <summary>
        /// Elimina producto existente del inventario
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public bool eliminar(string nombre)
        {
            bool productoEliminado = false;
            int posicion = 0;
            for (int i = 0; i < referencia; i++)
            {
                if (buscar(nombre) != null)
                {
                    posicion = i;
                    productos[i] = productos[i + 1];
                    productoEliminado = true;
                    break;
                }
            }
            if (productoEliminado)
            {
                for (int i = posicion; i < referencia; i++)
                    productos[i] = productos[i + 1];

                referencia--;
            }
            return productoEliminado;
        }

        /// <summary>
        /// Inserta un producto en la posicion deseada del inventario
        /// </summary>
        /// <param name="lugar"></param>
        /// <param name="producto"></param>
        public string insertar (int lugar, Producto producto)
        {
            if (referencia < 20)
            {
                for (int i = productos.Length - 1; i >= lugar; i--)
                {
                    productos[i] = productos[i - 1];
                }
                productos[lugar - 1] = producto;
                referencia++;
                return "Echo";
            }
            else
                return "Invntario lleno";

        }

        public override string ToString()
        {
            return Convert.ToString(referencia);
        }
    }
}
