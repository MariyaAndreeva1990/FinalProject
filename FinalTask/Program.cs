string[] MyString1 = new string[5] { "Vitaliy", "Anna", "Mary", "Dan", "Ma" };
string[] MyString2 = new string[MyString1.Length];

ArrayCutString(MyString1, MyString2, 3);
PrintArray(MyString2);


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
