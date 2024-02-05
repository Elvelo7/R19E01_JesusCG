namespace R19E01_JesusCG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES
            const int TAMANIO = 5;

            // RECURSOS
            Vehiculo[] listaVehiculos;

            int opcionMenu = 0;
            int cocheSeleccionado = 0;

            // INICIALIZACIÓN 
            // Instanciación (Reserva de Memoria) para los cinco elementos del array
            listaVehiculos = new Vehiculo[TAMANIO];

            // Proceso: Carga de los coches en la lista
            ListaNegocio.CargarListaVehiculos(listaVehiculos);

            Pantalla.MenuPrincipal(listaVehiculos);

            //opcionMenu = Pantalla.MenuPrincipal();

            //do
            //{
            //    switch (opcionMenu)
            //    {
            //        case 0:
            //            // No hace nada
            //            break;
            //        case 1:
            //            Pantalla.MostrarListadoCompleto(listaVehiculos);
            //            break;
            //        case 2:
            //            Pantalla.MostrarListadoVehiculo(listaVehiculos);
            //            break;
            //    }
            //} while (opcionMenu != 0);






            //TipoCombustible fuel = TipoCombustible.Hibrido;

            //// Incremento o descuento del precio del vehículo según el tipo de combustible
            //switch (fuel)
            //{
            //    case TipoCombustible.Gasolina:
            //        break;
            //    case TipoCombustible.Hibrido:
            //        break;
            //    case TipoCombustible.Diesel:
            //        break;
            //    case TipoCombustible.Electrico:
            //        break;
            //}

        }
    }
}
