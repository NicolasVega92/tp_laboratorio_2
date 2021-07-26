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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPrincipal
{
    public partial class FrmPrincipal : Form
    {
        private int indice;
        Mensaje miMensaje;
        List<Mensaje> listaMensajes;
        List<MateriaPrima> listaThread;
        List<MateriaPrima> materiasPrimas;

        public delegate void Botones();
        public event Botones okEditarEventHandler;
        public event Botones okEditarDeshabilitarEventHandler;

        Thread thread; //creo el hilo
        public delegate void Callback(string lista);
        Thread threadIniciador;

        /// <summary>
        /// Constructor del FrmPrincipal
        /// </summary>
        public FrmPrincipal()
        {
            InitializeComponent();
            listaMensajes = new List<Mensaje>();
        }
        /// <summary>
        /// Se genera cuando se carga el formulario, agregando informacion al dataGrid y colocando valores a los comboBox
        /// Inicia El thread Iniciador 
        /// Se asocian eventos a su correspondiente manejador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                this.materiasPrimas = MateriaPrimaDAO.SelectMateriaPrima();
                foreach (var item in materiasPrimas)
                {
                    miMensaje = new Mensaje
                    (
                        item.Proceso,
                        item.Material,
                        item.Origen,
                        item.Cantidad.ToString(),
                        item.Calidad,
                        item.Color
                    );
                    MensajeCargado.Mensaje = miMensaje;
                    listaMensajes = listaMensajes + miMensaje;
                }

            }
            catch(SqlMensajeExcepcion ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }

            this.okEditarEventHandler += DeshabilitarBotonesMenosOkEditar;
            this.okEditarDeshabilitarEventHandler += ActivarBotonesMenosOkEditar;

            threadIniciador = new Thread(InicializarThread);
            threadIniciador.Start();

            //Agrego los valores al los COMBOBOX
            this.cmbProceso.DataSource = Enum.GetNames(typeof(EProceso));
            this.cmbMaterial.DataSource = Enum.GetNames(typeof(ETipoMaterial));
            this.cmbCalidad.DataSource = Enum.GetNames(typeof(ECalidad));
            this.cmbColor.DataSource = Enum.GetNames(typeof(EColorMaterial));
            this.cmbFiltroTabla.DataSource = Enum.GetNames(typeof(EFiltro));
            this.cmbOrigen.DataSource = Enum.GetNames(typeof(EOrigen));

            this.btnOkEditar.Enabled = false;
            this.dtgvView.DataSource = this.materiasPrimas; //asigno al DataGrid la lista de la BD

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
                if(this.cmbMaterial.Text == "Arrabio")
                {
                    Arrabio arrabioAInsertar = new Arrabio
                    {
                        Material = this.cmbMaterial.Text,
                        Proceso = this.cmbProceso.Text,
                        Origen = this.cmbOrigen.Text,
                        Cantidad = int.Parse(this.txtCantidad.Text),
                        Calidad = this.cmbCalidad.Text,
                        Color = this.cmbColor.Text
                    };
                    miMensaje = new Mensaje(this.cmbProceso.Text,
                                            this.cmbMaterial.Text,
                                            this.cmbOrigen.Text,
                                            this.txtCantidad.Text,
                                            this.cmbCalidad.Text,
                                            this.cmbColor.Text);
                    MensajeCargado.Mensaje = miMensaje;
                    listaMensajes = listaMensajes + miMensaje;
                    MateriaPrimaDAO.InsertMateriaPrima(arrabioAInsertar);
                }
                else if(this.cmbMaterial.Text == "Reciclado")
                {
                    Reciclado recicladoAInsertar = new Reciclado
                    {
                        Material = this.cmbMaterial.Text,
                        Proceso = this.cmbProceso.Text,
                        Origen = this.cmbOrigen.Text,
                        Cantidad = int.Parse(this.txtCantidad.Text),
                        Calidad = this.cmbCalidad.Text,
                        Color = this.cmbColor.Text
                    };
                    miMensaje = new Mensaje(this.cmbProceso.Text,
                                            this.cmbMaterial.Text,
                                            this.cmbOrigen.Text,
                                            this.txtCantidad.Text,
                                            this.cmbCalidad.Text,
                                            this.cmbColor.Text);
                    MensajeCargado.Mensaje = miMensaje;
                    listaMensajes = listaMensajes + miMensaje;
                    MateriaPrimaDAO.InsertMateriaPrima(recicladoAInsertar);
                }
                ActualizarDataGrid();
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
        /// Establece los campos del formulario en vacios
        /// </summary>
        private void Limpiar()
        {
            this.cmbProceso.SelectedIndex = -1;
            this.cmbMaterial.SelectedIndex = -1;
            this.cmbOrigen.SelectedIndex = -1;
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
            if (this.dtgvView.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = this.dtgvView.SelectedRows[0];
                int id = (int)fila.Cells[0].Value;
                DialogResult respuesta = MessageBox.Show("¿Esta seguro que desea eliminar este Material?", "Aviso de Elimniar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    if (!MateriaPrimaDAO.DeleteMateriaPrima(id))
                    {
                        MessageBox.Show("Error al intentar eliminar el Material!");
                    }
                    else
                    {
                        MessageBox.Show("Material Eliminado!", "Delete from DB", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            ActualizarDataGrid();
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
                this.cmbOrigen.Text != string.Empty     &&
                this.txtCantidad.Text != string.Empty   &&
                this.cmbCalidad.Text != string.Empty    &&
                this.cmbColor.Text != string.Empty)
            {
                retorno = true;
            }
            return retorno;
        }
        /// <summary>
        /// Coloca los datos de la fila seleccionada en los cuadors de texto para poder ser editados, 
        /// Utiliza el okEditarEventHandler para deshabilitar botones y habilitar otro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.btnOkEditar.Enabled = true;
            this.okEditarEventHandler.Invoke();
            if(indice >= 0 && this.dtgvView.SelectedRows.Count > 0)
            {
                this.cmbProceso.Text = (string)this.dtgvView.Rows[indice].Cells[2].Value;
                this.cmbMaterial.Text = (string)this.dtgvView.Rows[indice].Cells[1].Value;
                this.cmbOrigen.Text = (string)this.dtgvView.Rows[indice].Cells[3].Value;
                this.txtCantidad.Text = this.dtgvView.Rows[indice].Cells[4].Value.ToString();
                this.cmbCalidad.Text = (string)this.dtgvView.Rows[indice].Cells[5].Value;
                this.cmbColor.Text = (string)this.dtgvView.Rows[indice].Cells[6].Value;
                MessageBox.Show("Luego de editar los valores en el FORM, presione el boton \"Ok Editar\"",
                                "¿Como editar?",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
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
        /// <summary>
        /// Realiza una consulta a la BD dependiendo la opcion seleccionada en el comboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVerMateriales_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.cmbFiltroTabla.Text == "Todos")
                {
                    List<MateriaPrima> fabris = MateriaPrimaDAO.SelectMateriaPrima();
                    this.dtgvView.DataSource = fabris;
                }
                else if (this.cmbFiltroTabla.Text == "Arrabio")
                {
                    List<MateriaPrima> fabris = MateriaPrimaDAO.SelectMateriaPrimaRecicladoOArrabio(this.cmbFiltroTabla.Text);
                    this.dtgvView.DataSource = fabris;
                }
                else if (this.cmbFiltroTabla.Text == "Reciclado")
                {
                    List<MateriaPrima> fabris = MateriaPrimaDAO.SelectMateriaPrimaRecicladoOArrabio(this.cmbFiltroTabla.Text);
                    this.dtgvView.DataSource = fabris;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Actualiza la informacion del DataGrid
        /// </summary>
        private void ActualizarDataGrid()
        {
            this.dtgvView.DataSource = null;
            this.dtgvView.DataSource = MateriaPrimaDAO.SelectMateriaPrima();
        }
        /// <summary>
        /// Coloca los datos de los cuadros de texto en un nuevo Material a la BD
        /// Utiliza el okEditarDeshabilitarEventHandler para deshabilitar y habilitar botones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOkEditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = this.dtgvView.SelectedRows[0];
            int id = (int)fila.Cells[0].Value;
            try
            {
                if (this.cmbMaterial.Text == "Arrabio")
                {
                    try
                    {
                        Arrabio arrabioAUpdate = new Arrabio
                        {
                            Material = this.cmbMaterial.Text,
                            Proceso = this.cmbProceso.Text,
                            Origen = this.cmbOrigen.Text,
                            Cantidad = int.Parse(this.txtCantidad.Text),
                            Calidad = this.cmbCalidad.Text,
                            Color = this.cmbColor.Text,
                            Id = id

                        };
                        MateriaPrimaDAO.UpdateMateriaPrima(arrabioAUpdate);
                    }
                    catch(Exception ex)
                    {
                        throw new FaltanDatosException("Intento Editar un Material sin llenar todos sus datos");
                    }
                    
                }
                else if (this.cmbMaterial.Text == "Reciclado")
                {
                    try
                    {
                        Reciclado recicladoAUpdate = new Reciclado
                        {
                            Material = this.cmbMaterial.Text,
                            Proceso = this.cmbProceso.Text,
                            Origen = this.cmbOrigen.Text,
                            Cantidad = int.Parse(this.txtCantidad.Text),
                            Calidad = this.cmbCalidad.Text,
                            Color = this.cmbColor.Text,
                            Id = id
                        };
                        MateriaPrimaDAO.UpdateMateriaPrima(recicladoAUpdate);
                    }
                    catch (Exception ex)
                    {
                        throw new FaltanDatosException("Intento Editar un Material sin llenar todos sus datos");
                    }
                }
            }catch(FaltanDatosException ex)
            {
                MessageBox.Show(ex.Message, "La agarre a tiempo!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ActualizarDataGrid();
            this.btnOkEditar.Enabled = false;
            this.okEditarDeshabilitarEventHandler.Invoke();
            Limpiar();
        }
        /// <summary>
        /// Deshabilita todos los botones, menos el btnOkEditar
        /// </summary>
        private void DeshabilitarBotonesMenosOkEditar()
        {
            if(this.btnOkEditar.Enabled == true)
            {
                this.btnEditar.Enabled = false;
                this.btnAgregar.Enabled = false;
                this.btnEliminar.Enabled = false;
                this.btnVerMateriales.Enabled = false;
                this.btnExportar.Enabled = false;
            }
        }
        /// <summary>
        /// Habilita todos los botones, menos el btnOkEditar
        /// </summary>
        private void ActivarBotonesMenosOkEditar()
        {
            if(this.btnOkEditar.Enabled == false)
            {
                this.btnEditar.Enabled = true;
                this.btnAgregar.Enabled = true;
                this.btnEliminar.Enabled = true;
                this.btnVerMateriales.Enabled = true;
                this.btnExportar.Enabled = true;
            }
        }
        /// <summary>
        /// Metodo que crea la informacion a reproducirse en el RichTextBox
        /// </summary>
        /// <param name="listaDeMateriaPrima"></param>
        /// <returns></returns>
        private string InfoTemporal(List<MateriaPrima> listaDeMateriaPrima)
        {
            int contadorArrabio = 0;
            int contadorReciclado = 0;
            float gananciaArrabio = 0;
            float gananciaReciclado = 0;
            float gananciaTotal = 0;
            foreach (var item in listaDeMateriaPrima)
            {
                if (item.Material == "Arrabio")
                {
                    contadorArrabio++;
                    gananciaArrabio += item.CalcularGanancia((Arrabio)item);
                }
                else
                {
                    contadorReciclado++;
                    gananciaReciclado += item.CalcularGanancia((Reciclado)item);
                }
                if (MateriaPrima.Finalizar(item))
                {
                    gananciaTotal += 500;
                }
            }
            gananciaTotal = gananciaTotal + gananciaArrabio + gananciaReciclado;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("");
            sb.AppendLine("En estos momentos el Stock de materiales cuenta con:");
            sb.AppendLine("");
            sb.AppendLine($"Arrabios: {contadorArrabio}");
            sb.AppendLine($"Con una ganancia de $ {gananciaArrabio}");
            sb.AppendLine("");
            sb.AppendLine($"Materiales reciclados: {contadorReciclado}");
            sb.AppendLine($"Con una ganancia de $ {gananciaReciclado}");
            sb.AppendLine("");
            sb.AppendLine($"La ganancia total: $ {gananciaTotal}");
            sb.AppendLine("Con el Plus de $500 por Material Finalizado");
            int cantidadLetras = CustomExtensionMethod.ContadorDeLetrasInforme(sb.ToString());
            sb.AppendLine($"El informe cuenta con un total de {cantidadLetras} letras.");
            return sb.ToString();
        }
        /// <summary>
        /// Retorna la los materiales de la BD actualizada en todo momento
        /// </summary>
        /// <returns></returns>
        private List<MateriaPrima> DevolverListaActualizada()
        {
            return this.listaThread = MateriaPrimaDAO.SelectMateriaPrima();
        }
        /// <summary>
        /// Metodo llamado por el Thread con parametros
        /// Añade texto en el richTextBox
        /// </summary>
        /// <param name="texto"></param>
        public void MostrarInfoTemporalEnRichTextBox(object texto)
        {
            if (this.rchInfoTemporal.InvokeRequired)
            {
                Callback d = new Callback(this.MostrarInfoTemporalEnRichTextBox);
                object[] objs = new object[] { texto };
                this.Invoke(d, objs);
            }
            else
            {
                this.rchInfoTemporal.Clear();
                if(this.rchInfoTemporal.BackColor == Color.Green)
                {
                    this.rchInfoTemporal.BackColor = Color.Gray;
                }
                else
                {
                    this.rchInfoTemporal.BackColor = Color.Green;

                }
                this.rchInfoTemporal.Text += texto;
            }
        }
        /// <summary>
        /// Metodo utilizado en el ThreadInicializador para llamar al Thread con parametros
        /// </summary>
        private void InicializarThread()
        {
            while (true)
            {
                List<MateriaPrima> listaPrueba = DevolverListaActualizada();
                string texto = InfoTemporal(listaPrueba);
                thread = new Thread(new ParameterizedThreadStart(MostrarInfoTemporalEnRichTextBox));
                thread.Start(texto);
                Thread.Sleep(5000);
            }
        }
        /// <summary>
        /// Al cerrar el form realiza una pregunta, en caso de ser Yes
        /// evalua si hay algun thread "vivo" y lo aborta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Quiere cerrar?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                if(thread != null)
                {
                    if (thread.IsAlive)
                    //if (thread.ThreadState != ThreadState.Stopped &&
                    //    thread.ThreadState != ThreadState.Aborted)
                    {
                        thread.Abort();
                    }
                }
                if(threadIniciador != null)
                {
                    if (threadIniciador.IsAlive)
                    //if (threadIniciador.ThreadState != ThreadState.Stopped &&
                    //    threadIniciador.ThreadState != ThreadState.Aborted)
                    {
                        threadIniciador.Abort();
                    }
                }
            }
        }
    }
}
