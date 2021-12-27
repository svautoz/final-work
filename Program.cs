﻿int[] CreateRandomArray(int leftBound, int rightBound, int arrayLength)
{
    Random rand = new Random();
    int[] array = new int[arrayLength];
    for (int i = 0; i < arrayLength; i++)
    {
        array[i] = rand.Next(leftBound, rightBound + 1);
    }
    return array;
}

