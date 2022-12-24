/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/
double DistPoint3D(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double AB;
    double[]A = new double[]{x1, y1, z1};
    double[]B = new double[]{x2, y2, z2};
    AB = Math.Sqrt((B[0]-A[0])*(B[0]-A[0]) +  (B[1]-A[1])*(B[1]-A[1]) + (B[2]-A[2])*(B[2]-A[2]));
    return AB;
}

Console.WriteLine("Введите координаты первой точки через <,> : ");
string[] A = Console.ReadLine().Split(",");
double x1 = double.Parse(A[0]);
double y1 = double.Parse(A[1]);
double z1 = double.Parse(A[2]);
Console.WriteLine("Введите координаты второй точки через ",": ");
string[] B = Console.ReadLine().Split(",");
double x2 = double.Parse(B[0]);
double y2 = double.Parse(B[1]);
double z2 = double.Parse(B[2]);


double res = DistPoint3D(x1,y1,z1,x2,y2,z2);
Console.WriteLine(res);