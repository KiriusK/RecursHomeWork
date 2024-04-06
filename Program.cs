// Задача 1. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от M до N. Использовать рекурсию, не использовать циклы.

void CountFunction(int m,int n) {
    if (m==n) {
        Console. Write($"{m}");
        Console.WriteLine();
    }
    if (m<n) {
        Console. Write($"{m}, ");
        CountFunction(m+1,n);
    }
    if (n<m) {
        Console. Write($"{n}, ");
        CountFunction(m,n+1);
    }
}

Console.Write("Задача 1. Введите натуральное число M: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int num2 = Convert.ToInt32(Console.ReadLine());
CountFunction(num1,num2);

// Задача 2. Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int AckFunction(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return AckFunction(m - 1, 1);
    if (m > 0 && n > 0) return AckFunction(m - 1, AckFunction(m, n - 1));
    Console.WriteLine("Что-то пошло не так, возможно вы ввели отрицательные значения");
    return -1;
}

Console.Write("Задача 2. Введите число m для функции Аккермана A(m,n): ");
int ackNum1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n для функции Аккермана A(m,n): ");
int ackNum2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Результат вычисления функции Аккермана равен {AckFunction(ackNum1, ackNum2)}");

// Задача 3. Задайте произвольный массив. Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.

int[] FillArr(int[] arr,int i,Random rnd) {
    if (i==arr.Length-1) {
        arr[i]=rnd.Next(1,100);
        return arr;
    }
    arr[i]=rnd.Next(1,100);
    return FillArr(arr,i+1,rnd);
}

void PrintArr(int[] arr, int i) {
    if (i==arr.Length-1) {
        Console.Write(arr[i]);
        Console.WriteLine();
        return;
    }
    Console.Write($"{arr[i]} ");
    PrintArr(arr,i+1);
}

void ReversePrintArr(int[] arr, int len) {
    if (len==1) {
        Console.Write(arr[len-1]);
        Console.WriteLine();
        return;
    }
    Console.Write($"{arr[len-1]} ");
    ReversePrintArr(arr,len-1);
}

Console.Write("Задача 3. Введите длину массива для генерации: ");
int len = Convert.ToInt32(Console.ReadLine());
int[] arr=new int[len];
Random rnd=new Random();
arr=FillArr(arr,0,rnd);
Console.WriteLine("Сгенерирован массив: ");
PrintArr(arr,0);
Console.WriteLine("В обратную сторону: ");
ReversePrintArr(arr,len);