// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.


string[] ArrayText (string[] array)
{
    string[] newarray = new string [array.Length];
    int n = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <=3)
        {
            newarray[n] = array[i];
            n++;
        }
    }
    return newarray;
}

void PrintArray (string[] arr)
{
    string toPrintString = "";
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] != null) toPrintString = toPrintString + arr[i] +"; ";
    }
    if (toPrintString != "")
    {
        Console.WriteLine($"Массив из строк длиной меньше 4 символов: ");
        Console.WriteLine($"[{toPrintString.Substring(0,toPrintString.Length-2)}]");
    }
    else
    {
        Console.WriteLine("Не введены подходящие элементы для формирования нового массива");
    }
}


Console.Write("Введите длину массива: ");
int number = Convert.ToInt32(Console.ReadLine());
string[] arrayFirst = new string[number];
for (int i = 0; i < number; i++)
{
      Console.Write($"Введите {i+1} элемент массива: ");
      arrayFirst[i] = Console.ReadLine();  
}


Console.WriteLine();
PrintArray(ArrayText(arrayFirst));