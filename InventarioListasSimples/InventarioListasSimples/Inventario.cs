using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioListasSimples
{
    class Inventario
    {
        Producto inicio;

        public Inventario()
        {
            //inicio = new Producto();
        }

        public void agregar(Producto nuevo)
        {
            if(inicio == null)
                inicio = nuevo;
            else
            {
                Producto temp = inicio;
                while (temp.siguiente != null)
                    temp = temp.siguiente;
                temp.siguiente = nuevo;
                
            }
        }

        public string reporte()
        {
            string datos = "";

            Producto t = inicio;
            while(t != null)
            {
                datos += t.ToString() + Environment.NewLine;
                t = t.siguiente;
            }

            return datos;
        }
    }
}
