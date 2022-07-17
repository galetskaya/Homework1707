//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Enter the number");
int num = Convert.ToInt32(Console.ReadLine());

void findQuar(double arg)
{
    for(double y = 1; y <= arg; y++)
    {
        double a = Math.Pow((y), 3);
        Console.Write(a);
        Console.Write(", ");
    }
}


findQuar(num);