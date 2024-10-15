using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    internal class Vasos
    {
        private int cantidadDeVasos;
        private int contenido;

        public void setCantidadVasos(int cantidad){
            if (cantidad < 0){
                throw new ArgumentException("La cantidad de vasos no puede ser negativa.");
            }
            cantidadDeVasos = cantidad;
        }

        public string getCantidadVasos(){
            return "Actualmente tenemos " + cantidadDeVasos + " vasos disponibles.";
        }

        public void setContenido(int cantidad){ 
            contenido = cantidad; 
        }

        public string getContenidos(){
            return "El vaso tinene " + contenido + " Oz. de café";
        }

        public bool hasVasos(int cantidad){
            return cantidadDeVasos >= cantidad;
        }

        public void giveVasos(int cantidad){
            if (hasVasos(cantidad)){
                cantidadDeVasos -= cantidad;
            }
            else{
                throw new InvalidOperationException("No hay suficientes vasos, ve a buscar.");
            }
        }
    }
}
