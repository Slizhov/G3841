// Задача 25:
// Напишите цикл, который принимает на вход два числа (А и В)
// и возводит число А в натуральную степень В.


// Ввод данных
int numberA = ReadData("Введите число: ");
int numberB = ReadData("Введите необходимую степень данного числа: ");
//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//Выводим результат пользователю
void PrintData(string msg1, string msg2)
{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);
}
//Запускаем цикл возведения в степень числа
Console.WriteLine (Math.Pow(numberA,numberB));
{
    int result =1;
    while (numberB>0)
    {
        numberB=numberB-1;
        result=result*numberA;
    }
    return result;
}

