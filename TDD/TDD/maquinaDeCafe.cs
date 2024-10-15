using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    internal class maquinaDeCafe
    {
        private Cafetera cafetera;
        private Vasos vasosSmall;
        private Vasos vasosMedium;
        private Vasos vasosLarge;
        private Azucarero azucarero;

        public maquinaDeCafe(Vasos vasosS, Vasos vasosM, Vasos vasosB){
            this.cafetera = Cafetera.ObtenerInstancia();
            this.vasosSmall = vasosS;
            this.vasosMedium = vasosM;
            this.vasosLarge = vasosB;
            this.azucarero = Azucarero.ObtenerInstancia();
        }

        public int getTipoVaso(char tipo){
            switch (tipo){
                case 'P':
                    return 3;

                case 'M':
                    return 5;

                case 'G':
                    return 7;
                default:
                    throw new ArgumentException("Tamaño de vaso no valido.");
            }
        }
        public void getVasoDeCafe(char tipo, int cantidadVasos, int cantidadAzucar){
            int onzas = getTipoVaso(tipo);

            for (int i = 0; i < cantidadVasos; i++){
                    
                if (tipo == 'P'){
                    if (vasosSmall.hasVasos(1)){
                        vasosSmall.giveVasos(1);
                        cafetera.giveCafe(onzas);
                        azucarero.giveAzucar(cantidadAzucar);
                    }
                    else{
                    Console.WriteLine("No hay vasos pequeños.");
                    }
                }
                

                else if (tipo == 'M'){
                    if (vasosMedium.hasVasos(1)){
                        vasosMedium.giveVasos(1);
                        cafetera.giveCafe(onzas);
                        azucarero.giveAzucar(cantidadAzucar);
                    }
                    else{
                    Console.WriteLine("No hay vasos medianos.");
                    }
                }
                

                else if (tipo == 'G'){
                    if (vasosLarge.hasVasos(1))
                    {
                        vasosLarge.giveVasos(1);
                        cafetera.giveCafe(onzas);
                        azucarero.giveAzucar(cantidadAzucar);
                    }
                    else{
                    Console.WriteLine("No hay vasos Grandes.");
                    }
                }
                
                else{
                    throw new ArgumentException("Tamaño de vaso no valido.");
                }
            }
        }
    }
}
