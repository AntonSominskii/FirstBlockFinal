/*Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами. */

int ReadNumber(string message) //Функция принимает целое положительное число, как string и преобразует его в int. 
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


string[] StringArray(int size) //Функция принимает количество элементов массива, содержимое элементов(через консоль).
{
    string[] p = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите строку №{0}:\r\n    ", i + 1);
        p[i] = Console.ReadLine();
    }
    return p;
}

void PrintArray(string[] array) // Функция выводит в консоль элементы одномерного массива.
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(array[i] + " ");
    }
}

string[] ArrayFilter(string[] originalArray)               // Функция создает новый массив с длиной исходного. Вводится счетчик "newIndex".
{                                                          // Далее идет цикл, где через if каждый элемент(его длина) иссходного массива сравнивается с 3 и, если элемент 
    string[] newArray = new string[originalArray.Length];  // подходит под условие, то записывается в в/у новый массив, который функция затем возвращает.
    int newIndex = 0;
    for (int i = 0; i < originalArray.Length; i++)
    {
        if (originalArray[i].Length <= 3)
        {
            newArray[newIndex] = originalArray[i];
            newIndex++;
        }
    }
    return newArray;
}

int x = ReadNumber("Введите количество элементов массива:");
string[] startArray = StringArray(x);
Console.WriteLine("Исходный массив:");
PrintArray(startArray);
Console.WriteLine("\nКонечный массив:");
PrintArray(ArrayFilter(startArray));
