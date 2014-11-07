using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ESRI.ArcGIS.Geoprocessing;
using ESRI.ArcGIS.Geodatabase;
using System.Net;
using System.IO;
using System.Threading;

namespace Teleobservacion_Captura
{
    public partial class Principal : Form
    {
        private string rutaArchivo = "";
        private string rutaMuestra = "";
        private string IdBorrar ="";

        ComboBox cbxTipoRadar = null;
        Label lblTipoRadar = null;
        TextBox txbIdentificador = null;
        Label lblTipoIdentificador = null;
        Label lblpath = null;
        TextBox txbPath = null;
        Label lblrow = null;
        TextBox txbRow = null;
        TextBox txbLineaVuelo = null;
        Label lblLineaVuelo = null;

        public Principal()
        {
            InitializeComponent();
            Table_To_DataTable tabla = new Table_To_DataTable();
            IGPUtilities pGPUtilities = new GPUtilitiesClass();
            ITable pTable = pGPUtilities.OpenTableFromString(@"E:\SICAT\TELEOBSERVACION\TeleObservacion.mdb\F03IMG_IMGN_100K");
            bindingSource1.DataSource = tabla.ConvertITable(pTable, "");
            bindingNavigator1.BindingSource = bindingSource1;
            dataGridView1.DataSource=bindingSource1;
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.Visible = false;
            }
            dataGridView1.Columns[4].Visible = true;
            dataGridView1.Columns[4].Width = 230;

