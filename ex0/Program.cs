// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// Примечание преподавателя: Количество элементов запрашивается у пользователя

int[] array = GenerateArrayWithNumbers(GetIntNatFromUser("Задайте количество элементов в массиве: "), 100, 999);

Console.WriteLine($"[{ArrayToString(array)}] -> {CountEvensInArray(array)}"); 


static int CountEvensInArray(int[] array)
{
    int result = 0;
    foreach (int element in array)
    {
        result += element % 2 == 0 ? 1 : 0;
    }
    return result;
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
