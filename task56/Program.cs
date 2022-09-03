// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] FillMatrix(int rowsCount, int columnsCount, int leftRange = 0, int rightRange = 10)
{
    int[,] matrix = new int[rowsCount, columnsCount];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
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
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите число строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrix(m, n);
int[] sumRow = new int[m];          // сумма строки в двумерном массиве
PrintMatrix(matrix);
int i, j;

for (i = 0; i < matrix.GetLength(0); i++)
 {int sum = 0;                         // подсчет суммы
    for (j = 0; j < matrix.GetLength(1); j++)
    
        sum = sum + matrix[i, j];
        sumRow[i] = sum;

    }
   
    int rowMin = sumRow[0];            // строка с наименьшей суммой
    int numberRow = 0;                      // номер строки с минимальной суммой
    for (i = 0; i < sumRow.Length; i++)
    {
        if (rowMin > sumRow[i])
        {
            rowMin = sumRow[i];
            numberRow = i;
        }
       
    }


int numberRowPrint = numberRow +1;
Console.WriteLine();
Console.WriteLine("Строка № " + numberRowPrint + " с наименьшей суммой элементов " + rowMin);