// 2) Для этого попросим у пользователя ввести его имя, фамилию, логин и пароль, 
// а после выведем сообщение:

// Привет (имя) (фамилия)! Регистрация пройдена успешно!
// Твой логин: (логин) 

// Твой пароль: (пароль) 

Console.WriteLine("Plesae enter your name");
string name = Console.ReadLine();
Console.WriteLine("Please enter your last name");
string lastName = Console.ReadLine();
Console.WriteLine("Please enter your login");
string login = Console.ReadLine();
Console.WriteLine("Please enter your password");
string password = Console.ReadLine();
Console.WriteLine($"Your name is - {name}");
Console.WriteLine($"You last name is - {lastName}");
Console.WriteLine($"You login is - {login}");
Console.WriteLine($"You password is - {password}");