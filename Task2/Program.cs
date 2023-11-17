// Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности, 
// с каждым новым элементом увеличивающимся на определенное число. 
// Метод принимает на вход три числа 
// (n - количество строк матрицы, m - количество столбцов матрицы, 
// k - число, на которое увеличивается каждый новый элемент) 
// и возвращает матрицу, удовлетворяющую этим условиям.




int n = 4;
int m = 5;
int k = 3;
int x = 2;
int y = 2;

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


for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]}\t");
    }
    Console.WriteLine();
}

// int[] FindNumberByPosition (int [,] matrix, int rowPosition, int columnPosition)
int[] results = new int[2];
if (x < matrix.GetLength(0) && y < matrix.GetLength(1)) results[0] = matrix[x, y];




if (results[0] != 0) Console.WriteLine($"The number in [{x}, {y}] is {results[0]}");
else Console.WriteLine("There is no such index");

