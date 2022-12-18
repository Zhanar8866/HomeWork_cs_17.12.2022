// Написать программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее

Console.Write("Введите число A = ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B = ");
int B = Convert.ToInt32(Console.ReadLine());
if(A>B)
{
    Console.WriteLine("max="+A);
    Console.WriteLine("min="+B);
}
else
{
    Console.WriteLine("max="+B);
    Console.WriteLine("min="+A);
}