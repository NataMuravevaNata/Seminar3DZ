// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());
int result=1;
while (result <=N)
{
    Console.WriteLine(result*result*result);
    result ++;
}
