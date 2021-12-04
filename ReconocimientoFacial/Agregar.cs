using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReconocimientoFacial
{
    public partial class Agregar : Form
    {
        Form1 formu;
        public Agregar(Form1 formulario)
        {
            InitializeComponent();
            formu = formulario;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text == "")
            {
                MessageBox.Show("Se necesita ingresar el nombre de la persona", "Error al registrar datos");
            }
            else if(txtHistorial.Text == "")
            {
                MessageBox.Show("Se necesita ingresar un historial para la persona", "Error al registrar datos");
            }
            else
            {
                    ConexionSQL.InsertarUsuario(txtNombre.Text, txtCorreo.Text, txtTelefono.Text, txtHistorial.Text);
                    formu.CambiarNombre(txtNombre.Text);
                    this.Close();
            }
            
        }

        private void Agregar_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
