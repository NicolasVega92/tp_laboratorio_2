using Entidades;
using Entidades.Enumerados;
using Serializable;
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
        List<MateriaPrima> listaFiltro;
        Mensaje miMensaje;
        List<Mensaje> listaMensajes;
        /// <summary>
        /// Constructor del FrmPrincipal
        /// </summary>
        public FrmPrincipal()
        {
            InitializeComponent();
            stock = new Stock("Lista de materiales");
            listaFiltro = new List<MateriaPrima>();
            listaMensajes = new List<Mensaje>();
        }
        /// <summary>
        /// Se genera cuando se carga el formulario, agregando informacion al dataGrid y colocando valores a los comboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            Arrabio arrabio = new Arrabio(EProceso.SinOperar, "Arrabio", "Ushuahia", 1000, ECalidad.Excelente, EColorMaterial.Azul);
            Arrabio arrabioIgual = new Arrabio(EProceso.SinOperar, "Arrabio", "Ushuahia", 1000, ECalidad.Excelente, EColorMaterial.Azul);
            Reciclado reciclado = new Reciclado(EProceso.CorteConGas, "Reciclado", "CABA", 333, ECalidad.Excelente, EColorMaterial.Rojo);
            Arrabio arrabioMismosDatosReciclado = new Arrabio(EProceso.CorteConGas, "Arrabio", "CABA", 333, ECalidad.Excelente, EColorMaterial.Rojo);
            Reciclado recicladoIgual = new Reciclado(EProceso.CorteConGas, "Reciclado", "CABA", 333, ECalidad.Excelente, EColorMaterial.Rojo);
            Reciclado recicladoOtro = new Reciclado(EProceso.Laminada, "Reciclado", "Ushuahia", 222, ECalidad.Malo, EColorMaterial.Descolorido);
            stock = stock + arrabio;
            stock = stock + arrabioIgual;   //NO SE DEBERIA SUMAR
            stock = stock + arrabioMismosDatosReciclado; //con diferente tipo de dato 
            stock = stock + reciclado;
            stock = stock + recicladoIgual; //NO SE DEBERIA SUMAR
            stock = stock + recicladoOtro;

            this.cmbProceso.DataSource = Enum.GetNames(typeof(EProceso));
            this.cmbMaterial.DataSource = Enum.GetNames(typeof(ETipoMaterial));
            this.cmbCalidad.DataSource = Enum.GetNames(typeof(ECalidad));
            this.cmbColor.DataSource = Enum.GetNames(typeof(EColorMaterial));
            //this.dtgvView.DataSource = stock.ListaDeMateriales;
            AgregarData(stock.ListaDeMateriales);
            Limpiar();
        }
        /// <summary>
        /// Al presionar el boton Agregar, se generara una nueva linea en el DataGrid con los valores establecidos en los textBox y comboBox.
        /// A su vez se crea una instancia de Mensaje que se agrega a la lista con los valores del material
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (CorroborarDatos())
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
                miMensaje = new Mensaje(this.cmbProceso.Text,
                                        this.cmbMaterial.Text,
                                        this.txtOrigen.Text,
                                        this.txtCantidad.Text,
                                        this.cmbCalidad.Text,
                                        this.cmbColor.Text);
                MensajeCargado.Mensaje = miMensaje;
                listaMensajes = listaMensajes + miMensaje;
                //miMensaje.GuardarTxt();
                //miMensaje.GuardarXml();
                Limpiar();
            }
            else
            {
                MessageBox.Show("Complete todos los campos, antes de continuar",
                                "Rellenar datos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Agrega informacion por defecto al DataGrid cuando se inicia el programa
        /// </summary>
        /// <param name="lista"></param>
        private void AgregarData(List<MateriaPrima> lista)
        {
            this.dtgvView.DataSource = null;
            foreach (var item in lista)
            {
                indice = this.dtgvView.Rows.Add();
                this.dtgvView.Rows[indice].Cells[0].Value = item.Proceso;
                this.dtgvView.Rows[indice].Cells[1].Value = item.GetType().Name;
                this.dtgvView.Rows[indice].Cells[3].Value = item.Cantidad;
                this.dtgvView.Rows[indice].Cells[4].Value = item.Calidad;
                this.dtgvView.Rows[indice].Cells[5].Value = item.Color;
                if(item is Arrabio)
                {
                    this.dtgvView.Rows[indice].Cells[2].Value = ((Arrabio)item).Origen;
                }
                else if(item is Reciclado)
                {
                    this.dtgvView.Rows[indice].Cells[2].Value = ((Reciclado)item).Origen;
                }
                miMensaje = new Mensaje(item.Proceso.ToString(),
                                        item.GetType().Name,
                                        item.Origen,
                                        item.Cantidad.ToString(),
                                        item.Calidad.ToString(),
                                        item.Color.ToString());
                MensajeCargado.Mensaje = miMensaje;
                listaMensajes = listaMensajes + miMensaje;
            }
        }
        /// <summary>
        /// Establece los campos del formulario en vacios
        /// </summary>
        private void Limpiar()
        {
            this.cmbProceso.SelectedIndex = -1;
            this.cmbMaterial.SelectedIndex = -1;
            this.txtOrigen.Text = string.Empty;
            this.txtCantidad.Text = string.Empty;
            this.cmbCalidad.SelectedIndex = -1;
            this.cmbColor.SelectedIndex = -1;
        }
        /// <summary>
        /// Identifica el indice de Fila seleccionado por el usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtgvView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
        }
        /// <summary>
        /// Elimina del DataGrid la fila seleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (indice != -1)
                {
                    dtgvView.Rows.RemoveAt(indice);
                }
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("Seleccione la fila que desea borrar", 
                                "CUIDADO!", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Corrobora que todos los campos a llenar no esten vacios al momento de proseguir con la accion
        /// </summary>
        /// <returns></returns>
        private bool CorroborarDatos()
        {
            bool retorno = false;
            if( this.cmbProceso.Text != string.Empty    &&
                this.cmbMaterial.Text != string.Empty   &&
                this.txtOrigen.Text != string.Empty     &&
                this.txtCantidad.Text != string.Empty   &&
                this.cmbCalidad.Text != string.Empty    &&
                this.cmbColor.Text != string.Empty)
            {
                retorno = true;
            }
            return retorno;
        }
        /// <summary>
        /// Filtra la lista de elementos del DataGrid segun el proceso del material
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <param name="proceso"></param>
        private void FiltrarDataGrid(DataGridView dataGridView, EProceso proceso)
        {
            listaFiltro = stock.FiltrarLista(stock.ListaDeMateriales, proceso);
            if(listaFiltro.Count > 0)
            {
                AgregarData(listaFiltro);
            }
        }
        /// <summary>
        /// Permite Editar una fila del DataGrid, al seleccionar la fila, esta sera eliminada y los valores retornaran a los campos a completar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if(indice != -1)
                {
                    this.cmbProceso.Text = (string)this.dtgvView.Rows[indice].Cells[0].Value;
                    this.cmbMaterial.Text = (string)this.dtgvView.Rows[indice].Cells[1].Value;
                    this.txtOrigen.Text = (string)this.dtgvView.Rows[indice].Cells[2].Value;
                    this.txtCantidad.Text = (string)this.dtgvView.Rows[indice].Cells[3].Value;
                    this.cmbCalidad.Text = (string)this.dtgvView.Rows[indice].Cells[4].Value;
                    this.cmbColor.Text = (string)this.dtgvView.Rows[indice].Cells[5].Value;
                    btnEliminar_Click(sender, e);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Seleccione la fila que desea editar",
                "CUIDADO!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// Condiciona que solo se puedan ingresar numeros
        /// </summary>
        /// <param name="pE"></param>
        public static void SoloNumeros(KeyPressEventArgs pE)
        {
            if(char.IsDigit(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if(char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
            }
        }
        /// <summary>
        /// Permite solo ingresar numeros 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }
        /// <summary>
        /// Exporta en la carpeta del usuario todos los Materiales cargados por el, en formate TXT y XML
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExportar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se han creado los archivos correspondientes", "EXPORTAR INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            foreach (Mensaje item in listaMensajes)
            {
                item.GuardarTxt();
                item.GuardarXml();
            }

        }
    }
}
