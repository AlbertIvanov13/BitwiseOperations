
int number = int.Parse(Console.ReadLine());
byte number2 = byte.Parse(Console.ReadLine());

int counter = 0;
while (number != 0)
{
	int remainder = number % 2;

	if (remainder == number2)
	{
		counter++;
	}

	number /= 2;
}

Console.WriteLine(counter);