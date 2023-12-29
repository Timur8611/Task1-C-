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

Console.WriteLine("Введите кординату X");

int X = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кординату Y");

int Y = Convert.ToInt32(Console.ReadLine());

while(X==0) 
{
Console.WriteLine("Вы ввели 0, введите заново Х");

X= Convert.ToInt32(Console.ReadLine());

}
while(Y==0) 
{
Console.WriteLine("Вы ввели 0, введите заново Y");

Y= Convert.ToInt32(Console.ReadLine());

}
if(X>0 && Y>0)
{
Console.WriteLine("Точка находиться в первой четверти плоскости");
}

if(X<0 && Y>0)
{
Console.WriteLine("Точка находиться в второй четверти плоскости");
}

if(X<0 && Y<0)
{
Console.WriteLine("Точка находиться в третей четверти плоскости");
}

if(X>0 && Y<0)
{
Console.WriteLine("Точка находиться в четвертой четверти плоскости");
}

