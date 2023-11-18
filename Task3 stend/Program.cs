using System;

public class Answer {
    public static void PrintArray (int [,] matrix)
    {
      // Введите свое решение ниже
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]}\t");
    }
    Console.WriteLine();
}

    }
  
    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
      // Введите свое решение ниже
int[,] matrix = new int[n, m];
int sum = 1;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {

        matrix[i, j] = sum;
        sum = sum + k;
    }
}
return matrix;

    }
  
    static void PrintListAvr (double [] list)
    {
      // Введите свое решение ниже
Console.WriteLine("The averages in columns are:");
Console.Write($"{list[0]:F2}");
for (int i = 1; i < list.Length; i++)
{
Console.Write($"\t{list[i]:F2}");
}

    }

    static double [] FindAverageInColumns (int [,] matrix)
    { 
      // Введите свое решение ниже
double [] list = new double[matrix.GetLength(1)];
double s = 0;
for (int j = 0; j < matrix.GetLength(1); j++)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    { 
    s = s + Convert.ToDouble(matrix[i,j]);
    list[j]= s/Convert.ToDouble(matrix.GetLength(0));
    }
   s = 0;
}
return list;

    }


    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int n, m, k;

        if (args.Length >= 3) {
           n = int.Parse(args[0]);
           m = int.Parse(args[1]);
           k = int.Parse(args[2]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
           n = 3;
           m = 4;
           k = 2;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintListAvr(FindAverageInColumns(result));
    }
} // Проверяем решение