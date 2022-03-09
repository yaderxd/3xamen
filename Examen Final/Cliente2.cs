using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen_Final.Forms;

namespace Examen_Final
{
    class Cliente2
    {
        private int codigocliente;
        private string nombrecliente;

        public int CodigoCliente
        {
            get { return codigocliente; }
            set{ codigocliente = value; }
        }
        public string NombreCliente
        {
            get { return nombrecliente; }
            set { nombrecliente = value; }
        }
        public Cliente2()
        {
            CodigoCliente = 0;
            NombreCliente = string.Empty;
        }
        public Cliente2(int codigo,string nombre)
        {
            this.CodigoCliente = codigo;
            this.NombreCliente = nombre;
        }
        public string todo()
        {
            return "Codigo :" + CodigoCliente + " Nombre es : " + NombreCliente+"\r\n";
        }
    }
}
