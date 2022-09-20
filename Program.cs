// Создать программу, которая из имеющегося массива формирует массив из строк, длинна которых меньше или равна 3 символам //
Console.Clear();

// Методы программы
string[] CreateArray() // Метод создания и ручного заполнения массива
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Введите некоторый текст или оставьте строчку пустой, чтобы завершить заполнение массива.\n");

    string[] arr = new string[10];

    for (int i = 0; i < arr.Length; i++)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Ввод (осталось ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($"{10 - i}");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("): ");

        Console.ForegroundColor = ConsoleColor.White;
        arr[i] = Console.ReadLine();

        if (String.IsNullOrEmpty(arr[i]))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Пользователь прекратил ввод данных!\n");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            return arr;
        }
    }

    Console.WriteLine();
    return arr;
}

void PrintArray(string[] arr, bool color, string comment) // Метод вывода массива с выбором цвета и возможностью менять текст
{
    if (color == true)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
    }
    Console.Write($"{comment}: ");

    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.Write("[");

    for (int i = 0; i < arr.Length; i++)
    {
        if (String.IsNullOrEmpty(arr[i]))
        {
            Console.Write("]\n");
            Console.ForegroundColor = ConsoleColor.White;
            return;
        }
        else if (i == arr.Length - 1)
        {
            Console.Write($"{arr[i]}]\n");
            Console.ForegroundColor = ConsoleColor.White;
            return;
        }
        else if (String.IsNullOrEmpty(arr[i + 1]))
        {
            Console.Write($"{arr[i]}");
        }
        else
        {
            Console.Write($"{arr[i]}, ");
        }
    }
}

string[] CreateShapeArray(string[] arr) // Метод создаёт массив по правилу: длинна строк <= 3
{
    string[] oldArr = arr;
    string[] newArr = new string[arr.Length];
    int position = 0;

    for (int i = 0; i < oldArr.Length; i++)
    {
        if (String.IsNullOrEmpty(oldArr[i]))
        {
            return newArr;
        }

        int tempLength = oldArr[i].Length;
        if (tempLength <= 3)
        {
            newArr[position] = oldArr[i];
            position++;
        }
    }
    return newArr;
}

// Выполнение кода
string[] array = CreateArray();
PrintArray(array, false, "Созданный массив данных");

string[] newArray = CreateShapeArray(array);
PrintArray(newArray, true, "Массив данных с длинной строк <= 3");