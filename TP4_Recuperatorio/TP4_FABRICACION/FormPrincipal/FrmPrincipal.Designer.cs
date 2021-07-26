
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.lblProceso = new System.Windows.Forms.Label();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblCalidad = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cmbProceso = new System.Windows.Forms.ComboBox();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.cmbCalidad = new System.Windows.Forms.ComboBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.rchInfoTemporal = new System.Windows.Forms.RichTextBox();
            this.btnVerMateriales = new System.Windows.Forms.Button();
            this.lblInforme = new System.Windows.Forms.Label();
            this.lblFiltroVer = new System.Windows.Forms.Label();
            this.cmbFiltroTabla = new System.Windows.Forms.ComboBox();
            this.dtgvView = new System.Windows.Forms.DataGridView();
            this.btnOkEditar = new System.Windows.Forms.Button();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.lblNotaInfoTemporal = new System.Windows.Forms.Label();
            this.lblInfoTemporal2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(368, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Proceso de Fabricación del Acero";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(255, 178);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(125, 57);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(26, 286);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(86, 57);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(255, 286);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(125, 57);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(842, 39);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(160, 57);
            this.btnExportar.TabIndex = 6;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // lblProceso
            // 
            this.lblProceso.AutoSize = true;
            this.lblProceso.Location = new System.Drawing.Point(14, 53);
            this.lblProceso.Name = "lblProceso";
            this.lblProceso.Size = new System.Drawing.Size(49, 13);
            this.lblProceso.TabIndex = 9;
            this.lblProceso.Text = "Proceso:";
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Location = new System.Drawing.Point(14, 83);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(47, 13);
            this.lblMaterial.TabIndex = 10;
            this.lblMaterial.Text = "Material:";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(14, 112);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(41, 13);
            this.lblOrigen.TabIndex = 11;
            this.lblOrigen.Text = "Origen:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(14, 144);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 12;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblCalidad
            // 
            this.lblCalidad.AutoSize = true;
            this.lblCalidad.Location = new System.Drawing.Point(14, 180);
            this.lblCalidad.Name = "lblCalidad";
            this.lblCalidad.Size = new System.Drawing.Size(45, 13);
            this.lblCalidad.TabIndex = 13;
            this.lblCalidad.Text = "Calidad:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(14, 214);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(34, 13);
            this.lblColor.TabIndex = 14;
            this.lblColor.Text = "Color:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(72, 144);
            this.txtCantidad.MaxLength = 5;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(121, 20);
            this.txtCantidad.TabIndex = 16;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // cmbProceso
            // 
            this.cmbProceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProceso.FormattingEnabled = true;
            this.cmbProceso.Location = new System.Drawing.Point(72, 53);
            this.cmbProceso.Name = "cmbProceso";
            this.cmbProceso.Size = new System.Drawing.Size(121, 21);
            this.cmbProceso.TabIndex = 17;
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(72, 85);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(121, 21);
            this.cmbMaterial.TabIndex = 19;
            // 
            // cmbCalidad
            // 
            this.cmbCalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCalidad.FormattingEnabled = true;
            this.cmbCalidad.Location = new System.Drawing.Point(72, 180);
            this.cmbCalidad.Name = "cmbCalidad";
            this.cmbCalidad.Size = new System.Drawing.Size(121, 21);
            this.cmbCalidad.TabIndex = 20;
            // 
            // cmbColor
            // 
            this.cmbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(72, 214);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(121, 21);
            this.cmbColor.TabIndex = 21;
            // 
            // rchInfoTemporal
            // 
            this.rchInfoTemporal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchInfoTemporal.Location = new System.Drawing.Point(673, 238);
            this.rchInfoTemporal.Name = "rchInfoTemporal";
            this.rchInfoTemporal.Size = new System.Drawing.Size(643, 406);
            this.rchInfoTemporal.TabIndex = 22;
            this.rchInfoTemporal.Text = "";
            // 
            // btnVerMateriales
            // 
            this.btnVerMateriales.Location = new System.Drawing.Point(448, 286);
            this.btnVerMateriales.Name = "btnVerMateriales";
            this.btnVerMateriales.Size = new System.Drawing.Size(160, 57);
            this.btnVerMateriales.TabIndex = 23;
            this.btnVerMateriales.Text = "Ver Materiales";
            this.btnVerMateriales.UseVisualStyleBackColor = true;
            this.btnVerMateriales.Click += new System.EventHandler(this.btnVerMateriales_Click);
            // 
            // lblInforme
            // 
            this.lblInforme.AutoSize = true;
            this.lblInforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInforme.Location = new System.Drawing.Point(795, 168);
            this.lblInforme.Name = "lblInforme";
            this.lblInforme.Size = new System.Drawing.Size(345, 25);
            this.lblInforme.TabIndex = 25;
            this.lblInforme.Text = "Informe Temporal de Materiales";
            // 
            // lblFiltroVer
            // 
            this.lblFiltroVer.AutoSize = true;
            this.lblFiltroVer.Location = new System.Drawing.Point(445, 238);
            this.lblFiltroVer.Name = "lblFiltroVer";
            this.lblFiltroVer.Size = new System.Drawing.Size(62, 13);
            this.lblFiltroVer.TabIndex = 26;
            this.lblFiltroVer.Text = "Filtro Tabla:";
            // 
            // cmbFiltroTabla
            // 
            this.cmbFiltroTabla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroTabla.FormattingEnabled = true;
            this.cmbFiltroTabla.Location = new System.Drawing.Point(448, 259);
            this.cmbFiltroTabla.Name = "cmbFiltroTabla";
            this.cmbFiltroTabla.Size = new System.Drawing.Size(121, 21);
            this.cmbFiltroTabla.TabIndex = 27;
            // 
            // dtgvView
            // 
            this.dtgvView.AllowUserToAddRows = false;
            this.dtgvView.AllowUserToDeleteRows = false;
            this.dtgvView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgvView.BackgroundColor = System.Drawing.Color.White;
            this.dtgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvView.Location = new System.Drawing.Point(17, 349);
            this.dtgvView.MultiSelect = false;
            this.dtgvView.Name = "dtgvView";
            this.dtgvView.ReadOnly = true;
            this.dtgvView.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dtgvView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvView.Size = new System.Drawing.Size(630, 295);
            this.dtgvView.TabIndex = 8;
            this.dtgvView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvView_CellClick);
            // 
            // btnOkEditar
            // 
            this.btnOkEditar.Location = new System.Drawing.Point(118, 286);
            this.btnOkEditar.Name = "btnOkEditar";
            this.btnOkEditar.Size = new System.Drawing.Size(86, 57);
            this.btnOkEditar.TabIndex = 28;
            this.btnOkEditar.Text = "Ok Editar";
            this.btnOkEditar.UseVisualStyleBackColor = true;
            this.btnOkEditar.Click += new System.EventHandler(this.btnOkEditar_Click);
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(72, 112);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(121, 21);
            this.cmbOrigen.TabIndex = 29;
            // 
            // lblNotaInfoTemporal
            // 
            this.lblNotaInfoTemporal.AutoSize = true;
            this.lblNotaInfoTemporal.Location = new System.Drawing.Point(675, 200);
            this.lblNotaInfoTemporal.Name = "lblNotaInfoTemporal";
            this.lblNotaInfoTemporal.Size = new System.Drawing.Size(499, 13);
            this.lblNotaInfoTemporal.TabIndex = 30;
            this.lblNotaInfoTemporal.Text = "Este cuadro de texto se refrescara cada 5 segundos con la informacion actualizada" +
    " de la Base de Datos";
            // 
            // lblInfoTemporal2
            // 
            this.lblInfoTemporal2.AutoSize = true;
            this.lblInfoTemporal2.Location = new System.Drawing.Point(675, 217);
            this.lblInfoTemporal2.Name = "lblInfoTemporal2";
            this.lblInfoTemporal2.Size = new System.Drawing.Size(564, 13);
            this.lblInfoTemporal2.TabIndex = 31;
            this.lblInfoTemporal2.Text = "Para su correcto entendimiento, el cuadro de texto cambiará su fondo de color al " +
    "momento de actualizar la información";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1328, 656);
            this.Controls.Add(this.lblInfoTemporal2);
            this.Controls.Add(this.lblNotaInfoTemporal);
            this.Controls.Add(this.cmbOrigen);
            this.Controls.Add(this.btnOkEditar);
            this.Controls.Add(this.cmbFiltroTabla);
            this.Controls.Add(this.lblFiltroVer);
            this.Controls.Add(this.lblInforme);
            this.Controls.Add(this.btnVerMateriales);
            this.Controls.Add(this.rchInfoTemporal);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.cmbCalidad);
            this.Controls.Add(this.cmbMaterial);
            this.Controls.Add(this.cmbProceso);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblCalidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblOrigen);
            this.Controls.Add(this.lblMaterial);
            this.Controls.Add(this.lblProceso);
            this.Controls.Add(this.dtgvView);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblTitulo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nicolas.Vega.2C";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Label lblProceso;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblCalidad;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ComboBox cmbProceso;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.ComboBox cmbCalidad;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.RichTextBox rchInfoTemporal;
        private System.Windows.Forms.Button btnVerMateriales;
        private System.Windows.Forms.Label lblInforme;
        private System.Windows.Forms.Label lblFiltroVer;
        private System.Windows.Forms.ComboBox cmbFiltroTabla;
        private System.Windows.Forms.DataGridView dtgvView;
        private System.Windows.Forms.Button btnOkEditar;
        private System.Windows.Forms.ComboBox cmbOrigen;
        private System.Windows.Forms.Label lblNotaInfoTemporal;
        private System.Windows.Forms.Label lblInfoTemporal2;
    }
}

