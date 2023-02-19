using static System.Console;
WriteLine("Введите слова через пробел: ");
string[] startArray = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
PrintArray(startArray);
Write(" -> ");
string[] newArray = GetArray(startArray);
if (newArray.Length == 0) WriteLine("[]");
else PrintArray(newArray);
WriteLine();


string[] GetArray(string[] ar)
{
    int stringSize = 0;
    for (int i = 0; i < ar.Length; i++)
    {
        if (ar[i].Length <= 3) stringSize++;
    }
    string[] resultArray = new string[stringSize];
    int index = 0;
    for (int i = 0; i < ar.Length; i++)
    {
        if (ar[i].Length <= 3)
        {
            resultArray[index] = ar[i];
            index++;
        }
    }
    return resultArray;
}


void PrintArray(string[] array)
{
    Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Write($"\"{array[i]}\", ");
    }
    Write($"\"{array[array.Length - 1]}\"]");
}
