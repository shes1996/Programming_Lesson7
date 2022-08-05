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
    Console.WriteLine("Введите рост первого спортсмена в см");
    int sport1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите рост второго спортсмена в см");
    int sport2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите рост третьего спортсмена в см");
    int sport3 = int.Parse(Console.ReadLine());
    if (sport1 > 0 && sport2 > 0 && sport3 > 0)
    {
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
    else Console.WriteLine("Одно или несколько чисел введены некорректно");
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
    if (N < 0) Console.WriteLine("Время не может быть отрицательным");
    else Console.WriteLine(N + " секунд = " + hour + ":" + min + ":" + second);
}
//Zadacha4();

/* Задача 1. Написать программу, которая определяет, является ли треугольник со сторонами a, b, c равнобедренным.*/
void Zadacha1_2()
{
    Console.WriteLine("Введите сторону a");
    int sidea = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите сторону b");
    int sideb = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите сторону c");
    int sidec = int.Parse(Console.ReadLine());
    if (sidea > 0 && sideb > 0 && sidec > 0)
    {
        if ((sidea == sideb) ^ (sidea == sidec) ^ (sideb == sidec)) Console.WriteLine("Тругольник является равнобедренным");
        else Console.WriteLine("Тругольник не является равнобедренным");
    }
    else Console.WriteLine("Одно или несколько чисел введены некорректно");
}    
//Zadacha1_2();

/*Задача 2. На вход подаются год, номер месяца и день рождения человека, Определить возраст человека на момент 1 июля 2022 года.*/
void Zadacha2_2()
{
    int year = int.Parse(Console.ReadLine());
    int month = int.Parse(Console.ReadLine());
    int day = int.Parse(Console.ReadLine());
    int[] date = new int[] {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
    int temp = 1;
    int month_temp = 0;
    for (int i = 0; i < 6; i++)
    {
        temp += date[i];
    }
    Console.WriteLine(temp);
    for (int i = 0; i < month-1; i++)
    {
        month_temp += date[i];
    }
    month_temp += day;
    Console.WriteLine(month_temp);
    int age = 2022 - year;
    if (month_temp > temp) age -= 1;
    Console.WriteLine("Возраст человека на 1 июля 2022 года: " + age);
}
//Zadacha2_2();

/*Задача 3. Иван в начале года открыл счет в банке, вложив 1000 руб. 
Через каждый месяц размер вклада увеличивается на 1.5% от имеющейся суммы. Определить размер депозита через n месяцев.*/
void Zadacha3_2()
    {
        int n = int.Parse(Console.ReadLine());
        double money = 1000;
        for (int i = 1; i <= n; i++)
        {
            money = money + money * 0.015;
        }
        
        if (n > 1 && n < 5) 
        {
            Console.WriteLine("Размер депозита через " + n + " месяца" + " = " + money);
        }
        else Console.WriteLine("Размер депозита через " + n + " месяцев" + " = " + money);

    }
//Zadacha3_2();

/*Задача 4. Дано натуральное число, в котором все цифры различны. 
Определить, какая цифра расположена в нем левее: максимальная или минимальная.*/
void Zadacha4_2()
{
    string num = (Console.ReadLine());
    int number = int.Parse(num);
    int length = num.Length;
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = number % 10;
        number = number / 10;
        Console.WriteLine(array[i]);
    }
    int max = 0;
    int posmax = 0;
    for (int i = 0; i < length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
            posmax = i;
        }
    }
    int min = max;
    int posmin = 0;
    for (int i = 0; i < length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            posmin = i;
        }
    }
    
    Console.WriteLine(max+ " "+ posmax);
    Console.WriteLine(min+ " "+ posmin);
    if (posmin > posmax) Console.WriteLine("Минимальное число "+min+" находится левее от максимального числа " +max);
    else Console.WriteLine("Максимальное число "+max+" находится левее от минимального числа " +min);
}
//Zadacha4_2();

/*Задача 1. На вход подаётся натуральное десятичное число. 
Проверьте, является ли оно палиндромом в двоичной записи.*/

/*Задача 1. Рассчитать значение y при заданном x по формуле
y = Sin^2(x)  при x>0
y = 1-2sin(x^2) в других случаях*/
void Zadacha1_3()
{
    double x = double.Parse(Console.ReadLine());
    double y;
    if (x > 0) y = Math.Pow(Math.Sin(x), 2);
    else y = 1 - 2 * Math.Sin(Math.Pow(x, 2));
    Console.WriteLine(y);
}
//Zadacha1_3();

//Задача 2. Дано трёхзначное число N. Определить кратна ли трём сумма всех его цифр.
void Zadacha2_3()
{
    int number = int.Parse(Console.ReadLine());
    int sum = 0;
    if (number < 1000)
    {
    for (int i = 1; i != 4; i++)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    Console.WriteLine(sum);
    if (sum % 3 == 0) Console.WriteLine("Сумма цифр числа и само число кратно трем");
    else Console.WriteLine("Сумма цифр числа и само число не кратно трем");
    }
    else Console.WriteLine("Введено некорректное число");
}
//Zadacha2_3();

/*Задача 3. Дано трёхзначное число N. Определить, есть ли среди его цифр 4 или 7.*/
void Zadacha3_3()
{
    string number = Console.ReadLine();
    int i = 0;
    int count = 0;
    if ((number.Length) == 3 && (number[0] != '-') && (number[0] != '0'))
    {
        while (i < number.Length)
        {
            if ((number[i] == '4') ^ (number[i] == '7')) count += 1;
            i++;
        }
    if (count > 0) Console.WriteLine("Среди цифр введенного числа есть 4 или 7");
    else Console.WriteLine("Среди цифр введенного числа нет 4 или 7");
    }
    else Console.WriteLine("Неверное число");

}
Zadacha3_3();