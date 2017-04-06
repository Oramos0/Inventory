using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventarios
{
    class Producto
    {
        private int _codigo { get; }
        public int codigo { get { return _codigo; } }
        private string _nombre { get; }
        public string nombre { get { return _nombre; } }
        private int _cantidad { get; }
        public int cantidad { get { return _cantidad; } }
        private float _costo { get; }
        public float costo { get { return _costo; } }

        public Producto (int codigo, string nombre, int cantidad, float costo)
        {
            this._codigo = codigo;
            this._nombre = nombre;
            this._cantidad = cantidad;
            this._costo = costo;
        }

        public override string ToString()
        {
            string objetoProducto;

            objetoProducto = "Codigo: " + codigo + Environment.NewLine+ "Nombre: " + nombre + Environment.NewLine + "Cantidad: " + 
                cantidad + Environment.NewLine + "Costo: " + costo + Environment.NewLine + "//////////" + Environment.NewLine;
            return objetoProducto;
        }
    }
}
