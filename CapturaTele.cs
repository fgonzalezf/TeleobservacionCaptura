using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Teleobservacion_Captura
{
    public class CapturaTele : ESRI.ArcGIS.Desktop.AddIns.Button
    {
        public CapturaTele()
        {
        }

        protected override void OnClick()
        {
            //
            //  TODO: Sample code showing how to access button host
            Principal ventana = new Principal();
            ventana.Show();
            //
            ArcMap.Application.CurrentTool = null;
        }
        protected override void OnUpdate()
        {
            Enabled = ArcMap.Application != null;
        }
    }

}
