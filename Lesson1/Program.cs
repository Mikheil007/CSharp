// Задача № 4
int numbA;
Console.WriteLine("numbA ");
numbA = Convert.ToInt32(Console.ReadLine());
int numbB;
Console.WriteLine("numbB ");
numbB = Convert.ToInt32(Console.ReadLine());
int numbC;
Console.WriteLine("numbC ");
numbC = Convert.ToInt32(Console.ReadLine());
int max;
if (numbA > numbB)
{
max = numbA;
}
else
{
max = numbB;
}
if (numbC > max)
{
max = numbC;
}
Console.WriteLine($"максимальное число = {max}");
