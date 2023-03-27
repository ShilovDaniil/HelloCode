Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "daniil")
{
  Console.WriteLine("Yeah, it`s Daniil");
}
else
{
    Console.Write("Hi, ");
    Console.WriteLine(username);
}
