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
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {

        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {

            string contraseña = "Jehova";
            string usuario = "Jesucristo";

            if (txtUsuario.Text != usuario && txtPasword.Text != contraseña)
            {
                if (txtUsuario.Text != usuario)
                {
                    MessageBox.Show("usuario Incorrecto");
                    txtUsuario.Clear();
                    txtUsuario.Focus();
                    return;
                }
                if (txtPasword.Text != contraseña)
                {
                    MessageBox.Show("contraseña incorrecta");
                    txtPasword.Clear();
                    txtPasword.Focus();
                    return;
                }
            }
            else
            {
                pbBarrera.Visible = true;
                txtUsuario.Clear();
                txtPasword.Clear();
                this.timer1.Start();
            }
        }

        private void PbBarrera_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.pbBarrera.Increment(3);

            if(pbBarrera.Value >= pbBarrera.Maximum)
            {
                timer1.Stop();
                this.Hide();
                Clientes xd = new Clientes();
                xd.Show();
            }
        }
    }
}
