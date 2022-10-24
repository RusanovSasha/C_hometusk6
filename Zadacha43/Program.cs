//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void EnterLines(double[,] lineToCount)
{
    if (lineToCount[0, 0] == lineToCount[0, 1]) Console.WriteLine("Линии параллельны");
    else
    {
        double x = (lineToCount[1, 1] - lineToCount[1, 0]) / (lineToCount[0, 0] - lineToCount[0, 1]);
        double y = lineToCount[0, 0] * x + lineToCount[1, 0];
        Console.WriteLine($"Координаты пересечения ({x}; {y})");
    }
}

Console.Clear();
Console.WriteLine("Начинаем программу для нахождения точек пересечения двух прямых.");

double[,] lines = new double[2, 2];
Console.Write("Введите b1 ");
lines[1, 0] = double.Parse(Console.ReadLine());
Console.Write("Введите k1 ");
lines[0, 0] = double.Parse(Console.ReadLine());

Console.Write("Введите b2 ");
lines[1, 1] = double.Parse(Console.ReadLine());
Console.Write("Введите k2 ");
lines[0, 1] = double.Parse(Console.ReadLine());

EnterLines(lines);
