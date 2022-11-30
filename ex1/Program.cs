// // Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// // [3, 7, 23, 12] -> 19 ; [-4, -6, 89, 6] -> 0

int[] array = GenerateArrayWithNumbers(GetIntNatFromUser("Задайте количество элементов в массиве: "), -99, 99);

Console.WriteLine($"[{ArrayToString(array)}] -> {FindSumOfArrayElementsOnOddPositions(array)}"); 


static int FindSumOfArrayElementsOnOddPositions(int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i+= 2)
    {
        result += array[i];
    }
    return result;
}

static int[] GenerateArrayWithNumbers(int arraySize, int lowLimit, int highLimitIncluded)
{
    Random random = new Random();
    int[] array = new int[arraySize];

    for (int i = 0; i < arraySize; i++)
    {
        array[i] = random.Next(lowLimit, highLimitIncluded + 1);
    }
    return array;
}

static int GetIntNatFromUser(string userMsg)
{
    while(true)
    {
        Console.Write(userMsg);
        if (int.TryParse(Console.ReadLine(), out int num))
            if (num >0)
                return num;
        Console.WriteLine("Ошибка ввода!");
    }
}

static string ArrayToString(int[] array)
{
    // 0, 1, 2, 3
    string result = $"{array[0]}";
    for (int i = 1; i < array.Length; i++)
    {
        result = result + $", {array[i]}";
    }
    return result;
}
