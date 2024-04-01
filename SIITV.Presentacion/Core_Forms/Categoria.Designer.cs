namespace SIITV.Presentacion
{
    partial class Frm_Categoria
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
            this.Tc_Principal = new System.Windows.Forms.TabControl();
            this.Tbp_Lista = new System.Windows.Forms.TabPage();
            this.Dgv_Lista = new System.Windows.Forms.DataGridView();
            this.Txb_Buscar = new System.Windows.Forms.TextBox();
            this.Lbl_Buscar = new System.Windows.Forms.Label();
            this.Tbp_Edicion = new System.Windows.Forms.TabPage();
            this.Txb_Sigla = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Retornar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Tc_Principal.SuspendLayout();
            this.Tbp_Lista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Lista)).BeginInit();
            this.Tbp_Edicion.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tc_Principal
            // 
            this.Tc_Principal.Controls.Add(this.Tbp_Lista);
            this.Tc_Principal.Controls.Add(this.Tbp_Edicion);
            this.Tc_Principal.Location = new System.Drawing.Point(13, 15);
            this.Tc_Principal.Margin = new System.Windows.Forms.Padding(4);
            this.Tc_Principal.Name = "Tc_Principal";
            this.Tc_Principal.SelectedIndex = 0;
            this.Tc_Principal.Size = new System.Drawing.Size(465, 312);
            this.Tc_Principal.TabIndex = 10;
            // 
            // Tbp_Lista
            // 
            this.Tbp_Lista.Controls.Add(this.Dgv_Lista);
            this.Tbp_Lista.Controls.Add(this.Txb_Buscar);
            this.Tbp_Lista.Controls.Add(this.Lbl_Buscar);
            this.Tbp_Lista.Location = new System.Drawing.Point(4, 25);
            this.Tbp_Lista.Margin = new System.Windows.Forms.Padding(4);
            this.Tbp_Lista.Name = "Tbp_Lista";
            this.Tbp_Lista.Padding = new System.Windows.Forms.Padding(4);
            this.Tbp_Lista.Size = new System.Drawing.Size(457, 283);
            this.Tbp_Lista.TabIndex = 0;
            this.Tbp_Lista.Text = "Lista de Categorias";
            this.Tbp_Lista.UseVisualStyleBackColor = true;
            // 
            // Dgv_Lista
            // 
            this.Dgv_Lista.AllowUserToAddRows = false;
            this.Dgv_Lista.AllowUserToDeleteRows = false;
            this.Dgv_Lista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Lista.Location = new System.Drawing.Point(8, 44);
            this.Dgv_Lista.Margin = new System.Windows.Forms.Padding(4);
            this.Dgv_Lista.Name = "Dgv_Lista";
            this.Dgv_Lista.ReadOnly = true;
            this.Dgv_Lista.Size = new System.Drawing.Size(434, 231);
            this.Dgv_Lista.TabIndex = 1;
            this.Dgv_Lista.DoubleClick += new System.EventHandler(this.Dgv_Carroceria_DoubleClick);
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
            this.Tbp_Edicion.Controls.Add(this.Txb_Sigla);
            this.Tbp_Edicion.Controls.Add(this.label2);
            this.Tbp_Edicion.Controls.Add(this.Btn_Retornar);
            this.Tbp_Edicion.Controls.Add(this.Btn_Cancelar);
            this.Tbp_Edicion.Controls.Add(this.Btn_Guardar);
            this.Tbp_Edicion.Location = new System.Drawing.Point(4, 25);
            this.Tbp_Edicion.Margin = new System.Windows.Forms.Padding(4);
            this.Tbp_Edicion.Name = "Tbp_Edicion";
            this.Tbp_Edicion.Padding = new System.Windows.Forms.Padding(4);
            this.Tbp_Edicion.Size = new System.Drawing.Size(457, 283);
            this.Tbp_Edicion.TabIndex = 1;
            this.Tbp_Edicion.Text = "Edición";
            this.Tbp_Edicion.UseVisualStyleBackColor = true;
            // 
            // Txb_Sigla
            // 
            this.Txb_Sigla.Location = new System.Drawing.Point(116, 97);
            this.Txb_Sigla.Name = "Txb_Sigla";
            this.Txb_Sigla.ReadOnly = true;
            this.Txb_Sigla.Size = new System.Drawing.Size(100, 23);
            this.Txb_Sigla.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sigla: (*)";
            // 
            // Btn_Retornar
            // 
            this.Btn_Retornar.Enabled = false;
            this.Btn_Retornar.Location = new System.Drawing.Point(301, 157);
            this.Btn_Retornar.Name = "Btn_Retornar";
            this.Btn_Retornar.Size = new System.Drawing.Size(85, 28);
            this.Btn_Retornar.TabIndex = 5;
            this.Btn_Retornar.Text = "Retornar";
            this.Btn_Retornar.UseVisualStyleBackColor = true;
            this.Btn_Retornar.Click += new System.EventHandler(this.Btn_Retornar_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Enabled = false;
            this.Btn_Cancelar.Location = new System.Drawing.Point(209, 158);
            this.Btn_Cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(85, 28);
            this.Btn_Cancelar.TabIndex = 4;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Enabled = false;
            this.Btn_Guardar.Location = new System.Drawing.Point(116, 158);
            this.Btn_Guardar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(85, 28);
            this.Btn_Guardar.TabIndex = 3;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Btn_Nuevo
            // 
            this.Btn_Nuevo.Location = new System.Drawing.Point(17, 340);
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
            this.Btn_Modificar.Enabled = false;
            this.Btn_Modificar.Location = new System.Drawing.Point(140, 340);
            this.Btn_Modificar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(83, 33);
            this.Btn_Modificar.TabIndex = 7;
            this.Btn_Modificar.Text = "Modificar";
            this.Btn_Modificar.UseVisualStyleBackColor = true;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Enabled = false;
            this.Btn_Eliminar.Location = new System.Drawing.Point(267, 340);
            this.Btn_Eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(83, 33);
            this.Btn_Eliminar.TabIndex = 8;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.Location = new System.Drawing.Point(391, 339);
            this.Btn_Salir.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(83, 33);
            this.Btn_Salir.TabIndex = 9;
            this.Btn_Salir.Text = "SALIR";
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Frm_Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 386);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.Btn_Nuevo);
            this.Controls.Add(this.Tc_Principal);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Frm_Categoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categorias Vehiculares";
            this.Load += new System.EventHandler(this.Frm_Carroceria_Load);
            this.Tc_Principal.ResumeLayout(false);
            this.Tbp_Lista.ResumeLayout(false);
            this.Tbp_Lista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Lista)).EndInit();
            this.Tbp_Edicion.ResumeLayout(false);
            this.Tbp_Edicion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tc_Principal;
        private System.Windows.Forms.TabPage Tbp_Lista;
        private System.Windows.Forms.TabPage Tbp_Edicion;
        private System.Windows.Forms.DataGridView Dgv_Lista;
        private System.Windows.Forms.TextBox Txb_Buscar;
        private System.Windows.Forms.Label Lbl_Buscar;
        private System.Windows.Forms.Button Btn_Nuevo;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button Btn_Retornar;
        private System.Windows.Forms.TextBox Txb_Sigla;
        private System.Windows.Forms.Label label2;
    }
}