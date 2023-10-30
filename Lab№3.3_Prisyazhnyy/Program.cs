//сборник задач/тема 3/подтема 3.3/вариант 22
try
{
Console.Write("Введите число x: ");
double x = double.Parse(Console.ReadLine());
Console.Write("Введите количество повторений n: ");
double n = double.Parse(Console.ReadLine());
double numerator = 3;               //‾‾|
double moveNumerator = 0;           //  |--->  переменные взаимодействующие между собой
double denominatorAndDegree = 2;    //__|
double sum = 0;
for (int i = 1; i <= n; i++)
{
    double factorial = 1;
    for(int j = 1; j <= denominatorAndDegree; j++) factorial *= j;
    if(i % 2 == 1 && i > 1)
    {
        sum -= (numerator / factorial) * Math.Pow(x, denominatorAndDegree);
    } else
    {
        sum += (numerator / factorial) * Math.Pow(x, denominatorAndDegree);
    }
    if (i == 1) sum = 1 - sum;
        numerator += moveNumerator + denominatorAndDegree;
        moveNumerator += 3;
        denominatorAndDegree += 2;
}
Console.WriteLine($"Ответ: {sum:F2}");
}
catch (Exception ex)
{
Console.WriteLine(ex.Message);
}
