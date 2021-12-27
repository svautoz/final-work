int[] CreateRandomArray(int leftBound, int rightBound, int arrayLength)
{
    Random rand = new Random();
    int[] array = new int[arrayLength];
    for (int i = 0; i < arrayLength; i++)
    {
        array[i] = rand.Next(leftBound, rightBound + 1);
    }
    return array;
}

int GetArrayLength()
{
    int result;
    do
    {
        System.Console.WriteLine("Введите количество элементов массива: ");
    }
    while (!int.TryParse(Console.ReadLine(), out result));

    return result;
}

int[] GetEvenValuesArray(int[] initArray)
{
    int evenArrayLength = 0;
    for (int i = 0; i < initArray.Length; i++)
    {
        if (initArray[i] % 2 == 0)
        {
            evenArrayLength++;
        }
    }

    int[] evenArray = new int[evenArrayLength];
    int index = 0;
    for (int i = 0; i < initArray.Length; i++)
    {
        if (initArray[i] % 2 == 0)
        {
            evenArray[index] = initArray[i];
            index++;
        }
    }
    return evenArray;
}

void PrintArrayToConsole(int[] array)
{
    foreach (int el in array)
    {
        System.Console.WriteLine(el + " ");
    }
    System.Console.WriteLine();
}


int leftBound = -100;
int rightBound = 100;
int[] initArray, evenArray;

initArray = CreateRandomArray(leftBound, rightBound, GetArrayLength());
PrintArrayToConsole(initArray);
evenArray = GetEvenValuesArray(initArray);
PrintArrayToConsole(evenArray);