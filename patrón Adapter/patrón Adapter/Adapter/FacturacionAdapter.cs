using patrón_Adapter.Adaptee;
using patrón_Adapter.Target;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patrón_Adapter.Adapter
{
    // El Adapter implementa la interfaz moderna (Target) y traduce las
    // llamadas al formato que entiende el sistema antiguo (Adaptee).
    public class FacturacionAdapter : INuevaFacturacion
    {
        private readonly SistemaContableAntiguo _viejoSistema;
        public FacturacionAdapter(SistemaContableAntiguo viejoSistema)
        {
            _viejoSistema = viejoSistema;
        }
        public void ProcesarPago(double monto)
        {
            // Traducimos el 'double' que pide la interfaz a 'string'
            // que es lo que entiende la clase vieja.
            string montoConvertido = monto.ToString("F2");
            _viejoSistema.RegistrarEntradaDeDinero(montoConvertido);
        }
    }
}