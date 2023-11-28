// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Prompt(string messege)
{
    Console.Write(messege);
    string? value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int[] GetArray(int length)
{
    int[] res = new int[length];
    for (int i = 0; i < res.Length; i++)
    {
        res[i] = Prompt($"Введите число: ");
    }
    return res;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"a[{i}] = {array[i]}");
    }
}

int CountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int length = Prompt("Введите количество цифр: ");
int[] array;
array = GetArray(length);
PrintArray(array);
Console.WriteLine($"Количество чисел больше 0 = {CountPositiveNumbers(array)}");
