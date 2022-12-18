// Написать программу, которая принимает на вход три числа и выдает максимальное из этих чисел

int Amount=3;

Console.Write("Введите число A = ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B = ");
int B = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число С = ");
int C = Convert.ToInt32(Console.ReadLine());

if(A>B)
{
   if (A>C)
   {
        Console.WriteLine("max="+A);
    }
    else
    {
        Console.WriteLine("max="+C);
    }
    }
else
{
    if (B>C)
   {
        Console.WriteLine("max="+B);
    }
    else
    {
        Console.WriteLine("max="+C);
    } 
    }