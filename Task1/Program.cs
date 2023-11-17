// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// Внутри класса Answer напишите метод CreateRandomMatrix, 
// который принимал бы числа m и n (размерность массива), 
// а также minLimitRandom и maxLimitRandom, которые указывают на минимальную и максимальную границы случайных чисел.

// Также, задайте метод PrintArray, который выводил бы массив на экран.

// Для вывода матрица используйте интерполяцию строк 
// для форматирования числа matrix[i, j] с двумя знаками после запятой (f2) 
// и добавления символа табуляции (\t) после каждого элемента матрицы. 
// Таким образом, каждый элемент матрицы будет разделен символом табуляции при выводе.

int m = 3;
int n = 4;
int minLimitRandom = -10;
int maxLimitRandom = 10;

double[,] matrix = new double[m, n];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().NextDouble() * (maxLimitRandom - minLimitRandom) + minLimitRandom;
    }
}

 for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{Math.Round(matrix[i, j], 1)}\t");
        }
        Console.WriteLine();
    }

    // // Из эталона

//   static Random random = new Random();

  
//     double[, ] matrix = new double[m, n];

//     for (int i = 0; i < m; i++) 
//     {
//       for (int j = 0; j < n; j++) 
//       {
//         matrix[i, j] = random.Next(minLimitRandom, maxLimitRandom + 1) + random.NextDouble();
//       }
//     }

//     for (int i = 0; i < matrix.GetLength(0); i++) 
//     {
//       for (int j = 0; j < matrix.GetLength(1); j++) 
//       {
//         Console.Write($"{matrix[i, j]:f2}\t");
//       }
//       Console.WriteLine();
//     }

   
      