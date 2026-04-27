using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patrón_Adapter.Adaptee
{
    // Contiene la lógica de negocio antigua que queremos adaptar.
    public class SistemaContableAntiguo
    {
        public void RegistrarEntradaDeDinero(string cantidadTexto)
        {
            Console.WriteLine($"[SISTEMA ANTIGUO]: Registro guardado: {cantidadTexto} USD.");
        }
    }
}
