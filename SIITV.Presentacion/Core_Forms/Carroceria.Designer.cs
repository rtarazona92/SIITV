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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Dgv_Categorias = new System.Windows.Forms.DataGridView();
            this.Txb_Buscar = new System.Windows.Forms.TextBox();
            this.Lbl_Buscar = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Txb_Nombre_ca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.Btn_Actualizar = new System.Windows.Forms.Button();
            this.Btn_Reporte = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Tc_Carrocerias.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Categorias)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tc_Carrocerias
            // 
            this.Tc_Carrocerias.Controls.Add(this.tabPage1);
            this.Tc_Carrocerias.Controls.Add(this.tabPage2);
            this.Tc_Carrocerias.Location = new System.Drawing.Point(18, 17);
            this.Tc_Carrocerias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tc_Carrocerias.Name = "Tc_Carrocerias";
            this.Tc_Carrocerias.SelectedIndex = 0;
            this.Tc_Carrocerias.Size = new System.Drawing.Size(915, 399);
            this.Tc_Carrocerias.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Dgv_Categorias);
            this.tabPage1.Controls.Add(this.Txb_Buscar);
            this.tabPage1.Controls.Add(this.Lbl_Buscar);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(907, 368);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lista de Carrocerías";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Dgv_Categorias
            // 
            this.Dgv_Categorias.AllowUserToAddRows = false;
            this.Dgv_Categorias.AllowUserToDeleteRows = false;
            this.Dgv_Categorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Categorias.Location = new System.Drawing.Point(9, 50);
            this.Dgv_Categorias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Dgv_Categorias.Name = "Dgv_Categorias";
            this.Dgv_Categorias.ReadOnly = true;
            this.Dgv_Categorias.Size = new System.Drawing.Size(885, 305);
            this.Dgv_Categorias.TabIndex = 2;
            // 
            // Txb_Buscar
            // 
            this.Txb_Buscar.Location = new System.Drawing.Point(78, 14);
            this.Txb_Buscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txb_Buscar.Name = "Txb_Buscar";
            this.Txb_Buscar.Size = new System.Drawing.Size(361, 26);
            this.Txb_Buscar.TabIndex = 1;
            // 
            // Lbl_Buscar
            // 
            this.Lbl_Buscar.AutoSize = true;
            this.Lbl_Buscar.Location = new System.Drawing.Point(9, 18);
            this.Lbl_Buscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Buscar.Name = "Lbl_Buscar";
            this.Lbl_Buscar.Size = new System.Drawing.Size(65, 18);
            this.Lbl_Buscar.TabIndex = 1;
            this.Lbl_Buscar.Text = "Buscar:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Btn_Cancelar);
            this.tabPage2.Controls.Add(this.Btn_Guardar);
            this.tabPage2.Controls.Add(this.Txb_Nombre_ca);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(907, 368);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Edición";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Location = new System.Drawing.Point(225, 50);
            this.Btn_Cancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(112, 32);
            this.Btn_Cancelar.TabIndex = 3;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Location = new System.Drawing.Point(104, 50);
            this.Btn_Guardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(112, 32);
            this.Btn_Guardar.TabIndex = 2;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            // 
            // Txb_Nombre_ca
            // 
            this.Txb_Nombre_ca.Location = new System.Drawing.Point(104, 14);
            this.Txb_Nombre_ca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txb_Nombre_ca.Name = "Txb_Nombre_ca";
            this.Txb_Nombre_ca.Size = new System.Drawing.Size(232, 26);
            this.Txb_Nombre_ca.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categoría:";
            // 
            // Btn_Nuevo
            // 
            this.Btn_Nuevo.Location = new System.Drawing.Point(33, 424);
            this.Btn_Nuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.Size = new System.Drawing.Size(122, 60);
            this.Btn_Nuevo.TabIndex = 3;
            this.Btn_Nuevo.Text = "Nuevo";
            this.Btn_Nuevo.UseVisualStyleBackColor = true;
            // 
            // Btn_Actualizar
            // 
            this.Btn_Actualizar.Location = new System.Drawing.Point(219, 424);
            this.Btn_Actualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Actualizar.Name = "Btn_Actualizar";
            this.Btn_Actualizar.Size = new System.Drawing.Size(122, 60);
            this.Btn_Actualizar.TabIndex = 4;
            this.Btn_Actualizar.Text = "Modificar";
            this.Btn_Actualizar.UseVisualStyleBackColor = true;
            // 
            // Btn_Reporte
            // 
            this.Btn_Reporte.Location = new System.Drawing.Point(598, 424);
            this.Btn_Reporte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Reporte.Name = "Btn_Reporte";
            this.Btn_Reporte.Size = new System.Drawing.Size(122, 60);
            this.Btn_Reporte.TabIndex = 6;
            this.Btn_Reporte.Text = "Reporte";
            this.Btn_Reporte.UseVisualStyleBackColor = true;
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Location = new System.Drawing.Point(406, 424);
            this.Btn_Eliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(122, 60);
            this.Btn_Eliminar.TabIndex = 5;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.Location = new System.Drawing.Point(796, 424);
            this.Btn_Salir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(122, 60);
            this.Btn_Salir.TabIndex = 7;
            this.Btn_Salir.Text = "SALIR";
            this.Btn_Salir.UseVisualStyleBackColor = true;
            // 
            // Frm_Carroceria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 500);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Reporte);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Actualizar);
            this.Controls.Add(this.Btn_Nuevo);
            this.Controls.Add(this.Tc_Carrocerias);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_Carroceria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carrocerias Vehiculares";
            this.Tc_Carrocerias.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Categorias)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tc_Carrocerias;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView Dgv_Categorias;
        private System.Windows.Forms.TextBox Txb_Buscar;
        private System.Windows.Forms.Label Lbl_Buscar;
        private System.Windows.Forms.Button Btn_Nuevo;
        private System.Windows.Forms.Button Btn_Actualizar;
        private System.Windows.Forms.Button Btn_Reporte;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.TextBox Txb_Nombre_ca;
        private System.Windows.Forms.Label label1;
    }
}