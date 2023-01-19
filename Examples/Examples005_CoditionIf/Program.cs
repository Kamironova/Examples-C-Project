//Console.Write("Введите имя");
//String username = Console.ReadLine();
//if username = "Маша" then;
//Console.Write("Ура, Это же Маша!");
//else Console.Write("Привет, ");
//Console.Write(username):


Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.Write("Ура, это же МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
}
    
