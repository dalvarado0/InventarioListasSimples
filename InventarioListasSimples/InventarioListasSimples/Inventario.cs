using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioListasSimples
{
    class Inventario
    {
        Producto[] vec;
        public Inventario()
        {
            vec = new Producto[15];
        }

        private int _contador = -1;
        public bool agregarItem(Producto item)
        {
            if (_contador < vec.Length)
            {
                _contador++;
                vec[_contador] = item;
                return true;
            }
            else
                return false;
        }

        public bool eliminarItem(Producto item)
        {
            try
            {
                int indice = 0;
                for (int i = 0; i < _contador; i++)
                {
                    if (item.codigo == vec[i].codigo)
                    {
                        vec[i] = null;
                        indice = i;
                    }
                }

                if (_contador < 2)
                {
                    return true;
                }
                else
                {
                    for (int i = indice; i < _contador; i++)
                    {
                        vec[i] = vec[i + 1];
                    }
                }
                _contador--;
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool insertarItem(Producto item, int posicion)
        {
            if (posicion < vec.Length)
            {
                if (_contador < vec.Length)
                {
                    for (int i = vec.Length - 1; i >= posicion - 1; i--)
                    {
                        if (i == 0)
                        {
                            vec[i] = vec[i];
                        }
                        else
                        {
                            vec[i] = vec[i - 1];
                        }

                    }
                }
                vec[posicion - 1] = item;
                _contador++;
            }
            return true;
        }

        public string reporteItem()
        {
            string cadena = "";
            for (int i = 0; i < _contador; i++)
            {
                cadena += vec[i].ToString() + Environment.NewLine;
            }
            return cadena;
        }

        public Producto buscarProducto(int codigo)
        {
            Producto item = new Producto();
            item.codigo = codigo;
            for (int i = 0; i <= _contador; i++)
            {
                if (item.codigo == vec[i].codigo)
                {
                    return item = vec[i];

                }
            }
            item = null;
            return item;
        }
    }
}
