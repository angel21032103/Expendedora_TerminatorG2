using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Expendedora_TerminatorG2
{
    internal class Cafe : Expendedora
    {


        #region Propiedades
        public override byte Temperatura { 
            get => base.Temperatura; 
            set
            {
                if (50 < value && value < 70)
                {
                    temperatura = value;
                }
                else
                {
                    temperatura = 60;
                }
            }
        }

        #endregion

        public Cafe()
        {
            Saludar();
            Temperatura = 62;
            Console.WriteLine("Temperatura: {0} [°C]", Temperatura);
            LimpiarDisplay();
            String codigo = MostrarProducto();
            LimpiarDisplay();
            Precio = 10;
            MostrarPrecio(codigo);

           
        }

        public Cafe(bool Mantenimiento)
        {
            if (Mantenimiento)
                Console.WriteLine("Entrando a modo mantenimiento\n");
            else
                Saludar();
        }
        public Cafe(int cantidadProductos)
        {
            Console.WriteLine("La exoendedroa contiene {0} productos", cantidadProductos);
        }

        #region Métodos

        public override string MostrarProducto()
        {
            Console.WriteLine("4C: Americano\n4D: Expresso\nElije un producto: ");
            string codigo = Console.ReadLine();

            return codigo; 
        }
        public override void MostrarPrecio(string codigo)
        {
            switch(codigo)
            {
                case "4C":
                    Console.WriteLine("Precio ${0}", Precio+3);
                    break;

                case "4D":
                    Console.WriteLine("Precio ${0}", Precio+6);
                    break;

                default:
                    Console.WriteLine("Elige un producto valido\n");
                    break;
            }


            
        }

        #endregion
    }
}
