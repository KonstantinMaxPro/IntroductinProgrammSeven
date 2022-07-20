double[,] GetMatrix(int rows, int columns, int min = 0, int max = 9)
{
    double[,] matrix = new double[rows, columns];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void SearchValue(double[,] matrix)
{
    double[] sum = new double[matrix.GetLength(1)];
    double[] avg = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum[j] += matrix[i, j];


        }
        avg[j] = sum[j] / matrix.GetLength(0);
        System.Console.Write($"Среднеарифметическое число столбца {j}: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("{0,4:F2}", avg[j]);
        Console.ResetColor();

    }
}

var rand = new Random();
int rows = rand.Next(3, 10);
int columns = rand.Next(3, 10);
string programmName = "| ВЫВОД СРЕДНЕАРИФМЕТИЧЕСКОГО КАЖДОГО СТОЛБЦА |";
string line = new string('=', programmName.Length);

Console.Clear();//Очищаем консоль
/*ЗАГОЛОВОК (ДЛЯ КРАСОТЫ)*/
Console.WriteLine($"{line}\n{programmName}\n{line}\n");//Название
/*КОНЕЦ ЗАГОЛОВКА*/

Console.WriteLine($" Сгенерирован двумерный массив (матрица) [{rows},{columns}]");
Console.WriteLine(line);
double[,] result = GetMatrix(rows, columns);
Console.ForegroundColor = ConsoleColor.Yellow;
PrintMatrix(result);
Console.ResetColor();
Console.WriteLine(line);
SearchValue(result);
Console.WriteLine(line);
