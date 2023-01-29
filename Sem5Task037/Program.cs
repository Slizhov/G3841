


void show1DArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + "\t");
    }
    Console.WriteLine(" ");
}
double[] convert1DArray(double[] nums)
{
    double[] arr1={};
    for (int i = 0; i < nums.Length/2; i++)
    {
        arr1=arr1.Append(nums[i] * nums[nums.Length - 1 - i]).ToArray();
    }
    if (Convert.ToDouble(nums.Length)/2!=Convert.ToDouble(nums.Length/2))
    {
         arr1=arr1.Append(Math.Pow(nums[nums.Length/2],2)).ToArray();
    }
    return arr1;
}
double[] multiInputs(string msg)
{
    Console.Write(msg);
    string n = Console.ReadLine() ?? "0";
    string[] arr = n.Split(" ");
    double[] vec = { };
    for (int i = 0; i < arr.Length; i++)
    {
        if ((arr[i] != ""))
            vec = vec.Append(double.Parse(arr[i])).ToArray();
    }
    return vec;
}
show1DArray(convert1DArray(multiInputs("введите значения для массива в строку: ")));
