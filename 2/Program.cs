// See https://aka.ms/new-console-template for more information

Console.WriteLine(" Задача 2. На ввод принимает три числа  и выдает самое большое их них");

Console.WriteLine ("Введите первое число и нажмите Enter");
int A = int.Parse(Console.ReadLine());
Console.WriteLine ("Введите второе число и нажмите Enter");
int B = int.Parse(Console.ReadLine());
Console.WriteLine ("Введите третье число и нажмите Enter");
int C = int.Parse(Console.ReadLine());

int Max1 = A;


if (Max1 > B)
    { 
         Console.WriteLine (Max1=A);//($"Первое число {A} больше числа {B} и {Max1=A}");
    }
    else
     {  
         Console.WriteLine (Max1=B); //($"Второе число {B} больше первого числа {A} и {Max1=B}");
     } 
             if ( Max1 < C) 
         {   
             Console.WriteLine(Max1=C);//($"Третье число {C} больше числа {Max1} и {Max1=C}");
         } 
         else
         { 
             Console.WriteLine(Max1=Max1);//($"Число {C} меньше числа {Max1} и {Max1=Max1}");
         }
        
 

Console.WriteLine ($"{Max1} Самое большое число из {A}, {B}, {C}");
Console.WriteLine ("Задача 2 выполнена");