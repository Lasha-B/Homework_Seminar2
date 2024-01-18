// Напишите программу, которая принимает на вход координаты 
// точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной 
// четверти плоскости, в которой находится эта точка.

int X = -3;
int Y = -2;

if (X>0 && Y>0){
    Console.Write("1 quarter");
}
if (X>0 && Y<0){
    Console.Write("4 quarter");
}
if (X<0 && Y>0){
    Console.Write("2 quarter");
}
if (X<0 && Y<0){
    Console.Write("3 quarter");
}