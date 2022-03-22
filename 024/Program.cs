int number = Convert.ToInt32(Console.ReadLine());
Summ();

void Summ()
{
    int summ = 0;
    for (int i = 1; i <= number; i++)
    {
        summ += i;
    }
    Console.WriteLine(summ);
}
