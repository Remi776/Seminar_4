Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
Factorial();

void Factorial()
{
    int fact = 1;
    while (number > 0)
    {
        fact *= number;
        number--;
    }
    Console.WriteLine(fact);
}