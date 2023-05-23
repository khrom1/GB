Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "миша")
{
    Console.WriteLine("Ура это же Миша");
}
else
{
    Console.Write("Привет,");
    Console.Write(username);
}
