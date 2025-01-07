
int number = int.Parse(Console.ReadLine());

List<int> bits = new List<int>();

while (number != 0)
{
	int remainder = number % 2;
	bits.Add(remainder);

	number /= 2;
}

for (int i = bits.Count - 1; i >= 0; i--)
{
	Console.WriteLine(bits[1]);
	break;
}