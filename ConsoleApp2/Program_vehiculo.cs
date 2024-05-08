﻿using System;

namespace vehiculos
{
    class Program
    {
        class Vehiculo
        {
            public string Marca { get; set; }
            public string Modelo { get; set; }
            public int Año { get; set; }

            public Vehiculo(string marca, string modelo, int año)
            {
                Marca = marca;
                Modelo = modelo;
                Año = año;
            }

            public virtual void MostrarInformacion()
            {
                Console.WriteLine($"Marca: {Marca} \nModelo: {Modelo} \nAño: {Año}");
            }
        }
        class bicicleta : Vehiculo
        {
            public int numeromarchas{get; set;}
            public bicicleta(string marca, string modelo, int año, int numeromarcha) : base(marca, modelo, año)
            {
                numeromarcha = numeromarcha;
            }
            public override void MostrarInformacion()
            {
                base.MostrarInformacion();
                Console.WriteLine($"Tipo: Bicicleta \nmarchas: {numeromarchas}");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("--------VEHICULOS--------");
            Vehiculo vehi = new Vehiculo("Toyota", "Corolla", 2020);
            Vehiculo vehi2 = new Vehiculo("Chevrolet", "camaro", 2022);
            vehi.MostrarInformacion();
            Console.WriteLine("-----------------");
            vehi2.MostrarInformacion();
            bicicleta bic = new bicicleta("bmx", "patitoJuan", 2025, 1  );
            Console.WriteLine("-----------------");
            bic.MostrarInformacion();
        }
    }
}


