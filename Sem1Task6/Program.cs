// Задача №4
// Напишите программу, которая находит большое
// значение из трех введенных чисел

//Считываем данные с консоли 1 число
string? inputNum1 = Console.ReadLine();
//Считываем данные с консоли 2 число
string? inputNum2 = Console.ReadLine();
//Считываем данные с консоли 3 число
string? inputNum3 = Console.ReadLine();

if ((inputNum1 != null) && (inputNum2 != null) && (inputNum3 != null))
{
//Парсим введенное первое число
int numberA = int.Parse(inputNum1);
//Парсим введенное второе число
int numberB = int.Parse(inputNum2);
//Парсим введенное третье число
int numberC = int.Parse(inputNum3);

//Узнаем какое из двух чисел больше
    if (numberA > numberB) 
    {
              if (numberA > numberC)
              
                 Console.Write($"Первое число самое большое : {numberA}");
              
              else
              
                 Console.Write($"Третье число самое большое : {numberC}");
              }  
    else if  (numberB > numberC)
    {
       Console.Write($"Второе число самое большое : {numberB}"); 
    }  
    else
    {
        Console.Write($"Третье число самое большое : {numberC}");
    }
        Console.WriteLine();

    }



