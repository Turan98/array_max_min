int [] array  = new int [] {2, 6, -3, 4, 7, 0};
int min = array[0];
int max = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (min > array[i])
    {
        min = array[i];
    
    }

    if (max < array[i])
    {
        max = array[i];
    }
}

Console.WriteLine("Min elemet in array: " + min);
Console.WriteLine("Max elemet in array: " + max);
