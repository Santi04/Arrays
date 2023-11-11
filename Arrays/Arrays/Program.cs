using System;

class Arrays
{
    static void Main()
    {
        Console.Write("Ingrese la longitud del vector: ");
        int n = int.Parse(Console.ReadLine());

        // Crear un vector de tamaño N
        int[] vector = new int[n];

        // Llenar el vector aleatoriamente con números enteros
        LlenarVectorAleatorio(vector);

        // Mostrar el vector generado
        Console.WriteLine("Vector generado:");
        MostrarVector(vector);

        // Pedir un número al usuario
        Console.Write("Ingrese un número para buscar en el vector: ");
        int numBuscado = int.Parse(Console.ReadLine());

        // Buscar el número en el vector
        int posicion = BuscarNumeroEnVector(vector, numBuscado);

        // Mostrar el resultado
        if (posicion != -1)
        {
            Console.WriteLine($"El número {numBuscado} se encuentra en la posición {posicion} del vector.");
        }
        else
        {
            Console.WriteLine($"El número {numBuscado} no existe en el vector.");
        }
    }

    // Función para llenar el vector aleatoriamente con números enteros
    static void LlenarVectorAleatorio(int[] vector)
    {
        Random random = new Random();
        for (int i = 0; i < vector.Length; i++)
        {
            vector[i] = random.Next(1, 101); // Números aleatorios entre 1 y 100, puedes ajustar el rango según tus necesidades
        }
    }

    // Función para mostrar el contenido del vector
    static void MostrarVector(int[] vector)
    {
        foreach (int numero in vector)
        {
            Console.Write(numero + "| ");
        }
        Console.WriteLine();
    }

    // Función para buscar un número en el vector y devolver su posición (índice)
    static int BuscarNumeroEnVector(int[] vector, int numeroBuscado)
    {
        for (int i = 0; i < vector.Length; i++)
        {
            if (vector[i] == numeroBuscado)
            {
                return i; // Devolver la posición si se encuentra el número
            }
        }
        return -1; // Devolver -1 si el número no se encuentra en el vector
    }
}