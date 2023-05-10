namespace CSharp_PR_5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = { 1, 2, 3, 4, 5 };

			for (int i = 0; i <= 5; i++)
			{
				try
				{
					Console.WriteLine($"\nindex : {numbers[i]}");
				}
				catch (IndexOutOfRangeException e)
				{
					Console.WriteLine($"\nException message is : {e.Message}");
				}
				finally
				{
					Console.WriteLine("\nThis is finally block");
				}
			}
		}
	}
}