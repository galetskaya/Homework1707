//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Enter 5 digit number");
int num = Convert.ToInt32(Console.ReadLine());

string PolindromeCheck (int arg)
{
    string newArg = Convert.ToString(arg);

    if (arg < 10000 || arg > 99999)
    {
        return "Your number is not 5 digit";
    }

    else if(newArg[0] == newArg[4] && newArg[1] == newArg[3])
    {
        return "Number is the palindrome";
    }

    else
    {
        return "Number is not the palindrome";
    }

}

Console.WriteLine(PolindromeCheck(num));