void PrintArray(string[] array)
{
    int rows = array.Length;

    for (int i = 0; i < rows; i++)
    {
        Console.Write($"{array[i]} ");
    }

}

int GetCountElemventByLength(string[] array)
{
    int nowIndex = 0;
    int countString = 0;

    while (nowIndex < array.Length)
    {
        if (array[nowIndex].Length <= 3)
        {
            countString++;
        }
        nowIndex++;
    }

    return countString;
}

string[] arrayStrings = { "123", "1234", "test", "run", "test2" };

string[] arrayStringsLimitedByCondition = new string[GetCountElemventByLength(arrayStrings)];

int position = 0;
int nowIndex = 0;
while (nowIndex < arrayStrings.Length)
{
    if (arrayStrings[nowIndex].Length <= 3)
    {
        arrayStringsLimitedByCondition[position] = arrayStrings[nowIndex];
        position++;
    }
    nowIndex++;
}
Console.Write("Исходный массив: ");
PrintArray(arrayStrings);
Console.WriteLine();
Console.Write("Результат: ");
PrintArray(arrayStringsLimitedByCondition);