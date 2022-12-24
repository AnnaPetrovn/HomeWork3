/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */
void Palindrom()
{
    Console.WriteLine("Введите пятизначное число");
    string nu = Console.ReadLine();
if(nu[0] == nu[4] && nu[1] == nu[3])
    {
        int number = Convert.ToInt32(nu);
        if(number<100000 && number>9999)
        {
        Console.WriteLine($"число {number} является палиндромом");
        }
        else
        {
            Console.WriteLine("Данное число не является пятизначным числом");
        }
    }
else
{
    Console.WriteLine("Данное число не является палиндромом или не является числом");
}   
}  

Palindrom();



    




