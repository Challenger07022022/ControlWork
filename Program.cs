string[] CreateArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Input " + i + " element of the array: ");
        array[i] = Console.ReadLine();
    }
    return array;
}
string PrintArray(string[] array)
{
    string result = string.Empty;
    result = "[";
    for (int i = 0; i < array.Length; i++)
    {
        result += array[i];
    }
    result += "]";
    return result;
}
// void ShowArray(string[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
//     Console.WriteLine();
// }
string[] SolveEx(string[] array)
{
    string[] resultArray = new string[array.Length];
    int len = array.Length;
    for (int i = 0, j = 0; i < len; i++)
    {
        if (array[i].Length <= 3)
        {
            resultArray[j] += array[i];
            j++;
        }
    }
    return resultArray;
}

string[] a = CreateArray(4);
string[] b = SolveEx(a);
Console.WriteLine(PrintArray(b));