// Задача 13:
// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

//Console.Write("Введите любое число больше 2-х символов:");
Char[] digit = (Console.ReadLine()??"0").ToCharArray();
// Проверяем длину массива
if (digit.Length >=3)
{
    // Выводим значение третьей цифры слева
    Console.WriteLine (digit[2]);
}
else
{
     Console.WriteLine("Третьей цифры нет");
}

//Вариант 2.
// Console.Write("Введите любое число больше 2-х символов:"); 
// int n = int.Parse(Console.ReadLine());
// int k = (int)Math.Log10(n)-2;
// Console.WriteLine(k < 0 ? "Число меньше трех знаков" : (n % (int)Math.Pow(10, k + 1) / (int)Math.Pow(10, k)).ToString());



