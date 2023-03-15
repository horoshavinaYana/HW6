// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int GetIncomingData(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] CreateArray(int length)
{
    return new int[length];
}

void Print(int[] array)
{
    int size = array.Length;
    int index = 0;
    while (index < size)
    {
        if (index == size - 1)
        {
            Console.Write(array[index]);
        }
        else
        {
            Console.Write($"{array[index]},");
        }
        ++index;
    }
    Console.WriteLine();

}
int GetQtyPositiveNumbers(int[] array)
{
    int Qty = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            Qty++;
        }
    }
    return Qty;
}

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = GetIncomingData($"Введите {index + 1} элемент массива");
        index++;
    }
}

int length = GetIncomingData("Введите длину массива");
int[] arr = CreateArray(length);
FillArray(arr);
Print(arr);
 Console.WriteLine(GetQtyPositiveNumbers(arr));