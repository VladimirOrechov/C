void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
    
}
void PrintArray(int[] col)
{
    int counte = col.Length;
    int position = 0;
    while(position < counte)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int indexof(int[] collection, int find)
{
    int counte = collection.Length;
    int index = 0;
    int position = -1;
    while(index < counte)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
array[4] = 4;
array[6] = 4;
PrintArray(array);
Console.WriteLine();

int pos = indexof(array, 444);
Console.WriteLine(pos);






