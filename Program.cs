using System;
using System.Collections;

namespace test
{
    class Program
    {



        static int[] myArray = { 13, 2, 4, 35, 1 };


        public static void Main()
        {
            int max = myArray[0], min = myArray[0];
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] > max)

                    max = myArray[i];


                else if (myArray[i] < min)

                    min = myArray[i];
            }

            Console.Write(max);

        }

        ////---------------------------------------------------------------------------------------------------------------------

        static int[] myArray = { 1, 2, 1, 3, 3, 1, 2, 1, 5, 1 };

        public static void Main()
        {
            var n = myArray.Length;
            bool[] visited = new bool[n];
            // Recorro de 1 a 5 para ver cu?ntas veces se repite cada valor
            for (int i = 1; i <= 5; i++)
            {
                // Cantidad de veces que se repite i
                var count = 0;
                // se inicia en 0 porque hasta ahora no hay coincidencias
                // Recorro el arreglo
                for (int j = 0; j < n; j++)
                {
                    // Skip this element if already processed
                    // Esto lo hago aqu? adentro porque es donde recorro el arreglo ahora
                    if (visited[j] == true)
                    {
                        continue;
                    }
                    // Si el valor en esa posici?n es el analizado (i) incremento
                    if (myArray[j] == i)
                    {
                        visited[j] = true;
                        count++;
                    }
                }
                // La i tiene el valor y count las veces que se repite
                Console.Write(i.ToString() + ": ");
                for (int k = 0; k < count; k++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }

        ////----------------------------------------------------------------------------------------------------------------------------------


        static int[] myArray = { 1, 2, 2, 4, 5, 6, 7, 8, 8, 8 };

        public static void Main()
        {
            int maxNumero = myArray[0];
            int maxVeces = 0;

            int i = 0;
            while (i < myArray.Length)
            {
                int numVeces = 0;
                int j = 0;
                while (j < myArray.Length)
                {
                    if (myArray[j] == myArray[i]) numVeces++;
                    {
                        j++;
                    }
                }

                if (numVeces > maxVeces)
                {
                    maxNumero = myArray[i];
                    maxVeces = numVeces;
                }
                i++;
            }
            Console.WriteLine("Longest: " + maxVeces);
            Console.WriteLine("Number: " + maxNumero);
        }

    }
    

}