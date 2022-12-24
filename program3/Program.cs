/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/
int[] FillArrey()
{
    Console.WriteLine("Введите количество целых значений массива");
    String nu = Console.ReadLine();
    int N = Convert.ToInt32(nu);
    int m = 1;
    int[] Array = Enumerable.Range(m, N-m+1).ToArray(); //создать последовательность
    Console.WriteLine(String.Join(",", Array));
    return Array;
}    
 
 void  KubedNum(int[] Array)  
 {
    int res = 0;
    int index = 0;
    int len = Array.Length;
    while(index < len)
    {
        int number= Array[index];
        res = number*number*number;
        Console.WriteLine(res);
        index++;   
    }
 }
int[] Array = FillArrey();
KubedNum(Array);
