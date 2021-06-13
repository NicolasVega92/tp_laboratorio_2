using Entidades;
using Entidades.Enumerados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPrincipal
{
    public partial class FrmPrincipal : Form
    {
        Stock stock;
        private int indice;
        public FrmPrincipal()
        {
            InitializeComponent();
            stock = new Stock("Lista de materiales");
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            Arrabio arrabio = new Arrabio("Ushuahia", 1000, ECalidad.Excelente, EColorMaterial.Azul, EProceso.SinOperar);
            Arrabio arrabioIgual = new Arrabio("Ushuahia", 1000, ECalidad.Excelente, EColorMaterial.Azul, EProceso.SinOperar);
            Reciclado reciblado = new Reciclado("BuenosAires", 200, ECalidad.Bueno, EColorMaterial.Descolorido, EProceso.AltoHorno);
            Arrabio arrabioMismosDatosReciclado = new Arrabio("BuenosAires", 200, ECalidad.Bueno, EColorMaterial.Descolorido, EProceso.AltoHorno);
            Reciclado recibladoIgual = new Reciclado("BuenosAires", 200, ECalidad.Malo, EColorMaterial.Descolorido, EProceso.AltoHorno);
            Reciclado recibladoOtro = new Reciclado("Cordoba", 400, ECalidad.Malo, EColorMaterial.Rojo, EProceso.CorteConGas);

            stock = stock + arrabio;
            stock = stock + arrabioIgual;   //NO SE DEBERIA SUMAR
            stock = stock + arrabioMismosDatosReciclado; //con diferente tipo de dato 
            stock = stock + reciblado;
            stock = stock + recibladoIgual; //NO SE DEBERIA SUMAR
            stock = stock + recibladoOtro;

            //this.dtgvView.DataSource = stock.ListaDeMateriales;

            this.cmbProceso.DataSource = Enum.GetNames(typeof(EProceso));
            this.cmbMaterial.DataSource = Enum.GetNames(typeof(ETipoMaterial));
            this.cmbCalidad.DataSource = Enum.GetNames(typeof(ECalidad));
            this.cmbColor.DataSource = Enum.GetNames(typeof(EColorMaterial));
            AgregarData();
            Limpiar();
        }
        private void chckBoxTodos_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Obtengo el indice de la nueva linea creada
            int indice = this.dtgvView.Rows.Add();
            //agrego informacion en el dataGrid
            this.dtgvView.Rows[indice].Cells[0].Value = this.cmbProceso.Text;
            this.dtgvView.Rows[indice].Cells[1].Value = this.cmbMaterial.Text;
            this.dtgvView.Rows[indice].Cells[2].Value = this.txtOrigen.Text;
            this.dtgvView.Rows[indice].Cells[3].Value = this.txtCantidad.Text;
            this.dtgvView.Rows[indice].Cells[4].Value = this.cmbCalidad.Text;
            this.dtgvView.Rows[indice].Cells[5].Value = this.cmbColor.Text;
            Limpiar();
        }
        private void AgregarData()
        {
            int indice;
            foreach (var item in stock.ListaDeMateriales)
            {
                indice = this.dtgvView.Rows.Add();
                this.dtgvView.Rows[indice].Cells[0].Value = item.Proceso;
                this.dtgvView.Rows[indice].Cells[1].Value = item.GetType().Name;
                this.dtgvView.Rows[indice].Cells[3].Value = item.Cantidad;
                this.dtgvView.Rows[indice].Cells[4].Value = item.Calidad;
                this.dtgvView.Rows[indice].Cells[5].Value = item.Color;
                if(item is Arrabio)
                {
                    this.dtgvView.Rows[indice].Cells[2].Value = ((Arrabio)item).EmpresaOrigen;
                }
                else if(item is Reciclado)
                {
                    this.dtgvView.Rows[indice].Cells[2].Value = ((Reciclado)item).BasuralOrigen;
                }
            }
        }
        private void Limpiar()
        {
            this.cmbProceso.SelectedIndex = -1;
            this.cmbMaterial.SelectedIndex = -1;
            this.txtOrigen.Text = string.Empty;
            this.txtCantidad.Text = string.Empty;
            this.cmbCalidad.SelectedIndex = -1;
            this.cmbColor.SelectedIndex = -1;
        }

        private void dtgvView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(indice != -1)
            {
                dtgvView.Rows.RemoveAt(indice);
            }
        }
    }
}
