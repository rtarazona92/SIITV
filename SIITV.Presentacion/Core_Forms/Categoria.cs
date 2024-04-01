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
    public partial class Frm_Categoria : Form
    {
        public Frm_Categoria()
        {
            InitializeComponent();
        }

        #region "MIS VARIABLES"
        int EstadoGuarda = 0;   // Sin ninguna Acción
        int Codigo_ca = 0;    //
        #endregion

        #region "MIS METODOS"
        public void Formato_ca()
        {
            //Dgv_Lista.Columns[0].Width=100;
            Dgv_Lista.Columns[0].HeaderText = "CÓDIGO";
            //Dgv_Lista.Columns[1].Width = 200;
            Dgv_Lista.Columns[1].HeaderText = "SIGLA";
            //Dgv_Lista.Columns[2].Width = 300;
            Txb_Buscar.Focus();
        }

        private void Listado_ca(string cTexto)
        {
            try
            {
                Dgv_Lista.DataSource = N_Categoria.Listado_ca(cTexto);
                this.Formato_ca();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Estado_BotonesPrincipales(bool lEstado)
        {
            this.Btn_Nuevo.Enabled = lEstado;
            this.Btn_Modificar.Enabled = !lEstado;
            this.Btn_Eliminar.Enabled = !lEstado;
            this.Btn_Salir.Enabled = lEstado;
        }

        private void Estado_BotonesEdicion(bool lEstado)
        {
            this.Btn_Guardar.Enabled = lEstado;
            this.Btn_Cancelar.Enabled = lEstado;
            this.Btn_Retornar.Enabled = !lEstado;
        }

        private void Selecciona_Item()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_Lista.CurrentRow.Cells["codigo_ca"].Value)))
            {
                MessageBox.Show("No hay información para visualizar", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Codigo_ca = Convert.ToInt32(Dgv_Lista.CurrentRow.Cells["codigo_ca"].Value);
                Txb_Sigla.Text = Convert.ToString(Dgv_Lista.CurrentRow.Cells["sigla_ca"].Value);
            }
        }
        #endregion

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Carroceria_Load(object sender, EventArgs e)
        {
            this.Listado_ca("%");
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            if (Txb_Sigla.Text==string.Empty)
            {
                MessageBox.Show("Los datos requeridos no estan completos.. (*)", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else    // Se procederá a registrar la información
            {
                E_Categoria oCa = new E_Categoria();
                string Rpta = "";
                oCa.Codigo_ca = this.Codigo_ca;
                oCa.Sigla_ca = Txb_Sigla.Text.Trim();
                Rpta = N_Categoria.Guardar_ca(EstadoGuarda, oCa);
                if (Rpta=="OK")
                {
                    this.Listado_ca("%");
                    
                    MessageBox.Show("Los datos de guardaron correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EstadoGuarda = 0;   // Sin Ninguna Acción
                    Txb_Sigla.Text = "";
                    Txb_Sigla.ReadOnly = true;
                    Tc_Principal.SelectedIndex = 0;
                    this.Estado_BotonesPrincipales(true);
                    this.Estado_BotonesEdicion(false);
                    Btn_Retornar.Enabled = false;
                    this.Codigo_ca = 0;
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
            this.Estado_BotonesEdicion(true);
            Btn_Nuevo.Enabled = false;
            Btn_Salir.Enabled = false;
            EstadoGuarda = 1;   // Realiza un nuevo registro
            Txb_Sigla.Text = string.Empty;
            Txb_Sigla.ReadOnly = false;
            Tc_Principal.SelectedIndex = 1;
            Txb_Sigla.Focus();
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            EstadoGuarda = 2;   // Realiza una Modificación de Registro
            this.Estado_BotonesEdicion(true);
            Btn_Modificar.Enabled = false;
            Btn_Eliminar.Enabled = false;
            Txb_Sigla.ReadOnly = false;
            Txb_Sigla.Focus();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Estado_BotonesPrincipales(true);
            this.Estado_BotonesEdicion(false);
            Btn_Retornar.Enabled = false;
            EstadoGuarda = 0;   // Sin niguna acción.
            Txb_Sigla.Text = "";
            Tc_Principal.SelectedIndex = 0;
            Txb_Sigla.ReadOnly = true;
            Txb_Buscar.Focus();
            this.Codigo_ca = 0;
        }

        private void Btn_Retornar_Click(object sender, EventArgs e)
        {
            this.Estado_BotonesPrincipales(true);
            this.Estado_BotonesEdicion(false);
            Btn_Retornar.Enabled = false;
            Txb_Buscar.Focus();            
            Txb_Sigla.Text = "";
            Tc_Principal.SelectedIndex = 0;
            Txb_Sigla.ReadOnly = true;
            this.Codigo_ca = 0;
        }

        private void Dgv_Carroceria_DoubleClick(object sender, EventArgs e)
        {
            this.Selecciona_Item();
            this.Estado_BotonesPrincipales(false);
            this.Estado_BotonesEdicion(false);
            Tc_Principal.SelectedIndex = 1;
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            DialogResult Opcion = MessageBox.Show("Estas seguro de eliminar el Registro seleccionado?", "Aviso del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Opcion==DialogResult.Yes)
            {
                string Rpta = "";
                this.Codigo_ca = Convert.ToInt32(Dgv_Lista.CurrentRow.Cells["codigo_ca"].Value);
                // Enviar a ejecutar la eliminacion de datos
                Rpta=N_Categoria.Eliminar_ca(this.Codigo_ca);
                if (Rpta.Equals("OK"))
                {
                    this.Listado_ca("%");
                    MessageBox.Show("Registro Eliminado..", "Aviso dle Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Txb_Sigla.Text = "";
                    Txb_Sigla.ReadOnly = true;
                    Tc_Principal.SelectedIndex = 0;
                    this.Estado_BotonesPrincipales(true);
                    this.Estado_BotonesEdicion(false);
                    Btn_Retornar.Enabled = false;
                    this.Codigo_ca = 0;
                }
            }
        }
    }
}