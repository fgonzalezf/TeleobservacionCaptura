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
            bindingSource1.DataSource =tabla.ConvertITable(pTable,null);
            bindingNavigator1.BindingSource = bindingSource1;
            dataGridView1.DataSource=bindingSource1;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
