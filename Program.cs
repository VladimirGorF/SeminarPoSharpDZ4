/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

/*
int NaturalDegreeA()
{
Console.WriteLine("Please input number A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please input degree");
int B = Convert.ToInt32(Console.ReadLine());
int ND = A;

for (int i = 0; i < B-1; i++ ) ND = ND*A;

return ND;
}
Console.WriteLine(NaturalDegreeA()); 


Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 

int SumOfDiggits()
{
Console.WriteLine("Please input number A");
int A = Convert.ToInt32(Console.ReadLine());
int Sum = 0;
for(int i = 0; A > 0; i++) 
{
    Sum = Sum + A%10;
    A = A/10;
}
return Sum; 
}
try { 
Console.WriteLine("Sum of digits of number is: " + SumOfDiggits());
}
catch 
{
Console.WriteLine("Please input number A correctly");
}


Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]


int [] Array = {1,2,3,4,5,6,7,8};
for (int i = 0; i<8; i++) Console.WriteLine($"{Array[i]}");
*/
/*
  Необязательная задача 
Написать программу сортировки массива от большего к меньшему. Массив задается размерностью N с клавиатуры, далее заполняется случайными целыми числами.
*/
try{
    Console.WriteLine("Please input a number");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Array :");
    int [] Array = new int [n];

    void ArrInput (int [] Array)
    {
    int count = Array.Length;
    for(int i = 0; i < count; i++)
    {
        Array [i] = new Random().Next(1,10);
        Console.Write(Array[i] + " "); 
    }
    Console.WriteLine(); 
    }

    void ArraySorting(int [] Array)
    {
        for (int i = 0; i<Array.Length - 1; i++)
        {
            int maxPos = i;
            for (int j = i+1; j<Array.Length; j++)
            {
                if (Array [j] > Array [maxPos])  maxPos = j;
            }
            int Temp = Array[i];
            Array [i] = Array [maxPos];
            Array [maxPos] = Temp; 
            Console.Write(Array[i] + " ");
        }
        Console.Write(Array[n-1]);
        Console.WriteLine();
    }
    ArrInput(Array);
    ArraySorting(Array);
}
catch
{
    Console.Write("It is wonderful but incorrectly. Please imput integer!");
}
Console.WriteLine();

