// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

int Prompt(string message)
{
    Console.WriteLine(message);
    string intString = Console.ReadLine();
    return int.Parse(intString);
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}" + "\t");
        }
        Console.WriteLine();
    }
}

void PrintListAvr(double[] list)
{
    Console.WriteLine("Cреднее арифметическое элементов в каждом столбце: ");
    foreach (double el in list)
    {
        Console.Write($"{el:f2}" + "\t");

    }
    Console.WriteLine();
}

int[,] CreateRandomMatrix(int row, int column, int min, int max)
{
    var rnd = new Random();
    int[,] newMatrix = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            newMatrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return newMatrix;
}

double[] FindAverageInColumns(int[,] matrix)
{
    double runningSum = 0;
    double[] columns = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        runningSum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            runningSum = runningSum + matrix[i, j];
        }
        columns[j] = runningSum / matrix.GetLength(0);
    }
    return columns;
}

int n = Prompt("Введите количество строк ");
int m = Prompt("Введите количество столбцов ");
int min = Prompt("Введите минимальное значение ");
int max = Prompt("Введите максимальное значение ");

int[,] myArray = CreateRandomMatrix(n, m, min, max);

PrintArray(myArray);

PrintListAvr(FindAverageInColumns(myArray));
