using System;

namespace Expendedora_TerminatorG2
{
    internal class Snack : Expendedora
    {
        public Snack()
        {
            Saludar();
            Console.WriteLine("Marca: {0}", Marca);
            LimpiarDisplay();
            string codigo = MostrarProducto();
            LimpiarDisplay();
            MostrarPrecio(codigo);
        }
    }
}
