// Задача: 
// 1. Написать программу, которая из имеющегося массива строк
// 2. формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// 3. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//  При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Clear();

Console.Write("Введите количество элементов в массиве: ");

int quantityElementArray = Convert.ToInt32(Console.ReadLine());

string[] quantityArray = InputElementArray(quantityElementArray);
Console.Write("[");
PrintArray(quantityArray);
Console.Write("] -> ");

string[] arrayGivenElementLength = PrintElemArray(quantityArray, PrintQuantityElemStringArray(quantityArray));
Console.Write("[");
PrintArray(PrintElemArray(quantityArray, PrintQuantityElemStringArray(quantityArray)));
Console.Write("]");

string[] InputElementArray(int quantityElem)
{
    string[] quantityElemArray = new string[quantityElem];
    for (int i = 0; i < quantityElemArray.Length; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
        quantityElemArray[i] = Console.ReadLine()!;
    }
    return quantityElemArray;
}

string[] PrintArray(string[] array, char sep = '"')
{
    for (int i = 0; i < array.Length; i++)
    {
        // Console.Write(string.Join(", ", array) ); // Плоды просмотра Буткемпа
        if (i < array.Length - 1) Console.Write($"{sep}{array[i]}{sep}, ");
        else Console.Write($"{sep}{array[i]}{sep}");
    }
    return array;
}

string[] PrintElemArray(string[] array1, int quantityArr)
{
    string[] arr = new string[quantityArr];
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            arr[count] = array1[i];
            count++;
        }
    }
    return arr;
}

int PrintQuantityElemStringArray(string[] array2)
{
    int strLength = 0;
    for (int i = 0; i < array2.Length; i++)
    {
        if (array2[i].Length <= 3) strLength++;  
    }
    return strLength;
}