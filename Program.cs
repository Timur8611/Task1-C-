// Задача 1: Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите число");
        int value = Convert.ToInt32(Console.ReadLine());

        if(value%7==0 && value%23==0)
        {
            Console.WriteLine("Число кратное");
        }
        else 
        {
            Console.WriteLine("Число не кратное");
        }
        
    }

}