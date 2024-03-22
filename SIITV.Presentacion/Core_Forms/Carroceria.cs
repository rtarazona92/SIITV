using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIITV.Entidades;
using SIITV.Negocio;

namespace SIITV.Presentacion
{
    public partial class Frm_Carroceria : Form
    {
        public Frm_Carroceria()
        {
            InitializeComponent();
        }

        #region "MIS VARIABLES"
        int EstadoGuarda = 0;  // Sin ninguna Acción


        #endregion

        #region "MIS METODOS"

        public void Formato_carr()
        {
            Dgv_Carroceria.Columns[0].Width=100;
            Dgv_Carroceria.Columns[0].HeaderText = "CÓDIGO";
            Dgv_Carroceria.Columns[1].Width = 200;
            Dgv_Carroceria.Columns[1].HeaderText = "SIGLA";
            Dgv_Carroceria.Columns[2].Width = 300;
            Dgv_Carroceria.Columns[2].HeaderText = "CATEGORÍA";
            Txb_Buscar.Focus();
        }

        private void Listado_carr(string cTexto)
        {
            try
            {
                Dgv_Carroceria.DataSource = N_Carroceria.Listado_carr(cTexto);
                this.Formato_carr();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Estado_BotonesPrincipales(bool lEstado)
        {
            //this.Btn_Nuevo.Enabled = lEstado;
            //this.Btn_Modificar.Enabled = !lEstado;
            //this.Btn_Eliminar.Enabled = !lEstado;
            //this.Btn_Salir.Enabled = lEstado;
        }

        private void Estado_BotonesEdicion(bool lEstado)
        {
            //this.Btn_Guardar.Enabled = lEstado;
            //this.Btn_Cancelar.Enabled = lEstado;
            //this.Btn_Retornar.Enabled = !lEstado;
        }

        private void Selecciona_Item()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_Carroceria.CurrentRow.Cells["codigo_carr"].Value)))
            {
                MessageBox.Show("No hay información para visualizar", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Txb_Sigla_carr.Text = Convert.ToString(Dgv_Carroceria.CurrentRow.Cells["sigla_carr"].Value);
                Txb_Nombre_carr.Text = Convert.ToString(Dgv_Carroceria.CurrentRow.Cells["nombre_carr"].Value);
            }
        }

        #endregion
        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Carroceria_Load(object sender, EventArgs e)
        {
            this.Listado_carr("%");
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            if (Txb_Nombre_carr.Text == string.Empty || Txb_Sigla_carr.Text==string.Empty)
            {
                MessageBox.Show("Los datos requeridos no estan completos.. (*)", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else    // Se procederá a registrar la información
            {
                E_Carroceria oCarr = new E_Carroceria();
                string Rpta = "";
                oCarr.Codigo_carr = 0;
                oCarr.Sigla_carr = Txb_Sigla_carr.Text.Trim();
                oCarr.Nombre_carr = Txb_Nombre_carr.Text.Trim();
                Rpta = N_Carroceria.Guardar_carr(EstadoGuarda, oCarr);
                if (Rpta=="OK")
                {
                    this.Listado_carr("%");
                    MessageBox.Show("Los datos de guardaron correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EstadoGuarda = 0;   // Sin Ninguna Acción
                    Txb_Sigla_carr.Text = "";
                    Txb_Nombre_carr.Text = "";
                    Txb_Sigla_carr.ReadOnly = true;
                    Txb_Nombre_carr.ReadOnly = true;
                    Tc_Carrocerias.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show(Rpta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Txb_Buscar.Focus();
            }
            
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            EstadoGuarda = 1;   // Realiza un nuevo registro
            Txb_Nombre_carr.Text = string.Empty;
            Txb_Sigla_carr.Text = string.Empty;
            Txb_Nombre_carr.ReadOnly = false;
            Txb_Sigla_carr.ReadOnly = false;
            Tc_Carrocerias.SelectedIndex = 1;
            Txb_Sigla_carr.Focus();
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            EstadoGuarda = 2;   // Realiza una Modificación de Registro
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            EstadoGuarda = 0;   // Sin niguna acción.
            Txb_Sigla_carr.Text = "";
            Txb_Nombre_carr.Text = "";
            Tc_Carrocerias.SelectedIndex = 0;
            Txb_Nombre_carr.ReadOnly = true;
            Txb_Sigla_carr.ReadOnly = true;
            Txb_Buscar.Focus();
        }

        private void Btn_Retornar_Click(object sender, EventArgs e)
        {
            Txb_Buscar.Focus();            
            Txb_Sigla_carr.Text = "";
            Txb_Nombre_carr.Text = "";
            Tc_Carrocerias.SelectedIndex = 0;
            Txb_Nombre_carr.ReadOnly = true;
            Txb_Sigla_carr.ReadOnly = true;
        }

        private void Btn_Modificar_Click_1(object sender, EventArgs e)
        {
            //Btn_Nuevo.Enabled = false;
            //Btn_Salir.Enabled = false;
            //Btn_Guardar.Enabled = true;
            //Btn_Cancelar.Enabled = true;
        }

        private void Dgv_Carroceria_DoubleClick(object sender, EventArgs e)
        {
            this.Selecciona_Item();
            Tc_Carrocerias.SelectedIndex = 1;
        }
    }
}
