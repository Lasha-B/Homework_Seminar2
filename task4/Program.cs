int number = 6532;
int result = 0;
int y = number.ToString().Length;
 
while (number > 0)
{
result *= 10;
result += number % 10;
number /= 10;
}
 
for (int i = 0; i < y; i++)
{
Console.Write(result % 10 + ",");
result /= 10;
}
Console.ReadKey();
