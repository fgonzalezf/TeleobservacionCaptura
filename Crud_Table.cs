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
                pRow.set_Value(1,Convert.ToInt16(pRow.get_Value(0))+366);
                pRow.set_Value(2, Convert.ToInt16(pRow.get_Value(0)) + 365);
                pRow.Store();

            }
            catch (Exception Ex)
            {
                MessageBox.Show ( "Error Insertando Nueva Fila: " + Ex.Message);
            }

        }

        public void updateRow (ITable pTable, Dictionary<string, string> rowUpdate)
        {
            try
            {
                IQueryFilter pQuery = new QueryFilterClass();
                pQuery.WhereClause = "[OBJECTID_1]=" + rowUpdate["OBJECTID_1"];
                ICursor pCursor = pTable.Update(pQuery, true);
                IRow pRow = pCursor.NextRow();
                foreach (KeyValuePair<string, string> kvp in rowUpdate)
                {
                    if (kvp.Key != "OBJECTID_1")
                    {
                        pRow.set_Value(pRow.Fields.FindField(kvp.Key), kvp.Value);
                        pRow.Store();
                    }
                    
                }
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
                IQueryFilter pQuery = new QueryFilterClass();
                pQuery.WhereClause = "[OBJECTID_1]=" + id;
                pTable.DeleteSearchedRows(pQuery);

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error Borrando  Fila: " + Ex.Message);
            }

        }
    }
}
