//Задача № 0
//Напишите программу, которая на входе принимает
//число и выдает его квадрат (число умноженное на 
//само себя)
string? inputNum = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if(inputNum!=null)
{
    //Парсим введное число
    //int number = int.Parse(inputNum);
    //Находим квадрат числа
    //int result = number*number;
    //int result = (int)Math.Pow(number,2); 

    //Выводим данные в консоль
    //Console.WriteLine(result);


    Console.WriteLine(Math.Pow(int.Parse(inputNum),2));

}