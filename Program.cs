int a;
Console.Write("Введите количество элементов массива: ");
int.TryParse(Console.ReadLine(), out a);
string[] array = new string[a];
for( int i = 0; i < a; i++)
{
    Console.Write("Введите элемент массива: ");
    array[i] = Console.ReadLine()!;
}

for( int i = 0; i < a; i++) Console.Write($"{array[i]}, ");
Console.WriteLine();

string[] newArray = new string[a];

int k = 0;
for( int i = 0; i < a; i++)
{
    if (array[i].Length < 4)
    {
    newArray[k] = array[i];
    k++;
    }
}

Console.WriteLine(string.Join( " ", newArray));
