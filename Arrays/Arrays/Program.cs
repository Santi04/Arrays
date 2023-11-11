using System;
using System.Numerics;

class Arrays
{
    static void Main()
    {
        //Dado un vector de tamaño N, llenar el vector aleatoriamente con números enteros.
        //Pedir por pantalla un número y determinar si ese número se encuentra en el vector,
        //en caso afirmativo, indicar su posición (índice) dentro del vector, en caso negativo,
        //mostrar el mensaje “El número no existe”

        Console.Write("Ingrese la longitud del vector: ");
        int n = int.Parse(Console.ReadLine());

        // Creamos un vector de tamaño n
        int[] vec = new int[n];

        // Llamamos el metodo para llenar el vector
        FillVector(vec);

        // Llamamos el metodo para imprimir el vector
        Console.WriteLine("Vector generado es:");
        PrintVector(vec);

        // Pedimos el número a buscar en el vector
        Console.Write("Ingrese un número a buscar en el vector: ");
        int numberToSearch = int.Parse(Console.ReadLine());

        // Buscamos el número en el vector
        int posicion = SearchNumberOnVector(vec, numberToSearch);

        // Mostrar el resultado
        if (posicion != -1)
        {
            Console.WriteLine($"El número {numberToSearch} se encuentra en la posición {posicion} del vector.");
        }
        else
        {
            Console.WriteLine($"El número {numberToSearch} no existe en el vector.");
        }
    }

    // Metodo para llenar el vector aleatoriamente
    static void FillVector(int[] vec)
        {
            Random random = new Random();
            for (int i = 0; i < vec.Length; i++)
            {
                vec[i] = random.Next(1, 51);
            }
        }

        // Metodo para imprimir el vector
        static void PrintVector(int[] vec)
        {
            foreach (int numero in vec)
            {
                Console.Write("|"+numero + "| ");
            }
            Console.WriteLine();
        }

        // Metodo para buscar un número en el vector y devolver su posición (índice)
        static int SearchNumberOnVector(int[] vec, int numberToSearch)
        {
            for (int i = 0; i < vec.Length; i++)
            {
                if (vec[i] == numberToSearch)
                {
                    return i;
                }
            }
            return -1;
        }

}