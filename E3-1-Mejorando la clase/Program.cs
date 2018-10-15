using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_1_Mejorando_la_clase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero de clases a asignar");
            int n = Int32.Parse(Console.ReadLine());

            string[] clases = new string[n];

            int[] numAlumnos = new int[n];
            int i = 0;
            int cantidadAlumnos = 0;
            for (int c = 0; c < n; c++)//asignar nombres a las clases y cantidad de alumnos permitidos por cada una
            {

                Console.WriteLine("Nombre de la clase {0}", c + 1);
                clases[i] = Console.ReadLine();


                Console.WriteLine("Numero de alumnos en la clase {0}", clases[i]);
                numAlumnos[i] = Int32.Parse(Console.ReadLine());

                cantidadAlumnos += numAlumnos[i];//contador de alumnos en total

                i++;
            }
            int nom = 0;

            string[] Alumnos = new string[cantidadAlumnos];
            double[] calificacion = new double[cantidadAlumnos];

            int r = 0;//contador para ver posicion en arreglo de numAlumnos y clases
            while (nom < cantidadAlumnos)
            {
                for (int cont = 0; cont < numAlumnos[r]; cont++)
                {
                    Console.WriteLine("Nombre de alumno {0} clase {1}", cont + 1, clases[r]);

                    Alumnos[nom] = Console.ReadLine();




                    Console.WriteLine("Calificacion de {0}: ", Alumnos[nom]);
                    calificacion[nom] = double.Parse(Console.ReadLine());

                    nom++;
                }
                r++;
            }

            //imprimiendo datos


            int j = 0;//contador para los arreglos de la cantidad de clases y tambien dealumnos por clase
            int conA = 0;//contador de numero en que va el arreglo de cantidad de alumnos
            foreach (string m in clases)
            {
                Console.WriteLine("Clase: ");
                Console.WriteLine(m + "\n");
                Console.WriteLine("Alumnos en clase {0} y su calificacion:", m);


                for (int cont = 0; cont < numAlumnos[j]; cont++)
                {
                    Console.WriteLine(Alumnos[conA] + ", calificacion: " + calificacion[conA] + "\n");
                    conA++;
                }



                j++;
            }

            Console.ReadKey();

        }
    }

}
