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
//Zadacha1();

/*Задача 2. Даны два числа a, b, такие что a < b. 
Вывести на экран сколько раз число a поместиться в числе b.*/
void Zadacha2()
{
    int number1 = 27;
    int number2 = 5;
    if ((number1/number2) % 10 > 1 && (number1/number2) % 10 < 5)
    {
        Console.WriteLine("Число " + number2 + " помешается в число " + number1 + " " + number1/number2 + " раза");
    }
    else Console.WriteLine("Число " + number2 + " помешается в число " + number1 + " " + number1/number2 + " раз");
}
Zadacha2();