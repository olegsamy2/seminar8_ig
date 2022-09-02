// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.			
// Например, на выходе получается вот такой массив:			
// 01 02 03 04			
// 12 13 14 05			
// 11 16 15 06			
// 10 09 08 07			

int n = 4;                                   // массив 4Х4			
int[,] spiralArray = new int[n, n];


int num = 1; // номер в ячейках по спирали  			

for (int y = 0; y < n; y++)
{
    spiralArray[0, y] = num;
    num = num + 1;                          // num++ 			
}                               //по горизонтали  			
for (int x = 1; x < n; x++)
{
    spiralArray[x, n - 1] = num;
    num = num + 1;
}                               //по вертикали  			
for (int y = n - 2; y >= 0; y--)
{
    spiralArray[n - 1, y] = num;
    num = num + 1;
}                                //по горизонтали  (обратно)   			
for (int x = n - 2; x > 0; x--)
{
    spiralArray[x, 0] = num;
    num = num + 1;
}                                //по вертикали (обратно)  			

int a = 1;  // координаты следующей ячейки заполнения 			
int b = 1;

while (num < n * n)   // 16 - размер массива 			
{
    while (spiralArray[a, b + 1] == 0)
    {
        spiralArray[a, b] = num;
        num = num + 1;
        b = b + 1;           // вправо - по горизонтали  			
    }
    while (spiralArray[a + 1, b] == 0)
    {
        spiralArray[a, b] = num;
        num = num + 1;
        a = a + 1;           // вниз - по вертикали  			
    }
    while (spiralArray[a, b - 1] == 0)
    {
        spiralArray[a, b] = num;
        num = num + 1;
        b = b - 1;           // влево - по горизонтали  			
    }

    for (int x = 0; x < n; x++)   // что б поставить последнюю цифру
    {
        for (int y = 0; y < n; y++)
        {
            if (spiralArray[x, y] == 0)
            {
                spiralArray[x, y] = num;
            }
        }
    }
}

PrintArray(spiralArray);
void PrintArray(int[,] spiralArray)
{
    for (int i = 0; i < spiralArray.GetLength(0); i++)
    {
        for (int j = 0; j < spiralArray.GetLength(1); j++)
        {
            Console.Write(spiralArray[i, j] + " \t");   //  \t - выравнивания столбцов
        }
        Console.WriteLine();
    }
}
