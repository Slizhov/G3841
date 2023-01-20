// Задача 15: 
// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

int dayofWeek = int.Parse(Console.ReadLine()??"0");
//вводим условие, когда введенная цифра не соответствует дню недели
if ((dayofWeek>7) && (dayofWeek<1))
{
Console.WriteLine("Введенное число не день недели");
}
else

    if (dayofWeek >5)
    {
    Console.WriteLine("ВЫХОДНОЙ!");
}
else
{
    Console.WriteLine("РАБОЧИЙ ДЕНЬ!");
}