using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ReconocimientoFacial
{
    public partial class VerPersona : Form
    {
        public VerPersona(SqlDataReader datos, Form1 form)
        {
            InitializeComponent();
            MostrarDatos(datos);
        }

        private void MostrarDatos(SqlDataReader datos)
        {
            if (datos.Read())
            {
                textnombre.Text = datos.GetValue(1).ToString();
                textocorreo.Text = datos.GetValue(2).ToString();
                textotelefono.Text = datos.GetValue(3).ToString();  
                txtHistorial.Text = datos.GetValue(4).ToString();   
            }
        }
    }
}
