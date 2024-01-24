using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main (string[] args)
        {
            int count1 = 0, count2=0, sum=0, proiz =0;
            Console.Write("Введите число k: ");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество строк массива: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов массива: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите начальную строку: ");
            int k1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите конечную строку: ");
            int k2 = Convert.ToInt32(Console.ReadLine());
            int[,] mas = new int[a, b];
            Random rnd = new Random();
            for (int i=0; i<mas.GetLength(0); i++)
            {
                for (int j=0; j<mas.GetLength(1);j++)
                {
                    mas[i, j] = rnd.Next(-50, 51);
                    Console.Write($"{mas[i,j],4}");
                    if (mas[i, j] > 0 && mas[i, j] % k == 0)
                        count1++;
                    if (mas[i, j] % a == 0 || mas[i, j] % b == 0)
                        count2++;
                }
                Console.WriteLine();
            }
            for (int i = k1; i <=k2; i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    sum = mas[i,j] + mas[i, j];
                }
            }
            for (int i=0; i<mas.GetLength(0); i++)
            {
                for (int j = k1; j <= k2; j++)
                {
                    if (mas[i, j] < 0)
                        proiz = mas[i,j] * mas[i, j];
                }
            }
            Console.WriteLine("Количество положительных эллементов кратных k: " + count1);
            Console.WriteLine($"Сумма эллементов в строках с {k1} по {k2} равна: " +sum);
            Console.WriteLine("Количество эллементов кратных a или b: " + count2 );
            Console.WriteLine($"Произведение отрицательных эллементов в столбцах с {k1} по {k2}: " + proiz);
        }
    }
}