            cbxTipo.Items.Add("");
            cbxTipo.Items.Add("RADAR");
            cbxTipo.Items.Add("LANDSAT TM");
            cbxTipo.Items.Add("LANDSAT ETM");
            cbxTipo.Items.Add("SPOT");
            cbxTipo.Items.Add("IKONOS");
            cbxTipo.Items.Add("ORTOFOTO");
            cbxTipo.Items.Add("ASTER");
            
        }

       
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Desea Ingresar un Nuevo Registro?", "Confirmación", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                IGPUtilities pGPUtilities = new GPUtilitiesClass();
                ITable pTable = pGPUtilities.OpenTableFromString(@"E:\SICAT\TELEOBSERVACION\TeleObservacion.mdb\F03IMG_IMGN_100K");
                Crud_Table insertar = new Crud_Table();
                insertar.insert(pTable);
                Table_To_DataTable tabla = new Table_To_DataTable();
                bindingSource1.DataSource = tabla.ConvertITable(pTable, "");
                dataGridView1.Refresh();
                
            }
            else
            {
                
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Desea Borrar el registro?", "Confirmación", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                IGPUtilities pGPUtilities = new GPUtilitiesClass();
                ITable pTable = pGPUtilities.OpenTableFromString(@"E:\SICAT\TELEOBSERVACION\TeleObservacion.mdb\F03IMG_IMGN_100K");
                Crud_Table borrar = new Crud_Table();
                borrar.deleteRow(pTable, IdBorrar);
                Table_To_DataTable tabla = new Table_To_DataTable();
                bindingSource1.DataSource = tabla.ConvertITable(pTable, "");
                dataGridView1.Refresh();
            }
            else
            {
               
                
                
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                datosFila(row);
                IdBorrar = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch 
            {
                
            }


        }

        private void datosFila(DataGridViewRow row)
        {
            tbxNombre.Text = row.Cells[4].Value.ToString();


            if (row.Cells[5].Value.ToString() == "RADAR")
            {
                cbxTipo.SelectedIndex = 1;
            }
            else if (row.Cells[5].Value.ToString() == "LANDSAT TM")
            {
                cbxTipo.SelectedIndex = 2;
            }
            else if (row.Cells[5].Value.ToString() == "LANDSAT ETM")
            {
                cbxTipo.SelectedIndex = 3;
            }
            else if (row.Cells[5].Value.ToString() == "SPOT")
            {
                cbxTipo.SelectedIndex = 4;
            }
            else if (row.Cells[5].Value.ToString() == "IKONOS")
            {
                cbxTipo.SelectedIndex = 5;
            }
            else if (row.Cells[5].Value.ToString() == "ORTOFOTO")
            {
                cbxTipo.SelectedIndex = 6;
            }
            else if (row.Cells[5].Value.ToString() == "ASTER")
            {
                cbxTipo.SelectedIndex = 7;
            }
            else
            {
                cbxTipo.SelectedIndex = 0;
            }


            if (cbxTipoRadar != null)
            {
                if (row.Cells[19].Value.ToString() == "1")
                {
                    cbxTipoRadar.SelectedIndex = 1;
                    
                }
                else if (row.Cells[19].Value.ToString() == "2")
                {
                    cbxTipoRadar.SelectedIndex = 2;
                }
                else
                {
                    cbxTipoRadar.SelectedIndex = 0;
                }
            }


            if (txbIdentificador != null)
            {
                txbIdentificador.Text = row.Cells[3].Value.ToString();
            }
            if (txbPath != null)
            {
                txbPath.Text = row.Cells[16].Value.ToString();
            }
            if (txbRow != null)
            {
                txbRow.Text = row.Cells[17].Value.ToString();
            }
            if (txbLineaVuelo != null)
            {
                txbLineaVuelo.Text = row.Cells[18].Value.ToString();
            }
            txbObservaciones.Text = row.Cells[14].Value.ToString();
        
            tbxArchivo.Text = row.Cells[12].Value.ToString();
            tbxResolucionEspacial.Text = row.Cells[13].Value.ToString();
            tbxArea.Text = row.Cells[7].Value.ToString();
            dateTimePickerFecha.Text = row.Cells[6].Value.ToString();
            //MessageBox.Show(row.Cells[9].Value.ToString());
            txtBoxLatitudMin.Text= row.Cells[8].Value.ToString().Replace(",",".");
            txtBoxLatitudMax.Text = row.Cells[9].Value.ToString().Replace(",", ".");
            txtBoxLongitudMin.Text = row.Cells[10].Value.ToString().Replace(",", ".");
            txtBoxLongitudMax.Text = row.Cells[11].Value.ToString().Replace(",", ".");

            NetworkCredential writeCredentials = new NetworkCredential("usr-siger", "we3nya$i");
            using (new NetworkConnection(@"\\172.25.1.204\siger\imagenes\", writeCredentials))
            {
                string filaSeleccionada = row.Cells[20].Value.ToString();
                try
                {
                    picBoxMuestraGrafica.Image = Image.FromFile(@"\\172.25.1.204\siger\imagenes\" + row.Cells[20].Value.ToString());
                    picBoxMuestraGrafica.Refresh();
                }
                catch (Exception ex)
                {
                    picBoxMuestraGrafica.Image = null;
                    picBoxMuestraGrafica.Refresh();
                }
            }

        }

        private void btnArchivo_Click(object sender, EventArgs e)
        {
            try
            {
                
                OpenFileDialog sfd = new OpenFileDialog();
                sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                sfd.Filter = "Jpeg Imagen|*.jpg|Bitmap Imagen|*.bmp|Tif Imagen|*.tif";
                sfd.FilterIndex = 1;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    tbxArchivo.Text = Path.GetFileName(sfd.FileName);
                    rutaArchivo = sfd.FileName;
                }
                else
                {
                   
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Abriendo Imagen" + ex.Message);
            }
        }

        private void btnExaminarMG_Click(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog sfd = new OpenFileDialog();
                sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                sfd.Filter = "Jpeg Imagen|*.jpg|Bitmap Imagen|*.bmp|Tif Imagen|*.tif";
                sfd.FilterIndex = 1;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    txtBoxMuestraGrafica.Text = Path.GetFileName(sfd.FileName);
                    rutaMuestra = sfd.FileName;
                }
                else
                {

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Abriendo Imagen" + ex.Message);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string fileToCopy = rutaArchivo; // or whatever 
                string fileToCopyMuestra = rutaMuestra;
                string fileDestination = @"\\172.25.1.204\siger\imagenes\PruebaTeleobservacion\" + tbxArchivo.Text;
                string fileDestinationMuestra = @"\\172.25.1.204\siger\imagenes\PruebaTeleobservacion\" + txtBoxMuestraGrafica.Text;
                string IdActualizar = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string Id1Actualizar = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string IdImgActualizar = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                Dictionary<string, string> DatosActualizar = new Dictionary<string,string>();

                lblProceso.Text = "Descargando...";
                btnSalvar.Enabled = false;
                DialogResult dialogResult = MessageBox.Show("Sure", "Some Title", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    if (fileToCopy != "")
                    {
                        Thread threadExport = new Thread(() => copiaImagen(fileToCopy, fileDestination))
                        {
                            IsBackground = true,
                            Name = "threadExport",
                            Priority = ThreadPriority.Normal
                        };
                        threadExport.Start();
                    }
                    if (fileToCopyMuestra != "")
                    {
                        Thread threadExport2 = new Thread(() => copiaImagen(fileToCopyMuestra, fileDestinationMuestra))
                        {
                            IsBackground = true,
                            Name = "threadExport2",
                            Priority = ThreadPriority.Normal
                        };
                        threadExport2.Start();
                    }

                    DatosActualizar = this.actualizacion(IdActualizar, Id1Actualizar, IdImgActualizar);
                    Crud_Table Crud = new Crud_Table();
                    IGPUtilities pGPUtilities = new GPUtilitiesClass();
                    ITable pTable = pGPUtilities.OpenTableFromString(@"E:\SICAT\TELEOBSERVACION\TeleObservacion.mdb\F03IMG_IMGN_100K");
                    Crud.updateRow(pTable, DatosActualizar);
                    Table_To_DataTable tabla = new Table_To_DataTable();
                    bindingSource1.DataSource = tabla.ConvertITable(pTable, "");   

                    
                }
               else if(dialogResult == DialogResult.No)
                    {
                      lblProceso.Text = "";
                      btnSalvar.Enabled = true;
                    }
                
                
                   

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error en la descarga de la imagen" + ex.Message);
            }
        }


        public void copiaImagen(string fileToCopy, string Filename)
        {
            try
            {
                NetworkCredential writeCredentials = new NetworkCredential("usr-siger", "we3nya$i");
                using (new NetworkConnection(@"\\172.25.1.204\siger\imagenes\", writeCredentials))
                {

                    System.IO.File.Copy(fileToCopy, Filename, true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error conectandose al servidor de imagenes" + ex.Message);
            }

            lblProceso.Text = "";
            btnSalvar.Enabled = true;

        }

        public Dictionary<string, string> actualizacion(string OBJETID, string OBJETID_1, string IDImagen)
        {
            Dictionary<string, string> datos = new Dictionary<string, string>();
            datos.Add("OBJECTID_1", OBJETID);
            datos.Add("OBJECTID", OBJETID_1);
            datos.Add("ID_IMGN", IDImagen);
            if (txbIdentificador != null)
            {
                datos.Add("IMG_IDENT", txbIdentificador.Text);
            }
            else
            {
                datos.Add("IMG_IDENT", ""); 
            }
            datos.Add("IMG_NOMBRE", tbxNombre.Text);
            datos.Add("IMG_TIPO_IMGN", cbxTipo.Text);
            datos.Add("IMG_FECHA", dateTimePickerFecha.Value.ToString());
            datos.Add("IMG_AREA", tbxArea.Text);
            datos.Add("IMG_LAT_MIN", txtBoxLatitudMin.Text);
            datos.Add("IMG_LAT_MAX", txtBoxLatitudMax.Text);
            datos.Add("IMG_LONG_MIN", txtBoxLongitudMin.Text);
            datos.Add("IMG_LONG_MAX", txtBoxLongitudMax.Text);
            datos.Add("IMG_ARCH", tbxArchivo.Text);
            datos.Add("IMG_RESL_ESPC", tbxResolucionEspacial.Text);
            datos.Add("IMG_OBSRV", txbObservaciones.Text);
            datos.Add("IMG_PROCS", txbProcesamiento.Text);


            txbLineaVuelo = null;
            txbIdentificador = null;
            cbxTipoRadar = null;       
            txbPath = null;           
            txbRow = null;
            txbObservaciones = null;
            if (txbPath != null)
            {
                datos.Add("IMG_PATH", txbPath.Text);
                datos.Add("IMG_ROW", txbRow.Text);
            }
            else
            {
                datos.Add("IMG_PATH", "");
                datos.Add("IMG_ROW", "");
            }
            if (txbLineaVuelo != null)
            {
                datos.Add("IMG_LINEA_VUELO", txbLineaVuelo.Text);
            }
            else
            {
                datos.Add("IMG_LINEA_VUELO", "");
            }
            if (cbxTipoRadar != null)
            {
                if (cbxTipoRadar.Text == "Radarsat1")
                {
                    datos.Add("PST_TIPO_RADAR", "1");
                }
                else if (cbxTipoRadar.Text == "Radarsat2")
                {
                    datos.Add("PST_TIPO_RADAR", "2");
                }
                else
                {
                    datos.Add("PST_TIPO_RADAR", "0");
                }
            }
            else
            {
                datos.Add("PST_TIPO_RADAR", "0");
            }
            datos.Add("IMG_MUEST_GRAF", txtBoxMuestraGrafica.Text);
            datos.Add("IMG_ULTIMO_USUARIO",System.Environment.UserName);
            datos.Add("IMG_ULTIMA_FECHA", DateTime.Today.ToString());
            datos.Add("IMG_ORBIT","");
            datos.Add("IMG_TIPO_ORBIT","");
            datos.Add("IMG_BEAM_MODE","");
            datos.Add("IMG_SUBSISTEMA","");
            return datos;
        }

        private void cbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTipo.Text == "RADAR" || cbxTipo.Text == "ORTOFOTO")
            {
                if (gpboxDatosBasicos.Controls["txbPath"] != null)
                {
                    gpboxDatosBasicos.Controls.Remove(gpboxDatosBasicos.Controls["lblpath"]);
                    gpboxDatosBasicos.Controls.Remove(gpboxDatosBasicos.Controls["txbPath"]);
                    gpboxDatosBasicos.Controls.Remove(gpboxDatosBasicos.Controls["txbRow"]);
                    gpboxDatosBasicos.Controls.Remove(gpboxDatosBasicos.Controls["lblrow"]);

                    lblpath = null;
                    txbPath = null;
                    lblrow = null;                
                    txbRow = null;
                    
                }
                if (gpboxDatosBasicos.Controls["cbxTipoRadar"] == null && cbxTipo.Text == "RADAR")
                {
                    txbObservaciones.Visible = false;
                    if (gpboxDatosBasicos.Controls["txbLineaVuelo"] != null)
                    {
                        gpboxDatosBasicos.Controls.Remove(gpboxDatosBasicos.Controls["txbLineaVuelo"]);
                        gpboxDatosBasicos.Controls.Remove(gpboxDatosBasicos.Controls["lblLineaVuelo"]);
                        gpboxDatosBasicos.Controls.Remove(gpboxDatosBasicos.Controls["txbIdentificador"]);
                        gpboxDatosBasicos.Controls.Remove(gpboxDatosBasicos.Controls["lblTipoIdentificador"]);
                    }
                    cbxTipoRadar = new ComboBox();
                    cbxTipoRadar.Location = new System.Drawing.Point(123,183);
                    cbxTipoRadar.Name = "cbxTipoRadar";
                    cbxTipoRadar.Size = new System.Drawing.Size(180, 20);
                    cbxTipoRadar.Items.Add("");
                    cbxTipoRadar.Items.Add("Radarsat1");
                    cbxTipoRadar.Items.Add("Radarsat2");

                    lblTipoRadar = new Label();
                    lblTipoRadar.Name = "lblTipoRadar";
                    lblTipoRadar.Location = new System.Drawing.Point(11, 190);
                    lblTipoRadar.Text = "Tipo Radar ";


                    txbIdentificador = new TextBox();
                    txbIdentificador.Location = new System.Drawing.Point(123, 209);
                    txbIdentificador.Name = "txbIdentificador";
                    txbIdentificador.Size = new System.Drawing.Size(180, 20);


                    lblTipoIdentificador = new Label();
                    lblTipoIdentificador.Name = "lblTipoIdentificador";
                    lblTipoIdentificador.Location = new System.Drawing.Point(11, 216);
                    lblTipoIdentificador.Text = "Identificador ";


                    this.gpboxDatosBasicos.Controls.Add(cbxTipoRadar);
                    this.gpboxDatosBasicos.Controls.Add(lblTipoRadar);
                    this.gpboxDatosBasicos.Controls.Add(txbIdentificador);
                    this.gpboxDatosBasicos.Controls.Add(lblTipoIdentificador);
                    ToolTip tip = new ToolTip();
                    tip.SetToolTip(gpboxDatosBasicos.Controls["cbxTipoRadar"], "Seleccione el Tipo de Radar");
                    tip.SetToolTip(gpboxDatosBasicos.Controls["txbIdentificador"], "Ingrese el Identificador de la Imagen a Mostrar");
                }

                if (gpboxDatosBasicos.Controls["txbLineaVuelo"] == null && cbxTipo.Text == "ORTOFOTO")
                {
                    txbObservaciones.Visible = true;
                    if (gpboxDatosBasicos.Controls["cbxTipoRadar"] != null)
                    {
                        gpboxDatosBasicos.Controls.Remove(gpboxDatosBasicos.Controls["lblTipoRadar"]);
                        gpboxDatosBasicos.Controls.Remove(gpboxDatosBasicos.Controls["cbxTipoRadar"]);
                        gpboxDatosBasicos.Controls.Remove(gpboxDatosBasicos.Controls["txbIdentificador"]);
                        gpboxDatosBasicos.Controls.Remove(gpboxDatosBasicos.Controls["lblTipoIdentificador"]);
                    }
                    txbLineaVuelo = new TextBox();
                    txbLineaVuelo.Location = new System.Drawing.Point(123, 183);
                    txbLineaVuelo.Name = "txbLineaVuelo";
                    txbLineaVuelo.Size = new System.Drawing.Size(180, 20);


                    lblLineaVuelo = new Label();
                    lblLineaVuelo.Name = "lblLineaVuelo";
                    lblLineaVuelo.Location = new System.Drawing.Point(11, 190);
                    lblLineaVuelo.Text = "Linea de Vuelo";


                    txbIdentificador = new TextBox();
                    txbIdentificador.Location = new System.Drawing.Point(123, 209);
                    txbIdentificador.Name = "txbIdentificador";
                    txbIdentificador.Size = new System.Drawing.Size(180, 20);


                    lblTipoIdentificador = new Label();
                    lblTipoIdentificador.Name = "lblTipoIdentificador";
                    lblTipoIdentificador.Location = new System.Drawing.Point(11, 216);
                    lblTipoIdentificador.Text = "Identificador ";


                    this.gpboxDatosBasicos.Controls.Add(txbLineaVuelo);
                    this.gpboxDatosBasicos.Controls.Add(lblLineaVuelo);
                    this.gpboxDatosBasicos.Controls.Add(txbIdentificador);
                    this.gpboxDatosBasicos.Controls.Add(lblTipoIdentificador);
                    ToolTip tip = new ToolTip();
                    tip.SetToolTip(gpboxDatosBasicos.Controls["txbLineaVuelo"], "Linea de Vuelo de Fotografia Aerea");
                    tip.SetToolTip(gpboxDatosBasicos.Controls["txbIdentificador"], "Ingrese el Identificador de la Imagen a Mostrar");
                }

            }
            else if (cbxTipo.Text == "LANDSAT TM" || cbxTipo.Text == "LANDSAT ETM" || cbxTipo.Text == "SPOT")
            {
                txbObservaciones.Visible = false;
                if (gpboxDatosBasicos.Controls["txbLineaVuelo"] != null)
                {
                    gpboxDatosBasicos.Controls.Remove(gpboxDatosBasicos.Controls["txbLineaVuelo"]);
                    gpboxDatosBasicos.Controls.Remove(gpboxDatosBasicos.Controls["lblLineaVuelo"]);
                    gpboxDatosBasicos.Controls.Remove(gpboxDatosBasicos.Controls["txbIdentificador"]);
                    gpboxDatosBasicos.Controls.Remove(gpboxDatosBasicos.Controls["lblTipoIdentificador"]);
                    txbLineaVuelo = null;
                    txbIdentificador = null;
                    lblTipoIdentificador = null;
                    lblLineaVuelo = null;
                }
                if (gpboxDatosBasicos.Controls["cbxTipoRadar"] != null)
                {
                    gpboxDatosBasicos.Controls.Remove(gpboxDatosBasicos.Controls["lblTipoRadar"]);
                    gpboxDatosBasicos.Controls.Remove(gpboxDatosBasicos.Controls["cbxTipoRadar"]);
                    gpboxDatosBasicos.Controls.Remove(gpboxDatosBasicos.Controls["txbIdentificador"]);
                    gpboxDatosBasicos.Controls.Remove(gpboxDatosBasicos.Controls["lblTipoIdentificador"]);
                    
                    cbxTipoRadar = null;
                    lblTipoRadar = null;
                    txbIdentificador = null;
                    lblTipoIdentificador = null;

                    
                }
                if (gpboxDatosBasicos.Controls["txbPath"] == null)
                {

                    lblpath = new Label();
                    lblpath.Name = "lblpath";
                    lblpath.Location = new System.Drawing.Point(11, 190);
                    lblpath.Text = "Path ";


                    txbPath = new TextBox();
                    txbPath.Location = new System.Drawing.Point(123,183);
                    txbPath.Name = "txbPath";
                    txbPath.Size = new System.Drawing.Size(180, 20);


                    lblrow = new Label();
                    lblrow.Name = "lblrow";
                    lblrow.Location = new System.Drawing.Point(11, 216);
                    lblrow.Text = "Row ";

                    txbRow = new TextBox();
                    txbRow.Location = new System.Drawing.Point(123, 209);
                    txbRow.Name = "txbRow";
                    txbRow.Size = new System.Drawing.Size(180, 20);

                    this.gpboxDatosBasicos.Controls.Add(txbRow);
                    this.gpboxDatosBasicos.Controls.Add(lblpath);
                    this.gpboxDatosBasicos.Controls.Add(txbPath);
                    this.gpboxDatosBasicos.Controls.Add(lblrow);
                    ToolTip tip = new ToolTip();
                    tip.SetToolTip(gpboxDatosBasicos.Controls["txbPath"], "Ingrese el Path de la Imagen a buscar");
                    tip.SetToolTip(gpboxDatosBasicos.Controls["txbRow"], "Ingrese el Row de la Imagen a buscar");
                }

            }
            
            else
            {
                txbObservaciones.Visible = false;
                if (gpboxDatosBasicos.Controls["cbxTipoRadar"] != null)
                {
                    gpboxDatosBasicos.Controls.Remove(gpboxDatosBasicos.Controls["lblTipoRadar"]);
                    gpboxDatosBasicos.Controls.Remove(gpboxDatosBasicos.Controls["cbxTipoRadar"]);
                    gpboxDatosBasicos.Controls.Remove(gpboxDatosBasicos.Controls["txbIdentificador"]);
                    gpboxDatosBasicos.Controls.Remove(gpboxDatosBasicos.Controls["lblTipoIdentificador"]);
                    lblTipoRadar=null;
                    cbxTipoRadar = null;
                    txbIdentificador= null;
                    lblTipoIdentificador = null;
                }
                else if (gpboxDatosBasicos.Controls["txbPath"] != null)
                {
                    gpboxDatosBasicos.Controls.Remove(gpboxDatosBasicos.Controls["lblpath"]);
                    gpboxDatosBasicos.Controls.Remove(gpboxDatosBasicos.Controls["txbPath"]);
                    gpboxDatosBasicos.Controls.Remove(gpboxDatosBasicos.Controls["txbRow"]);
                    gpboxDatosBasicos.Controls.Remove(gpboxDatosBasicos.Controls["lblrow"]);
                    lblpath = null;
                    txbPath = null;
                    txbRow = null;
                    lblrow = null;
                }

                else if (gpboxDatosBasicos.Controls["txbLineaVuelo"] != null)
                {
                    gpboxDatosBasicos.Controls.Remove(gpboxDatosBasicos.Controls["txbLineaVuelo"]);
                    gpboxDatosBasicos.Controls.Remove(gpboxDatosBasicos.Controls["lblLineaVuelo"]);
                    gpboxDatosBasicos.Controls.Remove(gpboxDatosBasicos.Controls["txbIdentificador"]);
                    gpboxDatosBasicos.Controls.Remove(gpboxDatosBasicos.Controls["lblTipoIdentificador"]);
                    txbLineaVuelo = null;
                    txbIdentificador = null;
                    lblTipoIdentificador = null;
                    lblLineaVuelo = null;
                    
                }
            }

        }

        

        

        
        
    }
}
