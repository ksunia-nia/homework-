// See https://aka.ms/new-console-template for more information

Console.WriteLine(" Задача 1. На ввод принимает два числа  и выдает какое больше, а какое меньше");

Console.WriteLine ("Введите первое число и нажмите Enter");
int N = int.Parse(Console.ReadLine());
Console.WriteLine ("Введите второе число и нажмите Enter");
int A = int.Parse(Console.ReadLine());

if ( N > A)
{
    Console.WriteLine($"Число {N} больше числа {A} ");
}
else 
 if ( N == A)
 {
 Console.WriteLine ($"Число {A} и  число {N} равны ");
 }
 else 
 if ( N < A)
 {
 Console.WriteLine ($"Число {A} больше числа {N}  ");
 }
Console.WriteLine ("Задача 1 выполнена");