// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 29

// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

void PrintNaturalNumbers(int m, int n)
{
    Console.Write(m+", ");
    if (m!=n)
    {
        PrintNaturalNumbers(m+1, n);
    }
    return;
}

void PrintNumbers(int[] array, int i)
{
    Console.Write(array[i]+" ");
    if (array.Length-1 == i)
    {
        Console.Write("=> "+array[i]+" ");
        return;    
    }
    PrintNumbers(array, i+1);
    Console.Write(array[i]+" ");            
}

int GetAkkerman(int m, int n)
{
    if (m == 0) 
    {
        return n + 1;        
    }   
    else if (n == 0) 
    {
        return GetAkkerman(m - 1, 1);
    }
    else return GetAkkerman(m - 1, GetAkkerman(m, n - 1));
}

int[] GetArray(int n)
{
    int[] array = new int[n];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 100);
    }
    return array;
}

void task1()
{
    Console.Write("Введите значение M: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите значение N: ");
    int n = Convert.ToInt32(Console.ReadLine());
    PrintNaturalNumbers(m, n);
}

void task2()
{
    Console.Write("Введите значение M: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите значение N: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int akker = GetAkkerman(m, n);
    Console.Write($"Функция Аккермана равно {akker}");
}

void task3()
{
    Console.Write("Введите размер массива: ");
    int n = Convert.ToInt32(Console.ReadLine());
    PrintNumbers(GetArray(n), 0);
}

void main()
{
    Console.Write("Введите номер задания: ");
    int tasknumber = Convert.ToInt32(Console.ReadLine());
    // int tasknumber = 3;

    if (tasknumber == 1)
    {
        task1();    
    }
    else if (tasknumber == 2) 
    {
        task2();    
    } 
    else if (tasknumber == 3)
    {
        task3();    
    } 
    else
    {
        Console.Write("Введен некорректный номер задания!");    
    }
}

main();