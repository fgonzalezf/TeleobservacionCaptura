using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ESRI.ArcGIS.Geodatabase;
using System.Windows.Forms;

namespace Teleobservacion_Captura
{
    class Crud_Table
    {

        public void insert(ITable pTable)
        {
            try
            {
                IRow pRow = pTable.CreateRow();

            }
            catch (Exception Ex)
            {
                MessageBox.Show ( "Error Insertando Nueva Fila: " + Ex.Message);
            }

        }

        public void updateRow (ITable pTable,string id)
        {
            try
            {
                IQueryFilter pQuery = new QueryFilterClass();
                pQuery.WhereClause=
                ICursor pCursor = pTable.Update(pQuery, true);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error Actualizando Fila: " + Ex.Message);
            }
        }
        public void deleteRow(ITable pTable, string id)
        {
            try
            {
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error Borrando  Fila: " + Ex.Message);
            }

        }
    }
}
