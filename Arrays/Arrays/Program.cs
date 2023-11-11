using System;

class Arrays
{
    static void Main()
    {
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
        int numeroToSearch = int.Parse(Console.ReadLine());


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
    }

}