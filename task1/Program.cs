// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int Prompt(string message)
{
    Console.WriteLine(message);
    string intString = Console.ReadLine();
    return int.Parse(intString);
}

void PrintArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]:f2}" + "\t");
        }
        Console.WriteLine();
    }
}

double[,] CreateRandomMatrix(int row, int column, int min, int max)
{
    var rnd = new Random();
    double[,] newMatrix = new double[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            newMatrix[i, j] = rnd.Next(min, max) + rnd.NextDouble();
        }
    }
    return newMatrix;
}


int n = Prompt("Введите количество строк ");
int m = Prompt("Введите количество столбцов ");
int min = Prompt("Введите минимальное значение ");
int max = Prompt("Введите максимальное значение ");


double[,] myArray = CreateRandomMatrix(n, m, min, max);

PrintArray(myArray);
