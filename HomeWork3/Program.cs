// 3) Напиши программу, где мы вводим одно число, 
// а она потом нам выводит предыдущее число, 
// наше число и следующее

// Console.WriteLine("Введите возраст человека ");
// int Age = Convert.ToInt32(Console.ReadLine());
// if (Age > 18 )
// {
// Console.WriteLine("Доступ разрешен ");
// }
// else {Console.WriteLine("Доступ запрешен");}

Console.WriteLine("enter the number");
int num = Convert.ToInt32(Console.ReadLine());
int num2 = num - 1;
int num3 = num + 1;
if (num2 < num)
if (num == num)
if (num3 > num)
{
Console.WriteLine($"previus number - {num2}");
Console.WriteLine($"our number - {num}");
Console.WriteLine($"nex number - {num3}");
}