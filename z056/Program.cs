//  Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
//  строку с наименьшей суммой элементов.
//  Например, задан массив:
//  1 4 7 2
//  5 9 2 3
//  8 4 2 4
//  5 2 6 7
//   Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
 
int ReadInt(string text) // читаем число из терминала
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}


int[,] FillMatrix(int row, int col, int leftRange, int rightRange)// Функция заполнения массива рандомными числами 
{
    int[,] tempMatrix = new int[row, col];
    Random rand = new Random();
    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return tempMatrix;
}
void PrintMatrix(int[,] matrixForPrint) // Функция вывода двумерного массива
{
    for (int i = 0; i < matrixForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixForPrint.GetLength(1); j++)
        {
            System.Console.Write(matrixForPrint[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}


void NumbSmallSumElements(int[,] array)// Функция вывода номера строки  с наименьшей суммой элементов 
{
    int smallElements = 0; //создали переменную для хранения наименьших элементов строки
    int smallSumElements = 0; //создали переменную для хранения суммы наименьших элементов строки
    int sumElements = 0; //создали переменную для хранения суммы элементов строки
    
    for (int i = 0; i < array.GetLength(0); i++) // цикл проходит по строкам нашего массива
    {
        for (int j = 0; j < array.GetLength(1); j++) sumElements += array[i, j];//цикл который считает сумму строки массива i
        {
            smallElements = sumElements; // сумма элементов текущей строки
            smallSumElements = i; // номер строки с наименьшей суммой
        }
        sumElements = 0;// при выходе из цикла сброс на 0
    }
    System.Console.WriteLine(); // пробел между выводом результата операции
    Console.Write($"{smallSumElements + 1} строка"); // вывод результата операции
}

void Main()
{
int row = ReadInt("введите количество строк в массиве: ");
int col = ReadInt("введите количество столбцов в массиве: ");
int[,]matrix = FillMatrix(row, col, 0, 10);

System.Console.WriteLine();
System.Console.WriteLine();
PrintMatrix(matrix);
NumbSmallSumElements(matrix);
}
Main();
Console.ReadLine();



 


