// Вид 1. Метод который ничего не принимает и не возвращает


void Method1()
{
    System.Console.WriteLine("Автор проекта...");
}
// Так можно этот метод вызвать:
//Method1();  



// Вид 2. Метод который принимает, но не возвращает

void Method2(string msg)
{
    System.Console.WriteLine(msg);
}
// Так можно этот метод вызвать:
//Method2(msg: "Текст сообщения");

// Еще вариант:
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        System.Console.WriteLine(msg);
        i++;
    }
}
//Method21("Текст", 4);
//Method21(msg: "Текст", count: 4); // (если они названы, то можно не попорядку)


// Вид 3. Метод который не принимает, но возвращает

int Method3()
{
    return DateTime.Now.Year;
}

//int year = Method3();
//System.Console.WriteLine(year);

//Вид 4. Метот который принимает и возвращает

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// этот же цикл только не While а For:

string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "Ура ");
System.Console.WriteLine(res);

// Цикл в цикле For на примере таблици умножения

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        System.Console.WriteLine($"{i} * {j} = {i * j}");
    }
    System.Console.WriteLine();
}