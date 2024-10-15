using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    internal class maquinaDeCafe
    {
        private Cafetera cafe;
        private Vasos vasosS;
        private Vasos vasosM;
        private Vasos vasosXL;
        private Azucarero azucar;

        public maquinaDeCafe(Cafetera cafetera, Vasos vasosSmall. Vasos vasosMedium, Vasos vasosBig, Azucarero azucarero)
        {
            if (cafe < 0 || vasosS < 0 || vasosM < 0 || vasosXL < 0 || Azucar < 0)
            {
                Console.WriteLine("No se pueden asignar valores negativos.");
            }
            else
            {
                this.cafe = cafetera;
                this.vasosS = vasosSmall;
                this.vasosM = vasosMedium;
                this.vasosG = vasosBig;
                this.azucar = azucarero
            }
        }

        public void interfaz()
        {
            Console.WriteLine("Elija El tamaño de su cafe: Grande (G), Mediana (M), Pequeña (P)");
            string input = Console.ReadLine();

            switch (input.ToUpper())
            {
                case "G":
                    vasoSeleccionado = vasosXL;
                    break;
                case "M":
                    vasoSeleccionado = vasosM;
                    break;
                case "P":
                    vasoSeleccionado = vasosP;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, elige G, M o P.");
                    break;
            }
        }
        return vasoSeleccionado;
    }

    public vasos elegirVaso()
    {
        string tipoDeVaso = "";
        Vasos vasoSeleccionado = null;

        while (vasoSeleccionado == null)
        {
            Console.WriteLine("Elija El tamaño de su cafe: Grande (G), Mediana (M), Pequeña (P)");
            string input = Console.ReadLine();

            switch (input.ToUpper())
            {
                case "G":
                    vasoSeleccionado = vasosXL;
                    break;
                case "M":
                    vasoSeleccionado = vasosM;
                    break;
                case "P":
                    vasoSeleccionado = vasosP;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, elige G, M o P.");
                    break;
            }
        }
        return vasoSeleccionado;
    }

    public void servirCafe(int cantidadDeVasos, int cantidadDeAzucar)
    {
        Vasos vasoSeleccionado = elegirVaso();

        int cantidadDeCafe;
        switch (vasoSeleccionado)
        {
            case var _ when vasoSeleccionado == vasosS:
                cantidadCafe = 4;
                break;
            case var _ when vasoSeleccionado == vasosM:
                cantidadCafe = 8;
                break;
            case var _ when vasoSeleccionado == vasosXL:
                cantidadCafe = 12;
                break;
        }

        if (cafe.hayCafe(cantidadCafe * cantidadDeVasos))
        {
            // Usar los vasos y servir el café
            vasoSeleccionado.usarVasos(cantidadDeVasos);
            cafe.echarCafe(cantidadCafe * cantidadDeVasos);
            azucar.echarAzucar(cantidadDeAzucar);
            Console.WriteLine("Su café ha sido servido.");
        }
        else
        {
            Console.WriteLine("No hay suficiente café disponible.");
        }
    }
}
