//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
//элементы каждой строки двумерного массива.
/*
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

int[,] CreateRandomArray()
{
    Console.WriteLine("Введите количество строк массива");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов массива");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите минимальное значение элементов массива");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите максимальное значение элементов массива");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
        
    }
    return array;
}

void PrintArray(int[,] arr)
{    
    for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++) 
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
}
void SortingDiminutionArray(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0, counter = 0; j < array.GetLength(1); j++, counter = 0)
        {
            counter = j;
            while(counter != array.GetLength(1))
            {
                if (array[i, j] < array[i, counter])
                {
                    temp = array[i, counter];
                    array[i, counter] = array[i, j];
                    array[i, j] = temp;
                }
                counter++;
            }
        }
    }
}
int[,] myArray = CreateRandomArray();
PrintArray(myArray);
SortingDiminutionArray(myArray);
PrintArray(myArray);
*/

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
//находить строку с наименьшей суммой элементов.
/*
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки 
//с наименьшей суммой элементов: 1 строка

int[,] CreateRandomArray()
{
    Console.WriteLine("Введите количество строк массива");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов массива");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите минимальное значение элементов массива");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите максимальное значение элементов массива");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
        
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int SearchLineWithMinSum(int[,] array)
{
    int Sum = 0;
    int PreSum = 0;
    int indexLineMinsum = 0;
    for (int i = 0; i < array.GetLength(0); i++, Sum = 0)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Sum = Sum + array[i,j];
        }
        Console.WriteLine("Строка - " + (i+1) + " Сумма = " + Sum);
        if (Sum < PreSum)
        {
            PreSum = Sum;
            indexLineMinsum = i;
        }
    }
    return indexLineMinsum;
}
int[,] myArray = CreateRandomArray();
PrintArray(myArray);
int minLine = SearchLineWithMinSum(myArray) + 1;
Console.WriteLine("Строка с минимальной суммой - " + minLine);
*/

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

int[,] CreateRandomArray()
{
    Console.Write("Введите количество строк матрицы: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов матрицы: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальное значение элементов матрицы: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение элементов матрицы: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
        
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] MultiplicationMatrix(int[,] mat1, int[,] mat2)
{
    int[,] result = new int[mat1.GetLength(0), mat2.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < mat1.GetLength(1); k++)
            {
                result[i,j] = result[i,j] + mat1[i, k] * mat2[k, j];
            }
        }
    }
    return result;
}
Console.WriteLine("Параметры для первой матрицы: ");
int[,] array1 = CreateRandomArray();
Console.WriteLine("Параметры для второй матрицы:");
int[,] array2 = CreateRandomArray();
PrintArray(array1);
PrintArray(array2);
int[,] result = {};
if (array1.GetLength(1) == array2.GetLength(0))
    {
        result = MultiplicationMatrix(array1, array2);
    }
    else Console.WriteLine("Такие матрицы нельзя переменожить!");
PrintArray(result);
*/

//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

int[,,] CreateRandomArray()
{
    int rows = 0;
    int columns = 0;
    int deep = 0;
    while(true)
    {
        Console.WriteLine("Введите количество строк массива");
        rows = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов массива");
        columns = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество глубину массива");
        deep = Convert.ToInt32(Console.ReadLine());
        if (rows * columns * deep > 90)
            Console.WriteLine("Такой размер массива недопустим. Введите другие значения");
        else break;
    }
    int[,,] array = new int[rows, columns, deep];
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(2); k++)
                {
                    while(true)
                    {
                        temp = new Random().Next(10, 100);
                        if (CheckNumber(array, temp))
                        {
                            array[i,j,k] = temp;
                            break;
                        }
                        
                    }
                }
                
            }
        }
    return array;
}
bool CheckNumber(int[,,] array, int num)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(2); k++)
                {
                    if (array[i,j,k] == num)
                    return false;
                }
                
            }
        }
    return true;
}
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
            }
            Console.Write("    ");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,,] myArray = CreateRandomArray();
PrintArray(myArray);
*/

//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07
void FillingInCircle(int[,] array)
{
    int number = 1;
    int counter = 0;
    while(number <= array.GetLength(0) * array.GetLength(1))
    {
        //Движение вправо
        for(int j = counter; j < array.GetLength(1) - counter; j++,number++)
        {
            array[counter, j] = number;
        }
        //Движение вниз
        for(int i = counter + 1 ; i < array.GetLength(0) - counter; i++,number++)
        {
            array[i, (array.GetLength(1)-1) - counter] = number;
        }
        //Движение влево
        for(int j = (array.GetLength(1)-2) - counter; j > 0 + counter; j--,number++)
        {
            array[(array.GetLength(0)-1) - counter, j] = number;
        }
        //Дивжение вверх
        for(int i = (array.GetLength(0)-1) - counter; i > 0 + counter; i--, number++)
        {
            array[i, counter] = number;
        }
        counter++;
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] < 10)
            Console.Write("0"+array[i,j] + " ");
            else
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
Console.WriteLine("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, columns];
FillingInCircle(array);
PrintArray(array);