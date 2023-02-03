// Задача №39
// Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на
// первом месте, а первый - на последнем и т.д.)

int[] testArr = Gen1DArray(12,1,999);
Print1DArr(testArr);
ChangeArr(testArr);
Print1DArr(testArr);

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string res)
{
    Console.WriteLine(res);
}

int[] Gen1DArray(int len, int minValue, int maxValue)
{
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}

void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

void ChangeArr(int[] arr)
{
    
    // int temp=0;
    //когда делим на 2, мы ограничиваем счетчик на половине массива
    for(int i=0;i<arr.Length/2;i++)
    {
        // (х,y) = (y,x)
        //взаимный обмен переменными, что слева меняется с тем что справа
        (arr[i],arr[arr.Length-1-i])=(arr[arr.Length-1-i],arr[i]);
        // temp=arr[i];
        // //меняем первый элемент на последний
        // arr[i]=arr[arr.Length-1-i];
        // //меняем последний элемент на первый
        // arr[arr.Length-1-i]=temp;
    }
}
    
