// метод, кот заполняется пользователем

string[] CreateArray(int size)

{
        string[] newArray = new string[size]; 

        Console.WriteLine("Creating array here: ");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Input {i+1} element: "); 
            newArray[i] = Convert.ToString(Console.ReadLine()); 
        }
        Console.WriteLine();
        return newArray;
}

// метод печатает массив на экран

void ShowArray(string[] array)

{
    for (int i = 0; i < array.Length; i++) 
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.WriteLine("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] array = CreateArray(size);

Console.Write("Массив: ");
ShowArray(array);

string[] result_array = new string[size];

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3) result_array[i] = array[i];
}

Console.Write("Новый массив: ");
ShowArray(result_array);


        