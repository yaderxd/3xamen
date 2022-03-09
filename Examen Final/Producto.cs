using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Final
{
    class Producto
    {
        string b;
        int a;
        private int codigoproducto;
        private string nombreproducto;
        private int precio;
        private int existencia;
        public int CodigoProducto
        {
            get { return codigoproducto; }
            set { codigoproducto = value; }
        }
        public string NombreProducto
        {
            get { return nombreproducto; }
            set { nombreproducto = value; }
        }
        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public int Existencia
        {
            get { return existencia; }
            set { existencia = value; }
        }
        public Producto()
        {
            CodigoProducto = 0;
            NombreProducto = string.Empty;
            Precio = 0;
            Existencia = 0;
        }
        public Producto(int codigop, string nombrep,int preciop,int existenciap)
        {
            this.CodigoProducto = codigop;
            this.NombreProducto = nombrep;
            this.Precio = preciop;
            this.Existencia = existenciap;
        }
        public string mondongo()
        {
            return NombreProducto + " y Esitencia es :" + Existencia;
        }
        public string todo2()
        {
            return "Codigo :" + CodigoProducto + " Nombre es: " + NombreProducto + " y el Precio es: " + Precio+ "\r\n";
        }
        public string ba()
        {
            return "Codigo";
        }
    }
}
