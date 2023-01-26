// Задача 25*
// Написать калькулятор с операциями +, -, /, * и возведение в степень.

class Program
{
    static void Main (string[] args)
    {
    //Вводим две переменные значений и переменную действия
    double firstValue, secondValue;
    string action; 
    
    //вводим первое цифровое значение
    Console.WriteLine ("Введите число 1");
    firstValue = double.Parse(Console.ReadLine());
    //вводим второе цифровое значение
    Console.WriteLine ("Введите число 2");
    secondValue = double.Parse(Console.ReadLine());
    //выбираем необходимое действие
    Console.WriteLine ("Выберите совершаемое действие: '+' '-' '*' '/' '^'");
    action = Console.ReadLine();
    //описываем действия с введенными значениями
    if (action =="+")
    {
        Console.WriteLine (firstValue + secondValue);
    }
    else if (action =="-")
    {
        Console.WriteLine (firstValue - secondValue);
    }
    else if (action =="^")
    {
        Console.WriteLine (Math.Pow(firstValue,secondValue));
    }
    else if (action =="*")
    {
        Console.WriteLine (firstValue * secondValue);
    }       
    else if (action =="/")
       {
        //возьмем, что при делении на 0 будет всегда 0
            if (secondValue ==0)
                Console.WriteLine (0);
            else
               Console.WriteLine (firstValue / secondValue);
        }       
    else 
    {
        Console.WriteLine ("Ошибка: Выбрано неверное действие!");
    }       
                 
    }
}


