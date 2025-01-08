
int n = int.Parse(Console.ReadLine());
int p = int.Parse(Console.ReadLine());
int mask = 0;
int newNumber = 0;

mask = ~(1 << p);

newNumber = n & mask;

Console.WriteLine(newNumber);