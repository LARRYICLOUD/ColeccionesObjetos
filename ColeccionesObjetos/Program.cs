using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionesObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*EjemploGenerico<string>generico1 = new EjemploGenerico<string>();
            EjemploGenerico<int> generico2 = new EjemploGenerico<int>();*/

            //variables locales
            Alumno valorElemento;
            //instanciando la clase
            GuardaObjetos objetos1 = new GuardaObjetos(3);

            //agregar objetos
            /*objetos1.AgregarElementos("LARRYSALSA");
            objetos1.AgregarElementos("LARRYSALSADECALI");
            objetos1.AgregarElementos("LARRYSALSAONLINE");*/

            //instanciamos a la clase alumno
            Alumno alumno1 = new Alumno(4.5);
            Alumno alumno2 = new Alumno(3.5);
            Alumno alumno3 = new Alumno(4.0);

            //agregar objetos a la clase "GuardaObjetos"
            objetos1.AgregarElementos(alumno1);
            objetos1.AgregarElementos(alumno2);
            objetos1.AgregarElementos(alumno3);

            //obtener elemento
            valorElemento =(Alumno) objetos1.obtenerElemento(0); //utilizamos string como expresion cast o casting
            Console.WriteLine(valorElemento.Calificacion);

        }
    }

    /*class EjemploGenerico<T>
    {
        
    }*/
    class GuardaObjetos
    {
        //campos
        private int i = 0;
    private Object[] matrizElementos;


        //constructor
        public GuardaObjetos (int elementosPa)
        {
            matrizElementos = new Object[elementosPa];
        }

        //metodos
        public void AgregarElementos(object elementoPa)
        {
            matrizElementos[i] = elementoPa;
            i++;

        }
        public object obtenerElemento (int elementoPa)
        {
            return matrizElementos[elementoPa];
        }
    }
    class Alumno
    {
        //campo
        double calificacion;


        //constructor
        public Alumno(double calificacionPa)
        {
            calificacion = calificacionPa;
        }

        //propiedades
        public double Calificacion
        {
            get => calificacion;
        }

       

    }
}

