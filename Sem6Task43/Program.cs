// Задача 43: 
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


int k1 = InputNum("Введите значение точки k1: ");
int b1 = InputNum("Введите значение точки b1: ");
int k2 = InputNum("Введите значение точки k2: ");
int b2 = InputNum("Введите значение точки b2: ");

calc(Convert.ToDouble(k1),Convert.ToDouble(b1),Convert.ToDouble(k2),Convert.ToDouble(b2));

// Добавляет пробел, если последний символ не пробел
string editLine(string text)
{
    string txt = text;
    if (txt[txt.Length - 1] != ' ')
    {
        txt += " ";
    }
    return txt;
}
// Ввод целочисленного значения
int InputNum(string msg)
{
    Console.Write(editLine(msg));
    return int.Parse(Console.ReadLine() ?? "0");
}
// Выводит точку пересечения двух линий заданных по функции: k * x + b
void calc(double k1, double b1, double k2, double b2)
{
    if ((k1 == k2) && (b1 == b2))
    {
        Console.WriteLine("При данном условии прямые совпадают");
    }
    else
    {
        if (k1 == k2)
        {
            Console.WriteLine("При данном условии прямые параллельны");
        }
        else
        {
            double x = (b2 - b1) / (k1 - k2);
            double y = (k1 * (b2 - b1)) / (k1 - k2) + b1;
            Console.WriteLine("точка пересечения в ("+x.ToString()+"; "+y.ToString()+")");
        }
    }
}




