// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.WriteLine("Input a five-digit number");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);
int secondnumber = number / 1000 % 10;
int fourthnumber = number / 10 % 10;
if (number >= 10000 && number < 100000)
{
   if ((number / 10000 == number % 10) && (secondnumber == fourthnumber))
     {
     Console.WriteLine("This is palindrome");
    }   
        else
        {
           Console.WriteLine("This is not palindrome"); 
        } 
}
else
    {
        Console.WriteLine("This is not a five-digit number");
    }