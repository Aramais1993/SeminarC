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





// Task 4. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
