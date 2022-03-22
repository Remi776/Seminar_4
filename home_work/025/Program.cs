Console.Write("Enter the number: ");
float a = Convert.ToSingle(Console.ReadLine());
Console.Write("Enter the power of number: ");
float b = Convert.ToSingle(Console.ReadLine());

Console.WriteLine($"\n{a} to the power of {b} = {Power(a, b)}");

float Power(float m, float n)
{
    float res = 1;
    for (float i = 1; i <= Math.Abs(n); i++)
    {
        res *= m;
    }
    if (m == 0) return 0;
    else if (n == 0) return 1;
    else if (n < 0) return 1 / res;
    return res;
}