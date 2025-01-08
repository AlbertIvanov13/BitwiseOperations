
int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

int result = 0;

for (int i = 0; i < numbers.Length; i++)
{
	string binary1 = Convert.ToString(result, 2).PadLeft(8, '0');
	string binary2 = Convert.ToString(numbers[i], 2).PadLeft(8, '0');

	result = result ^ numbers[i];
	string binary3 = Convert.ToString(result, 2).PadLeft(8, '0');
}
  
Console.WriteLine(result);