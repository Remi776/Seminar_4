int[] array = new int[8];
Random rnd = new Random();

void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = rnd.Next(0, 51);
    }
}

void PrintArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        Console.Write(collection[i] + " ");
    }
    Console.WriteLine("\n");
}

void Sort(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        int MinPosition = i;
        for (int j = i + 1; j < collection.Length; j++)
        {
            if (collection[j] < collection[MinPosition])
            {
                MinPosition = j;
            }
        }
        int temp = collection[i];
        collection[i] = collection[MinPosition];
        collection[MinPosition] = temp;
    }
}

FillArray(array);
PrintArray(array);

Sort(array);
PrintArray(array);