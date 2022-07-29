/*Задача 1. Пользователь вводит число N (N > 0). Программа должна вывести N единиц на экран.
N = 4 -> 1, 1, 1, 1
N = 2 -> 1, 1 */

void Zadacha1()
{
    int number = int.Parse(Console.ReadLine());
    while (number>0)
    {
        Console.Write("1 ");
        number--;
    }
}
Zadacha1();