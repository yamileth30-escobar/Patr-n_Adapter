using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patrón_Adapter.Target
{
    //Contiene la interfaz moderna que el cliente espera usar.
    public interface INuevaFacturacion
    {
        void ProcesarPago(double monto);
    }
}
