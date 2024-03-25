﻿using System;
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
    public partial class Frm_TipoCombustible : Form
    {
        public Frm_TipoCombustible()
        {
            InitializeComponent();
        }

        #region "MIS VARIABLES"
        int EstadoGuarda = 0;   // Sin ninguna Acción
        int Codigo_tc = 0;    //
        #endregion

        #region "MIS METODOS"
        public void Formato_tc()
        {
            //Dgv_Lista.Columns[0].Width=100;
            Dgv_Lista.Columns[0].HeaderText = "CÓDIGO";
            //Dgv_Lista.Columns[1].Width = 200;
            Dgv_Lista.Columns[1].HeaderText = "SIGLA";
            //Dgv_Lista.Columns[2].Width = 300;
            Dgv_Lista.Columns[2].HeaderText = "COMBUSTIBLE";
            Dgv_Lista.Columns[3].HeaderText = "DEFINICIÓN";
            Txb_Buscar.Focus();
        }

        private void Listado_tc(string cTexto)
        {
            try
            {
                Dgv_Lista.DataSource = N_TipoCombustible.Listado_tc(cTexto);
                this.Formato_tc();
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
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_Lista.CurrentRow.Cells["codigo_tc"].Value)))
            {
                MessageBox.Show("No hay información para visualizar", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Codigo_tc = Convert.ToInt32(Dgv_Lista.CurrentRow.Cells["codigo_tc"].Value);
                Txb_Sigla.Text = Convert.ToString(Dgv_Lista.CurrentRow.Cells["sigla_tc"].Value);
                Txb_Nombre.Text = Convert.ToString(Dgv_Lista.CurrentRow.Cells["nombre_tc"].Value);
                Txb_Definicion.Text = Convert.ToString(Dgv_Lista.CurrentRow.Cells["definicion_tc"].Value);
            }
        }
        #endregion

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_TipoCombustible_Load(object sender, EventArgs e)
        {
            this.Listado_tc("%");
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            if (Txb_Nombre.Text == string.Empty || Txb_Sigla.Text==string.Empty || Txb_Definicion.Text == string.Empty)
            {
                MessageBox.Show("Los datos requeridos no estan completos.. (*)", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else    // Se procederá a registrar la información
            {
                E_TipoCombustible oTc = new E_TipoCombustible();
                string Rpta = "";
                oTc.Codigo_tc = this.Codigo_tc;
                oTc.Sigla_tc = Txb_Sigla.Text.Trim();
                oTc.Nombre_tc = Txb_Nombre.Text.Trim();
                oTc.Definicion_tc = Txb_Definicion.Text.Trim();
                Rpta = N_TipoCombustible.Guardar_tc(EstadoGuarda, oTc);
                if (Rpta=="OK")
                {
                    this.Listado_tc("%");
                    MessageBox.Show("Los datos de guardaron correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EstadoGuarda = 0;   // Sin Ninguna Acción
                    Txb_Sigla.Text = string.Empty;
                    Txb_Nombre.Text = string.Empty;
                    Txb_Definicion.Text = string.Empty;
                    Txb_Sigla.ReadOnly = true;
                    Txb_Nombre.ReadOnly = true;
                    Txb_Definicion.ReadOnly = true;
                    Tc_Principal.SelectedIndex = 0;
                    this.Estado_BotonesPrincipales(true);
                    this.Estado_BotonesEdicion(false);
                    Btn_Retornar.Enabled = false;
                    this.Codigo_tc = 0;
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
            Txb_Nombre.Text = string.Empty;
            Txb_Sigla.Text = string.Empty;
            Txb_Nombre.ReadOnly = false;
            Txb_Sigla.ReadOnly = false;
            Txb_Definicion.ReadOnly = false;
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
            Txb_Nombre.ReadOnly = false;
            Txb_Definicion.ReadOnly = false;
            Txb_Sigla.Focus();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Estado_BotonesPrincipales(true);
            this.Estado_BotonesEdicion(false);
            Btn_Retornar.Enabled = false;
            EstadoGuarda = 0;   // Sin niguna acción.
            Txb_Sigla.Text = string.Empty;
            Txb_Nombre.Text = string.Empty;
            Txb_Definicion.Text = string.Empty;
            Tc_Principal.SelectedIndex = 0;
            Txb_Sigla.ReadOnly = true;
            Txb_Nombre.ReadOnly = true;
            Txb_Definicion.ReadOnly = true;
            Txb_Buscar.Focus();
            this.Codigo_tc = 0;
        }

        private void Btn_Retornar_Click(object sender, EventArgs e)
        {
            this.Estado_BotonesPrincipales(true);
            this.Estado_BotonesEdicion(false);
            Btn_Retornar.Enabled = false;
            Txb_Buscar.Focus();            
            Txb_Sigla.Text = string.Empty;
            Txb_Nombre.Text = string.Empty;
            Txb_Definicion.Text = string.Empty;
            Tc_Principal.SelectedIndex = 0;
            Txb_Sigla.ReadOnly = true;
            Txb_Nombre.ReadOnly = true;
            Txb_Definicion.ReadOnly = true;
            this.Codigo_tc = 0;
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
                this.Codigo_tc = Convert.ToInt32(Dgv_Lista.CurrentRow.Cells["codigo_tc"].Value);
                // Enviar a ejecutar la eliminacion de datos
                Rpta=N_TipoCombustible.Eliminar_tc(this.Codigo_tc);
                if (Rpta.Equals("OK"))
                {
                    this.Listado_tc("%");
                    MessageBox.Show("Registro Eliminado..", "Aviso dle Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Txb_Sigla.Text = string.Empty;
                    Txb_Nombre.Text = string.Empty;
                    Txb_Definicion.Text = string.Empty;
                    Txb_Sigla.ReadOnly = true;
                    Txb_Nombre.ReadOnly = true;
                    Txb_Definicion.ReadOnly = true;
                    Tc_Principal.SelectedIndex = 0;
                    this.Estado_BotonesPrincipales(true);
                    this.Estado_BotonesEdicion(false);
                    Btn_Retornar.Enabled = false;
                    this.Codigo_tc = 0;
                }
            }
        }
    }
}