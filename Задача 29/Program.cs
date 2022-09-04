void randomArray(int number, int min, int max)

{
    int[] array = new int[number];

    for (int i = 0; i < number; i++)
    {
        array[i] = new Random().Next(min, (max + 1));
        Console.Write(array[i]+" ");
    }

}


randomArray(5, 1, 20);

