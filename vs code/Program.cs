Console.Clear();

string[] array = {"Geek","Brains","-","это","лучшее","место","для","обучения","программированию"};
Console.WriteLine("Исходный массив:");
foreach (string i in array)
{
    Console.Write(i + " ");
}
Console.WriteLine();

string[] arrayNew = new string [array.Length];
int index = 0;
foreach (string i in array)
{
    if(i.Length <= 3)
    {
        arrayNew[index] = i;
        index++;
    }
}
