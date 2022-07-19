double[,] GetMatrix(int rows, int columns, int min = 0, int max = 10)
{
    double[,] matrix = new double[rows, columns];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.NextDouble() * max;
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
            Console.Write("{0,6:F2}\t", matrix[i, j]);
        }
        Console.WriteLine();
    }
}

int rows = 0;
int columns = 0;
string programmName = "|  ГЕНЕРАЦИЯ МАССИВА С ВЕЩЕСТВЕННЫМИ ЧИСЛАМИ  |";
string line = new string('=', programmName.Length);

Console.Clear();//Очищаем консоль
/*ЗАГОЛОВОК (ДЛЯ КРАСОТЫ)*/
Console.WriteLine($"{line}\n{programmName}\n{line}\n");//Название
/*КОНЕЦ ЗАГОЛОВКА*/


Console.Write("Введите количество строк в массиве: ");
while (!int.TryParse(Console.ReadLine(), out rows))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("ОШИБКА! ВЫ ВВЕЛИ НЕ ЦЕЛОЧИСЛЕННОЕ ЗНАЧЕНИЕ\n");
    Console.ResetColor();
    Console.Write("Введите количество строк в массиве: ");
}
Console.Write("Введите количество столбцов в массиве: ");
while (!int.TryParse(Console.ReadLine(), out columns))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("ОШИБКА! ВЫ ВВЕЛИ НЕ ЦЕЛОЧИСЛЕННОЕ ЗНАЧЕНИЕ\n");
    Console.ResetColor();
    Console.Write("Введите количество столбцов в массиве: ");
}

Console.Clear();//Очищаем консоль
/*ЗАГОЛОВОК (ДЛЯ КРАСОТЫ)*/
Console.WriteLine($"{line}\n{programmName}\n{line}\n");//Название
/*КОНЕЦ ЗАГОЛОВКА*/
System.Console.WriteLine($" Сгенерирован двумерный массив (матрица) [{rows},{columns}]");
System.Console.WriteLine(line);
Console.ForegroundColor = ConsoleColor.Yellow;
PrintMatrix(GetMatrix(rows, columns));
Console.ResetColor();
System.Console.WriteLine(line);