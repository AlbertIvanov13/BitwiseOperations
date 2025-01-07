
int n = int.Parse(Console.ReadLine());
int newNumber = n;
int p = int.Parse(Console.ReadLine());
int bitAtPositionP = 0;

List<int> remainders = new List<int>();
while (n != 0)
{
	int remainder = n % 2;
	remainders.Add(remainder);

	n /= 2;
}

bitAtPositionP = (newNumber >> p) & 1;
Console.WriteLine(bitAtPositionP);