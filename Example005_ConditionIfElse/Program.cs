Console.Write("Введите имя пользователя: ");
string username =  Console.ReadLine();

if(username.ToLower() == "acid")
{
    Console.WriteLine("Ура! Это же acid!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);

}