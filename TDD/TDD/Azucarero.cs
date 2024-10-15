using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    internal class Azucarero
    {
            private int cantidadDeAzucar;

    public Azucarero(int cantidadAzucar){
        if (cantidadAzucar < 0){
                Console.WriteLine("No se pueden asignar valores negativos.");
            }
        else{ cantidadDeAzucar = cantidadAzucar; }
        
    }

    public int llenarAzucar(){
        return cantidadDeAzucar;
    }

    public string decirAzucar(){
        return "Actualmente el azucarero cuenta con: " + cantidadDeAzucar + " cubos";
    }
    
    public bool hayAzucar(int cantidadAzucar){
        if (cantidadDeAzucar >= cantidadAzucar){
            return true;
        }
        else{
            return false;
        }
    }

    public void echarAzucar(int cantidadAzucar){
        
        if( hayAzucar(cantidadAzucar)){
           cantidadDeAzucar -= cantidadAzucar;
            Console.WriteLine("Se ha servido " + cantidadAzucar + " cubos de azucar");
        }
        else{
            Console.WriteLine("El azucarero no tiene suficiente azucar... Pidele azucar a la vecina");
        }
        
    }
    }
}
