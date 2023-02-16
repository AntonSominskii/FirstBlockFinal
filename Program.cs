/*Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами. */

int ReadNumber(string message) //Функция принимает целое положительное число и преобразует его в int. 
        {
            Console.WriteLine(message);
            return Convert.ToInt32(Console.ReadLine());
        }


string [] StringArray(int size) //Функция принимает целое положительное число и преобразует его в int.
        {
           // int x = Convert.ToInt32(Console.ReadLine());
            string[] p = new string[size];
            for(int i = 0; i<size; i++)
            {
                Console.Write("Введите строку №{0}:\r\n    ", i + 1);
                p[i] = Console.ReadLine(); //Заполняем его
            }
            return p;
        }

void PrintArray(string[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        
            Console.Write(array[i] + " ");
       
        
    }
}

int x = ReadNumber("Введите количество элементов массива:");
string [] startArray = StringArray(x);
PrintArray(startArray);