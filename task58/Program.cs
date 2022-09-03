// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] FillMatrix(int rowsCount, int columnsCount)
{
    int[,] matrix = new int[rowsCount, columnsCount];

    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(0, 9);
        }
    }

    return matrix;
}
void PrintMatrix(int[,] matrix)               // метод печати матриц
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
Console.Write("Введите число строк матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());                          //число строк
Console.Write("Введите число столбцов матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());                          //число столбцов

int[,] firstMatrix = FillMatrix(m, n);
int[,] secondMatrix = FillMatrix(m, n);

Console.WriteLine("Первая матрица: ");
PrintMatrix(firstMatrix);   // вызов метода печати матрицы A
Console.WriteLine("Вторая матрица: ");
PrintMatrix(secondMatrix);    // вызов метода печати матрицы B

Console.WriteLine();
int[,] matrixMultiplication(int[,] matrixA, int[,] matrixB)   // метод ппроизведения матриц
{
    int[,] matrixC = new int[m, n];
    for (int i = 0; i < matrixC.GetLength(0); i++)
    {
        for (int j = 0; j < matrixC.GetLength(1); j++)
        {
            for (int k = 0; k < matrixC.GetLength(1); k++)
            {
                matrixC[i, j] = matrixC[i, j] + matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return matrixC;
}
int[,] thirdMatrix = matrixMultiplication(firstMatrix, secondMatrix);
                                                                       // вызов метода произведения матриц

Console.WriteLine("Результирующая матрица (произведение первой и второй матрицы): ");
PrintMatrix(thirdMatrix);        // вызов метода печати матрицы C
