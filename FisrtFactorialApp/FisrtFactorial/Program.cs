static int FirstFactorial(int num)
{
    int result = 1;
    for (int i = 1; i <= num; i++)
    {
        result *= i;
    }
    return result;
}

Console.WriteLine(FirstFactorial(4));
