using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R19E01_JesusCG
{
    public static class ListaNegocio
    {
        public static void CargarListaVehiculos(Vehiculo[] lista)
        {
            // VARIABLES
            Vehiculo coche;

            // Instanciar el objeto
            coche = new Vehiculo("Ferrari", " F40");

            // Proporcionar el resto de los datos
            coche.TVehiculo = TipoVehiculo.Turismo;
            coche.Combustibl = TipoCombustible.Gasolina;
            coche.Estad = EstadoVehiculo.Nuevo;
            coche.Matriculacion = new DateTime(2023, 12, 5);
            coche.PrecioContado = 80000;

            // Asignarlo al array
            lista[0] = coche;


            // Instanciar el objeto 2
            coche = new Vehiculo("Masseratti", " Levante");

            // Proporcionar el resto de los datos
            coche.TVehiculo = TipoVehiculo.Turismo;
            coche.Combustibl = TipoCombustible.Gasolina;
            coche.Estad = EstadoVehiculo.Nuevo;
            coche.Matriculacion = new DateTime(2023, 10, 4);
            coche.PrecioContado = 80000;

            // Asignarlo al array
            lista[1] = coche;

            // Instanciar el objeto 3
            coche = new Vehiculo("Bugatti", " Veyron");

            // Proporcionar el resto de los datos
            coche.TVehiculo = TipoVehiculo.Turismo;
            coche.Combustibl = TipoCombustible.Gasolina;
            coche.Estad = EstadoVehiculo.Nuevo;
            coche.Matriculacion = new DateTime(2022, 12, 1);
            coche.PrecioContado = 80000;

            // Asignarlo al array
            lista[2] = coche;


            // Instanciar el objeto 4
            coche = new Vehiculo("Ferrari", " LaFerrari");

            // Proporcionar el resto de los datos
            coche.TVehiculo = TipoVehiculo.Turismo;
            coche.Combustibl = TipoCombustible.Gasolina;
            coche.Estad = EstadoVehiculo.Nuevo;
            coche.Matriculacion = new DateTime(2023, 11, 30);
            coche.PrecioContado = 80000;

            // Asignarlo al array
            lista[3] = coche;

            // Instanciar el objeto 5
            coche = new Vehiculo("Seat", "     Leon");

            // Proporcionar el resto de los datos
            coche.TVehiculo = TipoVehiculo.Turismo;
            coche.Combustibl = TipoCombustible.Gasolina;
            coche.Estad = EstadoVehiculo.Nuevo;
            coche.Matriculacion = new DateTime(2020, 11, 30);
            coche.PrecioContado = 80000;

            // Asignarlo al array
            lista[4] = coche;
        }


    }
}
