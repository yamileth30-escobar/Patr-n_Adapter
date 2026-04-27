using patrón_Adapter.Adaptee;
using patrón_Adapter.Adapter;
using patrón_Adapter.Target;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patrón_Adapter
{
    //Contiene el código cliente que interactúa con la interfaz moderna (Target)
    /// <summary>
    /// //sin preocuparse por las diferencias con el sistema antiguo (Adaptee).
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Instanciamos la clase antigua (el Adaptee)
            SistemaContableAntiguo sistemaViejo = new SistemaContableAntiguo();
            // 2. La envolvemos en el adaptador (el Adapter)
            INuevaFacturacion sistemaAdaptado = new FacturacionAdapter(sistemaViejo);
            // 3. El cliente usa la interfaz moderna (el Target)
            Console.WriteLine("--- Ejecutando Sistema con Patrón Adapter ---");
            sistemaAdaptado.ProcesarPago(250.75);
            Console.WriteLine("\nPresione cualquier tecla para finalizar...");

            Console.ReadKey();
        }
    }
}