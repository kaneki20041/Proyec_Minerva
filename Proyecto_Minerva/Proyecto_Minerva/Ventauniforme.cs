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
    public partial class Ventauniforme : Form
    {
        public Ventauniforme()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox8.Enabled = false;
                textBox6.Enabled = false;
                dateTimePicker2.Enabled = false;
                btnBuscMot.Enabled = false;
            }
            else
            {
                textBox8.Enabled = true;
                textBox6.Enabled = true;
                dateTimePicker2.Enabled = true;
                btnBuscMot.Enabled = true;
            }
        }

        private void Ventauniforme_Load(object sender, EventArgs e)
        {
            textBox8.Enabled = false;
            textBox6.Enabled = false;
            dateTimePicker2.Enabled = false;
            btnBuscMot.Enabled = false;
        }
    }
}
