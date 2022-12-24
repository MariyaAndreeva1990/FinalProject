string[] myString1 = new string[5] { "Vitaliy", "Anna", "Mary", "Dan", "Ma" };
string[] myString2 = new string[myString1.Length];

ArrayCutString(myString1, myString2, 3);
PrintArray(myString2);


void ArrayCutString(string[] array1, string[] array2, int cut)
{
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= cut)
        {
            array2[i] = array1[i];
        }
        else if (array1[i].Length >= cut)
        {
            array2[i] = array1[i].Remove(cut);
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
