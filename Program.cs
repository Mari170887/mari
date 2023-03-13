// **Задача**: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массива

string[] array = new string[] { "project", "five", "Lipetsk", "+-/*7", "$ %" };

void FillArray(string[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

void Diffarray(string[] arr)
{
       for (int i = 0; i < arr.Length; i++)
    {
        string element = arr[i];
        if (element.Length <= 3)
        {
            arr[i] = element;
        }
        else arr[i] =  string.Empty;

    }
}
FillArray(array);

Diffarray(array);

Console.Write("-> ");

FillArray(array);

