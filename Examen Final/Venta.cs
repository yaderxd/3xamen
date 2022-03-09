using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Final
{
    class Venta
    {
        private int codigoVenta;
        private int codigocliente;
        private int codigoproducto;
        private int cantidad;
        private int subtotal;
        private DateTime fecha;
        public int CodigoVenta
        {
            get { return codigoVenta; }
            set { codigoVenta = value; }
        }
        public int CodigoCliente
        {
            get { return codigocliente; }
            set { codigocliente = value; }
        }
        public int CodigoProducto
        {
            get { return codigoproducto; }
            set { 
                codigoproducto= value; }
        }
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        public int SubTotal
        {
            get { return subtotal; }
            set{subtotal = value;}
        }
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public Venta()
        {
            CodigoVenta = 0;
            CodigoCliente = 0;
            CodigoProducto = 0;
            Cantidad = 0;
            SubTotal = 0;
            Fecha = DateTime.MaxValue;
        }
        public Venta(int codigov, int codigoc, int codigop, int cantidadv,int subtotal,DateTime fecha)
        {
            this.CodigoVenta = codigov;
            this.CodigoCliente = codigoc;
            this.CodigoProducto = codigop;
            this.Cantidad = cantidadv;
            this.SubTotal = subtotal;
            this.Fecha = fecha;
        }
        public string todo3()
        {
            return "Codigo de Venta : "+ CodigoVenta +" Codigo de cliente :"+ CodigoCliente +" Codigo de Producto :"+ CodigoProducto+"\r\n";
        }
    }
}
