/*Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. */

Console.Write($"Введите количество элементов ");
int kol = int.Parse(Console.ReadLine()!);
int j = 0;
string[] massiv = new string[kol];
string[] massiv2 = new string[kol];

for (int i = 0; i<massiv.Length; i++)
    {   
        Console.Write($"{i+1} элемент ");
        massiv[i] = Console.ReadLine()!; // Задаем элементы массива
    }
Console.Write($"Вывод элементов массива \n");
PrintArray(massiv);
Console.WriteLine();

for (int k = 0; k < massiv.Length; k++)  // проверка элементов, чья длина будет меньше, либо равна 3
{
    if (massiv[k].Length <=3)
    {
        massiv2[j]=massiv[k];
        j++;
    }
}

Console.Write($"Вывод элементов, чья длина меньше или равно 3 \n");
PrintArray(massiv2);

void PrintArray(string[] matr)    // Вывод массива
{
    for (int i=0; i<matr.GetLength(0); i++)
    {
            Console.Write($" {matr[i]} ");
    }
}