/*Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. */

Console.Write($"Введите количество элементов");
int kol = int.Parse(Console.ReadLine()!);

string[] massiv = new string[kol];

for (int i = 0; i<massiv.Length; i++)
    {   
        Console.Write($"{i+1} 'элемент' ");
        massiv[i] = Console.ReadLine()!; // Задаем элементы массива
    }
PrintArray(massiv);

void PrintArray(string[] matr)    // Вывод массива
{
    for (int i=0; i<matr.GetLength(0); i++)
    {
            Console.Write("{0,3}", matr[i, j]);
    }
}