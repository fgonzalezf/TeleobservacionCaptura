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
            cbxTipo.Text = row.Cells[5].Value.ToString();
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
                        Thread threadExport = new Thread(() => copiaImagen(fileToCopy, fileDestination))
                        {
                            IsBackground = true,
                            Name = "threadExport",
                            Priority = ThreadPriority.Normal
                        };
                        threadExport.Start();
                    }
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
            
            lblProceso.Text = "Copia Terminada";
            btnSalvar.Enabled = true;

        }

        public Dictionary<string, string> actualizacion(string OBJETID, string OBJETID_1, string IDImagen)
        {
            Dictionary<string, string> datos = new Dictionary<string, string>();
            datos.Add("OBJECTID_1", OBJETID);
            datos.Add("OBJECTID", OBJETID_1);
            datos.Add("ID_IMGN", IDImagen);
            datos.Add("IMG_IDENT","");
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
            datos.Add("IMG_PATH","");
            datos.Add("IMG_ROW","");
            datos.Add("IMG_LINEA_VUELO","");
            datos.Add("PST_TIPO_RADAR","");
            datos.Add("IMG_MUEST_GRAF", txtBoxMuestraGrafica.Text);
            datos.Add("IMG_ULTIMO_USUARIO","");
            datos.Add("IMG_ULTIMA_FECHA","");
            datos.Add("IMG_ORBIT","");
            datos.Add("IMG_TIPO_ORBIT","");
            datos.Add("IMG_BEAM_MODE","");
            datos.Add("IMG_SUBSISTEMA","");
            return datos;
        }

        

        
        
    }
}
