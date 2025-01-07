
int n = int.Parse(Console.ReadLine());
int newNumber = n;
int position = 1;
int bitAtPosition1 = 0;

List<int> bits = new List<int>();
while (n != 0)
{
	int remainder = n % 2;
	bits.Add(remainder);

	n /= 2;
}


bitAtPosition1 = (newNumber >> position) & 1;

for (int i = 0; i < bits.Count; i++)
{
	if (bitAtPosition1 == 1)
	{
		bitAtPosition1 = 1;
		break;
	}
	else
	{
		bitAtPosition1 = 0;
		break;
	}
}

Console.WriteLine(bitAtPosition1);