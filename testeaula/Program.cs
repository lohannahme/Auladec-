using System;


namespace testeaula
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int n;
            double med = 0;

            n = int.Parse(Console.ReadLine());

            double[] vet = new double[n];

            for(int i = 0; i < n; i++)
            {
                vet[i] = double.Parse(Console.ReadLine());
                med += vet[i];
            }

            med = med / n;

            Console.WriteLine($"AVERAGE HEIGHT = {med.ToString("F2")}");





            Console.ReadLine();

        }
    }
}
