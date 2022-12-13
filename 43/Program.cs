// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// Точка пересечения прямых: k1*x+b1=k2*x+b2
Console.WriteLine("Для вычисления точки пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2,");
Console.WriteLine("необходимо будет ввести значения k1,k2,b1,b2.");
Console.WriteLine("Введите k1:");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b1:");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2:");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2:");
double b2 = Convert.ToDouble(Console.ReadLine());

double Peres(double k1, double k2, double b1, double b2)
{
    double x = 0;
    if (k1 == k2)
    {
        if (b1 == b2)
        {
            Console.WriteLine("Прямые совпадают и имеют бесконечное количество точек пересечения.");
        }
        else
        {
            Console.WriteLine("Прямые параллельны");
        }
    }
    else 
    {
        x = (b2-b1)/(k1-k2);
    }
    return x;
}
if (Peres(k1,k2,b1,b2) != 0)
{
    Console.WriteLine($" y = {k1} * x + {b1}, y = {k2} * x + {b2} имеют одну точку пересечения ({Peres(k1,k2,b1,b2)};{k1*Peres(k1,k2,b1,b2)+b1}).");
}