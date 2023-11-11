using System;

class Arrays
{
    static void Main()
    {
        Console.Write("Ingrese la longitud del vector: ");
        int n = int.Parse(Console.ReadLine());

        // Creamos un vector de tamaño n
        int[] vector = new int[n];

        // Llenamos el vector aleatoriamente
        LlenarVectorAleatorio(vector);


        // Metodo para llenar el vector
        static void LlenarVectorAleatorio(int[] vector)
        {
            Random random = new Random();
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = random.Next(1, 51);
            }
        }
    }

}