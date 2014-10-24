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

namespace Teleobservacion_Captura
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            Table_To_DataTable tabla = new Table_To_DataTable();
            IGPUtilities pGPUtilities = new GPUtilitiesClass();
            ITable pTable = pGPUtilities.OpenTableFromString(@"E:\SICAT\TELEOBSERVACION\TeleObservacion.mdb\F03IMG_IMGN_100K");
            bindingSource1.DataSource = tabla.ConvertITableField(pTable, null, "IMG_NOMBRE");
            bindingNavigator1.BindingSource = bindingSource1;
            dataGridView1.DataSource=bindingSource1;
            dataGridView1.Columns[0].Width = 230;
            dataGridView1.Refresh();
            
        }

       
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Desea Ingresar un Nuevo Registro?", "Confirmación", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                //MessageBox.Show("Si..");


            }
            else
            {
                dataGridView1.Rows.Remove(dataGridView1.Rows[dataGridView1.RowCount - 2]);
                dataGridView1.Refresh();
            }
        }

        
    }
}
