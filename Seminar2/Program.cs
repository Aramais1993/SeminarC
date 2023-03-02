// Task 1. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
/*
int CutNumber(int num)
{
    int hundreds = num / 100;
    int units = num % 10;
    int result = hundreds * 10 + units;

    return result;
}

int randNumber = new Random().Next(100,1000);

int newNumber = CutNumber(randNumber);
Console.WriteLine($"New version of {randNumber} is {newNumber}");
*/
// Task 2. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно a и b.
/*
bool IsMultiplyed(int num, int div1, int div2)
{
    if(num % div1 == 0 && num % div2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.Write("Input a number for checking: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a first divider: ");
int divider1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second divider: ");
int divider2 = Convert.ToInt32(Console.ReadLine());

bool result = IsMultiplyed(number, divider1, divider2);
Console.WriteLine(result);
*/
// Task 3. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
/*
int BiggestNum(int num)
{
    int tens = num / 10;
    int units = num % 10;
    if (units > tens)
       return units;
    else
       return tens;
}

int randNumber = new Random().Next(10, 100);
int big = BiggestNum(randNumber);
Console.WriteLine($"The biggest sign of number {randNumber} is {big}");
*/

// Task 4. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
/*
bool SquareOrNot (int num1, int num2)
{
    return (num1 / num2 == num2 || num2 / num1 == num1);
}
Console.WriteLine ("Please insert first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Please insert second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool result = SquareOrNot(num1, num2);
if (result) Console.WriteLine($"Number {num1} or number {num2} is a square of the other number");
else Console.WriteLine($"Number {num1} or number {num2} is not a square of the other number");
*/

// Homework.

// Task 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
 int CutNumber (int func_num)
{   
     int result = func_num / 10 % 10;
     return result;
}

Console.Write("Input a three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num < 100 || num > 1000)
{
    Console.Write("This is not a three-digit nimber, please insert a three-digit number");
}
else
{
    int newNumber = CutNumber(num);
    Console.WriteLine($"New version of {num} is {newNumber}");
}    
*/

// Task 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int reverseDigits(int p_initialNum)
{
    int revNum = 0;
    while (p_initialNum > 0) 
    {
        revNum = revNum * 10 + p_initialNum % 10; 
        p_initialNum = p_initialNum / 10;
    }
    return revNum;
}

Console.Write("Input a number: ");
int initialNum = Convert.ToInt32(Console.ReadLine());
int reverseNum = reverseDigits(initialNum);

int digit3;
if (reverseNum >= 100)
{
    digit3 = reverseNum / 100 % 10;
    Console.WriteLine($"Third digit of {initialNum} is {digit3}");
}    
else
   Console.WriteLine($"The number does not have third digit");
*/

// Task 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
bool WEorNot(int p_num)
{
    if(p_num == 6 || p_num == 7)
        return true;      
    else
        return false;
}        

Console.Write("Please, insert a nunber of a day of the week: ");
int number = Convert.ToInt32(Console.ReadLine());
bool result = WEorNot(number);

if (result) 
{
    Console.WriteLine($"This day is a Weekend!");
}
else
{
    if (number > 0 && number < 6)
    {
        Console.WriteLine($"This day is not a Weekend!");
    }
    else
    { 
        if (number <=0 || number > 7)
        {
            Console.WriteLine($"This number is not a number of a day of the week, please insert a number form 1 to 7");
        }
    }
}
*/