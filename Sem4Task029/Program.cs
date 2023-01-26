// Задача*:"Кто пойдет за пивом"
class Program
{

static void Main(string[] args)
    {
    string[] mas = new string[] {"Игорь","Антон","Сергей","Миша","Андрей"};
    Random rand = new Random();
    //Задаем случайное число от 0 до 4. 
    int i = rand.Next (0,4); 
    Console.WriteLine(mas[i]);
    Console.ReadKey();
    Console.WriteLine ("Вам идти за пивом!!!");
    }
}