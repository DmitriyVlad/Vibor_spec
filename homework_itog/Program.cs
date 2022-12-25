// Задача. Программа, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам

string[] array1 = new string[7] {"777", "3", "moskow", "leningrad", "sum", "1234", "privet"};
string[] array2 = new string[array1.Length];
void SecondArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
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
SecondArray(array1, array2);
PrintArray(array2);
