// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями: 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


double k1 = InputCheck("Введите координаты точки k1");
double b1 = InputCheck("Введите координаты точки b1");
double k2 = InputCheck("Введите координаты точки k2");
double b2 = InputCheck("Введите координаты точки b2");

double x = (b1 - b2) / (k2 - k1);
double y = (k2 * x + b2);
Console.WriteLine($"Точка пересечения двух прямых: ({x};{y})");



double InputCheck(string msg)
{
    Console.WriteLine(msg);

    bool isNum = double.TryParse(Console.ReadLine(), out double num);

    if (isNum)
    {
        return num;
    }
    else
    {
        Console.WriteLine("Вы ввели некорректные значения координат");
        return -1;
    }
}