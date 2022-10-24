//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3

int[] EnterNumber(int[] count)
{   
    if (count[0] == 0) Console.WriteLine("Начинаем нашу программу для счета нулей. Введите любое количество чисел подряд.");
    else Console.WriteLine($"Вы ввели {count[0]} чисел, из них было введено {count[1]} нулей");
    Console.Write("Введите число (для выхода введите q) ");
    string enterString = Console.ReadLine();
    if (enterString == "q" || enterString == "Q") return count;
    int enterNum;
    if (int.TryParse(enterString, out enterNum))
    {
        count[0]++;
        if (enterNum == 0) count[1]++;
    }
    else Console.WriteLine("Боюсь это было не число. Оно не засчитывается в общей массе");
    Console.WriteLine();
    EnterNumber(count);
    return count;
}

Console.Clear();
int[] countNull = { 0, 0 };
countNull = EnterNumber(countNull);
Console.Clear();
Console.WriteLine($"Программа завершена пользователем");
Console.WriteLine($"Всего было введено {countNull[0]} чисел, из них программа насчитала {countNull[1]} нулей");
