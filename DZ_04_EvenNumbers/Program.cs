// Программа, которая на вход принимает число N, а на выходе показывает чётные числа от 1 до N

Console.Write("Введите число = ");
int N = Convert.ToInt32(Console.ReadLine());

int k = 1;

while (k < N-2)
{
   if(k%2==0)
{
    Console.Write(k+", ");
}
k++; 
}

while (k < N)
{
if(k%2==0)
{
    Console.Write(k+".");
}
k++; 
}