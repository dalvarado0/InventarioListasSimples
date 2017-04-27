using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioListasSimples
{
    class Producto
    {
        private int _codigo;
        public int codigo
        {
            set { _codigo = value; }
            get { return _codigo; }
        }

        private string _nombre;
        public void setNombre(string nombre)
        {
            _nombre = nombre;
        }

        private int _cantidad;
        public int catidad
        {
            set { _cantidad = value; }
            get { return _cantidad; }
        }

        private int _costo;
        public int costo
        {
            set { _costo = value; }
            get { return _costo; }
        }

        public Producto()
        {
            _codigo = 0;
            _nombre = "";
            _cantidad = 0;
            _costo = 0;
        }

        private Producto _siguiente;

        public Producto siguiente 
        {
            set
            {
                _siguiente = value;
            }
            get { return _siguiente;}
        }

        public override string ToString()
        {
            return "Código: " + _codigo.ToString() + " Nombre " + _nombre.ToString() + " Cantidad " + _cantidad.ToString() + " Costo: " + _codigo.ToString();
        }

    }
}
