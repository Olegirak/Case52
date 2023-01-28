/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int GetDataFromUser(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    System.Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    Console.ResetColor();
    return result;
}

int[,] get2DDoubleArray(int colLength,
                        int rowLength,
                        int start,
                        int finish)
{
    int[,] array = new int[colLength, rowLength];
    for (int i = 0; i < colLength; i++)
    {
        for (int j = 0; j < rowLength; j++)
        {
            array[i, j] = new Random().Next(start, finish + 1);
        }
    }
    return array;
}
void printInColor(string data)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write(data);
    Console.ResetColor();
}
void print2Darray(int[,] array)
{
    Console.Write(" \t");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        printInColor(j + "\t");
    }
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        printInColor(i + "\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
string SredArifSt(int[,] mas)
{
    string res = string.Empty;
    for( int i = 0; i< mas.GetLength(1);i++)
    {
        
        int sumst = 0;
        for( int j = 0; j< mas.GetLength(0);j++)
        {
            sumst = sumst+mas[j,i];
        }
        double srarif =1.0* sumst/mas.GetLength(0);
        srarif = Math.Round(srarif,1);
        res = res+srarif+";";
    }
    return res;
}


int n = GetDataFromUser("Введите количество строк");
int m = GetDataFromUser("Введите количество столбцов");
int[,] Array = get2DDoubleArray(n, m, 1, 15);
print2Darray(Array);
String res = "Среднее арифметическое каждого столбца :" + SredArifSt(Array);
res = res[..^1];
Console.WriteLine(res);
