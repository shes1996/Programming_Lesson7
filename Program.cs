// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
void Zadacha47()
{
    Console.WriteLine("Введите размерность массива m");
    int m = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите размерность массива n");
    int n = int.Parse(Console.ReadLine());
    Random rnd = new Random();
    double[ , ] array = new double[m,n];
    for (int i = 0; i < m; ++i)
        {
            for (int j = 0; j < n; ++j)
            {
                array[i, j] = Math.Round(rnd.NextDouble() * rnd.Next(-10, 10), 2, MidpointRounding.ToEven);
            }
        }
        for (int i = 0; i < m; ++i)
        {
            for (int j = 0; j < n; ++j)
            {
                Console.Write(array[i, j] + "   ");
                
            }
            Console.WriteLine();
        }
}
//Zadacha47();

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void Zadacha50()
{
    int[ , ] array = {
        {1, 4, 7, 2},
        {5, 9, 2, 3},
        {8, 4, 2, 4}
    };
    Console.WriteLine("Введите номер строки элемента");
    int m = int.Parse(Console.ReadLine()) - 1;
    Console.WriteLine("Введите номер столбца элемента");
    int n = int.Parse(Console.ReadLine()) - 1;
    int dimension = 1;
    int column = 1;
    Console.WriteLine("Количество элементов в массиве:      {0,3}", array.Length);
    Console.WriteLine("Размерность массива: {0,3}", array.Rank);
        // For multidimensional arrays, show number of elements in each dimension.
        if (array.Rank > 1) {
            for (dimension = 1; dimension <= array.Rank; dimension++)
                {
                    Console.WriteLine("   Dimension {0}: {1,3}", dimension, array.GetUpperBound(dimension - 1) + 1);
                    column = array.GetUpperBound(dimension - 1) + 1;
                }
        
        }
        if ((m < dimension) && (n <= column))
        {
            Console.WriteLine(array[m,n]);
        }
        else Console.WriteLine("Элемента с такими индексами нет в массиве");
        Console.WriteLine();
}
//Zadacha50();

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void Zadacha52()
{
    int[ , ] array = {
        {1, 4, 7, 2},
        {5, 9, 2, 3},
        {8, 4, 2, 4}
    };

    int dimension = 1;
    int column = 1;
    Console.WriteLine("Количество элементов в массиве:      {0,3}", array.Length);
    Console.WriteLine("Размерность массива: {0,3}", array.Rank);
        // For multidimensional arrays, show number of elements in each dimension.
        if (array.Rank > 1) {
            for (dimension = 1; dimension <= array.Rank; dimension++)
                {
                    Console.WriteLine("   Dimension {0}: {1,3}", dimension, array.GetUpperBound(dimension - 1) + 1);
                    column = array.GetUpperBound(dimension - 1) + 1;
                }
        
        }
        for (int i = 0; i < dimension; ++i)
        {
            double average = 0;
            for (int j = 0; j < column; ++j)
            {
                average += array[i,j];
                
            }
            Console.WriteLine("   Среднее арифметическое столбца {0}: {1}", i + 1, average/column);
        }

}
//Zadacha52();