// double bigNum = 12.13;
// bool isEven = true;
// string word = "flower";
// char symbol = '$';

// int num1 = -12;
// int num2 = 6;

// Console.WriteLine("My numbers are " + (num1 + num2) + " and it is good!");
// Console.WriteLine($"My numbers are  {num1} and {num2}  and it is good!");

// Console.Write("Input an integer number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Your number is " + num);

// Seminar1

// Task 1.Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
/*
Console.Write("Input a first number: "); заправшиваем переменную
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int quad2 = num2 + num2;

if(num1 == quad2)
    Console.Write("Yes!");
else
    Console.Write("No!");
*/

// Task 2. Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N.
/*
Console.Write("Input a positive number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = -num;

while(current <= num)
{
    Console.Write(current + " ");
    current++;
}
*/

// HomeWork

// Task 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.WriteLine("Input a first number:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input an second number:");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine($"First number {num1} greater than the second {num2}");
}
else
{
    Console.WriteLine($"Second number {num2} greater than the first {num1}");
}
*/

// Task2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.WriteLine("Input a first number:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input an second number:");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the third  number:");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num2 > max)
    max = num2;
else
num1 = max;
if (num3 > max)
    max = num3;
else
    num3 = max;
Console.WriteLine("The largest of the three numbers: "+ max);
*/

// Task3. Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Input an integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 1)
{
    Console.WriteLine($"Number {num} is odd ");
} else
 {
     Console.WriteLine($"Number {num} is even");
 }
*/

// Task4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
int b = 1;
int current = b;

while(current <= num)
{
    if (current % 2 == 0)
    {
        Console.Write(current + " ");
    }
    current++;
}
*/