using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R19E01_JesusCG
{
    public static class Pantalla
    {
        public static void MenuPrincipal(Vehiculo[] lista)
        {
            int opcionSelect = 0;
            Console.Clear();
            string? aux = "";

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n\tBIENVENIDO AL MENÚ DEL CONCESIONARIO :)\n");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\t0.- SALIR");
            Console.WriteLine("\t1.- Mostrar Listado de Vehículos");
            Console.WriteLine("\t2.- Mostrar Datos de un Vehículo\n");

            Console.Write("\tSeleccione una Opción: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            aux = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            opcionSelect = Convert.ToInt32(aux);

            do
            {
                switch (opcionSelect)
                {
                    case 0:
                        // No hace nada
                        break;
                    case 1:
                        MostrarListadoCompleto(lista);
                        break;
                    case 2:
                        MostrarListadoVehiculo(lista);
                        break;
                }
            } while (opcionSelect != 0);
        }

        public static void MostrarListadoCompleto(Vehiculo[] lista)
        {
            int finalizador = 0;
            Console.WriteLine("\tMARCA\t\t MODELO\t\t TIPO\t\t COMBUSTIBLE\t\t ESTADO\t FECHA MATRICULACIÓN");

            foreach(Vehiculo coche in lista)
            {
                Console.WriteLine($"\t{coche.Marca}\t\t{coche.Modelo}\t\t{coche.TVehiculo}\t\t{coche.Combustibl}\t\t{coche.Estad}\t{coche.Matriculacion}");
            }

            
            
                Console.WriteLine("Pulse Enter para Continuar ...");
                Console.Write("Introduzca 0 para finalizar el programa: ");
                Console.ReadLine();
                MenuPrincipal(lista);



            


        }

        public static void MostrarListadoVehiculo(Vehiculo[] listaVehicu)
        {
            int numerito = 1;
            string seleccion = "";
            int opcion = 0;

            Console.WriteLine("\tMARCA \t\t MODELO");
            foreach (Vehiculo coche in listaVehicu)
            {
                Console.WriteLine($"\t{numerito}.- {coche.Marca}\t{coche.Modelo}");
                numerito++;
            }


            Console.WriteLine("Pulse 0 para salir: ");
            Console.WriteLine("Pulse 6 para volver al menú principal: ");
            Console.Write("\nSeleccione un Vehículo (1-5): ");

            do
            {
                seleccion = Console.ReadLine();
                opcion = Convert.ToInt32(seleccion);

                switch (opcion)
                {
                    case 0:
                        
                        break;
                    case 1:
                        Console.WriteLine("\tMARCA\t\t MODELO\t\t TIPO\t\t COMBUSTIBLE\t\t ESTADO\t FECHA MATRICULACIÓN");
                        Vehiculo coche1 = listaVehicu[0];
                        Console.WriteLine($"\t{coche1.Marca}\t\t{coche1.Modelo}\t\t{coche1.TVehiculo}\t\t{coche1.Combustibl}\t\t{coche1.Estad}\t{coche1.Matriculacion}");

                        Console.WriteLine("Pulse Enter para Continuar ...");
                        Console.ReadLine();
                        Console.Clear();

                        MostrarListadoVehiculo(listaVehicu);

                        break;
                    case 2:
                        Console.WriteLine("\tMARCA\t\t MODELO\t\t TIPO\t\t COMBUSTIBLE\t\t ESTADO\t FECHA MATRICULACIÓN");
                        Vehiculo coche2 = listaVehicu[1];
                        Console.WriteLine($"\t{coche2.Marca}\t\t{coche2.Modelo}\t\t{coche2.TVehiculo}\t\t{coche2.Combustibl}\t\t{coche2.Estad}\t{coche2.Matriculacion}");

                        Console.WriteLine("Pulse Enter para Continuar ...");
                        Console.ReadLine();
                        Console.Clear();

                        MostrarListadoVehiculo(listaVehicu);

                        break;

                    case 3:
                        Console.WriteLine("\tMARCA\t\t MODELO\t\t TIPO\t\t COMBUSTIBLE\t\t ESTADO\t FECHA MATRICULACIÓN");
                        Vehiculo coche3 = listaVehicu[2];
                        Console.WriteLine($"\t{coche3.Marca}\t\t{coche3.Modelo}\t\t{coche3.TVehiculo}\t\t{coche3.Combustibl}\t\t{coche3.Estad}\t{coche3.Matriculacion}");

                        Console.WriteLine("Pulse Enter para Continuar ...");
                        Console.ReadLine();
                        Console.Clear();

                        MostrarListadoVehiculo(listaVehicu);

                        break;

                    case 4:
                        Console.WriteLine("\tMARCA\t\t MODELO\t\t TIPO\t\t COMBUSTIBLE\t\t ESTADO\t FECHA MATRICULACIÓN");
                        Vehiculo coche4 = listaVehicu[3];
                        Console.WriteLine($"\t{coche4.Marca}\t\t{coche4.Modelo}\t\t{coche4.TVehiculo}\t\t{coche4.Combustibl}\t\t{coche4.Estad}\t{coche4.Matriculacion}");

                        Console.WriteLine("Pulse Enter para Continuar ...");
                        Console.ReadLine();
                        Console.Clear();

                        MostrarListadoVehiculo(listaVehicu);

                        break;

                    case 5:
                        Console.WriteLine("\tMARCA\t\t MODELO\t\t TIPO\t\t COMBUSTIBLE\t\t ESTADO\t FECHA MATRICULACIÓN");
                        Vehiculo coche5 = listaVehicu[4];
                        Console.WriteLine($"\t{coche5.Marca}\t\t{coche5.Modelo}\t\t{coche5.TVehiculo}\t\t{coche5.Combustibl}\t\t{coche5.Estad}\t{coche5.Matriculacion}");

                        Console.WriteLine("Pulse Enter para Continuar ...");
                        Console.ReadLine();
                        Console.Clear();

                        MostrarListadoVehiculo(listaVehicu);

                        break;
                    case 6:
                        MenuPrincipal(listaVehicu);
                        break;
                   
                }
            } while (opcion != 0);

        }

        //public static void MostrarUnVehiculo()
        //{
        //    int seleccion = 0;

        //    seleccion = Pantalla.MostrarListadoVehiculo();
        //}
          
    }
}
