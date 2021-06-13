
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnAvanzarProceso = new System.Windows.Forms.Button();
            this.dtgvView = new System.Windows.Forms.DataGridView();
            this.ColProceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblProceso = new System.Windows.Forms.Label();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblCalidad = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cmbProceso = new System.Windows.Forms.ComboBox();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.cmbCalidad = new System.Windows.Forms.ComboBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.grpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvView)).BeginInit();
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
            this.grpBox.Location = new System.Drawing.Point(12, 302);
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
            this.chckBoxTodos.CheckedChanged += new System.EventHandler(this.chckBoxTodos_CheckedChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(472, 192);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(125, 57);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(358, 526);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(125, 57);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(598, 526);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(125, 57);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(866, 526);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(125, 57);
            this.btnExportar.TabIndex = 6;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            // 
            // btnAvanzarProceso
            // 
            this.btnAvanzarProceso.Location = new System.Drawing.Point(227, 526);
            this.btnAvanzarProceso.Name = "btnAvanzarProceso";
            this.btnAvanzarProceso.Size = new System.Drawing.Size(125, 57);
            this.btnAvanzarProceso.TabIndex = 7;
            this.btnAvanzarProceso.Text = "Avanzar Proceso";
            this.btnAvanzarProceso.UseVisualStyleBackColor = true;
            // 
            // dtgvView
            // 
            this.dtgvView.BackgroundColor = System.Drawing.Color.White;
            this.dtgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColProceso,
            this.ColMaterial,
            this.ColOrigen,
            this.ColCantidad,
            this.ColCalidad,
            this.ColColor,
            this.ColPrecio});
            this.dtgvView.Location = new System.Drawing.Point(227, 311);
            this.dtgvView.Name = "dtgvView";
            this.dtgvView.Size = new System.Drawing.Size(764, 209);
            this.dtgvView.TabIndex = 8;
            this.dtgvView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvView_CellClick);
            // 
            // ColProceso
            // 
            this.ColProceso.HeaderText = "Proceso";
            this.ColProceso.Name = "ColProceso";
            // 
            // ColMaterial
            // 
            this.ColMaterial.HeaderText = "Material";
            this.ColMaterial.Name = "ColMaterial";
            // 
            // ColOrigen
            // 
            this.ColOrigen.HeaderText = "Origen";
            this.ColOrigen.Name = "ColOrigen";
            // 
            // ColCantidad
            // 
            this.ColCantidad.HeaderText = "Cantidad";
            this.ColCantidad.Name = "ColCantidad";
            // 
            // ColCalidad
            // 
            this.ColCalidad.HeaderText = "Calidad";
            this.ColCalidad.Name = "ColCalidad";
            // 
            // ColColor
            // 
            this.ColColor.HeaderText = "Color";
            this.ColColor.Name = "ColColor";
            // 
            // ColPrecio
            // 
            this.ColPrecio.HeaderText = "Precio";
            this.ColPrecio.Name = "ColPrecio";
            // 
            // lblProceso
            // 
            this.lblProceso.AutoSize = true;
            this.lblProceso.Location = new System.Drawing.Point(224, 67);
            this.lblProceso.Name = "lblProceso";
            this.lblProceso.Size = new System.Drawing.Size(49, 13);
            this.lblProceso.TabIndex = 9;
            this.lblProceso.Text = "Proceso:";
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Location = new System.Drawing.Point(224, 97);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(47, 13);
            this.lblMaterial.TabIndex = 10;
            this.lblMaterial.Text = "Material:";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(224, 126);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(41, 13);
            this.lblOrigen.TabIndex = 11;
            this.lblOrigen.Text = "Origen:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(224, 158);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 12;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblCalidad
            // 
            this.lblCalidad.AutoSize = true;
            this.lblCalidad.Location = new System.Drawing.Point(224, 194);
            this.lblCalidad.Name = "lblCalidad";
            this.lblCalidad.Size = new System.Drawing.Size(45, 13);
            this.lblCalidad.TabIndex = 13;
            this.lblCalidad.Text = "Calidad:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(224, 228);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(34, 13);
            this.lblColor.TabIndex = 14;
            this.lblColor.Text = "Color:";
            // 
            // txtOrigen
            // 
            this.txtOrigen.Location = new System.Drawing.Point(282, 126);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(121, 20);
            this.txtOrigen.TabIndex = 15;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(282, 158);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(121, 20);
            this.txtCantidad.TabIndex = 16;
            // 
            // cmbProceso
            // 
            this.cmbProceso.FormattingEnabled = true;
            this.cmbProceso.Location = new System.Drawing.Point(282, 67);
            this.cmbProceso.Name = "cmbProceso";
            this.cmbProceso.Size = new System.Drawing.Size(121, 21);
            this.cmbProceso.TabIndex = 17;
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(282, 99);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(121, 21);
            this.cmbMaterial.TabIndex = 19;
            // 
            // cmbCalidad
            // 
            this.cmbCalidad.FormattingEnabled = true;
            this.cmbCalidad.Location = new System.Drawing.Point(282, 194);
            this.cmbCalidad.Name = "cmbCalidad";
            this.cmbCalidad.Size = new System.Drawing.Size(121, 21);
            this.cmbCalidad.TabIndex = 20;
            // 
            // cmbColor
            // 
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(282, 228);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(121, 21);
            this.cmbColor.TabIndex = 21;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1003, 595);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.cmbCalidad);
            this.Controls.Add(this.cmbMaterial);
            this.Controls.Add(this.cmbProceso);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblCalidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblOrigen);
            this.Controls.Add(this.lblMaterial);
            this.Controls.Add(this.lblProceso);
            this.Controls.Add(this.dtgvView);
            this.Controls.Add(this.btnAvanzarProceso);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.grpBox);
            this.Controls.Add(this.lblTitulo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nicolas.Vega.2C";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvView)).EndInit();
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
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnAvanzarProceso;
        private System.Windows.Forms.DataGridView dtgvView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecio;
        private System.Windows.Forms.Label lblProceso;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblCalidad;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ComboBox cmbProceso;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.ComboBox cmbCalidad;
        private System.Windows.Forms.ComboBox cmbColor;
    }
}

