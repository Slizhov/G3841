// Задача 27:
// Напишите программу, которая принимает на вход число
// и выдает сумму цифр числе.

int number = ReadInt("Введите число: ");
int len = NumberLen(number);
SumNumbers(number, len);
 
// Функция ввода
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
 
// Функция подсчета цифр в числе
int NumberLen(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
} 
// Функция вывода суммы цифр в числе
void SumNumbers(int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine(sum);
}
//Вариант 2:
// // Ввод данных
// int numberA = ReadData("Введите число: ");
// //Метод читает данные от пользователя
// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }
// //Выводим результат пользователю
// void PrintData(string msg1, string msg2)
// {
//     Console.WriteLine(msg1);
//     Console.WriteLine(msg2);
// }
// //Запускаем цикл сложения цифр в числе
// void Sumnumbers(int numberA)
// {
//     int result =0;
//     while (numberA>0)
//     {
//         result=result+numberA%10;
//         numberA=numberA/10;
//     }
//     Console.WriteLine(Sumnumbers);
// }
