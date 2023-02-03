// Имеется одномерный массив array из n эллемннтов, требуется найти эллемент
// массива, равный find

Console.Clear();

int[] array = { 11, 22, 93, 49, 93, 71, 77, 8 };

int n = array.Length;
int find = 93;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;  // этот оператор прерывает поиск в случае если найдет значение( иначе он может найти второе такое же)

    }
    index++;


}