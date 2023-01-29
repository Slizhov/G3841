// Задача №32:
// Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.

Random rnd = new Random();
int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
int[] create1DArray(int len, int num1, int num2)
{
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = rnd.Next(Math.Min(num1, num2), Math.Max(num1, num2));
    }
    return arr;
}
void show1DArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + "\t");
    }
    Console.WriteLine(" ");
}
int[] reverse1DArray(int[] array)
{
    int[] arr=array;
    for (int i = 0; i < array.Length; i++)
    {
        arr[i]*=-1;
    }
    return arr;
}
int len = InputNum("Введите длинну массива: ");
int num1 = InputNum("Введите минимум для значений в массиве: ");
int num2 = InputNum("Введите максимум для значений в массиве: ");
Console.WriteLine("Оригинал:");
int[]arr=create1DArray(len,num1,num2);
show1DArray(arr);
Console.WriteLine("реверс:");
int[]reverse_arr=reverse1DArray(arr);
show1DArray(arr);
