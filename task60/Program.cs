// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int[,,] FillMatrix(int r, int c, int s, int LeftRange = 10, int RightRange = 90)
{
    int[,,] matrix = new int[r, c, s];

    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)

                matrix[i, j, k] = rand.Next(LeftRange, RightRange + 1);
        }
    }

    return matrix;
}


void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
                
            { Console.Write(matrix[i, j, k] + " ");
            Console.Write("("+i+","+ j+","+ k+") "); }
        }
        Console.WriteLine(" ");
    }
  Console.WriteLine(" ");
}

Console.WriteLine("Введите размер массива (Row x Column x Sheet)");
Console.WriteLine("Введите количество строк Excel:");
int r = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов Excel:");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество страниц Excel:");
int s = Convert.ToInt32(Console.ReadLine());


int[,,] matrix = FillMatrix(r, c, s);
Console.WriteLine("Элемент массива (row, column, sheet): ");
PrintMatrix(matrix);