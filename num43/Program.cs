// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double k1 = TakeNumbersFromCons("Введите первую координату первой линии: ");
double b1 = TakeNumbersFromCons("Введите вторую координату первой линии: ");
double k2 = TakeNumbersFromCons("Введите первую координату второй линии: ");
double b2 = TakeNumbersFromCons("Введите вторую координату второй линии: ");

(double x, double y) point;
bool success = TryFindIntersectionOfStraightLines(k1, b1, k2, b2, out point); 
if (success)
{
    Console.WriteLine($"Точка пересечения прямых с координатами ({k1}; {b1}) и ({k2}; {b2}) -> ({point.x}; {point.y})");
}
else{
Console.WriteLine("Прямые параллельны!");
}

double TakeNumbersFromCons(string message)
{
    Console.Write(message);
    double result = Convert.ToDouble(Console.ReadLine());
    return result;
}

bool TryFindIntersectionOfStraightLines(double a1, double b1, double a2, double b2, out (double , double) point)
{
    point = (0, 0);
    if (a1 - a2 != 0)
    {
        double x = (b2 - b1) / (a1 - a2);
        double y = a1 * ((b2 - b1) / (a1 - a2)) + b1;
        point = (x, y);
        return true;
    }
    return false;
}