using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_Minerva
{
    public partial class Produc_mat : Form
    {
        public Produc_mat()
        {
            InitializeComponent();
        }

        private void radbtnProd_CheckedChanged(object sender, EventArgs e)
        {
            if (radbtnProd.Checked)
            {
                textBox3.Enabled = false;
                textBox6.Enabled = false;
                textBox5.Enabled = false;
                btnAgreMat.Enabled = false;
                btnEditMat.Enabled = false;
                btnRemovMat.Enabled = false;
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                btnAgrePro.Enabled = true;
                btnEditPro.Enabled = true;
                BtnRemovPro.Enabled = true;
            }
            else
            {
                textBox3.Enabled = true;
                textBox6.Enabled = true;
                textBox5.Enabled = true;
                btnAgreMat.Enabled = true;
                btnEditMat.Enabled = true;
                btnRemovMat.Enabled = true;
            }
        }

        private void Produc_mat_Load(object sender, EventArgs e)
        {

            textBox3.Enabled = false;
            textBox6.Enabled = false;
            textBox5.Enabled = false;
            btnAgreMat.Enabled = false;
            btnEditMat.Enabled = false;
            btnRemovMat.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                comboBox2.Enabled = false;
                comboBox1.Enabled = false;
                comboBox3.Enabled = false;
                btnAgrePro.Enabled = false;
                btnEditPro.Enabled = false;
                BtnRemovPro.Enabled = false;
            }
        }

        private void btnAgrePro_Click(object sender, EventArgs e)
        {

        }
    }
}