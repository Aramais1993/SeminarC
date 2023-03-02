// Task 1.Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
/*
void ShowDiapozone (int quad)
{
    if(quad == 1) Console.WriteLine("x > 0 and y > 0");
    else if (quad == 2) Console.WriteLine("x < 0 and y > 0");
    else if (quad == 3) Console.WriteLine("x < 0 and y < 0");
    else if (quad == 4) Console.WriteLine("x > 0 and y < 0");
    else Console.WriteLine ("Uncorrect input");
}

Console.Write("Input a number of quadrant: ");
int quadrant = Convert.ToInt32(Console.ReadLine());

ShowDiapozone(quadrant);
*/

// Task 2. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
// и выдаёт номер четверти плоскости, в которой находится эта точка.
/*
int getQuarter(int x, int y) {
    
    if(x > 0 && y > 0)
      return 1;
    if(x < 0 && y > 0)
      return 2;
    if(x < 0 && y < 0)
      return 3;
    if(x > 0 && y < 0)
      return 4;

    return -1; 
}

Console.Write("Enter the cordinates X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the cordinates Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int quarter = getQuarter(x,y);
if (quarter > 0)
    Console.WriteLine($"point is in {quarter} quarter");
else
   Console.WriteLine($"point is not in  quarters");
*/

// Task 3. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

/*
double getDistance(double xa, double ya, double xb, double yb){
  return Math.Sqrt((xb-xa) * (xb-xa) + (yb-ya) * (yb-ya));
}

Console.Write("Введите координату X первой точки: ");
double xa= Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y первой точки: ");
double ya= Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату X второй точки: ");
double xb= Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y второй точки: ");
double yb= Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Растояние между точками: " + getDistance(xa, ya, xb, yb));
*/

// Task 4. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
/*
void squareTable(int n){
  int currentNumber = 1;
  while (currentNumber <= n){
    Console.WriteLine(currentNumber + "-" + (currentNumber * currentNumber));
    currentNumber++;
  }
}
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 0)
   squareTable(n);
else
  Console.Write("Введите число больше 0");
*/

// Homework.

// Task 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
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
Console.Write("Input a number >= 10: ");
int initialNum = Convert.ToInt32(Console.ReadLine());
int reverseNum = reverseDigits(initialNum);
if (initialNum >= 10)
{
    if (reverseNum == initialNum)
    {
        Console.WriteLine($"Yes, your number {initialNum} is a palindrome!");
    }    
    else
        Console.WriteLine($"No, your number {initialNum} is not a palindrome");
}
else
Console.WriteLine($"Please, input a number >= 10");
*/

// Task 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Distance ( double p_xA, double p_yA, double p_zA, double p_xB, double p_yB, double p_zB)
{
    double p_hypotenuse = Math.Sqrt ((p_xA - p_xB)*(p_xA - p_xB) + (p_yA - p_yB)*(p_yA - p_yB) + (p_zA - p_zB)*(p_zA - p_zB));
    return p_hypotenuse;
} 
Console.WriteLine("Input coordinates of point A in 3D (xA, yA, zA): ");
double xA = Convert.ToDouble(Console.ReadLine());
double yA = Convert.ToDouble(Console.ReadLine());
double zA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinates of point B in 3D (xB, yB, zB): ");
double xB = Convert.ToDouble(Console.ReadLine());
double yB = Convert.ToDouble(Console.ReadLine());
double zB = Convert.ToDouble(Console.ReadLine());
double dist = Distance (xA, yA, zA, xB, yB, zB);
Console.WriteLine ($"The distance between point A [{xA}, {yA}, {zA}] and point B [{xB}, {yB}, {zB}] is {dist}");
*/

// Task 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void CubNum (int p_num)
{
    int current = 1;
    while (current <= p_num)
    {
        Console.Write ($" {current * current * current},");
        current++;
    }
}
Console.Write ("Input your number: ");
int Number = Convert.ToInt32(Console.ReadLine());
CubNum (Number);
*/