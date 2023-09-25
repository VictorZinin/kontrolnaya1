// Задача: Написать программу, которая из имеющегося массива строк формирует
// новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

void FillArray(int N, string[] collection)
{
    int сount = 1;
    for (int i = 0; i < N; i++)
    {

        System.Console.Write($"Введите {сount}-е значение массива: ");
        collection[i] = Console.ReadLine();
        сount++;
    }
}

int CountChars(string[] collection1)
{
    int count = 0;
    for (int i = 0; i < collection1.Length; i++)
    {
        if (collection1[i].ToString().Length <= 3)
        {
            count++;
        }
    }
    return count;
}

void FillArrayRes(string[] collection1, string[] collection2)
{
    int count = 0;
    for (int i = 0; i < collection1.Length; i++)
    {
        if (collection1[i].ToString().Length <= 3)
        {
            collection2[count] = collection1[i];
            count++;
        }
    }
}
System.Console.WriteLine("Введите размерность массива: ");
int N = Convert.ToInt32(Console.ReadLine());

string[] array = new string[N];
FillArray(N, array);

var arrayRes = new string[CountChars(array)];
FillArrayRes(array, arrayRes);

System.Console.Write("[");
foreach (var item in array)
{
    System.Console.Write($"'{item}' ");
}
System.Console.Write("] -> ");
System.Console.Write("[");
foreach (var item in arrayRes)
{
    System.Console.Write($"'{item}' ");
}
System.Console.Write("]");