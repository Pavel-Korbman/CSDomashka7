// Внутри класса Answer напишите методы 
// CreateIncreasingMatrix, PrintArray, PrintListAvr и FindAverageInColumns.

// Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности, 
// с каждым новым элементом увеличивающимся на определенное число. 
// Метод принимает на вход три числа 
// (n - количество строк матрицы, m - количество столбцов матрицы, 
// k - число, на которое увеличивается каждый новый элемент) 
// и возвращает матрицу, удовлетворяющую этим условиям.

// Метод PrintArray должен выводить на экран 
// сгенерированную методом CreateIncreasingMatrix матрицу.

// Метод FindAverageInColumns принимает целочисленную матрицу типа int[,] 
// и возвращает одномерный массив типа double. 
// Этот метод вычисляет среднее значение чисел в каждом столбце матрицы 
// и сохраняет результаты в виде списка.

// Метод PrintListAvr принимает одномерный массив, 
// возвращенный методом FindAverageInColumns и выводит этот список на экран в формате
// The averages in columns are:
// x.x0 x.x0 x.x0 ..., где x.x0 - это значения средних значений столбцов, 
// округленные до двух знаков после запятой 
// (в дробной части ВСЕГДА должно быть 2 числа через точку, см. формат вывода), разделенные знаком табуляции.

int n = 3;
int m = 4;
int k = 2;

//public static void PrintArray (int [,] matrix)
//    {
//      // Введите свое решение ниже
//    }
void PrintArray (int [,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]}\t");
    }
    Console.WriteLine();
}
}

 //public static int[,] CreateIncreasingMatrix(int n, int m, int k)
 //   {
      // Введите свое решение ниже
//    }
int[,] CreateIncreasingMatrix(int n, int m, int k)
{
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

//static void PrintListAvr (double [] list)
//    {
      // Введите свое решение ниже
//    }
void PrintListAvr (double [] list)
{
Console.WriteLine("The averages in columns are:");
Console.Write($"{list[0]:F2}");
for (int i = 1; i < list.Length; i++)
{
Console.Write($"\t{list[i]:F2}");
}
}

//static double [] FindAverageInColumns (int [,] matrix)
//    { 
      // Введите свое решение ниже
 //   }
double[] FindAverageInColumns (int [,] matrix)
{
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



int[,] result = CreateIncreasingMatrix(n, m, k);
PrintArray(result);
PrintListAvr(FindAverageInColumns(result));
