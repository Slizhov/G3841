//Задача №6
//Напишите программу, которая на вход принимает
//одно число (N), а на выходе показывает четное
//это число или нечетное.

string? inputNumA = Console.ReadLine();
//Console.Write("input your num: ");
//string? inputNum = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if (inputNumA != null)
{
//Парсим введное число 
int numA = int.Parse(inputNumA);
//Проверяем на четность, делится ли число на 2 без остатка
    if (numA %2 ==0) 

    {
       Console.Write("Четное число");
    }
    else
    {
     Console.Write("Нечетное число");
    }
    
}
    
