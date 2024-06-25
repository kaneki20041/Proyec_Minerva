using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Minerva
{
    public partial class Proveedor : Form
    {
        public Proveedor()
        {
            InitializeComponent();
            listarProveedor();
            grupBoxDatos.Enabled = false;
            grupBoxDatos2.Enabled = false;
            //txtidCliente.Enabled = false;

        }
        public void listarProveedor()
        {
            dvgProveedor.DataSource = logProveedor.Instancia.ListarProveedor();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grupBoxDatos.Enabled = true;
            grupBoxDatos2.Enabled = true;
            btnAgregar.Visible = true;
            //LimpiarVariables();
            btnModificar.Visible = false;

        }
    }
}
