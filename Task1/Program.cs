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

   
      