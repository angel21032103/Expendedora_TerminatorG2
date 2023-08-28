﻿using System;
using System.Threading;
using System.Xml.Serialization;

namespace Expendedora_TerminatorG2
{
    internal abstract class Expendedora
    {

        #region Atributos

        private string marca;
        private ushort cantproductos;
        private byte temperatura;
        private float precio;

        #endregion

        #region Propieades
        public byte Temperatura { 
            get => temperatura;    //limites de lectura  
            set                    //limites de escritura 
            {
                if (0 < value &&  value < 25)
                    temperatura = value;
                else
                    temperatura = 20;
            }
                
        
        
        }

        public string Marca { get => marca; set => marca = value; }


        #endregion

        #region Metodos
        public void Saludar()
        {
            Console.WriteLine("Bienvenido, elige un producto");
        }
        public void LimpiarDisplay()
        {
            Thread.Sleep(2000);
            Console.Clear();
        }

        public string MostrarProducto()
        {
            string codigo = "";
            Console.WriteLine(" 3A: Doritos \n 3B: Churrumais ");
            Console.WriteLine("Ingresa el código del producto");
            codigo = Console.ReadLine();
            return codigo;

        }

        public void MostrarPrecio(string codigo)
        {
            switch(codigo)
            {
                case "3A":
                    Console.WriteLine("Precio: {0}", precio);
                    break;
                case "3B":
                    Console.WriteLine("Precio: {0}",precio-6);
                    break;
                default:
                    Console.WriteLine("No ingresaste un producto válido");
                    break;

            }

        }
        #endregion

        #region Constructor
        public Expendedora()
        {
            Marca = "AMS";
            precio = 18;
            Saludar();
            LimpiarDisplay();
           // Console.WriteLine("Marca: {0}",marca);
            //LimpiarDisplay();
            //string codigo = MostrarProducto();
            //LimpiarDisplay();
            //MostrarPrecio(codigo);
            

        }

        public Expendedora(bool Mantenimiento)
        {
            Temperatura = 1;

            if(Mantenimiento==true)
            Console.WriteLine("Entrando en modo mantenimiento");
            
            Console.WriteLine("Cambiando temperatua");
            LimpiarDisplay();
            for(int i=0; i< 20; i++)
            {
                Temperatura++;
            }
            Console.WriteLine("Mostramdo Temperatura {0} [°C]", Temperatura);

        }

        #endregion
    }
}
