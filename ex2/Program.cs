// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
// Вещественные числа = Real Numbers => Double

int arraySize = GetIntNatFromUser("Определите размер массива: ");
double[] array = new double[arraySize];

if (GiveUserAChoise("Сгенерировать массив автоматически?"))
    array = GenerateArrayWithDoubles(arraySize, -10, 10);
else 
    array = GetDoubleArrayFromUser(arraySize);

CheckForLimitsInDoubleArray(array, out double min, out double max);

min = Math.Round(min,2); max = Math.Round(max,2); // Округление min и max
Console.WriteLine($"[{ArrayDoubleToString(array)}] -> {max - min}"); 

//Console.Write($"{max} - {min}"); // Для удобной проверки результата



static void CheckForLimitsInDoubleArray(double[] array, out double min, out double max)
{
    min = array[0];
    max = array[0];
    foreach (double element in array)
    {
        if (element > max) max = element;
        else if (element < min) min = element;
    }
    return;
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

static bool GiveUserAChoise(string userMsg)
{
    while(true)
    {
        Console.Write($"{userMsg} (y/n): ");
        string ans = Console.ReadLine() ?? "";
        if (ans == "y")
            return true;
        else 
            if (ans == "n")
                return false;
        Console.WriteLine("Ошибка ввода!");
    }
}

static double[] GenerateArrayWithDoubles(int arraySize, double lowLimit, double highLimitIncluded)
{
    Random rnd = new Random();
    double[] array = new double[arraySize];

    for (int i = 0; i < arraySize; i++)
    {
        array[i] = rnd.NextDouble()* (highLimitIncluded - lowLimit) + lowLimit;
    }
    return array;
}

static double[] GetDoubleArrayFromUser(int arraySize)
{
    double[] array = new double[arraySize];
    for (int i = 0; i < arraySize; i++)
    {
        array[i] = GetDoubleFromUser($"Введите элемент массива #{i + 1}: ");
    }
    return array;
}

static string ArrayDoubleToString(double[] array)
{
    // 0; 1; 2; 3
    string result = $"{String.Format("{0:0.00}", array[0])}";
    for (int i = 1; i < array.Length; i++)
    {
       result = result + $"; {String.Format("{0:0.00}", array[i])}";
    }
    return result;
}

static double GetDoubleFromUser(string userMsg) //TryParse
{
    while(true)
    {
        Console.Write(userMsg);
        if (double.TryParse(Console.ReadLine(), out double num))
            return num;
        
        Console.WriteLine("Ошибка ввода!");
    }
}