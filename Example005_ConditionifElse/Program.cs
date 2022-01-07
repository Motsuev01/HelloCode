Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "хусейн")
{
    Console.WriteLine("Ура, это же ХУСЕЙН!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}