using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperacionEric_SLE
{
    public class IntentoListas
    {
        Nodo primerNodo;
        Nodo ultimoNodo;

        public IntentoListas()
        {
            primerNodo = null;
            ultimoNodo = null;
        }


        //METODO PARA CHECAR LA LISTA VACIA

        public bool ListaVacia()
        {
            return (primerNodo == null);
        }

        //METODO PARA CHECAR LA LONGITUD
        public void LongitudLista()
        {
            Nodo actual = primerNodo;
            int contador = 1;
            while (actual != null)
            {
                contador++;
                actual = actual.Siguiente;
            }
        }


        //AGREGAR INICIO
        public void InsertarInicio(Carro carro)
        {
            Nodo nuevoNodo = new Nodo(carro);
            if (ListaVacia())
            {
                primerNodo = nuevoNodo;
                ultimoNodo = nuevoNodo;
            }
            else
            {
                nuevoNodo.Siguiente = primerNodo;
                primerNodo = nuevoNodo;
            }
        }

        //IMPRIMIR LISTA SIUUUU

        public void ImprimirLista()
        {
            if (ListaVacia())
            {
                Console.WriteLine("La lista esta vacia karnal");
            }
            else
            {
                Nodo actual = primerNodo;
                while (actual != null)
                {
                    
                        Console.WriteLine($"La marca del carro es {actual.Valor._marca}, el modelo es {actual.Valor._modelo} y el año  de lanzamiento es {actual.Valor._anioLanzamiento}");
                       actual = actual.Siguiente;
                    
                   
                }
            }
        }


        //ORDENAR BUBUJA
        public void Ordenar()
        {
            if (ListaVacia())
            {
                Console.WriteLine("La lista esta vacia karnal");
            }
            else
            {
                Nodo actual = primerNodo;
                Nodo siguiente;

                while (actual != null)
                {
                    siguiente = actual.Siguiente;


                    while (siguiente != null)
                    {
                        if (  siguiente.Valor._anioLanzamiento  > actual.Valor._anioLanzamiento)
                        {
                            int temporal = actual.Valor._anioLanzamiento;
                            actual.Valor._anioLanzamiento = siguiente.Valor._anioLanzamiento;
                            siguiente.Valor._anioLanzamiento = temporal;
                        }
                        siguiente = siguiente.Siguiente;
                    }

                    actual = actual.Siguiente;
                }
            }
        }



        public void Busqueda(string buscar)
        {
            Console.WriteLine("--------------------------------");
            Nodo actual = primerNodo;
            bool encontrado = false;
            while (actual != null)
            {
                string aber = actual.Valor._marca;
                aber.CompareTo(buscar);
                
                Console.WriteLine("Los carros son " + buscar);
                break;

            }
            Console.WriteLine("No ai");


        }

        //MOSTRAR RESULTADOS DESPUES

        public void MostrarTodo()
        {
            Console.WriteLine("AL FINAL SUS DATOS SON");
           
            Ordenar();
            ImprimirLista();
        }









    }
}
