int n = 15;
bool[] primes = new bool[n + 1];
int count = 0;

for (int i = 2; i <= n; i++)
{
    primes[i] = true;
}

for (int i = 2; i * i <= n; i++)
{
    if (primes[i])
    {
        for (int j = i * i; j <= n; j += i)
        {
            primes[j] = false;
        }
    }
}

for (int i = 2; i <= n; i++)
{
    if (primes[i])
    {
        count++;
    }
}

Console.WriteLine(count);

//Использовал решето Эратосфена