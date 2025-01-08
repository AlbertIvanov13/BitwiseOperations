
int n = int.Parse(Console.ReadLine());
int p = int.Parse(Console.ReadLine());

int mask = 0;
int newNumber = 0;

string binary = Convert.ToString(n, 2).PadLeft(32, '0');

mask = (7 << p);

string binary2 = Convert.ToString(mask, 2).PadLeft(32, '0');

newNumber = n ^ mask;

string binary3 = Convert.ToString(newNumber, 2).PadLeft(32, '0');

Console.WriteLine(newNumber);