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
//Zadacha2();

/*Задача 3. На ввод подаётся рост трёх спортсменов. Расположить их от большего к меньшему.*/
void Zadacha3()
{
    Console.WriteLine("Введите рост первого спортсмена");
    int sport1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите рост второго спортсмена");
    int sport2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите рост третьего спортсмена");
    int sport3 = int.Parse(Console.ReadLine());
    if (sport1 > sport2)
    {
        if (sport2 > sport3)
        {
            Console.WriteLine(sport1 + " " + sport2 + " " + sport3);
        }
        else Console.WriteLine(sport1 + " " + sport3 + " " + sport2);
    }
    else if (sport3 > sport2)
        {
            Console.WriteLine(sport3 + " " + sport2 + " " + sport1);
        }
        else Console.WriteLine(sport2 + " " + sport3 + " " + sport1);
}
//Zadacha3();

/*Задача 4. Дано N секунд. Вывести время в формате часы:минуты:секунды.
N = 72334 -> 20:5:34 */
void Zadacha4()
{
    int N = int.Parse(Console.ReadLine());
    int hour = N / 3600;
    int min = (N % 3600) / 60;
    int second = N % 60;
    Console.WriteLine(N + " секунд = " + hour + ":" + min + ":" + second);
}
Zadacha4();
