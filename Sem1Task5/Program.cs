// Задача №2
// Напишите программу, которая находит большое
// значение из двух введенных чисел

//Считываем данные с консоли 1 число
string? inputNum1 = Console.ReadLine();
//Считываем данные с консоли 2 число
string? inputNum2 = Console.ReadLine();

if ((inputNum1 != null) && (inputNum2 != null))
{
//Парсим введенное первое число
int numberA = int.Parse(inputNum1);
//Парсим введенное второе число
int numberB = int.Parse(inputNum2);

//Узнаем какое из двух чисел больше
    if (numberA > numberB)

    Console.Write("Первое число больше второго");

    else

    Console.Write("Второе больше первого");
}
