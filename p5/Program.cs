Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "ира")
{
    Console.WriteLine("Любовь моя");
}
else
{
    Console.Write("Незнакомая тётя, ");
    Console.WriteLine(username);
}