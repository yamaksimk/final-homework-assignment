using static System.Console;

Clear();

string[] array = { "Geek", "Brains", "-", "это", "лучшее", "место", "для", "обучения", "программированию" };
WriteLine("Исходный массив:");
foreach (string i in array)
{
    Write(i + " ");
}
WriteLine();

string[] arrayNew = new string[array.Length];
int index = 0;
foreach (string i in array)
{
    if (i.Length <= 3)
    {
        arrayNew[index] = i;
        index++;
    }
}
WriteLine("Новый массив:");

Array.Resize(ref arrayNew, index);
foreach (string i in arrayNew)
{
    Write(i + " ");
}
WriteLine();