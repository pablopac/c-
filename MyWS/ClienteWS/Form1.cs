using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteWS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            var idetentificacion = txtIdentificacion.Text;
            using (WSPersonas.WSPersonasClient client = new WSPersonas.WSPersonasClient())
            {
                var persona = client.ObtenerPersona(idetentificacion);
                var nombre = persona.Nombre;
                var edad = persona.Edad;
            }
        }
    }
}
