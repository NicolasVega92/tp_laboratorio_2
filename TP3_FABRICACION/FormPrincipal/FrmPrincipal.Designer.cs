
namespace FormPrincipal
{
    partial class FrmPrincipal
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.chckBoxFinalizado = new System.Windows.Forms.CheckBox();
            this.chckBoxLaminado = new System.Windows.Forms.CheckBox();
            this.chckBoxCorteConGas = new System.Windows.Forms.CheckBox();
            this.chckBoxDistribuir = new System.Windows.Forms.CheckBox();
            this.chckBoxColada = new System.Windows.Forms.CheckBox();
            this.chckBoxAltohorno = new System.Windows.Forms.CheckBox();
            this.chckBoxSinOperar = new System.Windows.Forms.CheckBox();
            this.chckBoxTodos = new System.Windows.Forms.CheckBox();
            this.dtGridVista = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnAvanzarProceso = new System.Windows.Forms.Button();
            this.grpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridVista)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(13, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(368, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Proceso de Fabricación del Acero";
            // 
            // grpBox
            // 
            this.grpBox.Controls.Add(this.chckBoxFinalizado);
            this.grpBox.Controls.Add(this.chckBoxLaminado);
            this.grpBox.Controls.Add(this.chckBoxCorteConGas);
            this.grpBox.Controls.Add(this.chckBoxDistribuir);
            this.grpBox.Controls.Add(this.chckBoxColada);
            this.grpBox.Controls.Add(this.chckBoxAltohorno);
            this.grpBox.Controls.Add(this.chckBoxSinOperar);
            this.grpBox.Controls.Add(this.chckBoxTodos);
            this.grpBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox.Location = new System.Drawing.Point(18, 105);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(208, 218);
            this.grpBox.TabIndex = 1;
            this.grpBox.TabStop = false;
            this.grpBox.Text = "Vista";
            // 
            // chckBoxFinalizado
            // 
            this.chckBoxFinalizado.AutoSize = true;
            this.chckBoxFinalizado.Location = new System.Drawing.Point(7, 179);
            this.chckBoxFinalizado.Name = "chckBoxFinalizado";
            this.chckBoxFinalizado.Size = new System.Drawing.Size(110, 24);
            this.chckBoxFinalizado.TabIndex = 7;
            this.chckBoxFinalizado.Text = "Finalizado";
            this.chckBoxFinalizado.UseVisualStyleBackColor = true;
            // 
            // chckBoxLaminado
            // 
            this.chckBoxLaminado.AutoSize = true;
            this.chckBoxLaminado.Location = new System.Drawing.Point(7, 158);
            this.chckBoxLaminado.Name = "chckBoxLaminado";
            this.chckBoxLaminado.Size = new System.Drawing.Size(106, 24);
            this.chckBoxLaminado.TabIndex = 6;
            this.chckBoxLaminado.Text = "Laminado";
            this.chckBoxLaminado.UseVisualStyleBackColor = true;
            // 
            // chckBoxCorteConGas
            // 
            this.chckBoxCorteConGas.AutoSize = true;
            this.chckBoxCorteConGas.Location = new System.Drawing.Point(7, 135);
            this.chckBoxCorteConGas.Name = "chckBoxCorteConGas";
            this.chckBoxCorteConGas.Size = new System.Drawing.Size(140, 24);
            this.chckBoxCorteConGas.TabIndex = 5;
            this.chckBoxCorteConGas.Text = "Corte con gas";
            this.chckBoxCorteConGas.UseVisualStyleBackColor = true;
            // 
            // chckBoxDistribuir
            // 
            this.chckBoxDistribuir.AutoSize = true;
            this.chckBoxDistribuir.Location = new System.Drawing.Point(7, 112);
            this.chckBoxDistribuir.Name = "chckBoxDistribuir";
            this.chckBoxDistribuir.Size = new System.Drawing.Size(100, 24);
            this.chckBoxDistribuir.TabIndex = 4;
            this.chckBoxDistribuir.Text = "Distribuir";
            this.chckBoxDistribuir.UseVisualStyleBackColor = true;
            // 
            // chckBoxColada
            // 
            this.chckBoxColada.AutoSize = true;
            this.chckBoxColada.Location = new System.Drawing.Point(7, 89);
            this.chckBoxColada.Name = "chckBoxColada";
            this.chckBoxColada.Size = new System.Drawing.Size(84, 24);
            this.chckBoxColada.TabIndex = 3;
            this.chckBoxColada.Text = "Colada";
            this.chckBoxColada.UseVisualStyleBackColor = true;
            // 
            // chckBoxAltohorno
            // 
            this.chckBoxAltohorno.AutoSize = true;
            this.chckBoxAltohorno.Location = new System.Drawing.Point(7, 66);
            this.chckBoxAltohorno.Name = "chckBoxAltohorno";
            this.chckBoxAltohorno.Size = new System.Drawing.Size(111, 24);
            this.chckBoxAltohorno.TabIndex = 2;
            this.chckBoxAltohorno.Text = "Alto horno";
            this.chckBoxAltohorno.UseVisualStyleBackColor = true;
            // 
            // chckBoxSinOperar
            // 
            this.chckBoxSinOperar.AutoSize = true;
            this.chckBoxSinOperar.Location = new System.Drawing.Point(7, 43);
            this.chckBoxSinOperar.Name = "chckBoxSinOperar";
            this.chckBoxSinOperar.Size = new System.Drawing.Size(111, 24);
            this.chckBoxSinOperar.TabIndex = 1;
            this.chckBoxSinOperar.Text = "Sin operar";
            this.chckBoxSinOperar.UseVisualStyleBackColor = true;
            // 
            // chckBoxTodos
            // 
            this.chckBoxTodos.AutoSize = true;
            this.chckBoxTodos.Location = new System.Drawing.Point(7, 20);
            this.chckBoxTodos.Name = "chckBoxTodos";
            this.chckBoxTodos.Size = new System.Drawing.Size(183, 24);
            this.chckBoxTodos.TabIndex = 0;
            this.chckBoxTodos.Text = "Todos los procesos";
            this.chckBoxTodos.UseVisualStyleBackColor = true;
            // 
            // dtGridVista
            // 
            this.dtGridVista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridVista.Location = new System.Drawing.Point(232, 105);
            this.dtGridVista.Name = "dtGridVista";
            this.dtGridVista.Size = new System.Drawing.Size(691, 218);
            this.dtGridVista.TabIndex = 2;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(40, 421);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(125, 57);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(177, 421);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(125, 57);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(315, 421);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(125, 57);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(798, 437);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(125, 57);
            this.btnExportar.TabIndex = 6;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            // 
            // btnAvanzarProceso
            // 
            this.btnAvanzarProceso.Location = new System.Drawing.Point(177, 358);
            this.btnAvanzarProceso.Name = "btnAvanzarProceso";
            this.btnAvanzarProceso.Size = new System.Drawing.Size(125, 57);
            this.btnAvanzarProceso.TabIndex = 7;
            this.btnAvanzarProceso.Text = "Avanzar Proceso";
            this.btnAvanzarProceso.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(936, 506);
            this.Controls.Add(this.btnAvanzarProceso);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dtGridVista);
            this.Controls.Add(this.grpBox);
            this.Controls.Add(this.lblTitulo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nicolas.Vega.2C";
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridVista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.CheckBox chckBoxFinalizado;
        private System.Windows.Forms.CheckBox chckBoxLaminado;
        private System.Windows.Forms.CheckBox chckBoxCorteConGas;
        private System.Windows.Forms.CheckBox chckBoxDistribuir;
        private System.Windows.Forms.CheckBox chckBoxColada;
        private System.Windows.Forms.CheckBox chckBoxAltohorno;
        private System.Windows.Forms.CheckBox chckBoxSinOperar;
        private System.Windows.Forms.CheckBox chckBoxTodos;
        private System.Windows.Forms.DataGridView dtGridVista;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnAvanzarProceso;
    }
}

