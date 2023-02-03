// Задача 42:
// Напишите программу, которая будет
// преобразовывать десятичное число в двоичное

// string editLine(string text)
// {
//     string txt = text;
//     if (txt[txt.Length - 1] != ' ')
//     {
//         txt += " ";
//     }
//     return txt;
// }
// int InputNum(string msg)
// {
//     Console.Write(editLine(msg));
//     return int.Parse(Console.ReadLine() ?? "0");
// }
// int value = InputNum("Введите натуральное число:");
// string bin = Convert.ToString(value, 2);
// Console.WriteLine(bin);


//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод преобразовывает десятичные числа в двоичные
string Convert10to2 (int num)
{
    string result = string.Empty;
    while(num>=1)
    {
        result = Convert.ToString(num%2) + result;
        num=num/2;
    }
    return result;
}

string result = Convert10to2(ReadData("Введите число: "));
Console.WriteLine(result);