// Задача 50
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// * Заполнить числами Фиббоначи и выделить цветом найденную цифру

ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

///1) Получение данных от пользователя
int m = InputNum("Количество строк массива: ");
int n = InputNum("Количество столбцов массива: ");
int elem = InputNum("Введите искомое число: ");

//2) Генерация двумерного массива
int[,] matrix = FillTwoDimArray(m, n);

//3) Печатаем двумерный массив
PrintTwoDimArray(matrix);
SearchElem(matrix, elem);
int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// метод для заполнения двумерного массива
int[,] FillTwoDimArray(int countRow, int countColumn)
{
    System.Random numberSyntezator = new System.Random();
    int i = 0; int j = 0;
    int[,] outArray = new int[countRow, countColumn];
    while (i < countRow)
    {
        j = 0;
        while (j < countColumn)
        {
            outArray[i, j] = numberSyntezator.Next(0, 50);
            j++;
        }
        i++;
    }
    return outArray;
}
//метод для печати двумерного массива
void PrintTwoDimArray(int[,] inputArray)
{
    int i = 0; int j = 0;

    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            Console.ForegroundColor = (ConsoleColor)(new System.Random().Next(0,16));
            //col[new System.Random().Next(0,16)]; 
            Console.Write(inputArray[i, j] + " ");
            Console.ResetColor(); 
            j++;
        }
        //Console.Write("\n");
        Console.WriteLine();
        i++;
    }
// //метод для печати двумерного массива
// void PrintTwoDimArray(int[,] inputArray)
// {
//     int i = 0; int j = 0;
//     while (i < inputArray.GetLength(0))
//     {
//         j = 0;
//         while (j < inputArray.GetLength(1))
//         {
//             // Console.ForegroundColor = (ConsoleColor)(new System.Random().Next(0, 16));
//             //col[new System.Random().Next(0,16)];
//             Console.Write(inputArray[i, j] + " ");
//             Console.ResetColor();
//             j++;
//         }
//         //Console.Write("\n");
//         Console.WriteLine();
//         i++;
//     }
}
void SearchElem(int[,] arr, int elem)
{
    bool ElemFind = false;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (elem == arr[i, j])
            {
                Console.WriteLine(elem + " найден в позиции " + i + j);
                ElemFind = true;
            }
        }
    }
    if (ElemFind == false)
    {
        Console.WriteLine("Элемент не найден");
    }
}