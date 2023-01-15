//Задача №8
//Напишите программу, которая на вход принимает
//(N) кол-ва чисел, а на выходе показывает все четные
//числа в промежутке от 1 до N.

Console.Write("input your num: ");
string? inputNum = Console.ReadLine();
// Проверяем, чтобы данные не были пустыми
if (inputNum != null)
{
    // Парсим введенное число
    int num = int.Parse(inputNum);
    string? Result = string.Empty;
    //Начинаем проверку с 2 с шагом 2.
    for (int i = 2; i < num; i=i+2)
    {
        Result = Result + i + ",";
    }   
    //Проверяем на четность, делится ли число на 2 без остатка
    if (num%2==0)
    
        Result=Result+num;
       Console.WriteLine (Result);
        
}
