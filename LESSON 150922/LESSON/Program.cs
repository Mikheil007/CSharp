// int sumOfGigits(int n)
// {
//     if(n > 0) return sumOfGigits(n / 10) + n % 10;
//     else return 0;
// }

// Console.WriteLine(sumOfGigits(5734));



// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу 
//кубов чисел от 1 до N.

// Console.WriteLine("Введите число N");
// int numN = Convert.ToInt32(Console.ReadLine());
// int i = 1;
// Console.Write($"{numN} -> ");
// while (numN >= i)
// {
//     Console.Write($"{i*i*i} ");
//     i = i + 1;
// }

// 21 Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// Console.WriteLine("Введите координты точки A");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координты точки A");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координты точки А");
// int x3 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координты точки B");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координты точки B");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координты точки B");
// int y3 = Convert.ToInt32(Console.ReadLine());
// double w;
// w = Math.Sqrt(Math.Pow(x1-y1,2)+Math.Pow(x2-y2,2)+Math.Pow(x3-y3,2));
// Console.WriteLine($" расстояние между координат {w} ");


// Задача 19
// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.

// Console.WriteLine("Введите пятизначное число x");
// int x = Convert.ToInt32(Console.ReadLine());
// int x1 = x % 10;
// int x2 = x / 10 % 10;
// int x4 = x / 1000 % 10;
// int x5 = x / 10000;
// if (x1 == x5 & x2 == x4)
// {
//     Console.WriteLine("Введенное число полиндром");
// }
// else Console.WriteLine("Введенное число, не полиндром");


// Напиши программу, которая по введённому возрасту пользователя сообщает, 
// к какой возрастной группе он относится:
//   до 13 включительно – детство;
//   от 14 до 24 – молодость;
//   от 25 до 59 – зрелость;
//   от 60 – старость.

// Console.WriteLine("Введите возраст человека");
// int age = Convert.ToInt32(Console.ReadLine());
// if (age < 13)
// {
//     Console.WriteLine("возрастная группа - детство");
// }
//  else if (age < 25)
// {
//     Console.WriteLine("возрастная группа - молодость");
// }
//  else if (age < 60)
// {
//     Console.WriteLine("Возрастная группа - зрелость");
// }
//  else if (age > 60)
// {
//     Console.WriteLine("Возрастная группа - старость");
// }



// Напиши программу для нахождения цифр числа n , которое вводим с клавиатуры. от 1000 до 9999
// Например - ввели 7531 - выводим: тысяч 7, сотен 5, десятков 3, единиц -1

// Console.WriteLine("Введите четырёхзначное число N");
// int n = Convert.ToInt32(Console.ReadLine());
// if (n < 1000 | n > 9999)
// {
//     Console.WriteLine("Вы ввели не четырёх значное число");
// }
// else 
// {
//     int n1 = n / 1000;
//     Console.WriteLine(n1);
//     int n2 = n / 100 % 10;
//     Console.WriteLine(n2);
//     int n3 = n / 10 % 10;
//     Console.WriteLine(n3);
//     int n4 = n % 10; 
//     Console.WriteLine(n4);
//     Console.WriteLine($"тысяч - {n1}, сотен - {n2}, десятков - {n3}, единиц - {n4tudmsrntsna");
// }

