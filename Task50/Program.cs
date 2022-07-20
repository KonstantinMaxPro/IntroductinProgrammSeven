int[,] GetMatrix(int rows, int columns, int min = -9, int max = 99)
{
    int[,] matrix = new int[rows, columns];
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

void PrintMatrix(int[,] matrix)
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

void SearchValue(int[,] matrix, int x, int y)
{
    try
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nв массиве по адресу [{x},{y}] найдено значение: {matrix[x, y]}");
        Console.ResetColor();
    }
    catch
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("В массиве нет таких значений");
        Console.ResetColor();
    }
}

var rand = new Random();
int rows = rand.Next(3, 10);
int columns = rand.Next(3, 10);
string programmName = "| ВЫВОД ЗНАЧЕНИЯ ДВУМЕРНОГО МАССИВА ПО ВВОДНЫМ ДАННЫМ |";
string line = new string('=', programmName.Length);

Console.Clear();//Очищаем консоль
/*ЗАГОЛОВОК (ДЛЯ КРАСОТЫ)*/
Console.WriteLine($"{line}\n{programmName}\n{line}\n");//Название
/*КОНЕЦ ЗАГОЛОВКА*/

int row = 0;
int column = 1;
Console.Write("Введите номер строки в массиве: ");
while (!int.TryParse(Console.ReadLine(), out row))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("ОШИБКА! ВЫ ВВЕЛИ НЕ ЦЕЛОЧИСЛЕННОЕ ЗНАЧЕНИЕ\n");
    Console.ResetColor();
    Console.Write("Введите номер строки в массиве: ");
}
Console.Write("Введите номер столбца в массиве: ");
while (!int.TryParse(Console.ReadLine(), out column))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("ОШИБКА! ВЫ ВВЕЛИ НЕ ЦЕЛОЧИСЛЕННОЕ ЗНАЧЕНИЕ\n");
    Console.ResetColor();
    Console.Write("Введите номер столбца в массиве: ");
}

Console.Clear();//Очищаем консоль
/*ЗАГОЛОВОК (ДЛЯ КРАСОТЫ)*/
Console.WriteLine($"{line}\n{programmName}\n{line}\n");//Название
/*КОНЕЦ ЗАГОЛОВКА*/

Console.WriteLine($" Сгенерирован двумерный массив (матрица) [{rows},{columns}]");
Console.WriteLine(line);
int[,] result = GetMatrix(rows, columns);
Console.ForegroundColor = ConsoleColor.Yellow;
PrintMatrix(result);
Console.ResetColor();
SearchValue(result, row, column);
Console.WriteLine(line);
