using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        //(123) 456-7890"
        Console.WriteLine(CreatePhoneNumberLinq(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }));
    }

    public static string CreatePhoneNumber(int[] numbers)
    {
        if (numbers.Length < 10) 
            return "";
        var firstThree = $"{numbers[0]}{numbers[1]}{numbers[2]}";
        var secondThree = $"{numbers[3]}{numbers[4]}{numbers[5]}";
        var lastFour = $"{numbers[6]}{numbers[7]}{numbers[8]}{numbers[9]}";

        return $"({firstThree}) {secondThree}-{lastFour}";
    }
  
    public static string CreatePhoneNumberLinq(int[] numbers)
    {
        if (numbers.Length < 10) 
            return "";

        return string.Concat(numbers.Select((x, i) =>
        {
            switch (i)
            {
                case 0:
                    return $"({x}";
                case 2:
                    return $"{x}) ";
                case 6:
                    return $"-{x}";
                case 9:
                    return $"{x}";
            }
            return $"{x}";
        }));
    }
}