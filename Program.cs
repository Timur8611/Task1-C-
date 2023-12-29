// Задача 1: Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.

// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         Console.WriteLine("Введите число");
//         int value = Convert.ToInt32(Console.ReadLine());

//         if(value%7==0 && value%23==0)
//         {
//             Console.WriteLine("Число кратное");
//         }
//         else 
//         {
//             Console.WriteLine("Число не кратное");
//         }

//     }

// }




// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, 
// в которой находится эта точка.

// Console.WriteLine("Введите кординату X");

// int X = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите кординату Y");

// int Y = Convert.ToInt32(Console.ReadLine());

// while(X==0) 
// {
// Console.WriteLine("Вы ввели 0, введите заново Х");

// X= Convert.ToInt32(Console.ReadLine());

// }
// while(Y==0) 
// {
// Console.WriteLine("Вы ввели 0, введите заново Y");

// Y= Convert.ToInt32(Console.ReadLine());

// }
// if(X>0 && Y>0)
// {
// Console.WriteLine("Точка находиться в первой четверти плоскости");
// }

// if(X<0 && Y>0)
// {
// Console.WriteLine("Точка находиться в второй четверти плоскости");
// }

// if(X<0 && Y<0)
// {
// Console.WriteLine("Точка находиться в третей четверти плоскости");
// }

// if(X>0 && Y<0)
// {
// Console.WriteLine("Точка находиться в четвертой четверти плоскости");
// }



// Задача 3: Напишите программу, 
// которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

// int num = new Random().Next(10,100);
// Console.WriteLine (num);
// int firstNum = num/10;
// int secondNum = num%10;

// if(firstNum>secondNum) 
// {
// Console.WriteLine(firstNum);
// }
// else 
// {
// Console.WriteLine(secondNum);
// }


// Задача 4: Напишите программу, которая на вход принимает натуральное число N, 
// а на выходе показывает его цифры через запятую.

Console.WriteLine("Введите натуральное число");
int n = Convert.ToInt32(Console.ReadLine());
int nCopy = n;
int count = 0;
while (nCopy > 0)
{
    nCopy = nCopy / 10;
    count = count + 1;

}

int i = 1;
while (i <= count)
{
    Console.Write($"{n % 10},");
    n = n / 10;
    i = i + 1;
}
