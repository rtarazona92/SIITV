using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIITV.Presentacion
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private bool verificarFormularioAbierto(string nombreformulario)
        {
            bool IsOpen = false;
            foreach (Form formulario in MdiChildren)
            {
                if (formulario.Name.Equals(nombreformulario))
                {
                    formulario.Focus();
                    IsOpen = true;
                }
            }
            return IsOpen;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void categoriasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string FormName = "Frm_Categorias";
            if (verificarFormularioAbierto(FormName)==false)
            {
                Frm_Categorias categorias = new Frm_Categorias();
                categorias.MdiParent = this;
                categorias.Show();
            }
        }

        private void marcasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string FormName = "Frm_Marcas";
            if (verificarFormularioAbierto(FormName) == false)
            {
                Frm_Marcas marcas = new Frm_Marcas();
                marcas.MdiParent = this;
                marcas.Show();
            }
        }

        private void modelosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string FormName = "Frm_Modelos";
            if (verificarFormularioAbierto(FormName) == false)
            {
                Frm_Modelos modelos = new Frm_Modelos();
                modelos.MdiParent = this;
                modelos.Show();
            }
        }
    }
}
