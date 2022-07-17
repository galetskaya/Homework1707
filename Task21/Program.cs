//Напишите программу, которая принимает 
//на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Enter coordinates for point A");

int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter coordinates for point B");

int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());

double findDis (int arg1, int arg2)
{
    double dis = Math.Pow((arg2-arg1), 2);
    return dis;   
}

double mthSquare(double arg1, double arg2, double arg3)
{
    double result = Math.Sqrt(arg1 + arg2 + arg3);
    double result2 = Math.Round(result, 2);
    return result2;
}

double dis1 = findDis(x1, x2);
double dis2 = findDis(y1, y2);
double dis3 = findDis(z1, z2);

double newResult = mthSquare(dis1, dis2, dis3);
Console.WriteLine(newResult);

