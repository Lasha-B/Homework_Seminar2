﻿// Напишите программу, которая принимает на вход целое число 
// из отрезка [10, 99] и показывает наибольшую цифру числа.

int num = 18;
if (num > 10 && num < 100){
    int a = num%10;
    int b = num/10;
    if (a > b){
        Console.Write(a);
    }
    else{
        Console.Write(b);
    }
}
else{
    Console.Write("Число не принодлежит заданному отрезку");
}