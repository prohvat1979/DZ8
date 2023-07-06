 
//  Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки 
//  двумерного массива.
//  Например, задан массив:
//  1 4 7 2
//  5 9 2 3
//  8 4 2 4
//  В итоге получается вот такой массив:
//  7 4 2 1
//  9 5 3 2
//  8 4 4 2
 
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

void SortDecrease(int[,] matrix)// Функция сортировки элементов в строке  массива по убыванию
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)// алгоритм сортировки через переменную к, чтобы поменять местами элементы массива
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    int buffer = matrix[i, k + 1]; // буферная переменная для обмена значения в массиве
                    matrix[i, k + 1] = matrix[i, k];
                    matrix[i, k] = buffer;
                }
            }
        }
    }
    System.Console.WriteLine();// отступ перед новым массивом
    PrintMatrix(matrix); //печать нового массива
}
void Main()
{
int row = ReadInt("введите количество строк в массиве: ");
int col = ReadInt("введите количество столбцов в массиве: ");
int[,]matrix = FillMatrix(row, col, 0, 10);

System.Console.WriteLine();
System.Console.WriteLine();
PrintMatrix(matrix);
SortDecrease(matrix);
System.Console.WriteLine();
System.Console.WriteLine();
PrintMatrix(matrix);
}
Main();
Console.ReadLine();



 