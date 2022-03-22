Console.Write("Enter the number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nSum of numbers = " + Summ(a));

int Summ(int num)
{
    num = Math.Abs(num); // для отрицательного числа
    int res = 0;
    while (num > 0)
    {
        res += num % 10;
        num /= 10;
    }
    return res;
}