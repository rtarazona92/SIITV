namespace SIITV.Presentacion
{
    partial class Frm_Carroceria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tc_Carrocerias = new System.Windows.Forms.TabControl();
            this.Tbp_ListaDeCarrocerias = new System.Windows.Forms.TabPage();
            this.Dgv_Carroceria = new System.Windows.Forms.DataGridView();
            this.Txb_Buscar = new System.Windows.Forms.TextBox();
            this.Lbl_Buscar = new System.Windows.Forms.Label();
            this.Tbp_Edicion = new System.Windows.Forms.TabPage();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Txb_Nombre_carr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Retornar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Txb_Sigla_carr = new System.Windows.Forms.TextBox();
            this.Tc_Carrocerias.SuspendLayout();
            this.Tbp_ListaDeCarrocerias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Carroceria)).BeginInit();
            this.Tbp_Edicion.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tc_Carrocerias
            // 
            this.Tc_Carrocerias.Controls.Add(this.Tbp_ListaDeCarrocerias);
            this.Tc_Carrocerias.Controls.Add(this.Tbp_Edicion);
            this.Tc_Carrocerias.Location = new System.Drawing.Point(16, 15);
            this.Tc_Carrocerias.Margin = new System.Windows.Forms.Padding(4);
            this.Tc_Carrocerias.Name = "Tc_Carrocerias";
            this.Tc_Carrocerias.SelectedIndex = 0;
            this.Tc_Carrocerias.Size = new System.Drawing.Size(458, 355);
            this.Tc_Carrocerias.TabIndex = 10;
            // 
            // Tbp_ListaDeCarrocerias
            // 
            this.Tbp_ListaDeCarrocerias.Controls.Add(this.Dgv_Carroceria);
            this.Tbp_ListaDeCarrocerias.Controls.Add(this.Txb_Buscar);
            this.Tbp_ListaDeCarrocerias.Controls.Add(this.Lbl_Buscar);
            this.Tbp_ListaDeCarrocerias.Location = new System.Drawing.Point(4, 25);
            this.Tbp_ListaDeCarrocerias.Margin = new System.Windows.Forms.Padding(4);
            this.Tbp_ListaDeCarrocerias.Name = "Tbp_ListaDeCarrocerias";
            this.Tbp_ListaDeCarrocerias.Padding = new System.Windows.Forms.Padding(4);
            this.Tbp_ListaDeCarrocerias.Size = new System.Drawing.Size(450, 326);
            this.Tbp_ListaDeCarrocerias.TabIndex = 0;
            this.Tbp_ListaDeCarrocerias.Text = "Lista de Carrocerías";
            this.Tbp_ListaDeCarrocerias.UseVisualStyleBackColor = true;
            // 
            // Dgv_Carroceria
            // 
            this.Dgv_Carroceria.AllowUserToAddRows = false;
            this.Dgv_Carroceria.AllowUserToDeleteRows = false;
            this.Dgv_Carroceria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Carroceria.Location = new System.Drawing.Point(8, 44);
            this.Dgv_Carroceria.Margin = new System.Windows.Forms.Padding(4);
            this.Dgv_Carroceria.Name = "Dgv_Carroceria";
            this.Dgv_Carroceria.ReadOnly = true;
            this.Dgv_Carroceria.Size = new System.Drawing.Size(434, 271);
            this.Dgv_Carroceria.TabIndex = 1;
            this.Dgv_Carroceria.DoubleClick += new System.EventHandler(this.Dgv_Carroceria_DoubleClick);
            // 
            // Txb_Buscar
            // 
            this.Txb_Buscar.Location = new System.Drawing.Point(69, 12);
            this.Txb_Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.Txb_Buscar.Name = "Txb_Buscar";
            this.Txb_Buscar.Size = new System.Drawing.Size(373, 23);
            this.Txb_Buscar.TabIndex = 0;
            // 
            // Lbl_Buscar
            // 
            this.Lbl_Buscar.AutoSize = true;
            this.Lbl_Buscar.Location = new System.Drawing.Point(8, 16);
            this.Lbl_Buscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Buscar.Name = "Lbl_Buscar";
            this.Lbl_Buscar.Size = new System.Drawing.Size(57, 16);
            this.Lbl_Buscar.TabIndex = 1;
            this.Lbl_Buscar.Text = "Buscar:";
            // 
            // Tbp_Edicion
            // 
            this.Tbp_Edicion.Controls.Add(this.Txb_Sigla_carr);
            this.Tbp_Edicion.Controls.Add(this.label2);
            this.Tbp_Edicion.Controls.Add(this.Btn_Retornar);
            this.Tbp_Edicion.Controls.Add(this.Btn_Cancelar);
            this.Tbp_Edicion.Controls.Add(this.Btn_Guardar);
            this.Tbp_Edicion.Controls.Add(this.Txb_Nombre_carr);
            this.Tbp_Edicion.Controls.Add(this.label1);
            this.Tbp_Edicion.Location = new System.Drawing.Point(4, 25);
            this.Tbp_Edicion.Margin = new System.Windows.Forms.Padding(4);
            this.Tbp_Edicion.Name = "Tbp_Edicion";
            this.Tbp_Edicion.Padding = new System.Windows.Forms.Padding(4);
            this.Tbp_Edicion.Size = new System.Drawing.Size(450, 326);
            this.Tbp_Edicion.TabIndex = 1;
            this.Tbp_Edicion.Text = "Edición";
            this.Tbp_Edicion.UseVisualStyleBackColor = true;
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Location = new System.Drawing.Point(229, 158);
            this.Btn_Cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(85, 28);
            this.Btn_Cancelar.TabIndex = 4;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Visible = false;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Location = new System.Drawing.Point(116, 158);
            this.Btn_Guardar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(85, 28);
            this.Btn_Guardar.TabIndex = 3;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Visible = false;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Txb_Nombre_carr
            // 
            this.Txb_Nombre_carr.Location = new System.Drawing.Point(116, 127);
            this.Txb_Nombre_carr.Margin = new System.Windows.Forms.Padding(4);
            this.Txb_Nombre_carr.Name = "Txb_Nombre_carr";
            this.Txb_Nombre_carr.ReadOnly = true;
            this.Txb_Nombre_carr.Size = new System.Drawing.Size(315, 23);
            this.Txb_Nombre_carr.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carrocería:(*)";
            // 
            // Btn_Nuevo
            // 
            this.Btn_Nuevo.Location = new System.Drawing.Point(16, 374);
            this.Btn_Nuevo.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.Size = new System.Drawing.Size(83, 33);
            this.Btn_Nuevo.TabIndex = 6;
            this.Btn_Nuevo.Text = "Nuevo";
            this.Btn_Nuevo.UseVisualStyleBackColor = true;
            this.Btn_Nuevo.Click += new System.EventHandler(this.Btn_Nuevo_Click);
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.Location = new System.Drawing.Point(107, 374);
            this.Btn_Modificar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(83, 33);
            this.Btn_Modificar.TabIndex = 7;
            this.Btn_Modificar.Text = "Modificar";
            this.Btn_Modificar.UseVisualStyleBackColor = true;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click_1);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Location = new System.Drawing.Point(198, 374);
            this.Btn_Eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(83, 33);
            this.Btn_Eliminar.TabIndex = 8;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.Location = new System.Drawing.Point(391, 374);
            this.Btn_Salir.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(83, 33);
            this.Btn_Salir.TabIndex = 9;
            this.Btn_Salir.Text = "SALIR";
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_Retornar
            // 
            this.Btn_Retornar.Location = new System.Drawing.Point(346, 158);
            this.Btn_Retornar.Name = "Btn_Retornar";
            this.Btn_Retornar.Size = new System.Drawing.Size(85, 28);
            this.Btn_Retornar.TabIndex = 5;
            this.Btn_Retornar.Text = "Retornar";
            this.Btn_Retornar.UseVisualStyleBackColor = true;
            this.Btn_Retornar.Visible = false;
            this.Btn_Retornar.Click += new System.EventHandler(this.Btn_Retornar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sigla: (*)";
            // 
            // Txb_Sigla_carr
            // 
            this.Txb_Sigla_carr.Location = new System.Drawing.Point(116, 97);
            this.Txb_Sigla_carr.Name = "Txb_Sigla_carr";
            this.Txb_Sigla_carr.ReadOnly = true;
            this.Txb_Sigla_carr.Size = new System.Drawing.Size(100, 23);
            this.Txb_Sigla_carr.TabIndex = 1;
            // 
            // Frm_Carroceria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 419);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.Btn_Nuevo);
            this.Controls.Add(this.Tc_Carrocerias);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Frm_Carroceria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carrocerias Vehiculares";
            this.Load += new System.EventHandler(this.Frm_Carroceria_Load);
            this.Tc_Carrocerias.ResumeLayout(false);
            this.Tbp_ListaDeCarrocerias.ResumeLayout(false);
            this.Tbp_ListaDeCarrocerias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Carroceria)).EndInit();
            this.Tbp_Edicion.ResumeLayout(false);
            this.Tbp_Edicion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tc_Carrocerias;
        private System.Windows.Forms.TabPage Tbp_ListaDeCarrocerias;
        private System.Windows.Forms.TabPage Tbp_Edicion;
        private System.Windows.Forms.DataGridView Dgv_Carroceria;
        private System.Windows.Forms.TextBox Txb_Buscar;
        private System.Windows.Forms.Label Lbl_Buscar;
        private System.Windows.Forms.Button Btn_Nuevo;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.TextBox Txb_Nombre_carr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Retornar;
        private System.Windows.Forms.TextBox Txb_Sigla_carr;
        private System.Windows.Forms.Label label2;
    }
}