// Написать программ, которая из имеющегося массива строк формирует массив из строк,
//  длина которых меньше или равна трем символам. 
//  Первоначальный массив задать с клавиатуры, 
//  либо задать на старте выполнения алгоритма.

string[] GenArray(string[] array) 
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }

    string[] newarray = new string[count]; 
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newarray[j] = array[i];
            j++;
        }
    }
    return newarray;
}


void PrintArray(string[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}


string[] array = { "hello", "2", "world", ":-)" };


Console.WriteLine("Задан массив: ");
PrintArray(array);
Console.WriteLine();

string[] newarray = GenArray(array);
Console.WriteLine("В этом массиве символов <= 3: ");
PrintArray(newarray);