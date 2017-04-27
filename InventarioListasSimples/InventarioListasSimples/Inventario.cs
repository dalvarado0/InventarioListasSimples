using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioListasSimples
{
    class Inventario
    {
        private Producto inicio;

        public Inventario()
        {
            //inicio = new Producto();
        }

        //public void agregar(Producto nuevo)
        //{
        //    if (inicio == null)
        //        inicio = nuevo;
        //    else
        //    {
        //        Producto temp = inicio;
        //        while (temp.siguiente != null)
        //            temp = temp.siguiente;
        //        temp.siguiente = nuevo;

        //    }
        //}

        public void agregar(Producto nuevo)
        {
            if (inicio == null)
                inicio = nuevo;
            else
                agregar(inicio, nuevo);
        }

        private void agregar(Producto ultimo, Producto nuevo)
        {
            if (ultimo.siguiente == null)
                ultimo.siguiente = nuevo;
            else
                agregar(ultimo.siguiente, nuevo);
        }

        public void insertar(Producto nuevo, int posicion)
        {
            Producto temp = inicio;
            int cont = 1;
            while(temp.siguiente != null || cont < posicion)
            {
                cont++;
                if(cont == posicion)
                {
                    nuevo.siguiente = temp.siguiente;
                    temp.siguiente = nuevo;
                }
            }
        }

        public void eliminar(int codigo)
        {
            Producto temp = inicio;
            while(temp.siguiente != null)
            {
                if(temp.siguiente.codigo == codigo)
                    temp.siguiente = temp.siguiente.siguiente;
                temp = temp.siguiente;
            }
        }

        public Producto buscar(int codigo)
        {
            Producto item = null, temp = inicio;
            while(temp.siguiente != null)
            {
                if (temp.siguiente.codigo == codigo)
                    item = temp.siguiente;
                temp = temp.siguiente;
            }
            return item;
        }

        public string reporte()
        {
            string datos = "";

            Producto temp = inicio;
            while (temp != null)
            {
                datos += temp.ToString() + Environment.NewLine;
                temp = temp.siguiente;
            }

            return datos;
        }
        }
    }
}
