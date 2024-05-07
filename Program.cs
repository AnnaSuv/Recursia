/*Задача 1: Задайте значения M и N. Напишите программу,
которая выведет все натуральные числа в промежутке от M до N.
Использовать рекурсию, не использовать циклы.*/

System.Console.WriteLine("Введите два числа ");
int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());

void ReturnInt(int start, int end) // метод в рекурсии на вход отдаём изменяемое число start
{
    if (start > end)// условие выхода из функции когда M>N
    {
        return;//остановка метода
    }
    else//в else записываем результат работы функции
    {
        System.Console.Write($"{start} ");//выводим изменяемое значение start
        ReturnInt(start + 1, end);//вызываем функцию с новым значением start
    }
}
ReturnInt(M, N);


/*Задача 2: Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.*/


Console.Write("Введите два неотрицательных числа : ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());


int Ackermann(int M, int N)
{
    if (M == 0)
        return N + 1;
    else if (N == 0 && M > 0)
        return Ackermann(M - 1, 1);
    else
        return (Ackermann(M - 1, Ackermann(N - 1, M)));
}


Console.Write(Ackermann(m, n));

/*Задача 3: Задайте произвольный массив. Выведете его элементы,
 начиная с конца. Использовать рекурсию, не использовать циклы.*/


void PrintRevers(int[] array, int i)
{
    if (i == 0)
    {
        System.Console.Write(array[i]);
        return;
    }
    System.Console.Write(array[i] + " ");
    PrintRevers(array, i - 1);
    return;
}

int[] userArr = { 1, 2, 5, 0, 10, 34 }; //заводим массив
PrintRevers(userArr, userArr.Length - 1);