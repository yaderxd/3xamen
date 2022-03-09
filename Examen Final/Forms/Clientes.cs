using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Final.Forms
{
    public partial class Clientes : Form
    {
        List<Cliente2> cli = new List<Cliente2>();
        Cliente2 c;

        List<Producto> pro = new List<Producto>();
        Producto p;

        List<Venta> ven = new List<Venta>();
        Venta v;
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }
        public void GuardarCliente()
        {
            c = new Cliente2(int.Parse(txtCodigo.Text), txtNombre.Text);
            cli.Add(c);

            dgvClientes.DataSource = null;
            dgvClientes.DataSource = cli;
        }
        public void GuardarProducto()
        {
            p = new Producto(int.Parse(txtCodigoProdcuto.Text), txtNombreProducto.Text, int.Parse(txtPrecioProducto.Text), int.Parse(txtExistencia.Text));
            pro.Add(p);

            dgvProducto.DataSource = null;
            dgvProducto.DataSource = pro;
        }
        public void GuardarVenta()
        {
            v = new Venta(int.Parse(txtCodigoVenta.Text), int.Parse(txtCodigoCliente2.Text), int.Parse(txtCodigoProducto2.Text), int.Parse(txtCantidad.Text), int.Parse(txtSubTotal.Text), DateTime.Parse(dtpFecha.Text));
            ven.Add(v);

            dgvVentas.DataSource = null;
            dgvVentas.DataSource = ven;
        }
        public void ProductoExistencia()
        {
            IEnumerable<Producto> num=from xd in pro select xd;
            foreach(Producto xd in num)
            {
                txtDatos.Clear();
                txtDatos.AppendText(xd.mondongo());
            }
        }
        public void Mostrar()
        {
            IEnumerable<Cliente2> x = from j in cli select j;
            IEnumerable<Producto> y = from b in pro select b;
            IEnumerable<Venta> z = from ñ in ven select ñ;

            foreach(Cliente2 s in x )
            {
                txtDatos.AppendText(s.todo());
            }
            foreach(Producto s in y)
            {
                txtDatos.AppendText(s.todo2());
            }
            foreach(Venta s in z)
            {
                txtDatos.AppendText(s.todo3());
            }
        }
        void limpiar()
        {
            btnSalir.Enabled = true;
            txtCodigo.Text = "";
            txtNombre.Text = "";
        }
        void limpiar2()
        {
            btnSalir2.Enabled = true;
            txtCodigoProdcuto.Text = "";
            txtNombreProducto.Text = "";
            txtPrecioProducto.Text = "";
            txtExistencia.Text = "";
        }
        void limpiar3()
        {
            btnSalir3.Enabled = true;
            txtCodigoVenta.Text = "";
            txtCodigoCliente2.Text = "";
            txtCodigoProducto2.Text = "";
            txtCantidad.Text = "";
            txtSubTotal.Text = "";
            dtpFecha.Text = "";
        }
        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            GuardarCliente();
            limpiar();
            txtCodigo.Focus();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Estas Seguro?", "Menu", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (r == DialogResult.Yes) this.Close();
        }

        private void BtnIngresar2_Click(object sender, EventArgs e)
        {
            GuardarProducto();
            limpiar2();
            txtCodigoProdcuto.Focus();
        }

        private void BtnSalir2_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Estas Seguro?", "Menu", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (r == DialogResult.Yes) this.Close();
        }

        private void BtnIngresarProductos_Click(object sender, EventArgs e)
        {
            GuardarVenta();
            limpiar3();
            txtCodigoVenta.Focus();
        }

        private void BtnSalir3_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Estas Seguro?", "Menu", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (r == DialogResult.Yes) this.Close();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtDatos.Clear();
            ProductoExistencia();
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtDatos.Clear();
            Mostrar();
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
        public void Buscar(string xd)
        {

            foreach (var usuario in cli)
            {

                if (usuario.NombreCliente == xd)
                {

                    Mostrar2();

                    break;


                }

            }


        }
        public void Mostrar2()
        {
            IEnumerable<Cliente2> x = from j in cli select j;
            IEnumerable<Producto> y = from b in pro select b;
           

            foreach (Cliente2 s in x)
            {
                txtDatos.AppendText(s.todo());
            }
            foreach (Producto s in y)
            {
                txtDatos.AppendText(s.todo2());
            }
         
        }
    }
}
