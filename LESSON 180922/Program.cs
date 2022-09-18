// 2) Вводим с клавиатуры размер 3 сторон треугольника.
//   И говорим какой он - обычный, равнобедренный или равносторонний

Console.WriteLine("Введите сторону X сторону треугольника");
int X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите сторону Y треугольника");
int Y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите сторону Z треугольника");
int Z = Convert.ToInt32(Console.ReadLine());
if (X == Y & X == Z & Y == Z)
{
    Console.WriteLine("треугольник - равносторонний");
}
else if (X != Y & Z != Y & Z !=X)
{
    Console.WriteLine("треугольник - обычный");
}
else
{
    Console.WriteLine("треугольник равнобедренный");
}

